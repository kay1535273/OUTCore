namespace OUTCore.Dal.Repository
{
    /// <summary>
    /// Represents the base class of all repositories in the Libcor framework.
    /// </summary>
    public abstract class RepositoryBase : IRepositoryBase
    {
        /// <summary>
        /// Initialises a new instance of the Libcor.Dal.Repositories.RepositoryBase class.
        /// </summary>
        /// <param name="connectionStringKey">The database connection string key.</param>
        protected RepositoryBase(ConnectionStringKey connectionStringKey)
        {
            // Initialise connection string
            ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringKey.ToString()].ConnectionString;
        }

        /// <summary>
        /// Gets or sets the database connection string.
        /// </summary>
        protected string ConnectionString
        {
            get;
            private set;
        }
    }
}
