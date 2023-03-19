using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using OnlineMovieDownloaderApp.Data;
using OnlineMovieDownloaderApp.Forms.Admin;
using OnlineMovieDownloaderApp.Forms.Login;
using OnlineMovieDownloaderApp.Model;
using OnlineMovieDownloaderApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieDownloaderApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static IConfiguration config;
        public static ApplicationContext AppContext { get; set; } // save current main form 


        [STAThread]
        static async Task Main()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            config = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!TryStartDbConnection()) // try to start connection
                Environment.Exit(0); // exit if app failed to connect in database

            await RedirectUser();

            Application.Run(AppContext);
        }

        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            oldMainForm?.Hide();
            AppContext.MainForm = newForm;
            oldMainForm?.Close();
            newForm.Show();
        }

        private static bool TryStartDbConnection()
        {
            string conString = ConfigSettings.GetConnectionString();
            var con = new MySqlConnection() { ConnectionString = conString };

            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error while connecting to Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

        }
        private static async Task RedirectUser()
        {
            string userId = ConfigSettings.GetUserId();
            // if user has been logged in - go to main page
            if (userId.Length > 0)
            {
                UserRepository userRepo = new UserRepository();
                var result = await userRepo.GetOne(userId);

                if(result == null)
                {
                    MessageBox.Show("Error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                switch (result.Role)
                {
                    case "admin":
                        AppContext = new ApplicationContext(new AdminMainForm());
                        break;
                    default:
                        MessageBox.Show("You are not allowed to use this app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConfigSettings.SetUserId("");
                        AppContext = new ApplicationContext(new LoginForm());
                        break;
                }
            }
            else
            {
                AppContext = new ApplicationContext(new LoginForm());
            }
        }

        // DELETE SOON
        private static async void CreatNewDummyAccount()
        {
            UserRepository userRepo = new UserRepository();

            UserModel user = new UserModel()
            {
                Id = Guid.NewGuid().ToString(),
                Email = "user1@gmail.com",
                FirstName = "John",
                LastName = "Ramos",
                Password = StringEncryption.GetMD5Hash("11111111"),
                Role = "user"
            };

            await userRepo.Create(user);
        }
    }
}
