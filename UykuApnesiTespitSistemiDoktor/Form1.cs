using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace UykuApnesiTespitSistemiDoktor
{
    public partial class Register : Form
    {
        public Register()=> InitializeComponent();
        
        
        IFirebaseConfig ifc = new FirebaseConfig() //RealTime Database adresine baðlantý için bir nesne oluþturuldu.
        {
            //Database adresi ve þifresi
            AuthSecret = "UzExMUlmK4nGDVcAQvcxCDUkdoh0DOZDm3PMpxsL",
            BasePath = "https://uykuapnesitespitsistemi-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Baðlantýnýzý Kontrol Ediniz. \n Hata Kodu =>{ex}");
            }
        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            List<TheUsers> userList = new();
            List<Hasta> hastaList = new();
            List<Rapor> raporList = new();
            raporList.Add(new Rapor(1,"18.04.2023","deneme","deneme"));
            hastaList.Add(new Hasta(1, "Hasan", "Münir", "Apne", 22, 'E', raporList));
            userList.Add(new TheUsers(1, "Münir", "UykuApnesi",hastaList, "Sarukan151@gmail.com", "123456789"));
            string email = MailBox.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            //Kutucuklarý Kontrol Ediyoruz.
            if (string.IsNullOrWhiteSpace(MailBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanlarý Doldurunuz.");
                return;
            }
            else
                TheUsers.ShowError();
     
            SetResponse set = client.Set(@"Users/" + MailBox.Text, userList.First());

        }


        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UyeGirisButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Close();
        }
    }
}