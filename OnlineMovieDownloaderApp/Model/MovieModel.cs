using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieDownloaderApp.Model
{
    [Table("movie")]
    public class MovieModel
    {
        [Column("id")]
        public int? Id { get; set; }

        [Column("moviename")]
        public string MovieName { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("genre")]
        public string Genre { get; set; }

        [Column("actor")]
        public string Actor { get; set; }

        [Column("filesize")]
        public long FileSize { get; set; }

        [Column("filelocation")]
        public string FileLocation { get; set; }

        [Column("portraitthumbnaillocation")]
        public string PortraitThumbnailLocation { get; set; }

        [Column("landscapethumbnaillocation")]
        public string LandscapeThumbnailLocation { get; set; }


        [Column("downloadcount")]
        public int? DownloadCount { get; set; } = 0;

        [Column("ratings")]
        public double? Ratings { get; set; } = 0;

        [Column("ratingscount")]
        public int? RatingsCount { get; set; } = 0;

        [Column("releasedate")]
        public DateTime ReleaseDate { get; set; }

        [Column("createdat")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        
    }
}
