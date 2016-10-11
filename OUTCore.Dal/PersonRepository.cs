using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OUTCore.Dal.Repository;
using OUTCore.Dal.Interfaces;
using OUTCore.Diagnostics;
using OUTCore.Domain;

namespace OUTCore.Dal
{
    public class PersonRepository : FileRepositoryBase , IPersonRepository
    {

        public PersonRepository(string fileName) :
            base(fileName)
        {

        }

        public IEnumerable<Person> GetPersons()
        {
            IEnumerable<Person> personList = null; 
            try
            {
                   var idCount = 0;
                    personList = from line in File.ReadAllLines(FileName).Skip(1)
                    let columns = line.Split(',')
                    select new Person
                    {
                        ID = idCount++,
                        FirstName = columns[0],
                        LastName = columns[1],
                        Address= columns[2],
                        PhoneNumber = columns[3]
                    };
            }
            catch (Exception exception)
            {
                //Log the error but dont fail
                Diagnostics.Logger.Log(LogType.Fatal, exception.Message);
                personList = new List<Person>();
            }
            return personList;
        }
    }
}
