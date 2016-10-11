using OUTCoreBll.Services;
using OUTCore.Dal.Repository;

namespace OUTCore.Bll.Services
{
    /// <summary>
    /// Represents the base interface of all services in the Libcor framework.
    /// </summary>
    /// <typeparam name="TRepository">The System.Type of the repository.</typeparam>
    public interface IServiceBase<TRepository> : IServiceBase
        where TRepository : IRepositoryBase
    {

    }
}
