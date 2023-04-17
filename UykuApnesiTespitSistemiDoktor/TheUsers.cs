using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UykuApnesiTespitSistemiDoktor
{
    internal class TheUsers
    {
     
        public string Mail { get; set; }
        public string Password { get; set; }
        private static string error;
        public static bool IsEqual(TheUsers user1, TheUsers user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }
           if(user1.Mail != user2.Mail)
            {
                error = "Kullanıcı Bulunamadı";
                return false; 
            }
           else if(user1.Password != user2.Password)
            {
                error = "Kullanıcı Adı Veya Şifre Yanlış";
                return false;
            }
           return true;   
    }

    }
   
    
}
