using System;
using NUnit.Framework;
using Hash;

namespace TestForHashTable
{
    [TestFixture]
    public class TestForHashtable
    {
        [Test]
        public void TestThreeElements()
        {
            var el1 = 228;
            var el2 = "pudge";
            var el3 = new[] { 10, 20, 30, 40 ,50};
            var key1 = "int";
            var key2 = 6;
            var key3 = "4";
            var hashTable = new HashTable(3);
            hashTable.PutPair(key1, el1);
            hashTable.PutPair(key2, el2);
            hashTable.PutPair(key3, el3);
            Assert.AreEqual(el1, hashTable.GetValueByKey(key1));
            Assert.AreEqual(el2, hashTable.GetValueByKey(key2));
            Assert.AreEqual(el3, hashTable.GetValueByKey(key3));
        }

        [Test]
        public void TestAddTwiceElements()
        {
            var element2 = "asdas";
            var newElement2Value = "NoviiElement";
            var key2 = 0;
            var ht = new HashTable(3);
            ht.PutPair(key2, element2);
            ht.PutPair(key2, newElement2Value);
            Assert.AreEqual(newElement2Value, ht.GetValueByKey(key2));
        }

        [Test]
        public void TestOneThousands()
        {
            var keyOfFinding = 0;
            var elOfFind = 0;
            var size = 10000;
            var rnd = new Random(10);
            var flag = rnd.Next(size);
            var ht = new HashTable(size);
            for (var i = 0; i < size; i++)
            {
                var key = rnd.Next();
                var element = rnd.Next();
                ht.PutPair(key, element);
                if (i == flag)
                {
                    elOfFind = element;
                    keyOfFinding = key;
                }
            }
            Assert.AreEqual(elOfFind, ht.GetValueByKey(keyOfFinding));
        }

        [Test]
        public void Finding1000Elements()
        {
            var size = 10000;
            var rnd = new Random(3123125);
            var flag = rnd.Next(size);
            var hashTable = new HashTable(size);
            for (var i = 0; i < size; i++)
            {
                var value = rnd.Next();
                hashTable.PutPair(i, value);
            }
            for (var i = 0; i < 1000; i++)
                Assert.AreEqual(null, hashTable.GetValueByKey(rnd.Next(1000) + 10000));
        }
    }
}
