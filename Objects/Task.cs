using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class JobOpening
  // title, description
  {
    private string _title;
    private string _description;
    private object _contact;
    private static List<string> _instances = new List<string> {};

    public void Job (string title, string description, object contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string NewTitle)
    {
      _title = NewTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string NewDescription)
    {
      _description = NewDescription;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public object GetContact()
    {
      return _contact;
    }
    public void SetContact(string NewContact)
    {
      _contact = NewContact;
    }
    public void Save()
    {
      _instances.Add(_description);
    }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

  }

  public class contactInfo
  {
    private string _name;
    private string _email;
    private string _phoneNumber;
    private static List<string> _ContactInstances = new List<string> {};

    public void Contact (string name, string email, string phoneNumber)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string NewName)
    {
      _name = NewName;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string NewEmail)
    {
      _email = NewEmail;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string NewPhoneNumber)
    {
      _phoneNumber = NewPhoneNumber;
    }
    // name, email and phone number
  }


}
