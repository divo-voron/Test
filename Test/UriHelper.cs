using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class UriHelper
    {
        public static Uri GenerateUri(string startUri, string endUri)
        {
            if (Uri.TryCreate(startUri, UriKind.RelativeOrAbsolute, out var uriStart) == false)
            {
                return null;
            }

            Uri.TryCreate(uriStart, endUri, out var uriResult);
            return uriResult;
        }
    }
}
