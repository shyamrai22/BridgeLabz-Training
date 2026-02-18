using System;
using System.IO;

namespace TechVille.Utility
{
  public static class ExceptionLogger
  {
    private static string logFile = "error_log.txt";

    public static void Log(string message)
    {
      File.AppendAllText(logFile,
          $"[{DateTime.Now}] {message}{Environment.NewLine}");
    }
  }
}
