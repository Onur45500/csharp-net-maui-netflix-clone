using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_net_maui_netflix_clone.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string DisplayTitle { get; set; }
        public string MediaType { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailSmall { get; set; }
        public string ThumbnailUrl { get; set; }

        public string OverView { get; set; }
        public DateTime ReleaseDate { get; set; } 
    }
}
