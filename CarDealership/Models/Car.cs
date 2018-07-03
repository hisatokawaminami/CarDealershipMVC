using System;
using System.Collections.Generic;

namespace CarDealership.Models
{

public class Car
  {
    private string _makeModel;
    private string _year;
    private string _miles;
    private string _price;
    private static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, string year, string miles, string price)
    {
      _makeModel = makeModel;
      _year = year;
      _miles = miles;
      _price = price;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public string GetYear()
    {
      return _year;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }

    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }

    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void Save ()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
