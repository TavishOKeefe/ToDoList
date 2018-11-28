using System.Collections.Generic;

namespace ToDoListII.Models
{
  public class Item
  {
    private string _description;
    private int _id;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetDescription()
    {
      return _description;
    }

    public int GetId()
    {
      return _id;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
