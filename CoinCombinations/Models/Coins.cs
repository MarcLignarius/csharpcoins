using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class ChangeMake
  {
    private int Quarters;
    private int Dimes;
    private int Nickels;
    private int Pennies;

    public ChangeMake(int money)
    {
      Quarters = 0;
      Dimes = 0;
      Nickels = 0;
      Pennies = 0;
      while(money >= 25)
      {
        money -= 25;
        Quarters++;
      }
      while(money >=10)
      {
        money -= 10;
        Dimes++;
      }
      while(money >=5)
      {
        money -= 5;
        Nickels++;
      }
      while(money >=1)
      {
        money -= 1;
        Pennies++;
      }
    }

    public int GetQuarters()
    {
      return Quarters;
    }

    public int GetDimes()
    {
      return Dimes;
    }

    public int GetNickels()
    {
      return Nickels;
    }

    public int GetPennies()
    {
      return Pennies;
    }

    public string GiveChange()
    {
      return "Here's your change! Quarters: " + Quarters + ", Dimes: " + Dimes + ", Nickels: " + Nickels + ", Pennies: " + Pennies;
    }

  }
}
