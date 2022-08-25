namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    { 

        [Test]
        [TestCase("Maria", 45, 30)]
        [TestCase("Ivan", 30, 20)]
        public void ConstructorValidReferences(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }
        
           
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ConstructorReturnExceptionForInvalidName(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            new Warrior(name, 40, 50));
        }
       
        
        
        [TestCase(0)]
        [TestCase(-10)]
        public void ConstructorReturnExceptionForInvalidDamage(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            new Warrior("Maria", damage, 50)); 
        }  



        [TestCase(-3)]
        [TestCase(-10)]
        public void ConstructorReturnExceptionForInvalidHP(int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            new Warrior("Maria", 50, hp));
        }
        


        [TestCase ("Stoyan", 20, 50, 
            "Niki", 60, 50)]
        [TestCase("Stoyan", 60, 50,
            "Niki", 30, 50)]
        public void AttackMethodThrowsExeptionInvalidHealth
            (string name, int health, int damage,
            string enemyName, int enemyHealth, int enemyDamage)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHealth);
            Assert.Throws<InvalidOperationException>(()
                => myWarrior.Attack(enemyWarrior)); 

        } 




        [TestCase("Stoyan", 40, 50,
            "Niki", 60, 50)]
        [TestCase("Stoyan", 70, 50,
            "Niki", 60, 100)]
        public void AttackMethodThrowsExceptionStrongerEnemy(
            string name, int health, int damage,
            string enemyName, int enemyHealth, int enemyDamage)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHealth);
             
            Assert.Throws<InvalidOperationException>(()
                => myWarrior.Attack(enemyWarrior));
        }



        [TestCase ("Maria", 50, 100, 0, 
            "Ivan", 100, 100, 50)]
        [TestCase("Maria", 50, 100, 0,
            "Ivan", 100, 1, 0)]
        public void AttackMethodShouuldReduceHPForWarriorAndEnemyWarrior(
            string name,
            int damage, 
            int heath, 
            int result, 
            string enemyName, 
            int enemyDamage, 
            int enemyHeath, 
            int enemyResult
            )
        {
            Warrior warrior = new Warrior(name, damage, heath);
            Warrior enemy = new Warrior(enemyName, enemyDamage, enemyHeath);

            warrior.Attack(enemy);
            Assert.AreEqual(result, warrior.HP);
            Assert.AreEqual(enemyResult, enemy.HP); 
        }
    }
}