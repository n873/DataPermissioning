using System;
using System.Collections.Generic;
using System.Linq;

namespace DataPermissioning.Common
{
    public static class StringExtension
    {
        public static IEnumerable<string> ToStringList(this string input)
        {
            try
            {
                var output = 
                      input.Contains("#") ? input.Split('#')
                    : input.Contains(",") ? input.Split(',')
                    : input.Contains("|") ? input.Split('|')
                    : input.Contains("_") ? input.Split('_')
                    : input.Contains("-") ? input.Split('-')
                    : input.Contains(";") ? input.Split(';')
                    : new string[] { input };

                if (output != null && output.Length > 0)
                    return output.ToList();

                return null;
            }
            catch (Exception) { throw; }
        }
    }
}
