class Program
{
  static void Main()
  {
    IGreeting real = new Greeting();

    // Create proxy
    IGreeting proxy =
        DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

    // Attach real object
    ((LoggingProxy<IGreeting>)proxy).SetTarget(real);

    // Call via proxy
    proxy.SayHello("Shyam");
  }
}
