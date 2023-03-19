using MySqlX.XDevAPI.Common;
using OnlineMovieDownloaderApp.Data;
using OnlineMovieDownloaderApp.Model;
using OnlineMovieDownloaderApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineMovieDownloaderApp.Forms.Admin
{
    
    public partial class AddMovieForm : Form
    {
        private readonly MovieRepository _movieRepo = new MovieRepository(); 
        delegate void SetTextCallback(string text, Control control);
        public OpenFileDialog openMovieFileDialog = new OpenFileDialog() {
            InitialDirectory = ConfigSettings.GetMovieDir(),
            Title = "Select file to be upload.",
            Filter = "Media Files|*.mp4",
            FilterIndex = 0,
            Multiselect = false
        };
        public OpenFileDialog openPortraitThumbnailFileDialog = new OpenFileDialog()
        {
            InitialDirectory = ConfigSettings.GetThumbnailDir(),
            Title = "Select file to be upload.",
            Filter = "Media Files|*.jpeg; *.png; *.jpg",
            FilterIndex = 0,
            Multiselect = false
        };
        public OpenFileDialog openLandscapeThumbnailFileDialog = new OpenFileDialog()
        {
            InitialDirectory = ConfigSettings.GetThumbnailDir(),
            Title = "Select file to be upload.",
            Filter = "Media Files|*.jpeg; *.png; *.jpg",
            FilterIndex = 0,
            Multiselect = false
        };


        public AddMovieForm()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = DateTime.Now;
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
                return;

            DisableAllControl(false);
            statusLabel.Visible = true;
            progressBar.Visible = true;
            backgroundWorker.RunWorkerAsync();
            DisableAllControl(true);
        }


        /// <summary>
        ///     On Movie Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadMovieBtn_Click(object sender, EventArgs e)
        {

            Thread newThread = new Thread( 
                new ThreadStart(()  => 
                ThreadMethod(openMovieFileDialog, videoTextBox)) );
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }


        /// <summary>
        ///     On Portrait Thumbnail Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadPortaitThumbnailBtn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(
                new ThreadStart(() => 
                    ThreadMethod(openPortraitThumbnailFileDialog, portraitThumbnailTextBox)));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        /// <summary>
        ///     On Landscape Thumbnail Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadLandscapeThumbnailBtn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(
                new ThreadStart(() =>
                    ThreadMethod(openLandscapeThumbnailFileDialog, landscapeThumbnailTextBox)));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        /// <summary>
        ///     On New Thread Start
        /// </summary>
        /// <param name="openFileDialog"></param>
        /// <param name="control"></param>
        private void ThreadMethod(OpenFileDialog openFileDialog, Control control)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Before attempting to save the file, verify
                    // that the FileUpload control contains a file.

                    // Call a helper method routine to save the file.
                    if (openFileDialog.CheckFileExists)
                    {
                        // show the file name in text box
                        control.ForeColor = Color.White;
                        SetText(openFileDialog.SafeFileName, control);
                    }

                    else
                    {
                        // Notify the user that a file was not uploaded.
                        control.ForeColor = Color.SkyBlue;
                        SetText("SELECT FILE", control);
                    }
                    
                }
                else
                {
                    control.ForeColor = Color.SkyBlue;
                    SetText("PLEASE SELECT FILE.", control);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());

            }
        }
 

        /// <summary>
        ///     dynamic param must be any Control of Form class
        /// </summary>
        /// <param name="text"></param>
        /// <param name="control"></param>
        private void SetText(string text, Control control)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, control });
            }
            else
            {
                control.Text = text;
            }
        }
        
        
        /// <summary>
        ///     Disable all controls
        /// </summary>
        /// <param name="status"></param>
        private void DisableAllControl(bool status)
        {
            movieNameTextBox.Enabled = status;
            authorTextBox.Enabled = status;
            genreTextBox.Enabled = status;
            actorTextBox.Enabled = status;
            dateTimePicker.Enabled = status;

            uploadMovieBtn.Enabled = status;
            cancelbtn.Enabled = status;
            saveBtn.Enabled = status;
            uploadPortaitThumbnailBtn.Enabled = status;
            uploadLandscapeThumbnailBtn.Enabled = status;
        }

        /// <summary>
        ///     Check if all the form submitted is valid
        /// </summary>
        /// <returns></returns>
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

            var openFileList = new List<OpenFileDialog>
            {
                openMovieFileDialog,
                openPortraitThumbnailFileDialog,
                openLandscapeThumbnailFileDialog
            };

            foreach(var item in controlList)
            {
                bool isValid = isControlValid(item);
                if (!isValid) flagResult = false; 
            }

            foreach (var item in openFileList)
            {
                bool isValid = isOpenFileDialogValid(item);
                if (!isValid) flagResult = false;
            }

            return flagResult;
        }

        /// <summary>
        ///     Check field if valid
        /// </summary>
        /// <param name="control"></param>
        /// <returns>bool</returns>
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
        /// <summary>
        ///     Check if Files Exists
        /// </summary>
        /// <param name="ofd"></param>
        /// <returns></returns>
        private bool isOpenFileDialogValid(OpenFileDialog ofd)
        {
            return ofd.CheckFileExists;
        }



        private async void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // VIDEO AREA
            string videoFullFileName = openMovieFileDialog.FileName;
            //string videoFileName = openMovieFileDialog.SafeFileName;
            string videoFileExtension = Path.GetExtension(videoFullFileName);
            int videoFileSize = (int)new FileInfo(videoFullFileName).Length;

            string movieDestPath;
            string newFileNameMovie;
            int iter = 0;
            do
            {
                newFileNameMovie = GenerateRandomFileName(iter, videoFileExtension);
                movieDestPath = Path.Combine(ConfigSettings.GetMovieDir(), newFileNameMovie);
                iter++;
            } while ( File.Exists(movieDestPath) );
            

            // LANDSCAPE THUMBNAIL AREA
            string landscapeFullFileName = openLandscapeThumbnailFileDialog.FileName;
            string landscapeFileExtension = Path.GetExtension(landscapeFullFileName);

            string landscapeDestPath;
            string newFileNameLandscape;
            do
            {
                newFileNameLandscape = GenerateRandomFileName(iter, landscapeFileExtension);
                landscapeDestPath = Path.Combine(ConfigSettings.GetThumbnailDir(), newFileNameLandscape);
                iter++;
            } while (File.Exists(landscapeDestPath));


            // PORTRAIT THUMBNAIL AREA
            string portraitFullFileName = openPortraitThumbnailFileDialog.FileName;
            string portraitFileExtension = Path.GetExtension(portraitFullFileName);

            string portraitDestPath;
            string newFileNamePortait;
            do
            {

                newFileNamePortait = GenerateRandomFileName(iter, portraitFileExtension);
                portraitDestPath = Path.Combine(ConfigSettings.GetThumbnailDir(), newFileNamePortait);

                iter++;
            } while (File.Exists(portraitDestPath));

            SaveFile(videoFullFileName, movieDestPath); // save video file
            SaveFile(landscapeFullFileName, landscapeDestPath); // save landscape image file
            SaveFile(portraitFullFileName, portraitDestPath); // save portrait image file


            // DATABASE TRANSACTION

            MovieModel movie = new MovieModel(); // store all values
            movie.MovieName = movieNameTextBox.Text.Trim();
            movie.Author = authorTextBox.Text.Trim();
            movie.Actor = actorTextBox.Text.Trim();
            movie.Genre = genreTextBox.Text.Trim();
            movie.ReleaseDate = dateTimePicker.Value;
            movie.FileLocation = newFileNameMovie;
            movie.FileSize = videoFileSize;
            movie.LandscapeThumbnailLocation = newFileNameLandscape;
            movie.PortraitThumbnailLocation = newFileNamePortait;

            bool insertResult = await _movieRepo.Create(movie);

            Thread.Sleep(200);

            if (!insertResult)
                MessageBox.Show("Error Occured while saving file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Uploaded Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private string GenerateRandomFileName(int num, string fileExt)
        {
            DateTime dateNow = DateTime.Now;
            
            string randGuid = Guid.NewGuid().ToString();
            string hashedRandGuid = StringEncryption.GetMD5Hash(randGuid);
            string dateToString = dateNow.ToString("MM-dd-yyyy");
            string hashedDateString = StringEncryption.GetMD5Hash(dateToString);

            string newFileName = $"{num}-{dateToString}-{hashedDateString}-{hashedRandGuid}{fileExt}";
            
            return newFileName;
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Invoke( (MethodInvoker)( () => progressBar.Value = e.ProgressPercentage) );
            statusLabel.Invoke((MethodInvoker)(() =>
                {
                    if (progressBar.Value != progressBar.Maximum)
                        statusLabel.Text = $"Uploading files: {progressBar.Value}%";
                    else
                        statusLabel.Text = "Saved successfully";
                }
            ));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            this.Invoke( (MethodInvoker)( () => this.Close() ) );
        }


        /// <summary>
        ///      Process all Uploads
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        private void SaveFile(string source, string destination)
        {
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);

            byte[] buffer = new byte[2000000];
            int readByte;

            while ((readByte = fsIn.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsOut.Write(buffer, 0, readByte);
                backgroundWorker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();

        }
    }
}
