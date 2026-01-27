using System;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
  public string Name { get; }

  public AuthorAttribute(string name)
  {
    Name = name;
  }
}
