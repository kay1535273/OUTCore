using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUTCore.Domain;

namespace OUTCore.Bll.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPersons();
        IEnumerable<string> GetOrderedNameFrequencyList();
        IEnumerable<string> GetOrderedAddressList();
    }
}
