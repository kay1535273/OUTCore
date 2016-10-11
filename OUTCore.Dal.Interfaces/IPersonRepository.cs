using System.Collections.Generic;
using OUTCore.Dal.Repository;
using OUTCore.Domain;


namespace OUTCore.Dal.Interfaces
{
    public interface IPersonRepository : IRepositoryBase
    {
        IEnumerable<Person> GetPersons();
    }
}
