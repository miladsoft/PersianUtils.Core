using System.Linq;
using PersianUtils.Core.IranCities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersianUtils.Core.Tests
{
    [TestClass]
    public class IranCitiesTests
    {
        [TestMethod]
        public void Test_IranProvincesCount_Is_Correct()
        {
            Assert.AreEqual(31, Iran.Provinces.Count());
        }
    }
}