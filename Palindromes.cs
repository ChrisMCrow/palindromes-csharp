using System;
using System.Collections.Generic;

class Palindrome
{
  private string _input;

  public void SetInput(string newInput)
  {
    _input = newInput.ToLower();
  }

  public string GetInput()
  {
    return _input;
  }

  private string Reverse()
  {
    string reverse = "";
    int length = _input.Length - 1;
    while(length >= 0)
    {
      reverse = reverse + _input[length];
      length--;
    }
    return reverse;
  }

  public string IsPalindrome()
  {
    if (_input == Reverse())
    {
      return "This phrase is a palindrome.";
    }
    else
    {
      return "This phrase is not a palindrome.";
    }
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter a word or number so I can check if it's a Palindrome.");
    string userInput = Console.ReadLine();
    Palindrome newPalindrome = new Palindrome();

    newPalindrome.SetInput(userInput);
    string result = newPalindrome.IsPalindrome();

    Console.WriteLine(result);

    Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
    string finishedAnswer = Console.ReadLine();
    if (finishedAnswer == "Y" || finishedAnswer == "y")
    {
      Console.WriteLine("Goodbye.");
    }
    else
    {
      Main();
    }    
  }
}
