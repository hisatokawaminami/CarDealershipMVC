using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System.Collections.Generic;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTest
  {
    [TestMethod]
    public void GetMakeModel_Return()
    {
      //Arrange
      string makeModel = "Toyota";
      Car newCar = new Car(makeModel);

      //Act
      string result = newCar.GetMakeModel();

      //Assert
      Assert.AreEqual(makeModel, result);
    }
  }
}
