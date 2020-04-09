using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners;
    public VehicleRegistry()
    {
      this.owners = new Dictionary<LicensePlate, string>();
    }
    public bool Add(LicensePlate licensePlate, string owner)
    {
      if (!this.owners.ContainsKey(licensePlate))
      {
        this.owners.Add(licensePlate, owner);
        return true;
      }
      else
      {
        return false;
      }
    }

    public string Get(LicensePlate licensePlate)
    {
      if (this.owners.ContainsKey(licensePlate))
      {
        return this.owners[licensePlate];
      }
      return "No such license in the registry.";
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if (this.owners.ContainsKey(licensePlate))
      {
        this.owners.Remove(licensePlate);
        return true;
      }
      else
      {
        return false;
      }
    }

    public void PrintLicensePlates()
    {
      foreach (KeyValuePair<LicensePlate, string> plate in this.owners)
      {
        Console.WriteLine(plate.Key);
      }
    }

    public void PrintOwners()
    {
      List<string> alreadyPrinted = new List<string>();

      foreach (KeyValuePair<LicensePlate, string> owner in this.owners)
      {
        if (!alreadyPrinted.Contains(owner.Value))
        {
          Console.WriteLine(owner.Value);
        }
        alreadyPrinted.Add(owner.Value);
      }
    }
  }
}