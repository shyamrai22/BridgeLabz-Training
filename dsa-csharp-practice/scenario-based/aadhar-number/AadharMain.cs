/// <summary>
/// Acts as the entry point of the Aadhaar management application.
/// Initializes the menu system and starts the program execution
/// through the Main method.
/// </summary>


using System;

class AadharMain
{
  public static void Main()
  {
    AadharMenu menu = new AadharMenu();
    menu.Start();
  }
}
