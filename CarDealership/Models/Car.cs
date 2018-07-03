using System;
using System.Collections.Generic;

namespace CarDealership.Models
{

public class Car
  {
    private string _makeModel;
    private int _year;
    private int _miles;
    private int _price;
    public static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, int year, int miles, int price)
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

    public int GetYear()
    {
      return _year;
    }
    public void SetYear(int newYear)
    {
      _year = newYear;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
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
