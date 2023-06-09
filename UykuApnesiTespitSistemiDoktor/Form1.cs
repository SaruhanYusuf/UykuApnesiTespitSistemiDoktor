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
            catch(Exception ex)
            {
                MessageBox.Show($"Ba�lant�n�z� Kontrol Ediniz. \n Hata Kodu =>{ex}");
            }
            this.CenterToScreen();
        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            List<TheUsers> userList = new();
            List<Hasta> hastaList = new();
            List<Rapor> raporList = new();
            raporList.Add(new Rapor(1,null,null,null, null, null, null));
            hastaList.Add(new Hasta(new Guid().ToString(), "Hasan", "M�nir", "Apne", 22, "�yi" ,"E", raporList));

            string email = MailBox.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            //Kutucuklar� Kontrol Ediyoruz.
            if (string.IsNullOrWhiteSpace(MailBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("L�tfen T�m Alanlar� Doldurunuz.");
                return;
            }
            else if (expr.IsMatch(email))
            {
                

                string mail = MailBox.Text;
                string password = PasswordBox.Text;
       
                string referance = Guid.NewGuid().ToString();
                userList.Add(new TheUsers(referance, "M�nir", "UykuApnesi", hastaList, mail, password));
                SetResponse set = client.Set(@"Users/" + referance, userList.First());
            }
            else
                MessageBox.Show("Ge�erli Bir Mail Adresi Giriniz.");

        }

        private void UyeGirisButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Visible = false;
            log.ShowDialog();    
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}