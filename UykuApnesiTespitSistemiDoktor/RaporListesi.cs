using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class RaporListesi : Form
    {
        private Hasta h;
        private IFirebaseClient client;
        private List<Rapor> raporListesi;
        
        public RaporListesi(Hasta h) //Gelen parametre => RowIndex tıklanan hastanın ID'si
        {
            this.h = h;
            InitializeComponent();
        }
        private IFirebaseConfig ifc = new FirebaseConfig() //RealTime Database adresine bağlantı için bir nesne oluşturuldu.
        {
            //Database adresi ve şifresi
            AuthSecret = "UzExMUlmK4nGDVcAQvcxCDUkdoh0DOZDm3PMpxsL",
            BasePath = "https://uykuapnesitespitsistemi-default-rtdb.firebaseio.com/"
        };
        private void RaporListesi_Load_1(object sender, EventArgs e)
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
            dataGridView1.DataSource = h.RaporList; //Gelen ID'deki tabloyu grid ile listelemek için.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void RaporListesi_Load(object sender, EventArgs e)
        {
        }
        private void RaporListesi_Activated(object sender, EventArgs e)
        {
        }
    }
}
