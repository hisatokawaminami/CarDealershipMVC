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
      Car newCar = new Car(makeModel, 0, 0, 0);

      //Act
      string result = newCar.GetMakeModel();

      //Assert
      Assert.AreEqual(makeModel, result);
    }

    [TestMethod]
    public void GetYear_Return()
    {
      //Arrange
      int year = 2018;
      Car newCar = new Car("Toyota", year, 0, 0);

      //Act
      int result = newCar.GetYear();

      //Assert
      Assert.AreEqual(year, result);
    }

    [TestMethod]
    public void GetMiles_Return()
    {
      //Arrange
      int miles = 12345;
      Car newCar = new Car("0", 0, miles, 0);

      //Act
      int result = newCar.GetMiles();

      //Assert
      Assert.AreEqual(miles, result);
    }

    [TestMethod]
    public void GetPrice_Return()
    {
      //Arrange
      int price = 54321;
      Car newCar = new Car("0", 0, 0, price);

      //Act
      int result = newCar.GetPrice();

      //Assert
      Assert.AreEqual(price, result);
    }


  }
}
