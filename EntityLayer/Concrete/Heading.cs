using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //İLİŞKİ BLOĞUNUN 2.TARAFI  (1.TARAFI CATEGORY'DE)(1-SONSUZ İLİŞKİ KISMINDA BURASI "SONSUZ")
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //İLİŞKİ KURMA BLOĞU(3.ADIM(4.ADIM CONTENT'DE ALTTA) 1-SONSUZ İLİŞKİ KISMINDA BURASI "1")
        public ICollection<Content> Contents { get; set; }

        //İLİŞKİ BLOĞUNUN 6.TARAFI  (5.TARAFI WRITER'DA)(1-SONSUZ İLİŞKİ KISMINDA BURASI "SONSUZ")
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
