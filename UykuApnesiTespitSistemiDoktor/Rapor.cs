namespace UykuApnesiTespitSistemiDoktor
{
    public class Rapor
    {
        public int ID { get; set; }
        public string VeriTarihi { get; set; }
        public string Icerik { get; set; }
        public string Sıcaklık { get; set; }
        public string OksijenSeviyesi { get; set; }
        public string Pozisyon { get; set; }


        public Rapor(int ıD, string veriTarihi, string ıcerik, string sicaklik, string oksijen, string deneme ,string pozisyon)
        {
            ID = ıD;
            VeriTarihi = veriTarihi;
            Icerik = ıcerik;
            Sıcaklık = sicaklik;
            OksijenSeviyesi = oksijen;
            Pozisyon = pozisyon;
         
        }
    }
}