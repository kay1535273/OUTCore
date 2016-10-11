

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OUTCore.Bll.Interfaces;
using OUTCore.Dal.Interfaces;
using OUTCore.Domain;

namespace OUTCore.Bll.Services.Person
{
    public class PersonService : ServiceBase<IPersonRepository>, IPersonService
    {
        public PersonService(IPersonRepository repository) : base(repository)
        {
            
        }

        public IEnumerable<Domain.Person> GetPersons()
        {
            return Repository.GetPersons();
        }

        public IEnumerable<string> GetOrderedNameFrequencyList()
        {
            var personList = Repository.GetPersons().ToList();
            
            var lastNameList  = personList.Select(x => x.LastName);
            var firstNameList = personList.Select(x => x.FirstName);
           
            var nameList = new List<string>();
            nameList.AddRange(lastNameList.ToList());
            nameList.AddRange(firstNameList.ToList());

            var returnList = new List<NameFrequency>();

            foreach (var name in nameList)
            {
                var tmpName = name;
                var nameFreq =  !returnList.Any() ? null : returnList.FirstOrDefault(x => x.Name == tmpName);
                if (nameFreq == null)
                {
                    returnList.Add(new NameFrequency
                    {
                        Name = tmpName, 
                        Frequence = 1
                    });
                }
                else
                    nameFreq.Frequence++;
            }

            return returnList.OrderByDescending(x => x.Frequence).ThenBy(x => x.Name).Select(x=> x.Name + "," + x.Frequence).ToList();
        }

        public IEnumerable<string> GetOrderedAddressList()
        {
            var personList = Repository.GetPersons();
            return personList.GroupBy(x => x.Address).Select(x => x.Key).OrderByDescending(x=>x);
        }
    }
}
