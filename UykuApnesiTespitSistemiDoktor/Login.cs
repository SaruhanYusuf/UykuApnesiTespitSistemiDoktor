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

namespace UykuApnesiTespitSistemiDoktor
{
    public partial class Login : Form
    {
        public Login()
        {
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
            catch
            {
                MessageBox.Show("Bağlantınızı Kontrol Ediniz.");
            }

        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            //Kutucukları Kontrol Ediyoruz.
            if (string.IsNullOrWhiteSpace(MailBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
                return;
            }
            FirebaseResponse res = client.Get(@"Users/" + MailBox.Text);
            TheUsers ResUser = res.ResultAs<TheUsers>(); //Database tepkiyi TheUsers sınıfına göre kontrol edecek.
            TheUsers CurUser = new TheUsers()
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
                MessageBox.Show("Başarıyla Giriş Yapıldı.");
           


        }
        private void KayitOl_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
    }

}

   

