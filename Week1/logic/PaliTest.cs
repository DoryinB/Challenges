using System;

namespace logic
{
  public class PaliTest
  {
    string inputStr,reverseIn;
            
    public PaliTest()
    {
      getInput();
      reverseInput();
      checkPali();
    }

    public void getInput()
    {
      Console.WriteLine("Please input the the phrase you would like to check.");
      inputStr = Console.ReadLine();
      inputStr = inputStr.ToLower();
    }
    public void reverseInput()
    {
      char[] inputChar = inputStr.ToCharArray();
      Array.Reverse(inputChar);
      reverseIn = new string(inputChar);
    }

    public void checkPali()
    {
      if(inputStr == reverseIn)
      {  
        Console.WriteLine("This is a palindrone!");
      }
      else
      {
        Console.WriteLine("This not a palindrone.");
      }
    }
  }
}
