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
        public static string makeHashSHA256(string aText)
        {
            byte[] data = Encoding.UTF8.GetBytes(aText);
            SHA256Managed generator = new SHA256Managed();
            byte[] hashData = generator.ComputeHash(data);

            return makeHexString(hashData);
        }

        private static string makeHexString(byte[] aData)
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