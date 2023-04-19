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
    public partial class UykuApnesiTespitSistemi : Form
    {
       private IFirebaseClient client;
        private List<Hasta> hastaList;
        public UykuApnesiTespitSistemi(List<Hasta> hastaList)
        {
            InitializeComponent();
            this.hastaList= hastaList;
        }
        private IFirebaseConfig ifc = new FirebaseConfig() //RealTime Database adresine bağlantı için bir nesne oluşturuldu.
        {
            //Database adresi ve şifresi
            AuthSecret = "UzExMUlmK4nGDVcAQvcxCDUkdoh0DOZDm3PMpxsL",
            BasePath = "https://uykuapnesitespitsistemi-default-rtdb.firebaseio.com/"
        };
        

        private void UykuApnesiTespitSistemi_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantınızı Kontrol Ediniz. \n Hata Kodu => {ex}");
            }
            this.CenterToScreen();
            Login log = new Login();
            log.Visible = false;

            dataGridView1.DataSource = hastaList;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close(); 
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void HastaEkleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
