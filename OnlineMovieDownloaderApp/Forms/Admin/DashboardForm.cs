using OnlineMovieDownloaderApp.Model;
using OnlineMovieDownloaderApp.Repository;
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
    public partial class DashboardForm : Form
    {
        public readonly MovieRepository _movieRepo = new MovieRepository();
        public DashboardForm()
        {
            InitializeComponent();
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            List<MovieModel> movieList = (List<MovieModel>) await _movieRepo.GetAll();
            if(movieList == null)
            {
                return;
            }
            int totalDownloadCount = 0;
            int totalRateCount = 0;

            foreach (var movie in movieList)
            {
                totalDownloadCount += (int) movie.DownloadCount;
                totalRateCount += (int) movie.RatingsCount;
            }
            totalMovieLabel.Text = movieList.Count.ToString();
            downloadCountLabel.Text = totalDownloadCount.ToString();
            totalRateCountLabel.Text = totalRateCount.ToString();   
        }
    }
}
