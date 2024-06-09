using System;

class Program {
  public static void Main (string[] args) 
  {
    //Promt user for wind speed
    Console.Write("Please enter the wind speed in mph:");
    double windSpeed;
    //Try to parse the user input into a double
    if (double.TryParse(Console.ReadLine(),out windSpeed))
    {
      //set hurricane category based on wind speed
      string category = HurricaneCategory((int)windSpeed);
      //Output category
      Console.WriteLine(category);
    }
    else
    {
      //Output error message
      Console.WriteLine("Invalid input. Please enter a valid integer for the wind speed.");
    }
    }
    //Method to determine hurricane category based on wind speed
    public static string HurricaneCategory(int windSpeed)
    {
      if (windSpeed >=157)
        return "Category Five Hurricane";
      else if (windSpeed >=130)
        return "Category Four Hurricane";
      else if (windSpeed >=111)
        return "Category Three Hurricane";
      else if (windSpeed >=96)
        return "Category Two Hurricane";
      else if (windSpeed >=74)
        return "Category One Hurricane";
      else
        return "Not a hurricane";
      }
  }