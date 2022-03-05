using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace PickALock_Bot
{
    public partial class ScreenshotForm : Form
    {
        Bitmap screenshot;
        Screen screen;

        Rectangle rect;
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;

        public bool isCalibrated2 { get; set; }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public ScreenshotForm(Bitmap _screenshot, Screen _screen)
        {
            try
            {
                InitializeComponent();
                screenshot = _screenshot;
                screen = _screen;

                int FirstHotkeyId = 1;
                int FirstHotKeyKey = (int)Keys.Escape;
                Boolean EscapeRegistered = RegisterHotKey(this.Handle, FirstHotkeyId, 0x0000, FirstHotKeyKey);

                int SecondHotkeyId = 2;
                int SecondHotKeyKey = (int)Keys.F1;
                Boolean F1Registered = RegisterHotKey(this.Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey);
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void ScreenshotForm_Load(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(1500);
                this.WindowState = FormWindowState.Maximized;
                //this.BackgroundImage = screenshot;
                pbx_screenshot.Location = new Point(0, 0);
                pbx_screenshot.Width = screen.Bounds.Width;
                pbx_screenshot.Height = screen.Bounds.Height;
                pbx_screenshot.Image = screenshot;

                pbx_canvas.Size = pbx_screenshot.Size;
                pbx_canvas.Location = pbx_screenshot.Location;
                pbx_canvas.BackColor = Color.Transparent;
                pbx_canvas.BringToFront();
                pbx_canvas.Parent = this.pbx_screenshot;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private Rectangle GetRect()
        {
            try
            {
                rect = new Rectangle();
                rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
                rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
                rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
                rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
                return rect;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandlerew = new ErrorHandler(ex);
                return rect;
            }
        }

        private void pbx_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsMouseDown)
                {
                    LocationX1Y1 = e.Location;
                    pbx_canvas.Refresh();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsMouseDown)
                {
                    LocationX1Y1 = e.Location;
                    IsMouseDown = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pbx_canvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (rect != null)
                {
                    Pen pen = new Pen(Color.Red, 5);
                    e.Graphics.DrawRectangle(pen, GetRect());
                }
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
                    switch (id)
                    {
                        case 1:
                            this.isCalibrated2 = false;
                            this.Close();
                            break;
                        case 2:
                            if (!LocationXY.IsEmpty && !LocationX1Y1.IsEmpty)
                            {
                                string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                string folderPath = Path.Combine(rootPath, "Pick A Lock Bot");
                                string filePath = Path.Combine(folderPath, "calibration.txt");
                                string date = DateTime.Now.ToString("MM/dd/yyyy");
                                if (!Directory.Exists(folderPath))
                                {
                                    Directory.CreateDirectory(folderPath);
                                }
                                string text = $"{date};{screen.DeviceName};{screenshot.Width};{screenshot.Height};{LocationXY.X};{LocationXY.Y};{LocationX1Y1.X};{LocationX1Y1.Y}";
                                File.WriteAllText(filePath, text);
                                this.isCalibrated2 = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("You haven't set the game's area yet." + Environment.NewLine + "To exit calibration, you can press the Escape key.", "Calibration Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
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
