using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PySceneDetect_GUI
{
    public partial class Form1 : Form
    {
        class OneVideo
        {
            public string nameVideo { get; set; }
            public bool haveExportImage { get; set; }
            public bool scanAllVideo { get; set; }
            public string pathTimeVideo { get; set; }

        }
        public Form1()
        {
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
        }
        ToolTip tip = new ToolTip();
        List<OneVideo> listVideo = new List<OneVideo>();

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

        private void rbAllVideo_CheckedChanged(object sender, EventArgs e)
        {
            tbPathTimeVideo.Enabled = false;
            btGetPathTimeVideo.Enabled = false;
        }

        private void rbNotAllVideo_CheckedChanged(object sender, EventArgs e)
        {
            tbPathTimeVideo.Enabled = true;
            btGetPathTimeVideo.Enabled = true;
        }

        private void DgvListvideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbExportImage.Enabled = true;
            rbAllVideo.Enabled = true;
            rbNotAllVideo.Enabled = true;
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
    }
}
