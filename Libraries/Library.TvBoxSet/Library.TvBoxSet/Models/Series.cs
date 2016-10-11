using System.Collections.Generic;

namespace WoogieWare.Library.TvBoxSet.Models
{
    public class Series
    {
        public Series()
        {
            Episodes = new List<Episode>();
            Name = string.Empty;
        }

        public string Name { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
    }
}
