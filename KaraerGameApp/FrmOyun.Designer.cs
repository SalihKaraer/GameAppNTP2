namespace WindowsFormsApp2
{
    partial class FrmOyun
    {
     
        private System.ComponentModel.IContainer components = null;

       
        /// <param name="disposing".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.pnlhud = new System.Windows.Forms.Panel();
            this.lblsr = new System.Windows.Forms.Label();
            this.lblsk = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlhud.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 400;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // pnlhud
            // 
            this.pnlhud.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlhud.Controls.Add(this.lblsr);
            this.pnlhud.Controls.Add(this.lblsk);
            this.pnlhud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlhud.Location = new System.Drawing.Point(676, 0);
            this.pnlhud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlhud.Name = "pnlhud";
            this.pnlhud.Size = new System.Drawing.Size(110, 397);
            this.pnlhud.TabIndex = 0;
            // 
            // lblsr
            // 
            this.lblsr.AutoSize = true;
            this.lblsr.Location = new System.Drawing.Point(18, 25);
            this.lblsr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsr.Name = "lblsr";
            this.lblsr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsr.Size = new System.Drawing.Size(38, 17);
            this.lblsr.TabIndex = 1;
            this.lblsr.Text = "Süre";
            // 
            // lblsk
            // 
            this.lblsk.AutoSize = true;
            this.lblsk.Location = new System.Drawing.Point(18, 71);
            this.lblsk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsk.Name = "lblsk";
            this.lblsk.Size = new System.Drawing.Size(37, 17);
            this.lblsk.TabIndex = 0;
            this.lblsk.Text = "Skor";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // FrmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 397);
            this.Controls.Add(this.pnlhud);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOyun";
            this.Tag = "Oyun";
            this.Text = "Karaer";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.pnlhud.ResumeLayout(false);
            this.pnlhud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Panel pnlhud;
        private System.Windows.Forms.Label lblsr;
        private System.Windows.Forms.Label lblsk;
        private System.Windows.Forms.Timer tmrSure;
    }
}