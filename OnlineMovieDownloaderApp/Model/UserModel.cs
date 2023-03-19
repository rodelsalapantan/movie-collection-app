using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieDownloaderApp.Model
{
    [Table("user")]
    public class UserModel
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("firstName")]
        public string FirstName { get; set; }
        [Column("lastName")]
        public string LastName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("role")]
        public string Role { get; set; }
    }
}
