using DataPermissioning.Domain.Model;
using System;
using System.Collections.Generic;

namespace DataPermissioning.Common.Extension
{
    public static class PermissionExtension
    {
        public static IEnumerable<string> ToTickerStringList(this IEnumerable<IIndexIncludePermission> input)
        {
            try
            {
                var output = new List<string>();

                foreach (var permission in input)
                    if (!string.IsNullOrEmpty(permission.Ticker))
                        output.Add(permission.Ticker);

                if (output != null && output.Count > 0)
                    return output;

                return null;
            }
            catch (Exception) { throw; }
        }

        public static IEnumerable<string> ToTickerStringList(this IEnumerable<IIndexExcludePermission> input)
        {
            try
            {
                var output = new List<string>();

                foreach (var permission in input)
                    if (!string.IsNullOrEmpty(permission.Ticker))
                        output.Add(permission.Ticker);

                if (output != null && output.Count > 0)
                    return output;

                return null;
            }
            catch (Exception) { throw; }
        }
    }
}
