using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }

        //İLİŞKİ KURMA BLOĞU(5.ADIM(6.ADIM HEADİNG'DE EN ALTTA) "1-SONSUZ" İLİŞKİ KISMINDA BURASI "1")
        public ICollection<Heading> Headings { get; set; }

        //İLİŞKİ KURMA BLOĞU(7.ADIM(8.ADIM CONTENT'DE EN ALTTA) "1-SONSUZ" İLİŞKİ KISMINDA BURASI "1")
        public ICollection<Content> Contents { get; set; }

    }
}
