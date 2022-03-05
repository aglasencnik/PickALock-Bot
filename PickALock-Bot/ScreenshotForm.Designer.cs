namespace PickALock_Bot
{
    partial class ScreenshotForm
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
            this.pbx_canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_canvas
            // 
            this.pbx_canvas.BackColor = System.Drawing.Color.Transparent;
            this.pbx_canvas.Location = new System.Drawing.Point(288, 110);
            this.pbx_canvas.Name = "pbx_canvas";
            this.pbx_canvas.Size = new System.Drawing.Size(241, 148);
            this.pbx_canvas.TabIndex = 1;
            this.pbx_canvas.TabStop = false;
            this.pbx_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_canvas_Paint);
            this.pbx_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_canvas_MouseDown);
            this.pbx_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_canvas_MouseMove);
            this.pbx_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_canvas_MouseUp);
            // 
            // ScreenshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbx_canvas);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenshotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Lock Bot";
            this.Load += new System.EventHandler(this.ScreenshotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbx_canvas;
    }
}