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
    private static List<Order> _instances = new List<Order>{};
    //Constructor
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}