using System.Collections.Generic;

namespace WoogieWare.Library.TvBoxSet.Models
{
    public class Show
    {
        public Show()
        {
            Series = new List<Series>();
            Name = string.Empty;
        }

        public string Name { get; set; }
        public IEnumerable<Series> Series { get; set; }
    }
}
