using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class TestFixture
    {
        #region   Setup
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            //Debugging.Debugger.Launch();
        }

        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {

        }
        #endregion Setup

        /// <summary>
        /// Test test
        /// </summary>
        [Test]
        public void Test()
        {

        }
    }
}
