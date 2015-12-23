namespace ThuVien.GUI.BaoCao
{
    partial class MainBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.tabDaTra = new System.Windows.Forms.TabPage();
            this.grvPhieuDaTra = new System.Windows.Forms.DataGridView();
            this.lblDaTra = new System.Windows.Forms.Label();
            this.tabChuaTra = new System.Windows.Forms.TabPage();
            this.grvPhieuChuaTra = new System.Windows.Forms.DataGridView();
            this.txtPhieuMuon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvSach = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsoDocGia = new System.Windows.Forms.Label();
            this.grvDocGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.tabDaTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuDaTra)).BeginInit();
            this.tabChuaTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuChuaTra)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabPanel);
            this.panel1.Location = new System.Drawing.Point(9, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 467);
            this.panel1.TabIndex = 2;
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.tabDaTra);
            this.TabPanel.Controls.Add(this.tabChuaTra);
            this.TabPanel.Location = new System.Drawing.Point(3, 4);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(439, 445);
            this.TabPanel.TabIndex = 2;
            // 
            // tabDaTra
            // 
            this.tabDaTra.Controls.Add(this.grvPhieuDaTra);
            this.tabDaTra.Controls.Add(this.lblDaTra);
            this.tabDaTra.Location = new System.Drawing.Point(4, 22);
            this.tabDaTra.Name = "tabDaTra";
            this.tabDaTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaTra.Size = new System.Drawing.Size(431, 419);
            this.tabDaTra.TabIndex = 1;
            this.tabDaTra.Text = "Đã Trả";
            this.tabDaTra.UseVisualStyleBackColor = true;
            // 
            // grvPhieuDaTra
            // 
            this.grvPhieuDaTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPhieuDaTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvPhieuDaTra.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.grvPhieuDaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhieuDaTra.Location = new System.Drawing.Point(-4, -5);
            this.grvPhieuDaTra.Name = "grvPhieuDaTra";
            this.grvPhieuDaTra.RowHeadersVisible = false;
            this.grvPhieuDaTra.Size = new System.Drawing.Size(433, 402);
            this.grvPhieuDaTra.TabIndex = 4;
            // 
            // lblDaTra
            // 
            this.lblDaTra.AutoSize = true;
            this.lblDaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaTra.ForeColor = System.Drawing.Color.Red;
            this.lblDaTra.Location = new System.Drawing.Point(190, 400);
            this.lblDaTra.Name = "lblDaTra";
            this.lblDaTra.Size = new System.Drawing.Size(196, 16);
            this.lblDaTra.TabIndex = 5;
            this.lblDaTra.Text = "Có xx Phiếu Mượn Chưa Trả";
            // 
            // tabChuaTra
            // 
            this.tabChuaTra.Controls.Add(this.grvPhieuChuaTra);
            this.tabChuaTra.Controls.Add(this.txtPhieuMuon);
            this.tabChuaTra.Location = new System.Drawing.Point(4, 22);
            this.tabChuaTra.Name = "tabChuaTra";
            this.tabChuaTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuaTra.Size = new System.Drawing.Size(431, 419);
            this.tabChuaTra.TabIndex = 0;
            this.tabChuaTra.Text = "Chưa Trả";
            this.tabChuaTra.UseVisualStyleBackColor = true;
            // 
            // grvPhieuChuaTra
            // 
            this.grvPhieuChuaTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPhieuChuaTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvPhieuChuaTra.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.grvPhieuChuaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhieuChuaTra.Location = new System.Drawing.Point(-4, 0);
            this.grvPhieuChuaTra.Name = "grvPhieuChuaTra";
            this.grvPhieuChuaTra.RowHeadersVisible = false;
            this.grvPhieuChuaTra.Size = new System.Drawing.Size(433, 397);
            this.grvPhieuChuaTra.TabIndex = 2;
            // 
            // txtPhieuMuon
            // 
            this.txtPhieuMuon.AutoSize = true;
            this.txtPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuMuon.ForeColor = System.Drawing.Color.Red;
            this.txtPhieuMuon.Location = new System.Drawing.Point(229, 400);
            this.txtPhieuMuon.Name = "txtPhieuMuon";
            this.txtPhieuMuon.Size = new System.Drawing.Size(196, 16);
            this.txtPhieuMuon.TabIndex = 3;
            this.txtPhieuMuon.Text = "Có xx Phiếu Mượn Chưa Trả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvSach);
            this.panel2.Location = new System.Drawing.Point(501, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 456);
            this.panel2.TabIndex = 3;
            // 
            // grvSach
            // 
            this.grvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvSach.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.grvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSach.Location = new System.Drawing.Point(4, 4);
            this.grvSach.Name = "grvSach";
            this.grvSach.RowHeadersVisible = false;
            this.grvSach.Size = new System.Drawing.Size(233, 429);
            this.grvSach.TabIndex = 0;
            this.grvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xemChiTietDocGiaDangMuon);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblsoDocGia);
            this.panel3.Controls.Add(this.grvDocGia);
            this.panel3.Location = new System.Drawing.Point(783, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 456);
            this.panel3.TabIndex = 4;
            // 
            // lblsoDocGia
            // 
            this.lblsoDocGia.AutoSize = true;
            this.lblsoDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoDocGia.ForeColor = System.Drawing.Color.Red;
            this.lblsoDocGia.Location = new System.Drawing.Point(3, 436);
            this.lblsoDocGia.Name = "lblsoDocGia";
            this.lblsoDocGia.Size = new System.Drawing.Size(224, 16);
            this.lblsoDocGia.TabIndex = 2;
            this.lblsoDocGia.Text = "Có xx Độc Giả Đang Mượn Sách";
            // 
            // grvDocGia
            // 
            this.grvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDocGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvDocGia.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.grvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDocGia.Location = new System.Drawing.Point(3, 4);
            this.grvDocGia.Name = "grvDocGia";
            this.grvDocGia.RowHeadersVisible = false;
            this.grvDocGia.Size = new System.Drawing.Size(224, 429);
            this.grvDocGia.TabIndex = 1;
            this.grvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xemChiTietSachDangMuon);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thống Kê Phiếu Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(792, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Độc Giả Mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(543, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sách Mượn";
            // 
            // MainBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainBaoCao";
            this.Size = new System.Drawing.Size(1033, 533);
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.tabDaTra.ResumeLayout(false);
            this.tabDaTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuDaTra)).EndInit();
            this.tabChuaTra.ResumeLayout(false);
            this.tabChuaTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuChuaTra)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grvSach;
        private System.Windows.Forms.DataGridView grvDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoDocGia;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage tabDaTra;
        private System.Windows.Forms.TabPage tabChuaTra;
        private System.Windows.Forms.DataGridView grvPhieuChuaTra;
        private System.Windows.Forms.Label txtPhieuMuon;
        private System.Windows.Forms.DataGridView grvPhieuDaTra;
        private System.Windows.Forms.Label lblDaTra;
    }
}
