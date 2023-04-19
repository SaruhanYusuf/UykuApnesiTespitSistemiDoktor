using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UykuApnesiTespitSistemiDoktor
{
    internal class TheUsers
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Alan { get; set; }
        public List<Hasta> HastaList { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
       
        private static string error = "Bir Hata Oluştu";

      
        public TheUsers(int ıD, string name, string alan, List<Hasta> hastaList, string mail, string password)
        {
            ID = ıD; // Buraya bir düzenleme yapılacak! 
            Name = name;
            Alan = alan;
            HastaList = hastaList;
            Mail = mail;
            Password = password;

        }

        public TheUsers()
        {
        } 

        public static void ShowError() =>
            MessageBox.Show(error);
        public static bool IsEqual(TheUsers user1, TheUsers user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }
            if (user1.Mail != user2.Mail)
            {
                error = "Kullanıcı Bulunamadı";
                return false;
            }
            else if (user1.Password != user2.Password)
            {
                error = "Kullanıcı Adı Veya Şifre Yanlış";
                return false;
            }
            return true; 
        }
        public static bool IsEmail(TheUsers mailbox)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions
                .Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (mailbox.Mail.Length < 0 || !rEMail.IsMatch(mailbox.Mail))
            {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            return true;
        }
    }
}
   
    

