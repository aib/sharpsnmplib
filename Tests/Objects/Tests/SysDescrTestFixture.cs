﻿using Lextm.SharpSnmpLib.Pipeline;
using NUnit.Framework;

namespace Lextm.SharpSnmpLib.Objects.Tests
{
    [TestFixture]
    [Category("Default")]
    public class SysDescrTestFixture
    {
        [Test]
        public void Test()
        {
            var sys = new SysDescr();
            Assert.Throws<AccessFailureException>(() => sys.Data = OctetString.Empty);
        }
    }
}
