using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_User_Key_Generation
{
    class Base64Convert
    {
        public static string EncodeData(string incomingString)
        {
            byte[] baseBytes = Encoding.UTF8.GetBytes(incomingString);
            string baseString = Convert.ToBase64String(baseBytes);

            return baseString;
        }
    }
}
