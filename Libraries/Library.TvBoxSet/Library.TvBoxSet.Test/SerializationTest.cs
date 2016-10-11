using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework.Internal;
using NUnit.Framework;
using WoogieWare.Library.TvBoxSet.Models;

namespace WoogieWare.Library.TvBoxSet.Test
{
    [TestFixture]
    public class SerializationTest
    {
        [Test]
        public void CanShowBeSerialized()
        {
            var episodes = new List<Episode>
            {
                new Episode
                {
                    Name = "Mountain and the viper",
                    Rating = 2,
                    RunningTime = TimeSpan.MaxValue,
                    Synopsis = "Cool Episode"
                }
            };
            var series = new List<Series> {new Series {Name = "Series 4", Episodes = episodes}};
            var show = new Show
            {
                Name = "Game of Thrones",
                Series = series
            };

            var json = JsonConvert.SerializeObject(show);
            var bin = JsonConvert.DeserializeObject<Show>(json);

            Assert.That(bin, Is.Not.Null);
            Assert.That(bin.Name, Is.EqualTo(show.Name));
            Assert.That(bin.Series.Count(), Is.EqualTo(show.Series.Count()));
            
            var actualSeries = bin.Series.Single();
            var expectedSeries = series.Single();

            Assert.That(actualSeries.Name, Is.EqualTo(expectedSeries.Name));
            Assert.That(actualSeries.Episodes.Count(), Is.EqualTo(expectedSeries.Episodes.Count()));
            
            var actualEpisode = actualSeries.Episodes.Single();
            var expectedEpisode = episodes.Single();

            Assert.That(actualEpisode.Name, Is.EqualTo(expectedEpisode.Name));
            Assert.That(actualEpisode.Rating, Is.EqualTo(expectedEpisode.Rating));
            Assert.That(actualEpisode.RunningTime, Is.EqualTo(expectedEpisode.RunningTime));
            Assert.That(actualEpisode.Synopsis, Is.EqualTo(expectedEpisode.Synopsis));
       
        }
    }
}
