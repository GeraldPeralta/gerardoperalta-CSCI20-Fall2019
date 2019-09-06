//Gerardo Peralta
//9/5/2019
//calcutes the day that easter is on based on an inputed year
using System;

class MainClass {
public static void Main (string[] args) 
  {
    int year, A , B , C , D , E , day , dayRem;
    string yearString; 
    
    Console.WriteLine ("Please enter desired year."); //lets user know it started running
    yearString = Console.ReadLine();
    year = int.Parse(yearString);
    
    A = (year % 19);
    B = (year % 4);
    C = (year % 7);
    D = (((19 * A) + 24) % 30 );
    E = (((2 * B) + (4 * C) + (6*D) + 5) % 7 );
    day = (22 + D + E );//final formula to get the day
   
    if (year !=1954 && year!= 1981 && year != 2049 && year != 2076)//if year is not one of the exceptions
      if(day <= 31 )//if the day is in march
        {
          Console.WriteLine("Easter is on " + day + "of march");
        }
      else//the day is in april
        {
          dayRem = (day - 31);
          Console.WriteLine("Easter is on " + dayRem + " of april.");
        }
    else //if the year is an exception year
    {
      if(day <= 31 )//if the day is in march
        {
          day = (day - 7);
          Console.WriteLine("Easter is on " + day + "of march");
        }
      else//the day is in april
        {
          dayRem = ((day - 31)-7);
          Console.WriteLine("Easter is on " + dayRem + " of april.");
        }
    }
  }
}