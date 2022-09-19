using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature   //Öne çıkan kısmı burada tanımlıyorum. Büyük fotoğraf için tanımladım.Küçük fotolar için feature2 class'ı oluşturdum.Bu kısım revize edilebilir.
    {
        [Key]
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
