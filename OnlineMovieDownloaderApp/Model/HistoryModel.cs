using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieDownloaderApp.Model
{
    [Table("history")]
    public class HistoryModel
    {
        [Column("id")] 
        public int Id { get; set; }

        [Column("movie_id")] 
        public int MovieId { get; set; }

        [Column("user_id")] 
        public string UserId { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
