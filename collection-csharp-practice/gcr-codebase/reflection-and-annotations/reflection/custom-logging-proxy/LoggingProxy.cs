using System;
using System.Reflection;

public class LoggingProxy<T> : DispatchProxy
{
  private T _target;

  // Attach real object
  public void SetTarget(T target)
  {
    _target = target;
  }

  protected override object Invoke(
      MethodInfo targetMethod,
      object[] args)
  {
    Console.WriteLine($"[LOG] Calling: {targetMethod.Name}");
    object result = targetMethod.Invoke(_target, args);
    Console.WriteLine($"[LOG] Finished: {targetMethod.Name}");

    return result;
  }
}
