using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //İLİŞKİ BLOĞUNUN 4.TARAFI  (3.TARAFI HEADING'DE)("1-SONSUZ" İLİŞKİ KISMINDA BURASI "SONSUZ")
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //İLİŞKİ BLOĞUNUN 8.TARAFI  (7.TARAFI WRITER'DA)("1-SONSUZ" İLİŞKİ KISMINDA BURASI "SONSUZ")
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
