using Xunit;
using System.Collections;
using System.Collections.Generic;

namespace Jtk.Extensions.Tests
{
    public class EnumerableExtensions_UT
    {
        [Fact(Skip = "ObjectExtensions of the same name override this method")]     
        public void NullSafe_Handling_Null_Collection()
        {
            List<string> list = null;

            var count = list.NullSafe(h => h.Count);

            Assert.Equal(0, count);
        }

        [Fact(Skip = "ObjectExtensions of the same name override this method")]
        public void NullSafe_Handling_Non_Null_Collection()
        {
            var hashTable = new Hashtable();
            hashTable.Add("1", "Blah blah");

            var keyCount = hashTable.NullSafe(h => h.Keys.Count);

            Assert.Equal(1, keyCount);
        }

        [Fact]
        public void NullSafeCount_Handling_Null_Collection()
        {
            List<string> array = null;
            
            var count = array.NullSafeCount();

            Assert.Equal(0, count);
        }

        [Fact]
        public void NullSafeCount_Handling_Non_Null_Collection()
        {
            List<int> array = new List<int>();
            array.Add(1);

            var keyCount = array.NullSafeCount();

            Assert.Equal(1, keyCount);
        }

        [Fact]
        public void IsNullOrEmpty_Handling_Null_Collection()
        {
            List<int> array = null;

            var result = array.IsNullOrEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_Handling_Not_Null_Collection()
        {
            List<int> array = new List<int> { 1 };

            var result = array.IsNullOrEmpty();

            Assert.False(result);
        }
    }
}
