using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    /// <summary>
    /// Ana ekranda kullanıcı listelemek amacıyla kullacak nesnedir
    /// </summary>
    public class KullaniciDto:IDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Kullanıcını ad alanı boş geçilemez")]
        [MinLength(2)]
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
    }
}
