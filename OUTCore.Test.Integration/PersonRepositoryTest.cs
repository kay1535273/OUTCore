using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OUTCore.Dal.Interfaces;

namespace OUTCore.Test.Integration
{
    [TestClass]
    public class PersonRepositoryTest : IntegrationTestBase<IPersonRepository> 
    {
        [TestMethod]
        public void Given_GetPerson_Then_Returns_Persons()
        {
            var list = Instance.GetPersons();

            Assert.IsTrue(list.Any());

        }
    }
}
