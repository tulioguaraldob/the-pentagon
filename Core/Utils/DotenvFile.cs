using System;
using System.IO;

namespace Core.Utils
{
    public class DotenvFile
    {
        public static void LoadFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split("=", StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}