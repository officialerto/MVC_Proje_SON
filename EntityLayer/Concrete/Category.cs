using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //İLİŞKİ KURMA BLOĞU(1.ADIM(2.ADIM HEADİNG'DE ALTTA) 1-SONSUZ İLİŞKİ KISMINDA BURASI "1")
        public ICollection<Heading> Headings { get; set; }
    }
}
