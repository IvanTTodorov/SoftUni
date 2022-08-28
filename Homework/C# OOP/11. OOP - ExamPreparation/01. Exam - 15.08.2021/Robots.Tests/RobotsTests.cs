namespace Robots.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class RobotsTests
    {

        [Test]
        public void MakeRobot()
        {
            Robot robot = new Robot("Ivan", 100);
            Assert.AreEqual(robot.Name, "Ivan");
            Assert.AreEqual(robot.MaximumBattery, 100);
        }

        //========================================================================== 


        [TestCase(0)]
        [TestCase(1)]

        public void SetCapacityInRobotManager(int capacity)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Assert.AreEqual(robotManager.Capacity, capacity);
        }


        [Test]
        public void CapacityShouldThrowException()
        {
            Assert.Throws<ArgumentException>(()
                => new RobotManager(-12));
        }



        //===============================================================

        [Test]

        public void ValidAddingRobot()
        {
            Robot robot = new Robot("Ivan", 100);
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(robot);

            Assert.AreEqual(1, robotManager.Count);
        }

        [Test]
        public void AddMethodAlreadyExistinRobotInvalidOpertion()
        {
            Robot robot = new Robot("Ivan", 100);
            Robot robot2 = new Robot("Ivan", 100);
            RobotManager robotManager = new RobotManager(10);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Add(robot2));
        }

        [Test]
        public void AddMethod_NotEnoughCapacity()
        {
            Robot robot = new Robot("Ivan", 100);
            Robot robot2 = new Robot("Maria", 100);
            RobotManager robotManager = new RobotManager(1);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(()
                => robotManager.Add(robot2));
        }

        //==================================================================

        [Test]
        public void RemoveMethod_RemoveValidRobot()
        {
            Robot robot = new Robot("Ivan", 100);
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(robot);
            robotManager.Remove("Ivan");

            Assert.AreEqual(0, robotManager.Count);
        }


        [Test]
        public void RemoveMethod_FailRemovingNonExistedRobot()
        {
            Robot robot = new Robot("Ivan", 100);
            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(robot);


            Assert.Throws<InvalidOperationException>(()
                => robotManager.Remove("Maria"));


        }
        //================================================================
        [Test]
        public void WorkMethod_CanNotWorkBecauseOfNonExistingRobot()
        {
            
            RobotManager robotManager = new RobotManager(1);

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Work("Maria", "work", 40)); 
        }


        [Test]
        public void WorkMethod_NotEnoughBattery()
        {
            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Ivan", 50);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Work("Ivan", "work", 100)); 
        }


        [Test] 
        public void WorkMethod_RobotFinishingWork()
        {
            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Ivan", 50);
            robotManager.Add(robot);
            robotManager.Work("Ivan", "work", 10);

            Assert.AreEqual(robot.Battery, 40); 

        }


        //==============================================================
       
        
        
        
        [Test]
        public void ChargeMethod_CanNotChargeBecauseOfNonExistingRobot()
        {

            RobotManager robotManager = new RobotManager(1);

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Charge("Maria"));
        }


        [Test]
        public void ValidChargedBattery()
        {
            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Ivan", 50);
            robotManager.Add(robot); 

            robotManager.Work(robot.Name, "work", 20); 
            robotManager.Charge("Ivan");

            Assert.AreEqual(50, robot.Battery); 
        }
    }
}
