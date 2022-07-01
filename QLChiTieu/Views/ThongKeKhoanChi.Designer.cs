
namespace QLChiTieu.Views
{
    partial class ThongKeKhoanChi
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
            this.tk = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportKhoanChi1 = new QLChiTieu.Views.CrystalReportKhoanChi();
            this.SuspendLayout();
            // 
            // tk
            // 
            this.tk.ActiveViewIndex = 0;
            this.tk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tk.Cursor = System.Windows.Forms.Cursors.Default;
            this.tk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tk.Location = new System.Drawing.Point(0, 0);
            this.tk.Name = "tk";
            this.tk.ReportSource = this.CrystalReportKhoanChi1;
            this.tk.Size = new System.Drawing.Size(972, 450);
            this.tk.TabIndex = 0;
            // 
            // ThongKeKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.tk);
            this.Name = "ThongKeKhoanChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeKhoanChi";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer tk;
        private CrystalReportKhoanChi CrystalReportKhoanChi1;
    }
}