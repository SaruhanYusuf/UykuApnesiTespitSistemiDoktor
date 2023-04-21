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
        private string id;
        private int removeAt;

        private string isim, soyisim;
        private int yas;
        private bool eMi;
        public UykuApnesiTespitSistemi(List<Hasta> hastaList,string id)
        {
            InitializeComponent();
            this.hastaList= hastaList;
            this.id = id;
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
        private Hasta HastaEkle(string id,string isim,string soyisim,int dogumTarih,bool eMi)
        {
            string cinsiyet;
            if (eMi)
                cinsiyet = "E";
            else
                cinsiyet = "K";
           
            
            return new(id, isim, soyisim, "Apne", dogumTarih, cinsiyet, new List<Rapor>());


        }

        private void HastaSilButton_Click(object sender, EventArgs e)
        {
            hastaList.RemoveAt(removeAt);
            SetResponse set = client.Set(@"Users/" + id + "/HastaList", hastaList);



            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
            Task.Delay(100);
            dataGridView1.DataSource = hastaList;
            dataGridView1.Update();
            dataGridView1.Refresh();
           

        }

  

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            removeAt = e.RowIndex;
            HastaAdıTextBox.Text = hastaList[removeAt].Name;
            HastaSoyAdıTextBox.Text = hastaList[removeAt].Soyad;
            
        }

        private void HastaEkleButton_Click(object sender, EventArgs e)
        {
            string hastaadi = HastaAdıTextBox.Text;
            string hastasoyadi = HastaSoyAdıTextBox.Text;
            int dogumtarihi =2023-HastaYasi.Value.Year;
            bool cinsiyet = checkBox1.Checked;
            Guid random = new Guid();
            if (hastaList == null)
            {
                hastaList = new List<Hasta>();
            }
            
            hastaList.Add(HastaEkle(random.ToString(), hastaadi, hastasoyadi, dogumtarihi, cinsiyet));
            SetResponse set = client.Set(@"Users/" + id+"/HastaList",hastaList);
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
            Task.Delay(100);
            dataGridView1.DataSource = hastaList;
            dataGridView1.Update();
            dataGridView1.Refresh();


        }
    }
}
