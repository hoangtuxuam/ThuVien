namespace ThuVien.GUI.QuanLyMuonTra
{
    partial class MainMuonTra
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(153, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(866, 511);
            this.pnlMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTra);
            this.panel1.Controls.Add(this.btnMuon);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 514);
            this.panel1.TabIndex = 2;
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(8, 55);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(112, 41);
            this.btnTra.TabIndex = 3;
            this.btnTra.Text = "Trả sách";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(8, 8);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(112, 41);
            this.btnMuon.TabIndex = 2;
            this.btnMuon.Text = "Mượn Sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // MainMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainMuonTra";
            this.Size = new System.Drawing.Size(1033, 533);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
    }
}
