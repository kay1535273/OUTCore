using Ninject;
using Ninject.Modules;

namespace OUTCore.DI
{
    /// <summary>
    /// Represents the dependency resolver for injected types.
    /// </summary>
    public static class DependencyResolver<TNinjectModule>
        where TNinjectModule : NinjectModule, new()
    {
        /// <summary>
        /// The standard kernel.
        /// </summary>
        private static readonly StandardKernel _standardKernel;

        /// <summary>
        /// Initialises a new instance of the OUTCore.DI.DependencyResolver class.
        /// </summary>
        static DependencyResolver()
        {
            if (_standardKernel == null)
                _standardKernel = new StandardKernel(new TNinjectModule());
        }

        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <typeparam name="TInterface">The System.Type of the service to resolve.</typeparam>
        /// <returns>An instance of the service.</returns>
        public static TInterface Get<TInterface>()
        {
            return _standardKernel.Get<TInterface>();
        }
    }
}
