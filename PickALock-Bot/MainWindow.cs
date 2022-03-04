using System.Runtime.InteropServices;

namespace PickALock_Bot
{
    public partial class MainWindow : Form
    {
        private bool isActive;
        private bool isCalibrated;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                isActive = false;
                isCalibrated = false;

                int UniqueHotkeyId = 1;
                int HotKeyCode = (int)Keys.F9;
                Boolean F9Registered = RegisterHotKey(this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode);
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
                btn_start.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_start.Width, btn_start.Height, 30, 30));
                btn_calibrate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_calibrate.Width, btn_calibrate.Height, 30, 30));
                btn_tutorial.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_tutorial.Width, btn_tutorial.Height, 30, 30));
                btn_about.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_about.Width, btn_about.Height, 30, 30));
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                start_stop();
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void start_stop()
        {
            try
            {
                if (isCalibrated)
                {
                    if (!isActive)
                    {
                        startBot();
                    }
                    else
                    {
                        stopBot();
                    }
                }
                else
                {
                    if (MessageBox.Show("You haven't calibrated the application yet." + Environment.NewLine + "Do you want to calibrate the application now?", "Calibration warning", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        calibrate();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void startBot()
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                isActive = true;
                btn_start.BackColor = Color.DarkRed;
                LockPickingBot bot = new LockPickingBot();
                bot.startBot();
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void stopBot()
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
                isActive = false;
                btn_start.BackColor = Color.FromArgb(66, 220, 146);
                LockPickingBot bot = new LockPickingBot();
                bot.stopBot();
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_calibrate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCalibrated)
                {
                    if (MessageBox.Show("You already calibrated the application." + Environment.NewLine + "Do you want to calibrate the application again?", "Recalibration warning", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        calibrate();
                    }
                }
                else
                {
                    calibrate();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void calibrate()
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                isCalibrated = true;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_tutorial_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://aglasencnik.com");
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Amadej Glasenènik" + Environment.NewLine + "Version: 1.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_gameImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://www.y8.com/games/pick_a_lock");
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_start_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (!isActive)
                {
                    button_summary.Text = "Press this button to start the bot.";
                }
                else
                {
                    button_summary.Text = "Press this button to stop the bot.";
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_calibrate_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "Press this button to calibrate the bot.";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_calibrate_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_tutorial_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "Press this button to go to tutorial website.";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_tutorial_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_about_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "Press this button to view the about page.";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void btn_about_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_gameImage_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "Double click image to go to game's website.";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_gameImage_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                button_summary.Text = "";
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == 0x0312)
                {
                    int id = m.WParam.ToInt32();

                    if (id == 1)
                    {
                        start_stop();
                    }
                }

                base.WndProc(ref m);
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }
    }
}