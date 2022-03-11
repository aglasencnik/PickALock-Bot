using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace PickALock_Bot
{
    public class LockPickingBot
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_SPACE = 0x20; //Right Control key code

        Screen screen;

        string calDate;
        string calDeviceName;
        int calScreenWidth;
        int calScreenHeight;
        Point calA;
        Point calB;
        Point calC;
        Point calD;
        int calWidth;
        int calHeight;

        bool isActive;

        Thread gameStatusThread;

        public LockPickingBot(Screen _screen)
        {
            try
            {
                screen = _screen;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        public void startBot()
        {
            try
            {
                getCalibrationData();
                restartGame();
                isActive = true;
                gameStatusThread = new Thread(getGameStatus);
                gameStatusThread.IsBackground = true;
                gameStatusThread.Start();
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        public void stopBot()
        {
            try
            {
                isActive = false;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void pressKey()
        {
            try
            {
                keybd_event(VK_SPACE, 0, KEYEVENTF_EXTENDEDKEY, 0);
                Thread.Sleep(200);
                keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void restartGame()
        {
            try
            {
                pressKey();
                Thread.Sleep(200);
                pressKey();
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void getCalibrationData()
        {
            try
            {
                string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string folderPath = Path.Combine(rootPath, "Pick A Lock Bot");
                string filePath = Path.Combine(folderPath, "calibration.txt");
                string text = File.ReadAllText(filePath);
                string[] calText = text.Split(';');
                calDate = calText[0];
                calDeviceName = calText[1];
                calScreenWidth = int.Parse(calText[2]);
                calScreenHeight = int.Parse(calText[3]);
                int x4 = int.Parse(calText[4]);
                int y4 = int.Parse(calText[5]);
                int x2 = int.Parse(calText[6]);
                int y2 = int.Parse(calText[7]);
                calA = new Point(x4, y2);
                calB = new Point(x2, y2);
                calC = new Point(x2, y4);
                calD = new Point(x4, y4);
                calWidth = calC.X - calD.X;
                calHeight = calA.Y - calD.Y;
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

        private void getGameStatus()
        {
            try
            {
                while (isActive)
                {
                    Bitmap bm = new Bitmap(calScreenWidth, calScreenHeight);
                    Graphics g = Graphics.FromImage(bm);
                    g.CopyFromScreen(calD.X, calD.Y, 0, 0, new Size(calWidth, calHeight));
                    //g.CopyFromScreen(0, 0, 0, 0, bm.Size);
                    Mat game_img = bm.ToMat();
                    Mat button_img = CvInvoke.Imread("gameRetry.JPG", ImreadModes.Unchanged);
                    CvInvoke.CvtColor(game_img, game_img, ColorConversion.Bgr2Gray);
                    CvInvoke.CvtColor(button_img, button_img, ColorConversion.Bgr2Gray);
                    Mat result = new Mat();
                    double minVal = 0;
                    double maxVal = 0;
                    Point maxLoc = new Point();
                    Point minLoc = new Point();
                    CvInvoke.MatchTemplate(game_img, button_img, result, TemplateMatchingType.Ccoeff);
                    CvInvoke.MinMaxLoc(result, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                    double threshold = 0.9;

                    if (maxVal > threshold)
                    {
                        Thread.Sleep(2000);
                        restartGame();
                    }
                    game_img.Dispose();
                    button_img.Dispose();
                    result.Dispose();
                    bm.Dispose();
                    g.Dispose();
                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler(ex);
            }
        }

    }
}
