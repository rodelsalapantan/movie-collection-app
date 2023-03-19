using OnlineMovieDownloaderApp.Model;
using OnlineMovieDownloaderApp.Repository;
using Org.BouncyCastle.Crypto.Operators;
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
    public partial class ViewCollectionForm : Form
    {
        private readonly MovieRepository _movieRepo = new MovieRepository();
        private MovieModel selectedMovie = new MovieModel();
        private List<MovieModel> movieList;
        public ViewCollectionForm()
        {
            InitializeComponent();
        }
        
        private void ViewCollectionForm_Load(object sender, EventArgs e)
        {
            RefreshMovieList();
        }
        private async void RefreshMovieList()
        {
            movieList = (List<MovieModel>)await _movieRepo.GetAll();

            bindingSource.DataSource = movieList;
            dataGridView.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
        }

        private void createNewbtn_Click(object sender, EventArgs e)
        {
            Form addNewMovie = new AddMovieForm();
            addNewMovie.ShowDialog();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // if no item selected, return error
            if(dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Select item first", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var showUpdateDialog = new UpdateMovieForm(selectedMovie);
            showUpdateDialog.ShowDialog();
            RefreshMovieList();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                this.selectedMovie = (MovieModel)selectedRow.DataBoundItem;
            }
        }

        private async void deletebtn_Click(object sender, EventArgs e)
        {
            // if no item selected, return error
            if (dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Select item first", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show(
               $"Are you sure you want to delete: \"{selectedMovie.MovieName}\"", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                var deleteResult = await _movieRepo.Delete(selectedMovie.Id);

                if (deleteResult)
                {
                    MessageBox.Show("Delete successfully", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshMovieList();
                }
                else
                {
                    MessageBox.Show("Error occured while deleting item.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();
            if (searchText.Length > 0)
            {
                List<MovieModel> filteredmovieList = movieList
                    .Where( movie => 
                        movie.MovieName.ToLower().Contains( searchText.ToLower() )
                    ).ToList();

                bindingSource.DataSource = filteredmovieList;
                dataGridView.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;
            }
            else
            {
                bindingSource.DataSource = movieList;
                dataGridView.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;
            }
        }
    }
}
