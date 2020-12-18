using System;
using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    //Properties
    public string Title{get;set;}
    public string Description{get;set;}
    public int Price{get;set;}
    public string Date{get;set;}
    public static List<Order> _instances = new List<Order>{};
    public static List<string> testList = new List<string>{};
    //Constructor
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<string> GetAll()
    {
      return testList;
    }
  }

}