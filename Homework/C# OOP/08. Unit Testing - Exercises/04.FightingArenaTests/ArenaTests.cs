namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void IsWarriorInTheCollection()
        {
            Arena arena = new Arena();
            Assert.IsNotNull(arena.Warriors); 
        }
      
        
        //-------------------------------------------------------------------
        
         [Test]
        public void EnrollMethodAddWarriorIfDoesntExist()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Maria", 100, 100);

            arena.Enroll(warrior);

            bool warriorExists = arena.Warriors.Contains(warrior);

            Assert.True(warriorExists); 
        }

         
        //-------------------------------------------------------------------- 

        [Test]  
        public void CheckForTheSameNameInEnrollMethod()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Maria", 100, 100);
            Warrior warrior1 = new Warrior("Maria", 50, 50);

            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(()
                => arena.Enroll(warrior1));

        }

        //-------------------------------------------------------------------- 

        [Test] 
        public void CheckIfAttackerWarriorDoesNotExist()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Maria", 100, 100);
            Warrior warrior1 = new Warrior("Ivan", 100, 100);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(()
                => arena.Fight(warrior.Name, warrior1.Name));
        }
        [Test]
        public void CheckIfDefenderTheWarriorDoesNotExist()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Maria", 100, 100);
            Warrior warrior1 = new Warrior("Ivan", 100, 100);

            arena.Enroll(warrior1);

            Assert.Throws<InvalidOperationException>(()
                => arena.Fight(warrior.Name, warrior1.Name));
        }


        //--------------------------------------------------------------------

        [Test]

        public void FightReduceHP()
        {
            var arena = new Arena();

            Warrior attacker = new Warrior("Stoyan", 100, 50);
            Warrior defender = new Warrior("Kiro", 50, 100);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight("Stoyan", "Kiro");

            Assert.AreEqual(0, attacker.HP);
            Assert.AreEqual(0, defender.HP); 
        }
    }
}
