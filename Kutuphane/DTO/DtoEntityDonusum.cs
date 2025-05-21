using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    public class DtoEntityDonusum
    {
        public DataModel.Kullanici KullaniciDonustur(DTO.KullaniciDto dtoKullanici)
        {
            DataModel.Kullanici kullanici = new DataModel.Kullanici();
            kullanici.Ad = dtoKullanici.Ad;
            kullanici.Soyad=dtoKullanici.Soyad;
            kullanici.DogumTarihi = dtoKullanici.DogumTarihi;

            return kullanici; 
        }

        /// <summary>
        /// Dto ile entity arasında mapping yapan (propertyelerini eşleşitiren) generic metottur.
        /// Dto nesnesinin property ismi aynı olan entity propertylerine eşleştirilmesi sağlanır.
        /// Mapping işlemi property adına göre yapılır. Adı aynı olan propertylerin değerleri eşleşitrilir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="D"></typeparam>
        /// <param name="dtoNesnesi"></param>
        /// <returns></returns>
        public E EntiyDonustur<E,D>(D dtoNesnesi)where E:class, new() where D:class, IDto
        {
            E entity = new E();
            ///dto nesnesinin property isimlerinin listesi alınır. aynı ismli entity propertyleylerine değeri doldurulur.
            var dtoOzellikleri = typeof(D).GetProperties();
            var entityOzellikleri = typeof(E).GetProperties();
            foreach (var ozellikBilgi in dtoOzellikleri)
            {
                var deger = ozellikBilgi.GetValue(dtoNesnesi);//Dto nesnesenin sıradaki propertysinin değerini alıyoruz.
                //entity nesnesi propertylerinde dto nesnesenini property ismiyle aynı isimli özellik varsa onu getir
                var eslesenEntityOzelligi = entityOzellikleri.FirstOrDefault(p => p.Name == ozellikBilgi.Name);
                //aynı isimli özellik varsa o zaman dto propertysinden elde edilen değeri entity propertysne yaz
                if (eslesenEntityOzelligi!=null)
                {
                    eslesenEntityOzelligi.SetValue(entity,deger);
                }
            }


            return entity;
        }
    }
}
