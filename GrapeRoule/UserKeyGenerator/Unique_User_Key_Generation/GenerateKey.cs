using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Unique_User_Key_Generation
{
    public class GenerateKey
    {
        public static string Generate(long userID, string username)
        {
            string subJump0 = "";
            long usernameValue = 0;
            string usernameBaseValue = Base64Convert.EncodeData(username);

            for (int i = 0; i < username.Length; i++)
            {
                usernameValue += (byte)username[i];
            }

            for (int j = 0; j < usernameBaseValue.Length; j++)
            {
                subJump0 += (char)(usernameBaseValue[j] + (usernameValue/userID));
            }
            string generatedKey = Base64Convert.EncodeData(subJump0);            
            return generatedKey;
        }
    }
}
