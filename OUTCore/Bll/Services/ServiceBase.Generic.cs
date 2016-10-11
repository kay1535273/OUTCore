using OUTCore.Dal.Repository;

namespace OUTCore.Bll.Services
{
    /// <summary>
    /// Represents the base class of all services in the Libcor framework.
    /// </summary>
    /// <typeparam name="TRepository">The System.Type of the repository.</typeparam>
    public abstract class ServiceBase<TRepository> : ServiceBase, IServiceBase<TRepository>
        where TRepository : IRepositoryBase
    {
        /// <summary>
        /// Initialises a new instance of the OUTCoreBll.Services.ServiceBase class.
        /// </summary>
        /// <param name="repository">The service repository.</param>
        protected ServiceBase(TRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Gets the service repository.
        /// </summary>
        protected TRepository Repository
        {
            get;
            private set;
        }
    }
}
