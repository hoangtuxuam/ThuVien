namespace ThuVien.GUI.BaoCao
{
    partial class DocGiaa
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
            this.docGia1 = new ThuVien.GUI.BaoCao.DocGia();
            this.SuspendLayout();
            // 
            // docGia1
            // 
            this.docGia1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.docGia1.Location = new System.Drawing.Point(0, -1);
            this.docGia1.Name = "docGia1";
            this.docGia1.Size = new System.Drawing.Size(849, 475);
            this.docGia1.TabIndex = 0;
            // 
            // DocGiaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 473);
            this.Controls.Add(this.docGia1);
            this.Name = "DocGiaa";
            this.Text = "DocGiaa";
            this.ResumeLayout(false);

        }

        #endregion

        private DocGia docGia1;
    }
}