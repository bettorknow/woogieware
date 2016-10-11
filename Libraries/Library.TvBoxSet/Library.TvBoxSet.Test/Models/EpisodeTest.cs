using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WoogieWare.Library.TvBoxSet.Models;

namespace WoogieWare.Library.TvBoxSet.Test.Models
{
    [TestFixture]
    public class EpisodeTest
    {
        [Test]
        public void CanClassBeInstantiated()
        {
            var testEpisode = new Episode();
            Assert.That(testEpisode, Is.InstanceOf<Episode>());
        }

        [Test]
        public void CanPropertiesBeInvoked()
        {
            var testEpisode = new Episode();
            Assert.That(testEpisode.Name, Is.EqualTo(string.Empty));
            Assert.That(testEpisode.Rating, Is.EqualTo(0));
            Assert.That(testEpisode.RunningTime, Is.EqualTo(TimeSpan.Zero));
            Assert.That(testEpisode.Synopsis, Is.EqualTo(String.Empty));
        }
    }
}
