#region Thư viện sử dụng
using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
#endregion

namespace Project_PySceneDetect_GUI
{
    public partial class Form1 : Form
    {
        #region Một số hàm bổ sung
        class OneVideo
        {
            public string nameVideo { get; set; }
            public bool haveExportImage { get; set; }
            public bool scanAllVideo { get; set; }
            public string pathTimeVideo { get; set; }

        }

        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        #endregion

        public Form1()
        {
            #region Định nghĩa cài đặt ban đầu  
            InitializeComponent();
            this.MaximizeBox = false;
            this.rtbOutput.ReadOnly = true;
            tbPathTimeVideo.Enabled = false;
            btGetPathTimeVideo.Enabled = false;
            dgvListvideo.AllowUserToAddRows = false;
            dgvListvideo.ScrollBars = ScrollBars.Vertical;
            rbAllVideo.Enabled = false;
            rbNotAllVideo.Enabled = false;
            cbExportImage.Enabled = false;
            btDelete.Enabled = false;
            btSave.Enabled = false;
            foreach (DataGridViewColumn column in dgvListvideo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion
        }
        ToolTip tip = new ToolTip();
        List<OneVideo> listVideo = new List<OneVideo>();

        #region Sự kiện khi chọn vị trí chứa video gốc
        private void btGetPathVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Chọn vị trí chứa video";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string strPath = folder.SelectedPath.ToString();
                tbPathVideo.Text = strPath;
                if (dgvListvideo.RowCount != 0)
                {
                    dgvListvideo.Rows.Clear();
                }
                if (listVideo.Count >= 1)
                {
                    while (listVideo.Count != 0)
                    {
                        listVideo.RemoveAt(0);
                    }
                }

                string[] files = Directory.GetFiles(strPath, "*.mp4", SearchOption.TopDirectoryOnly);
                int count = 0;
                string[] namefiles = new string[files.Length];
                foreach (var item in files)
                {
                    string tempnamefiles = item.Remove(0, item.LastIndexOf(@"\") + 1);
                    namefiles[count] = tempnamefiles;
                    count++;
                }
                count = 0;
                foreach (var item in namefiles)
                {
                    dgvListvideo.Rows.Add();
                    dgvListvideo.Rows[count].Cells[0].Value = item;
                    dgvListvideo.Rows[count].Cells[1].Value = true;
                    dgvListvideo.Rows[count].Cells[2].Value = true;
                    listVideo.Add(new OneVideo() { nameVideo = item, haveExportImage = true, scanAllVideo = true, pathTimeVideo = "" });
                    count++;
                }
            }
        }
        #endregion

        #region Check chọn quét toàn bộ video
        private void rbAllVideo_CheckedChanged(object sender, EventArgs e)
        {
            tbPathTimeVideo.Enabled = false;
            btGetPathTimeVideo.Enabled = false;
        }
        #endregion

        #region Check chọn quét 1 phần video
        private void rbNotAllVideo_CheckedChanged(object sender, EventArgs e)
        {
            tbPathTimeVideo.Enabled = true;
            btGetPathTimeVideo.Enabled = true;
        }
        #endregion

        #region Khi chọn vào 1 ô trong Datagridview
        private void DgvListvideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbExportImage.Enabled = true;
            rbAllVideo.Enabled = true;
            rbNotAllVideo.Enabled = true;
            btDelete.Enabled = true;
            btSave.Enabled = true;
            tbPathTimeVideo.Text = "";
            int rowId = dgvListvideo.CurrentCell.RowIndex;
            lbNameVideo.Text = (string)dgvListvideo.Rows[rowId].Cells[0].Value;
            if ((bool)dgvListvideo.Rows[rowId].Cells[1].Value == true)
            {
                cbExportImage.Checked = true;
            }
            else
            {
                cbExportImage.Checked = false;
            }

            if ((bool)dgvListvideo.Rows[rowId].Cells[2].Value == true)
            {
                rbAllVideo.Checked = true;
            }
            else
            {
                rbNotAllVideo.Checked = true;
                tbPathTimeVideo.Text = (string)dgvListvideo.Rows[rowId].Cells[3].Value;
            }
        }
        #endregion

        #region Khi nhấn Delete để delete 1 ô
        private void btDelete_Click(object sender, EventArgs e)
        {
            int rowId = dgvListvideo.CurrentCell.RowIndex;
            dgvListvideo.Rows.RemoveAt(rowId);
            listVideo.RemoveAt(rowId);
            if (rowId != dgvListvideo.RowCount)
            {
                lbNameVideo.Text = (string)dgvListvideo.Rows[rowId].Cells[0].Value;
                if ((bool)dgvListvideo.Rows[rowId].Cells[1].Value == true)
                {
                    cbExportImage.Checked = true;
                }
                else
                {
                    cbExportImage.Checked = false;
                }

                if ((bool)dgvListvideo.Rows[rowId].Cells[2].Value == true)
                {
                    rbAllVideo.Checked = true;
                }
                else
                {
                    rbNotAllVideo.Checked = true;
                    tbPathTimeVideo.Text = (string)dgvListvideo.Rows[rowId].Cells[3].Value;
                }
            }
            else
            {
                lbNameVideo.Text = "";
                rbAllVideo.Enabled = false;
                rbNotAllVideo.Enabled = false;
                cbExportImage.Enabled = false;
                btDelete.Enabled = false;
                btSave.Enabled = false;
            }
        }
        #endregion

