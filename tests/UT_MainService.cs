using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cron.Plugins;
using Cron.Network.P2P.Payloads;
using Cron;
using Cron.Persistence;
//using Settings = Cron.Plugins.Settings;
using System.Collections.Generic;
using Cron.Cryptography;
using System.Numerics;
using System.Collections;
using System.Linq;
using System;
using Moq;
// Cron.CLI
using Cron.Shell;
using Cron.SmartContract;

namespace Cron.CLI.UnitTests
{
    [TestClass]
    public class UT_MainService
    {
        private static readonly Random _random = new Random(11121990);

        MainService uut;

        [TestInitialize]
        public void TestSetup()
        {
            uut = new MainService();
        }

        [TestMethod]
        public void TestTemplate()
        {
            // Nothing to do here now... put some tests
        }
    }
}
