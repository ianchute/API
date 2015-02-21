using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Infra;
using AutoMapper;
using NUnit.Framework;

namespace API.Tests.Infra
{
    [TestFixture]
    public class MapperTest
    {
        [SetUp]
        public void Setup()
        {
            Mapper.Initialize(MapperConfiguration.Configure);
        }

        [TearDown]
        public void Teardown()
        {
            Mapper.Reset();
        }

        [Test]
        public void Test()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
