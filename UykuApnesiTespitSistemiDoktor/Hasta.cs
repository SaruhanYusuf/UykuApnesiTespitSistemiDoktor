namespace UykuApnesiTespitSistemiDoktor
{
    public class Hasta
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Soyad { get; set; }
        public string Alan { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }

        public List<Rapor> RaporList { get; set; }

        public Hasta(string ıD, string name, string soyad, string alan, int yas, string cinsiyet, List<Rapor> raporList)
        {
            ID = ıD;
            Name = name;
            Soyad = soyad;
            Alan = alan;
            Yas = yas;
            Cinsiyet = cinsiyet;
            RaporList = raporList;
        }
    }
}