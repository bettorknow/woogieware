using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;
using WoogieWare.Library.TvBoxSet.Models;

namespace WoogieWare.Library.TvBoxSet.Test.Models
{
    [TestFixture] 
    public class SeriesTest
    {
        [Test]
        public void CanClassBeInstantiated()
        {
            var testSeries = new Series();
            Assert.That(testSeries, Is.InstanceOf<Series>());
        }

        [Test]
        public void CanPropertiesBeInvoked()
        {
            var testSeries = new Series();
            Assert.That(testSeries.Name, Is.EqualTo(string.Empty));
            Assert.That(testSeries.Episodes, Is.Not.Null);
            Assert.That(testSeries.Episodes.Count(), Is.EqualTo(0));
        }
    }
}
