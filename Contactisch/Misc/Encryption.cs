using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Contactisch.Misc
{
    public class Encryption
    {
        public static string MakeHash(string aText, string aSalt)
        {
            byte[] data = Encoding.UTF8.GetBytes(aText + aSalt);
            SHA256Managed generator = new SHA256Managed();
            byte[] hashData = generator.ComputeHash(data);

            return MakeHexString(hashData);
        }

        private static string MakeHexString(byte[] aData)
        {
            StringBuilder builder = new StringBuilder(2 * aData.Length);

            foreach (byte value in aData)
            {
                builder.AppendFormat("{0:x2}", value);
            }

            return builder.ToString();
        }
    }
}