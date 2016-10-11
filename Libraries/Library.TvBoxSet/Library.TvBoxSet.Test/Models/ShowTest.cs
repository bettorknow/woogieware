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
    public class ShowTest
    {
        [Test]
        public void CanClassBeInstantiated()
        {
            var testShow = new Show();
            Assert.That(testShow, Is.InstanceOf<Show>());
        }

        [Test]
        public void CanPropertiesBeInvoked()
        {
            var testShow = new Show();
            Assert.That(testShow.Name, Is.EqualTo(string.Empty));
            Assert.That(testShow.Series, Is.Not.Null);
            Assert.That(testShow.Series.Count(), Is.EqualTo(0));
        }
    }
}
