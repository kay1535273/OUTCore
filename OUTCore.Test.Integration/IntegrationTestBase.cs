using OUTCore.DI;

namespace OUTCore.Test.Integration
{
    /// <summary>
    /// Represents the integration test base class.
    /// </summary>
    /// <typeparam name="TObject">The type of the t object.</typeparam>
    /// <seealso cref="T:OUTCoreTest.TestBase{TObject}" />
    public abstract class IntegrationTestBase<TObject> : TestBase<TObject>
    {
        /// <summary>
        /// Creates the new instance.
        /// </summary>
        /// <returns>A TObject object instance.</returns>
        protected override TObject CreateNewInstance()
        {
            return DependencyResolver<IntegrationBindingModule>.Get<TObject>();
        }
    }
}
