namespace PickALock_Bot
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_summary = new System.Windows.Forms.Label();
            this.pbx_gameImage = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_calibrate = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_tutorial = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button_summary
            // 
            this.button_summary.AutoSize = true;
            this.button_summary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_summary.Location = new System.Drawing.Point(12, 444);
            this.button_summary.Name = "button_summary";
            this.button_summary.Size = new System.Drawing.Size(122, 28);
            this.button_summary.TabIndex = 0;
            this.button_summary.Text = "Summary";
            // 
            // pbx_gameImage
            // 
            this.pbx_gameImage.BackgroundImage = global::PickALock_Bot.Properties.Resources.GameImage;
            this.pbx_gameImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_gameImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_gameImage.Location = new System.Drawing.Point(312, 12);
            this.pbx_gameImage.Name = "pbx_gameImage";
            this.pbx_gameImage.Size = new System.Drawing.Size(360, 396);
            this.pbx_gameImage.TabIndex = 1;
            this.pbx_gameImage.TabStop = false;
            this.pbx_gameImage.DoubleClick += new System.EventHandler(this.pbx_gameImage_DoubleClick);
            this.pbx_gameImage.MouseEnter += new System.EventHandler(this.pbx_gameImage_MouseEnter);
            this.pbx_gameImage.MouseLeave += new System.EventHandler(this.pbx_gameImage_MouseLeave);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(146)))));
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(21)))));
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(24, 18);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(267, 75);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseEnter += new System.EventHandler(this.btn_start_MouseEnter);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            // 
            // btn_calibrate
            // 
            this.btn_calibrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(146)))));
            this.btn_calibrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calibrate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(21)))));
            this.btn_calibrate.FlatAppearance.BorderSize = 0;
            this.btn_calibrate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_calibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calibrate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calibrate.Location = new System.Drawing.Point(24, 116);
            this.btn_calibrate.Name = "btn_calibrate";
            this.btn_calibrate.Size = new System.Drawing.Size(267, 75);
            this.btn_calibrate.TabIndex = 3;
            this.btn_calibrate.Text = "Calibrate";
            this.btn_calibrate.UseVisualStyleBackColor = false;
            this.btn_calibrate.Click += new System.EventHandler(this.btn_calibrate_Click);
            this.btn_calibrate.MouseEnter += new System.EventHandler(this.btn_calibrate_MouseEnter);
            this.btn_calibrate.MouseLeave += new System.EventHandler(this.btn_calibrate_MouseLeave);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(146)))));
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(21)))));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_about.Location = new System.Drawing.Point(24, 313);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(267, 75);
            this.btn_about.TabIndex = 5;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            this.btn_about.MouseEnter += new System.EventHandler(this.btn_about_MouseEnter);
            this.btn_about.MouseLeave += new System.EventHandler(this.btn_about_MouseLeave);
            // 
            // btn_tutorial
            // 
            this.btn_tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(220)))), ((int)(((byte)(146)))));
            this.btn_tutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tutorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(146)))), ((int)(((byte)(21)))));
            this.btn_tutorial.FlatAppearance.BorderSize = 0;
            this.btn_tutorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tutorial.Location = new System.Drawing.Point(24, 214);
            this.btn_tutorial.Name = "btn_tutorial";
            this.btn_tutorial.Size = new System.Drawing.Size(267, 75);
            this.btn_tutorial.TabIndex = 4;
            this.btn_tutorial.Text = "Tutorial";
            this.btn_tutorial.UseVisualStyleBackColor = false;
            this.btn_tutorial.Click += new System.EventHandler(this.btn_tutorial_Click);
            this.btn_tutorial.MouseEnter += new System.EventHandler(this.btn_tutorial_MouseEnter);
            this.btn_tutorial.MouseLeave += new System.EventHandler(this.btn_tutorial_MouseLeave);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.version.Location = new System.Drawing.Point(24, 407);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(150, 24);
            this.version.TabIndex = 6;
            this.version.Text = "Version: 1.0.0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.version);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_tutorial);
            this.Controls.Add(this.btn_calibrate);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pbx_gameImage);
            this.Controls.Add(this.button_summary);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Lock Bot";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label button_summary;
        private PictureBox pbx_gameImage;
        private Button btn_start;
        private Button btn_calibrate;
        private Button btn_about;
        private Button btn_tutorial;
        private Label version;
    }
}