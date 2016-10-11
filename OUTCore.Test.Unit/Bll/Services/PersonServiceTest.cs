using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OUTCore.Bll.Interfaces;
using OUTCore.Bll.Services;
using OUTCore.Bll.Services.Person;
using OUTCore.Dal.Interfaces;
using OUTCore.Domain;

namespace OUTCore.Test.Unit.Bll.Services
{
    /// <summary>
    /// Summary description for PersonServiceTest
    /// </summary>
    [TestClass]

    public class PersonServiceTest : TestBase<PersonService>
    {

        private Mock<IPersonRepository> _mockPersonRepo;

        protected override PersonService CreateNewInstance()
        {
            _mockPersonRepo = new Mock<IPersonRepository>();
          
            return new PersonService(_mockPersonRepo.Object);
        }

        [TestMethod]
        [TestCategory(TestCategoryConstants.Unit)]
        public void Test_GetNameFrequencey()
        {
            //Arranage
            var data = new List<Person>()
            {
                new Person
                {
                    ID = 0,
                    FirstName = "Jimmy",
                    LastName = "Smith",
                    Address = "102 Long Lane",
                    PhoneNumber = "29384857"
                }
                ,
                 new Person
                {
                    ID = 1,
                    FirstName = "Clive",
                    LastName = "Owen",
                    Address = "65 Ambling Way",
                    PhoneNumber = "31214788"
                }
                ,
                 new Person
                {
                    ID = 2,
                    FirstName = "James",
                    LastName = "Brown",
                    Address = "82 Stewart St",
                    PhoneNumber = "32114566"
                }
                ,
                  new Person
                {
                    ID = 3,
                    FirstName = "Graham",
                    LastName = "Howe",
                    Address = "12 Howard St",
                    PhoneNumber = "8766556"
                }
                , new Person
                {
                    ID = 4,
                    FirstName = "John",
                    LastName = "Howe",
                    Address = "78 Short Lane",
                    PhoneNumber = "29384857"
                }
            };


            var expected = new List<string>()
            {
                "Howe,2", 
                "Brown,1",
                "Clive,1",
                "Graham,1",
                "James,1",
                "Jimmy,1",
                "John,1",
                "Owen,1",
                "Smith,1"
            };

            _mockPersonRepo.Setup(x => x.GetPersons()).Returns(data);

            var actual = Instance.GetOrderedNameFrequencyList().ToList();

            _mockPersonRepo.Verify(x => x.GetPersons());

            Assert.IsTrue(AreEqual(expected, actual));

        }

        [TestMethod]
        [TestCategory(TestCategoryConstants.Unit)]
        public void Test_GetAddressList()
        {
            //Arranage
            var data = new List<Person>()
            {
                new Person
                {
                    ID = 0,
                    FirstName = "Jimmy",
                    LastName = "Smith",
                    Address = "102 Long Lane",
                    PhoneNumber = "29384857"
                }
                ,
                 new Person
                {
                    ID = 1,
                    FirstName = "Clive",
                    LastName = "Owen",
                    Address = "65 Ambling Way",
                    PhoneNumber = "31214788"
                }
                ,
                 new Person
                {
                    ID = 2,
                    FirstName = "James",
                    LastName = "Brown",
                    Address = "82 Stewart St",
                    PhoneNumber = "32114566"
                }
                ,
                  new Person
                {
                    ID = 3,
                    FirstName = "Graham",
                    LastName = "Howe",
                    Address = "12 Howard St",
                    PhoneNumber = "8766556"
                }
                , new Person
                {
                    ID = 4,
                    FirstName = "John",
                    LastName = "Howe",
                    Address = "78 Short Lane",
                    PhoneNumber = "29384857"
                }
            };


            var expected = new List<string>()
            {
                "82 Stewart St",
                "78 Short Lane",
                "65 Ambling Way",
                "12 Howard St",
                "102 Long Lane"
            };

            _mockPersonRepo.Setup(x => x.GetPersons()).Returns(data);

            var actual= Instance.GetOrderedAddressList().ToList();

            _mockPersonRepo.Verify(x => x.GetPersons());

            Assert.IsTrue(AreEqual(expected, actual));

        }

        [TestMethod]
        [TestCategory(TestCategoryConstants.Unit)]
        public void Test_GetPerson()
        {
            //Arrange
            var expected = new List<Person>()
            {
                new Person
                {
                    ID = 0,
                    FirstName = "Jimmy",
                    LastName = "Smith",
                    Address = "102 Long Lane",
                    PhoneNumber = "29384857"
                }
                ,
                 new Person
                {
                    ID = 1,
                    FirstName = "Clive",
                    LastName = "Owen",
                    Address = "65 Ambling Way",
                    PhoneNumber = "31214788"
                }
                ,
                 new Person
                {
                    ID = 3,
                    FirstName = "Graham",
                    LastName = "Howe",
                    Address = "12 Howard St",
                    PhoneNumber = "8766556"
                }
                , new Person
                {
                    ID = 4,
                    FirstName = "John",
                    LastName = "Howe",
                    Address = "78 Short Lane",
                    PhoneNumber = "29384857"
                }
            };

            _mockPersonRepo.Setup(x => x.GetPersons()).Returns(expected);

            var actual = Instance.GetPersons();
            //Assert
            _mockPersonRepo.Verify(x=>x.GetPersons());
            Assert.IsTrue(AreEqual(expected, actual));

        }

     
    }
}
