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
    public partial class UpdateMovieForm : Form
    {
        private MovieModel _movie;
        private MovieRepository _movieRepo = new MovieRepository();
        public UpdateMovieForm(MovieModel movie)
        {
            InitializeComponent();
            _movie = movie;
        }

        private void UpdateMovieForm_Load(object sender, EventArgs e)
        {
            movieNameTextBox.Text = _movie.MovieName;
            authorTextBox.Text = _movie.Author;
            genreTextBox.Text = _movie.Genre;
            actorTextBox.Text = _movie.Actor;
            dateTimePicker.Value = _movie.ReleaseDate;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
                return;

            _movie.MovieName = movieNameTextBox.Text;
            _movie.Author = authorTextBox.Text;
            _movie.Genre = genreTextBox.Text;
            _movie.Actor = actorTextBox.Text;
            _movie.ReleaseDate =  dateTimePicker.Value;


            bool result = await _movieRepo.Update(_movie.Id, _movie);
            if(result)
            {
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error Occured while updating", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private bool IsFormValid()
        {
            bool flagResult = true;

            var controlList = new List<Control>
            {
                movieNameTextBox,
                authorTextBox,
                genreTextBox,
                actorTextBox
            };

            foreach (var item in controlList)
            {
                bool isValid = isControlValid(item);
                if (!isValid) flagResult = false;
            }

            return flagResult;
        }
        private bool isControlValid(Control control)
        {
            if (control.Text.Trim().Equals(String.Empty))
            {
                errorProvider.SetError(control, "Field required");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
    }
}
