namespace UykuApnesiTespitSistemiDoktor
{
    public class Rapor
    {
        public int ID { get; set; }
        public string VeriTarihi { get; set; }
        public string Tani { get; set; }
        public string Icerik { get; set; }

        public Rapor(int ıD, string veriTarihi, string tani, string ıcerik)
        {
            ID = ıD;
            VeriTarihi = veriTarihi;
            Tani = tani;
            Icerik = ıcerik;
        }
    }
}