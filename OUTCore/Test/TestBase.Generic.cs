namespace OUTCore.Test
{
    /// <summary>
    /// Represents the base class of all tests in the Libcor framework.
    /// </summary>
    /// <typeparam name="TObject">The System.Type of the object being tested.</typeparam>
    public abstract class TestBase<TObject> : TestBase
    {
        /// <summary>
        /// Initialises a new instance of the OUTCoreTest.TestBase class.
        /// </summary>
        protected TestBase()
        {
            Instance = CreateNewInstance();
        }

        /// <summary>
        /// Gets the object being tested.
        /// </summary>
        public TObject Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates the new instance.
        /// </summary>
        /// <returns>A TObject object instance.</returns>
        protected abstract TObject CreateNewInstance();
    }
}





