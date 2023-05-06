﻿using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.ConstrainedExecution;

namespace CarTests
{
    [TestClass]
    public class CarTestsClass
    {
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void SetsGasTankLevel()
        {
            double expectedGasTankLevel = 10;
            double actualGasTankLevel = test_car.GasTankLevel;
            Assert.AreEqual(expectedGasTankLevel, test_car.GasTankLevel, 0.001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void DrivingWithinTankRange()
        {
            double milesToDrive = 200;
            test_car.Drive(milesToDrive);
            double expectedGasTankLevel = test_car.GasTankSize - milesToDrive / test_car.MilesPerGallon;
            Assert.AreEqual(expectedGasTankLevel, test_car.GasTankLevel, 0.001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void AttemptingToDrivePastTankRange()
        {
            double milesToDrive = 600;
            test_car.Drive(milesToDrive);
            double expectedGasTankLevel = 0;
            Assert.AreEqual(expectedGasTankLevel, test_car.GasTankLevel, 0.001);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}