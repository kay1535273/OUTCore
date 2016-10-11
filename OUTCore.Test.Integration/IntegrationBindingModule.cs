using Ninject.Modules;
using OUTCore.Bll.Interfaces;
using OUTCore.Bll.Services.Person;
using OUTCore.Dal;
using OUTCore.Dal.Interfaces;

namespace OUTCore.Test.Integration
{
    /// <summary>
    /// Represents the integration binding module class. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Ninject.Modules.NinjectModule" />
    public sealed class IntegrationBindingModule : NinjectModule
    {
        
        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            // Repositories

            Bind<IPersonRepository>().To<PersonRepository>().WithConstructorArgument("fileName",Test.Default.TestFileName);

            // Services
            Bind<IPersonService>().To<PersonService>();
           
        }
    }
}
