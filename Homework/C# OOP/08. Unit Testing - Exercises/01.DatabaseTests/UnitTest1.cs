namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {

        [TestCase(10)]
        [TestCase(16)]
        public void AddMethodMustBeUnder16(int count)
        {
            Database database = new Database();
            for (int i = 0; i < count; i++)
            {
                database.Add(i); 
            }
            Assert.AreEqual(count, database.Count);
        }
        
        [Test]
        public void IfDatabaseIsMoreThan16ThrowInvalidOperationException()
        {
            Database database = new Database();
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }
            Assert.Throws<InvalidOperationException>(()
                => database.Add(5));
        }
        [TestCase (1, 15)]
        [TestCase(1, 16)]
        public void ConstructorMustBe16ElementsLong(int start, int count)
        {
            int[] elements = Enumerable.Range(start, count).ToArray(); 
            Database database = new Database(elements);
            
            Assert.AreEqual(count, database.Count);
        }
        [TestCase(1, 18)]
        [TestCase(1, 25)]

        public void IfConstructorIsMoreThan16ElementsThrowException(int start, int count)
        {
            int[] elements = Enumerable.Range(start, count).ToArray();

            Assert.Throws<InvalidOperationException>(()
                => new Database(elements)); 
        }

        [Test]
        public void RemoveElementsWith1()
        {
            int[] elements = Enumerable.Range(1, 10).ToArray();
            Database database = new Database(elements);

            database.Remove();
            Assert.AreEqual(9, database.Count);       
        }
        [Test]
        public void RemoveMethodThrowExceptionIfElementsAreZero()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()
                => database.Remove()); 
        }
        [Test] 
        public void FetchMethodReturnTheElementsAsArray()
        {
            int[] elements = Enumerable.Range(1, 10).ToArray();
            Database database = new Database(elements);
            database.Add(3);
            database.Add(9);
            database.Remove();
            int[] fetchData = database.Fetch();

            Assert.AreEqual(fetchData.Length, database.Count);






        }
    }
}
