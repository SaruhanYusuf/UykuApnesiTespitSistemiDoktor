using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace UykuApnesiTespitSistemiDoktor
{
    public partial class Register : Form
    {
        public Register()
        {
            
            InitializeComponent();
           

        }
        IFirebaseConfig ifc = new FirebaseConfig() //RealTime Database adresine ba�lant� i�in bir nesne olu�turuldu.
        {
            //Database adresi ve �ifresi
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
            catch
            {
                MessageBox.Show("Ba�lant�n�z� Kontrol Ediniz.");
            }
        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            //Kutucuklar� Kontrol Ediyoruz.
            if(string.IsNullOrWhiteSpace(MailBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("L�tfen T�m Alanlar� Doldurunuz.");
                return;
            }
            TheUsers user = new TheUsers()
            {
                Mail = MailBox.Text,
                Password = PasswordBox.Text,
            };
            SetResponse set = client.Set(@"Users/" +MailBox.Text,user);
            MessageBox.Show("Ba�ar�yla Kay�t Olundu.");
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
    }
}