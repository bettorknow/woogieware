using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoogieWare.Library.TvBoxSet.Models
{
    public class Episode
    {
        public Episode()
        {
            Name = string.Empty;
            RunningTime = TimeSpan.Zero;
            Rating = 0;
            Synopsis = string.Empty;
        }

        public string Name { get; set; }
        public TimeSpan RunningTime { get; set; }
        public int Rating { get; set; }
        public string Synopsis { get; set; }
    }
}
