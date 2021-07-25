
namespace Project_PySceneDetect_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbListVideo = new System.Windows.Forms.GroupBox();
            this.dgvListvideo = new System.Windows.Forms.DataGridView();
            this.dgvcNameVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHaveExportImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcCheckAllVideo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcPathTimeVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btSaveOutput = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.gbInfoVideo = new System.Windows.Forms.GroupBox();
            this.lbNameVideo = new System.Windows.Forms.Label();
            this.cbExportImage = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGetPathTimeVideo = new System.Windows.Forms.Button();
            this.rbNotAllVideo = new System.Windows.Forms.RadioButton();
            this.rbAllVideo = new System.Windows.Forms.RadioButton();
            this.lbPathTimeVideo = new System.Windows.Forms.Label();
            this.tbPathTimeVideo = new System.Windows.Forms.TextBox();
            this.lbExportImage = new System.Windows.Forms.Label();
            this.lbScanChoose = new System.Windows.Forms.Label();
            this.lbTextNameVideo = new System.Windows.Forms.Label();
            this.lbPathVideo = new System.Windows.Forms.Label();
            this.lbPathOutput = new System.Windows.Forms.Label();
            this.tbPathOutput = new System.Windows.Forms.TextBox();
            this.tbPathVideo = new System.Windows.Forms.TextBox();
            this.btPathOutput = new System.Windows.Forms.Button();
            this.btGetPathVideo = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.gbListVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListvideo)).BeginInit();
            this.gbOutput.SuspendLayout();
            this.gbInfoVideo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListVideo
            // 
            this.gbListVideo.Controls.Add(this.dgvListvideo);
            this.gbListVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbListVideo.Location = new System.Drawing.Point(12, 98);
            this.gbListVideo.Name = "gbListVideo";
            this.gbListVideo.Size = new System.Drawing.Size(776, 263);
            this.gbListVideo.TabIndex = 0;
            this.gbListVideo.TabStop = false;
            this.gbListVideo.Text = "List video";
            // 
            // dgvListvideo
            // 
            this.dgvListvideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListvideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNameVideo,
            this.dgvHaveExportImage,
            this.dgvcCheckAllVideo,
            this.dgvcPathTimeVideo});
            this.dgvListvideo.Location = new System.Drawing.Point(15, 16);
            this.dgvListvideo.Name = "dgvListvideo";
            this.dgvListvideo.Size = new System.Drawing.Size(761, 241);
            this.dgvListvideo.TabIndex = 0;
            this.dgvListvideo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListvideo_CellContentClick);
            // 
            // dgvcNameVideo
            // 
            this.dgvcNameVideo.Frozen = true;
            this.dgvcNameVideo.HeaderText = "Tên video";
            this.dgvcNameVideo.Name = "dgvcNameVideo";
            this.dgvcNameVideo.ReadOnly = true;
            this.dgvcNameVideo.Width = 250;
            // 
            // dgvHaveExportImage
            // 
            this.dgvHaveExportImage.Frozen = true;
            this.dgvHaveExportImage.HeaderText = "Xuất ra hình ảnh";
            this.dgvHaveExportImage.Name = "dgvHaveExportImage";
            this.dgvHaveExportImage.ReadOnly = true;
            // 
            // dgvcCheckAllVideo
            // 
            this.dgvcCheckAllVideo.Frozen = true;
            this.dgvcCheckAllVideo.HeaderText = "Quét toàn bộ video";
            this.dgvcCheckAllVideo.Name = "dgvcCheckAllVideo";
            this.dgvcCheckAllVideo.ReadOnly = true;
            this.dgvcCheckAllVideo.Width = 130;
            // 
            // dgvcPathTimeVideo
            // 
            this.dgvcPathTimeVideo.Frozen = true;
            this.dgvcPathTimeVideo.HeaderText = "Địa chỉ file chứa các mốc thời gian";
            this.dgvcPathTimeVideo.Name = "dgvcPathTimeVideo";
            this.dgvcPathTimeVideo.ReadOnly = true;
            this.dgvcPathTimeVideo.Width = 220;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btSaveOutput);
            this.gbOutput.Controls.Add(this.rtbOutput);
            this.gbOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbOutput.Location = new System.Drawing.Point(421, 367);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(367, 212);
            this.gbOutput.TabIndex = 0;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // btSaveOutput
            // 
            this.btSaveOutput.Location = new System.Drawing.Point(292, 181);
            this.btSaveOutput.Name = "btSaveOutput";
            this.btSaveOutput.Size = new System.Drawing.Size(75, 23);
            this.btSaveOutput.TabIndex = 1;
            this.btSaveOutput.Text = "Lưu";
            this.btSaveOutput.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(6, 18);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(355, 157);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // gbInfoVideo
            // 
            this.gbInfoVideo.Controls.Add(this.lbNameVideo);
            this.gbInfoVideo.Controls.Add(this.cbExportImage);
            this.gbInfoVideo.Controls.Add(this.btDelete);
            this.gbInfoVideo.Controls.Add(this.btSave);
            this.gbInfoVideo.Controls.Add(this.panel1);
            this.gbInfoVideo.Controls.Add(this.lbExportImage);
            this.gbInfoVideo.Controls.Add(this.lbScanChoose);
            this.gbInfoVideo.Controls.Add(this.lbTextNameVideo);
            this.gbInfoVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbInfoVideo.Location = new System.Drawing.Point(12, 367);
            this.gbInfoVideo.Name = "gbInfoVideo";
            this.gbInfoVideo.Size = new System.Drawing.Size(403, 212);
            this.gbInfoVideo.TabIndex = 0;
            this.gbInfoVideo.TabStop = false;
            this.gbInfoVideo.Text = "Thông tin về video";
            // 
            // lbNameVideo
            // 
            this.lbNameVideo.AutoSize = true;
            this.lbNameVideo.Location = new System.Drawing.Point(71, 27);
            this.lbNameVideo.Name = "lbNameVideo";
            this.lbNameVideo.Size = new System.Drawing.Size(0, 15);
            this.lbNameVideo.TabIndex = 8;
            // 
            // cbExportImage
            // 
            this.cbExportImage.AutoSize = true;
            this.cbExportImage.Location = new System.Drawing.Point(94, 49);
            this.cbExportImage.Name = "cbExportImage";
            this.cbExportImage.Size = new System.Drawing.Size(15, 14);
            this.cbExportImage.TabIndex = 7;
            this.cbExportImage.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(232, 182);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(313, 181);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGetPathTimeVideo);
            this.panel1.Controls.Add(this.rbNotAllVideo);
            this.panel1.Controls.Add(this.rbAllVideo);
            this.panel1.Controls.Add(this.lbPathTimeVideo);
            this.panel1.Controls.Add(this.tbPathTimeVideo);
            this.panel1.Location = new System.Drawing.Point(23, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 81);
            this.panel1.TabIndex = 6;
            // 
            // btGetPathTimeVideo
            // 
            this.btGetPathTimeVideo.Location = new System.Drawing.Point(290, 50);
            this.btGetPathTimeVideo.Name = "btGetPathTimeVideo";
            this.btGetPathTimeVideo.Size = new System.Drawing.Size(75, 23);
            this.btGetPathTimeVideo.TabIndex = 4;
            this.btGetPathTimeVideo.Text = "Chọn";
            this.btGetPathTimeVideo.UseVisualStyleBackColor = true;
            this.btGetPathTimeVideo.Click += new System.EventHandler(this.btGetPathTimeVideo_Click);
            // 
            // rbNotAllVideo
            // 
            this.rbNotAllVideo.AutoSize = true;
            this.rbNotAllVideo.Location = new System.Drawing.Point(3, 26);
            this.rbNotAllVideo.Name = "rbNotAllVideo";
            this.rbNotAllVideo.Size = new System.Drawing.Size(109, 19);
            this.rbNotAllVideo.TabIndex = 6;
            this.rbNotAllVideo.TabStop = true;
            this.rbNotAllVideo.Text = "Một phần video";
            this.rbNotAllVideo.UseVisualStyleBackColor = true;
            this.rbNotAllVideo.CheckedChanged += new System.EventHandler(this.rbNotAllVideo_CheckedChanged);
            // 
            // rbAllVideo
            // 
            this.rbAllVideo.AutoSize = true;
            this.rbAllVideo.Location = new System.Drawing.Point(3, 3);
            this.rbAllVideo.Name = "rbAllVideo";
            this.rbAllVideo.Size = new System.Drawing.Size(82, 19);
            this.rbAllVideo.TabIndex = 5;
            this.rbAllVideo.TabStop = true;
            this.rbAllVideo.Text = "Toàn video";
            this.rbAllVideo.UseVisualStyleBackColor = true;
            this.rbAllVideo.CheckedChanged += new System.EventHandler(this.rbAllVideo_CheckedChanged);
            // 
            // lbPathTimeVideo
            // 
            this.lbPathTimeVideo.AutoSize = true;
            this.lbPathTimeVideo.Location = new System.Drawing.Point(16, 50);
            this.lbPathTimeVideo.Name = "lbPathTimeVideo";
            this.lbPathTimeVideo.Size = new System.Drawing.Size(50, 15);
            this.lbPathTimeVideo.TabIndex = 4;
            this.lbPathTimeVideo.Text = "Vị trí file";
            // 
            // tbPathTimeVideo
            // 
            this.tbPathTimeVideo.Location = new System.Drawing.Point(67, 47);
            this.tbPathTimeVideo.Name = "tbPathTimeVideo";
            this.tbPathTimeVideo.Size = new System.Drawing.Size(217, 23);
            this.tbPathTimeVideo.TabIndex = 4;
            // 
            // lbExportImage
            // 
            this.lbExportImage.AutoSize = true;
            this.lbExportImage.Location = new System.Drawing.Point(6, 49);
            this.lbExportImage.Name = "lbExportImage";
            this.lbExportImage.Size = new System.Drawing.Size(81, 15);
            this.lbExportImage.TabIndex = 2;
            this.lbExportImage.Text = "Xuất hình ảnh";
            // 
            // lbScanChoose
            // 
            this.lbScanChoose.AutoSize = true;
            this.lbScanChoose.Location = new System.Drawing.Point(6, 72);
            this.lbScanChoose.Name = "lbScanChoose";
            this.lbScanChoose.Size = new System.Drawing.Size(72, 15);
            this.lbScanChoose.TabIndex = 4;
            this.lbScanChoose.Text = "Chế độ quét";
            // 
            // lbTextNameVideo
            // 
            this.lbTextNameVideo.AutoSize = true;
            this.lbTextNameVideo.Location = new System.Drawing.Point(6, 27);
            this.lbTextNameVideo.Name = "lbTextNameVideo";
            this.lbTextNameVideo.Size = new System.Drawing.Size(57, 15);
            this.lbTextNameVideo.TabIndex = 5;
            this.lbTextNameVideo.Text = "Tên video";
            // 
            // lbPathVideo
            // 
            this.lbPathVideo.AutoSize = true;
            this.lbPathVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPathVideo.Location = new System.Drawing.Point(15, 9);
            this.lbPathVideo.Name = "lbPathVideo";
            this.lbPathVideo.Size = new System.Drawing.Size(92, 15);
            this.lbPathVideo.TabIndex = 1;
            this.lbPathVideo.Text = "Path chứa video";
            // 
            // lbPathOutput
            // 
            this.lbPathOutput.AutoSize = true;
            this.lbPathOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPathOutput.Location = new System.Drawing.Point(15, 40);
            this.lbPathOutput.Name = "lbPathOutput";
            this.lbPathOutput.Size = new System.Drawing.Size(72, 15);
            this.lbPathOutput.TabIndex = 3;
            this.lbPathOutput.Text = "Path Output";
            // 
            // tbPathOutput
            // 
            this.tbPathOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPathOutput.Location = new System.Drawing.Point(106, 40);
            this.tbPathOutput.Name = "tbPathOutput";
            this.tbPathOutput.Size = new System.Drawing.Size(496, 23);
            this.tbPathOutput.TabIndex = 5;
            // 
            // tbPathVideo
            // 
            this.tbPathVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPathVideo.Location = new System.Drawing.Point(106, 6);
            this.tbPathVideo.Name = "tbPathVideo";
            this.tbPathVideo.Size = new System.Drawing.Size(496, 23);
            this.tbPathVideo.TabIndex = 6;
            // 
            // btPathOutput
            // 
            this.btPathOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btPathOutput.Location = new System.Drawing.Point(608, 40);
            this.btPathOutput.Name = "btPathOutput";
            this.btPathOutput.Size = new System.Drawing.Size(180, 23);
            this.btPathOutput.TabIndex = 7;
            this.btPathOutput.Text = "Chọn vị trí";
            this.btPathOutput.UseVisualStyleBackColor = true;
            this.btPathOutput.Click += new System.EventHandler(this.btPathOutput_Click);
            // 
            // btGetPathVideo
            // 
            this.btGetPathVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGetPathVideo.Location = new System.Drawing.Point(608, 4);
            this.btGetPathVideo.Name = "btGetPathVideo";
            this.btGetPathVideo.Size = new System.Drawing.Size(180, 23);
            this.btGetPathVideo.TabIndex = 8;
            this.btGetPathVideo.Text = "Quét video trong thư mục";
            this.btGetPathVideo.UseVisualStyleBackColor = true;
            this.btGetPathVideo.Click += new System.EventHandler(this.btGetPathVideo_Click);
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(422, 69);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(366, 23);
            this.btRun.TabIndex = 9;
            this.btRun.Text = "Thực thi";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btPathOutput);
            this.Controls.Add(this.btGetPathVideo);
            this.Controls.Add(this.tbPathVideo);
            this.Controls.Add(this.tbPathOutput);
            this.Controls.Add(this.lbPathVideo);
            this.Controls.Add(this.lbPathOutput);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInfoVideo);
            this.Controls.Add(this.gbListVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbListVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListvideo)).EndInit();
            this.gbOutput.ResumeLayout(false);
            this.gbInfoVideo.ResumeLayout(false);
            this.gbInfoVideo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListVideo;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbInfoVideo;
        private System.Windows.Forms.Label lbExportImage;
        private System.Windows.Forms.TextBox tbPathTimeVideo;
        private System.Windows.Forms.Label lbPathTimeVideo;
        private System.Windows.Forms.Label lbScanChoose;
        private System.Windows.Forms.Label lbTextNameVideo;
        private System.Windows.Forms.Label lbPathVideo;
        private System.Windows.Forms.Label lbPathOutput;
        private System.Windows.Forms.TextBox tbPathOutput;
        private System.Windows.Forms.TextBox tbPathVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAllVideo;
        private System.Windows.Forms.Button btSaveOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btGetPathTimeVideo;
        private System.Windows.Forms.RadioButton rbNotAllVideo;
        private System.Windows.Forms.Button btPathOutput;
        private System.Windows.Forms.Button btGetPathVideo;
        private System.Windows.Forms.DataGridView dgvListvideo;
        private System.Windows.Forms.CheckBox cbExportImage;
        private System.Windows.Forms.Label lbNameVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNameVideo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvHaveExportImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcCheckAllVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPathTimeVideo;
        private System.Windows.Forms.Button btRun;
    }
}

