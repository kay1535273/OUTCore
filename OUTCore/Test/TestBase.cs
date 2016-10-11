using DeepEqual;
using DeepEqual.Syntax;

namespace OUTCore.Test
{
    /// <summary>
    /// Represents the base class of all tests in the Libcor framework.
    /// </summary>
    public abstract class TestBase
    {
        /// <summary>
        /// The comparison.
        /// </summary>
        private IComparison _comparison;

        /// <summary>
        /// Initialises a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        public TestBase()
        {
            _comparison = new ComparisonBuilder().IgnoreUnmatchedProperties().Create();
        }

        /// <summary>
        /// Compares the properties of two objects of a different type and returns if all properties are equal.
        /// </summary>
        /// <param name="objectA">The first object to compare.</param>
        /// <param name="objectB">The second object to compare.</param>
        /// <returns><c>true</c> if all property values are equal, otherwise <c>false</c>.</returns>
        protected bool AreEqual(object objectA, object objectB)
        {
            return objectA.IsDeepEqual(objectB, _comparison);
        }
    }
}
