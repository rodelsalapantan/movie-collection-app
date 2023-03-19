using OnlineMovieDownloaderApp.Forms.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieDownloaderApp.Forms.Admin
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            DashboardForm dashForm = new DashboardForm();
            SwitchPanelBody(dashForm);

            this.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Header.Logout();
        }

        private void SwitchPanelBody(Form newform)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(mainPanel.Controls.Count - 1);
            }
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            newform.ShowInTaskbar = false;
            mainPanel.Controls.Add(newform);
            
            newform.Show();
        }

        private void viewCollectionBtn_Click(object sender, EventArgs e)
        {
            SwitchPanelBody(new ViewCollectionForm());
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            SwitchPanelBody(new DashboardForm());
        }
        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            Form addNewMovie = new AddMovieForm();
            this.Hide();
            var showDialogResult = addNewMovie.ShowDialog();
            SwitchPanelBody(new DashboardForm()); // refresh list
            this.Show();
        }
    }
}
