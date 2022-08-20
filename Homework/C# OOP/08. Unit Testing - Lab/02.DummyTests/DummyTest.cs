using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void LosingHealthAfterAttacking()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(1);
            Assert.AreEqual(9, dummy.Health); 
        }
        [Test] 
        public void DeadThrowsAnExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0,10);
             
            Assert.Throws<InvalidOperationException>(() =>
            dummy.TakeAttack(1));
        }
        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 1);
            dummy.GiveExperience(); 
            Assert.That(dummy.GiveExperience(), Is.EqualTo(1));   
        }
        [Test]
        public void AliveDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() =>
            dummy.GiveExperience()); 
        }

    }
}