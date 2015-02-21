using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Infra;
using NUnit.Framework;
using StructureMap;

namespace API.Tests.Infra
{
    [TestFixture]
    public class ContainerTest
    {
        [SetUp]
        public void Setup()
        {
            ObjectFactory.Configure(ContainerConfiguration.Configure);
        }

        [TearDown]
        public void Teardown()
        {
            ObjectFactory.Initialize();
        }

        [Test]
        public void Test()
        {
            ObjectFactory.Container.AssertConfigurationIsValid();
        }
    }
}
