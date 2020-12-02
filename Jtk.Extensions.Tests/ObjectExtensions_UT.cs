using System;
using System.Text;
using Xunit;

namespace Jtk.Extensions.Tests
{
    public class ObjectExtensions_UT
    {
        [Fact]
        public void NullSafe_Object_Not_Null_Object_Instance_Used()
        {
            var myString = "MyStr";
            var testObject = new StringBuilder(myString);
            var resultingString = testObject.NullSafe(t => t.ToString());

            Assert.Equal(myString, resultingString);
        }

        [Fact]
        public void NullSafe_Object_Is_Null_Default_Object_Used()
        {
            StringBuilder testObject = null;
            var resultingString =  testObject.NullSafe(t => t.ToString()); // should not throw exception

            Assert.Null(resultingString);
        }

        [Fact]
        public void IsNull_Return_True_For_Null_Object()
        {
            object testObject = null;
            Assert.True(testObject.IsNull());
        }

        [Fact]
        public void IsNull_Return_False_For_Not_Null_Object()
        {
            var testObject = DateTime.Now;
            Assert.False(testObject.IsNull());
        }

        [Fact]
        public void IsNotNull_Return_False_For_Null_Object()
        {
            object testObject = null;
            Assert.False(testObject.IsNotNull());
        }

        [Fact]
        public void IsNull_Return_True_For_Not_Null_Object()
        {
            var testObject = DateTime.Now;
            Assert.True(testObject.IsNotNull());
        }
    }
}