        #region Chọn file chứa các mốc thời gian
        private void btGetPathTimeVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbPathTimeVideo.Text = dialog.FileName;
            }
        }
        #endregion

        #region Nhấn nút Save điều gì sẽ xảy ra
        private void btSave_Click(object sender, EventArgs e)
        {
            int rowId = dgvListvideo.CurrentCell.RowIndex;
            if (cbExportImage.Checked == true)
            {
                dgvListvideo.Rows[rowId].Cells[1].Value = true;
                listVideo[rowId].haveExportImage = true;
            }
            else
            {
                dgvListvideo.Rows[rowId].Cells[1].Value = false;
                listVideo[rowId].haveExportImage = false;
            }

            if (rbAllVideo.Checked == true)
            {
                dgvListvideo.Rows[rowId].Cells[2].Value = true;
                dgvListvideo.Rows[rowId].Cells[3].Value = "";
                listVideo[rowId].scanAllVideo = true;
                listVideo[rowId].pathTimeVideo = "";
            }
            else
            {
                dgvListvideo.Rows[rowId].Cells[2].Value = false;
                dgvListvideo.Rows[rowId].Cells[3].Value = tbPathTimeVideo.Text;
                listVideo[rowId].scanAllVideo = false;
                listVideo[rowId].pathTimeVideo = tbPathTimeVideo.Text;
            }
        }
        #endregion

        #region Chọn vị trí chứa kết quả ra (Output)
        private void btPathOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Chọn vị trí chứa kết quả đầu ra";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string strPath = folder.SelectedPath.ToString();
                tbPathOutput.Text = strPath;
            }
        }
        #endregion

        #region Hàm chạy chương trình. Chạy từng video một để quét.
        private void btRun_Click(object sender, EventArgs e)
        {
            if (tbPathOutput.Text != "" && tbPathVideo.Text != "")
            {
                Directory.CreateDirectory(tbPathOutput.Text + @"\Output");
                foreach (var item in listVideo)
                {
                    #region Tạo thư mục
                    string pathParent = tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo);
                    rtbOutput.Text += "Thêm Folder " + pathParent + "\n";
                    Directory.CreateDirectory(pathParent);
                    DirectoryInfo dinfo = new DirectoryInfo(pathParent);
                    DirectorySecurity dSecurity = dinfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                    dinfo.SetAccessControl(dSecurity);

                    if (item.pathTimeVideo != "")
                    {
                        StreamReader streread = new StreamReader(item.pathTimeVideo);
                        string res = streread.ReadLine();
                        while (res != null)
                        {
                            string[] time = res.Split(' ');
                            if (time.Length == 2)
                            {
                                string path = pathParent + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-');
                                Directory.CreateDirectory(path);
                                rtbOutput.Text += "Thêm Folder " + path + "\n";
                            }
                            else
                            {
                                string path = pathParent + (@"\From " + time[0] + " to end video").Replace(':', '-');
                                Directory.CreateDirectory(path);
                                rtbOutput.Text += "Thêm Folder " + path + "\n";
                            }
                            res = streread.ReadLine();
                        }
                    }
                }
                #endregion

                #region Chạy code từng file
                foreach (var item in listVideo)
                {
                    if (item.scanAllVideo == true)
                    {
                        if (item.haveExportImage == true)
                        {
                            rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                            Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + "\" detect-content list-scenes save-images");

                            IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                            Thread.Sleep(5000);
                            while (hdle.ToString() != "0")
                            {
                                Thread.Sleep(500);
                                hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                            }
                        }
                        else
                        {
                            rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                            Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + "\" detect-content list-scenes");

                            IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                            Thread.Sleep(5000);
                            while (hdle.ToString() != "0")
                            {
                                Thread.Sleep(500);
                                hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                            }
                        }
                    }
                    else
                    {
                        if (item.haveExportImage == true)
                        {
                            StreamReader streread = new StreamReader(item.pathTimeVideo);
                            string res = streread.ReadLine();
                            while (res != null)
                            {
                                string[] time = res.Split(' ');
                                if (time.Length == 2)
                                {                                   
                                    rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                    Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes save-images");

                                    IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    Thread.Sleep(5000);
                                    while (hdle.ToString() != "0")
                                    {
                                        Thread.Sleep(500);
                                        hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    }
                                }
                                else
                                {
                                    //Quét video có điểm cuối là cuối video
                                    rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                    Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes save-images");

                                    IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    Thread.Sleep(5000);
                                    while (hdle.ToString() != "0")
                                    {
                                        Thread.Sleep(500);
                                        hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    }
                                }
                                res = streread.ReadLine();
                            }
                        }
                        else
                        {
                            //Quét theo từng phân đoạn và không xuất ra hình ảnh
                            StreamReader streread = new StreamReader(item.pathTimeVideo);
                            string res = streread.ReadLine();
                            while (res != null)
                            {
                                string[] time = res.Split(' ');
                                if (time.Length == 2)
                                {                                   
                                    //Trường hợp quét mà điểm đầu cuối không xác định
                                    rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                    Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes");

                                    IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    Thread.Sleep(5000);
                                    while (hdle.ToString() != "0")
                                    {
                                        Thread.Sleep(500);
                                        hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    }
                                }
                                else
                                {
                                    //Quét video có điểm cuối là cuối video
                                    rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                    Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes");

                                    IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    Thread.Sleep(5000);
                                    while (hdle.ToString() != "0")
                                    {
                                        Thread.Sleep(500);
                                        hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                    }
                                }
                                res = streread.ReadLine();
                            }
                        }
                    }
                }
            }
            #endregion


            else
            {
                MessageBox.Show("Thiếu đường dẫn chứa file gốc hoặc (và) đường dẫn đầu ra");
            }
                #endregion


            }
    }
}
