using OnlineMovieDownloaderApp.Data;
using OnlineMovieDownloaderApp.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieDownloaderApp.Forms.Components
{
    public static class Header
    {
        public static void Logout()
        {
            DialogResult res = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                ConfigSettings.SetUserId("");
                Program.SwitchMainForm(new LoginForm());
            }
        }
    }
}
