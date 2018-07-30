using System;
using NUnit.Framework;
using Test;

namespace SeleniumTests
{
    [TestFixture]
    public class HelperUnitTest
    {
        [TestCase("http://localhost/", "addressbook")]
        public void TestUriCreator(string uri1, string uri2)
        {
            var link = UriHelper.GenerateUri(uri1, "addressbook");
            Assert.AreEqual("http://localhost/addressbook", link.ToString());
        }
    }
}
