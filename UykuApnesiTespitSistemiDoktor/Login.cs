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
using Newtonsoft.Json;

namespace UykuApnesiTespitSistemiDoktor
{
    public partial class Login : Form
    {
        static List<TheUsers> userList;
        static string referance;  //Guild ID tutmak için gerekli bir değişken. Bir sonraki forma parametre yollamak için gerekli.
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
            this.CenterToScreen();
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
            //Database tepkiyi TheUsers sınıfına göre kontrol edecek.
            FirebaseResponse res = client.Get(@"Users/");
            var hastaList = res.Body;
            var firebaseData = JsonConvert.DeserializeObject<Dictionary<string, TheUsers>>(hastaList);
            foreach (var item in firebaseData)
            {
                TheUsers user = item.Value;
                userList.Add(user);
            }
            TheUsers CurUser = new TheUsers()
            {
                Mail = MailBox.Text,
                Password = PasswordBox.Text,
            };
            // CurUser frontend kısmında giriş yapmaya çalıştığımız kullanıcı firebaseData içinde mevcut ise finaluser'a atıyoruz.
            TheUsers finaluser = userList.FirstOrDefault(x => x.Mail.Equals(CurUser.Mail) && x.Password.Equals(CurUser.Password)); 
            if (finaluser!=null && expr.IsMatch(email))
            {
                //Bir sonraki form UykuApnesiTespitSistemi'ne finaluser'ın ID'si ve HastaList'ini parametre olarak yolluyoruz.
                //Bu parametreleri daha sonra Hasta listesini listelemek için kullanacağız.
                UykuApnesiTespitSistemi uykuApnesiTespitSistemi = new UykuApnesiTespitSistemi(finaluser.HastaList,finaluser.ID);
                uykuApnesiTespitSistemi.Show();
                this.Visible = false;
            }
            else
                TheUsers.ShowError();
        }
        private void KayitOl_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Visible = false;
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

   

