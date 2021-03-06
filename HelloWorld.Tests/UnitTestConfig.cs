﻿using System;

using NUnit.Framework;
using System.Configuration;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class UnitTestConfig
    {
        private static readonly Random Rnd = new Random();

        [Test]
        public void TestMethodConfig()
        {
            Console.Write(System.IO.Path.GetFileName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile));
            var message = ConfigurationManager.AppSettings["TestMessage"];
            Assert.IsNotNull(message);
        }
    }
}
