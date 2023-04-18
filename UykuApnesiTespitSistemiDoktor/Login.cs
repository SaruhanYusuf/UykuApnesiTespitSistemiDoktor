using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Drawing;

namespace UykuApnesiTespitSistemiDoktor
{
    public partial class Login : Form
    {
        List<TheUsers> userList;
        public Login()
        {
            userList = new List<TheUsers>();
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig() //RealTime Database adresine bağlantı için bir nesne oluşturuldu.
        {
            //Database adresi ve şifresi
            AuthSecret = "UzExMUlmK4nGDVcAQvcxCDUkdoh0DOZDm3PMpxsL",
            BasePath = "https://uykuapnesitespitsistemi-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Bağlantınızı Kontrol Ediniz. \n Hata Kodu => {ex}");
            }

        }
        private void GirisYap_Click(object sender, EventArgs e)
        {
            

            //Kutucukları Kontrol Ediyoruz.
            if (string.IsNullOrWhiteSpace(MailBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "HATA");
                return;
            }
            string email = MailBox.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions
                .Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

         
            FirebaseResponse res = client.Get(@"Users/" + userList.First());
            TheUsers ResUser = res.ResultAs<TheUsers>(); //Database tepkiyi TheUsers sınıfına göre kontrol edecek.
          /*  TheUsers CurUser = new TheUsers()
            {
                Mail = MailBox.Text,
                Password = PasswordBox.Text,
            };
            if (TheUsers.IsEqual(ResUser, CurUser))
            {
                
                UykuApnesiTespitSistemi uykuApnesiTespitSistemi = new UykuApnesiTespitSistemi();
                uykuApnesiTespitSistemi.ShowDialog();
            }
            else
                TheUsers.ShowError();*/
        }
        private void KayitOl_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            MailBox.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel2.BackColor = Color.White;
            PasswordBox.BackColor = Color.White;
        }
        private void MailBox_TextChanged(object sender, EventArgs e)
        {
            MailBox.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            PasswordBox.BackColor = SystemColors.Control;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

   

