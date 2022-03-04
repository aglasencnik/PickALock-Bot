using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickALock_Bot
{
    public class ErrorHandler
    {
        public ErrorHandler(Exception ex)
        {
            try
            {
                error(ex);
            }
            catch
            {
                Application.Exit();
            }
        }

        public void error(Exception ex)
        {
            try
            {
                if (MessageBox.Show("The application has encountered an unexpected error!" + Environment.NewLine + "Do you want to see more details?", "Error!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
