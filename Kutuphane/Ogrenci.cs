namespace Kutuphane
{
    public class Ogrenci
    {
        private int yas;
        public string ad;
        private string soyad;

        private int maas;

        public string Soyad {
            get
            {
                return soyad.ToUpper();
            }
            set 
            {
                soyad = value.ToUpper();
            }
        }
        public int Yas
        {
            get { return yas; }
            set 
            {
                yas = Math.Abs(value);
                //if (value > 0) 
                //{
                //    yas = value;
                //}
                //else
                //{
                //    int deger = Math.Abs(value);
                //    yas = deger;
                //}
            }
        }
    }
}
