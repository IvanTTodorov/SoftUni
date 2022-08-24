namespace ExtendedDatabase
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [TestFixture]
    public class DatabaseTests
    {


        [TestCaseSource("TestCasesConstructorData")]
        public void Constuctor_Should_Create_DataBase_PositiveTest(
            Person[] people,
            int count)
        {
            Database database = new Database(people);
            Assert.AreEqual(count, database.Count); 

        }
        public static IEnumerable<TestCaseData> TestCasesConstructorData()
        {
            yield return new TestCaseData(
                new Person[]
                {
                    new Person(2, "Ivan"),
                    new Person(6, "Iva"),
        },
        2);
            yield return new TestCaseData(
                           new Person[]
        {
        },
        0);


        }
         


        //====================================================================================== 


        [TestCase(1)]
        public void AddMethodMustBeUnder16(int count)
        {
            Database database = new Database();
            for (int i = 0; i < count; i++)
            {
                Person person = new Person(9809040302, "Ivan");
                database.Add(person);
            }
            Assert.AreEqual(count, database.Count);
        }
         

        //===============================================================================
         


        [Test]
        public void IfDatabaseIsMoreThan16ThrowInvalidOperationException()
        {
            Database database = new Database();
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");

            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                database.Add(person);
            }
            Person person1 = new Person(9809040302, "Ivan");
            Assert.Throws<InvalidOperationException>(()
                => database.Add(person1));
        }


        //=============================================================================== 



        [TestCase(15)]
        [TestCase(16)]
        public void ConstructorMustBe16ElementsLong(int count)
        {
            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Database database = new Database(people);

            Assert.AreEqual(count, database.Count);
        }

        //===================================================================== 


        [TestCase(1, 18)]
        [TestCase(1, 25)]

        public void IfConstructorIsMoreThan16ElementsThrowException(int start, int count)
        {
            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Assert.Throws<ArgumentException>(()
                => new Database(people));
        }


        //===================================================================== 
        [TestCase("Ivan", 12)]
        public void AddExistPersonByUsername(string name, int count)
        {
            {
                List<Person> people = new List<Person>();
                long n = 9809994433;

                for (int i = 0; i < people.Count; i++)
                {
                    Person person = new Person(n, name);
                    if (i == 0)
                    {
                        people.Add(person);
                    }
                    else
                    {
                        Assert.Throws<InvalidOperationException>(()
                    => people.Add(person));
                    }
                    n += 1;
                }
            }
        }

        //=====================================================================

        [TestCase(9809994433, 12)]
        public void AddExistPersonByID(long id, int count)
        {
            {
                List<Person> people = new List<Person>();
                long n = 9809994433;

                for (int i = 0; i < people.Count; i++)
                {
                    Person person = new Person(id, "Maria");
                    if (i == 0)
                    {
                        people.Add(person);
                    }
                    else
                    {
                        Assert.Throws<InvalidOperationException>(()
                    => people.Add(person));
                    }
                    n += 1;
                }
            }
        }

        //=====================================================================
        [TestCase(10)]
        [TestCase(2)]
        public void RemoveElementsWith1(int count)
        {
            Database database = new Database();
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                database.Add(person);
            }
            database.Remove();
            Assert.AreEqual(count - 1, database.Count);
        }

        //=========================================================================
        [Test]
        public void RemoveMethodThrowExceptionIfElementsAreZero()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()
                => database.Remove());
        }


        //============================================================================

        [TestCase("", 15)]
        [TestCase(null, 14)]
        public void UsernameIsNullThrowExceptionFindByUsernameMethod(string name, int count)
        {

            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Database database = new Database(people);
            Assert.Throws<ArgumentNullException>(()
                => database.FindByUsername(name));
        }


        //===============================================================================


        [TestCase("Maria", 6)]
        [TestCase("Ivann", 14)]
        public void UsernameNoUserIsFoundMethod(string name, int count)
        {
            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Database database = new Database(people);
            Assert.Throws<InvalidOperationException>(()
                => database.FindByUsername(name));
        }


        //============================================================================

        [TestCase(9984535432, 6)]
        [TestCase(2345554323, 14)]
        public void IDNoUserIsFoundMethod(long id, int count)
        {
            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Database database = new Database(people);
            Assert.Throws<InvalidOperationException>(()
                => database.FindById(id));
        }


        //============================================================================
        [TestCase(-2, 15)]
        [TestCase(-543294930, 14)]
        public void IdIsNegativeThrowException(long id, int count)
        {

            Person[] people = new Person[count];
            long n = 9809994433;
            StringBuilder sb = new StringBuilder();
            sb.Append("Ivan");
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(n, sb.ToString());
                n += 1;
                sb.Append("I");
                people[i] = person;
            }
            Database database = new Database(people);
            Assert.Throws<ArgumentOutOfRangeException>(()
                => database.FindById(id));
        }
    }
}












