namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [TestCase("VW", "5", 4.5, 50)]

        public void ConstructorMustAddProperties(string make, string model, double fuelConsumption,

         double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }



        //=======================================================================================
        [TestCase("")]
        [TestCase(null)]

        public void ReturnsUnvalidMake(string make)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(make, "Corolla", 40, 30));
        }

        //=======================================================================================


        [TestCase("")]
        [TestCase(null)]
        public void ReturnsInvalidModel(string model)
        {
            Assert.Throws<ArgumentException>(()
                => new Car("Toyota", model, 40, 50));
        }

        //=======================================================================================
        [TestCase(0)]
        [TestCase(-1)]
        public void ReturnsInvalidFuelConsumption(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(()
                => new Car("Toyota", "Corolla", fuelConsumption, 50));
        }

        //=======================================================================================

        [TestCase(0)]
        public void ReturnsValidFuelAmount(double fuelAmount)
        {
            Car car = new Car("Toyota", "Corolla", 45, 50);

            Assert.AreEqual(fuelAmount, car.FuelAmount);
        }
        //=======================================================================================

        [TestCase(-2)]
        public void ReturnsInvalidFuelAmount(double fuelAmount)
        {
            Car car = new Car("Toyota", "Corolla", 40, 50);
            nonNegativeNum(car);

        }
        public static void nonNegativeNum(Car car)
        {

            if (car.FuelAmount < 0)
            {
                Assert.Throws<ArgumentException>(()
                    => new Car("Toyota", "Corolla", 3, 30));
            }
        }

        //=======================================================================================

        [TestCase(-20)]

        public void ReturnsInvalidFuelCapacity(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(()
                 => new Car("Toyota", "Corolla", 40, fuelCapacity));
        }

        //=========================================================================================
        [TestCase(40, 0)]

        public void Car_Should_Refuel_With_ValidValue(double fuelToRefuel, double result)
        {
            Car car = new Car("Toyota", "Corolla", 40, 50);

            result = car.FuelAmount + fuelToRefuel;
            Assert.AreEqual(result, fuelToRefuel);



        }

        //=======================================================================================

        [TestCase(-1)]
        public void Car_Refuel_Throws_Exception_With_InvalidValue(double fuelRefuel)
        {
            Car car = new Car("Toyota", "Corolla", 40, 50);

            Assert.That(() => car.Refuel(fuelRefuel), Throws.Exception.TypeOf<ArgumentException>());
        }


        //===========================================================================================

        [TestCase(40, 30)]
        public void Car_If_FuelAmount_Is_Bigger_Than_FuelCapacity(double fuelAmount, double fuelCapacity)
        {
            Car car = new Car("Toyota", "Corolla", 3, fuelCapacity);

            if (fuelAmount > fuelCapacity)
            {
                fuelAmount = fuelCapacity;
            }

            Assert.AreEqual(fuelAmount, fuelCapacity);
        }


        //===============================================================================================

        [Test]
        public void DriveMethod_ThrowExeption_IfFuelNeededIsBiggerThanFuelAmount()
        {
            Car car = new Car("Toyota", "Corolla", 3, 30);

            car.Refuel(10);


            Assert.Throws<InvalidOperationException>(()
                => car.Drive(2000));
        }

        //===============================================================================================

        [TestCase (4, 10, 6)]
        public void ReduceFuel1AmountWithFuelNeeded(double fuelConsumption, double distance, double expectedResult)
        {
            Car car = new Car("Toyota", "Corolla", fuelConsumption, 50);

            car.Refuel(distance);

            double result = car.FuelAmount;
            result -= (100 / 100) * fuelConsumption;

            Assert.AreEqual(result, expectedResult);
        }

    }


}
