namespace UykuApnesiTespitSistemiDoktor
{
    public class Hasta
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Soyad { get; set; }
        public string Alan { get; set; }
        public int Yas { get; set; }
        public char Cinsiyet { get; set; }

        public List<Rapor> RaporList { get; set; }

        public Hasta(int ıD, string name, string soyad, string alan, int yas, char cinsiyet, List<Rapor> raporList)
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