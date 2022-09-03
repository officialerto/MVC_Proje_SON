using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BU KISIM SQL'E TABLO ŞEKLİNDE YANSITILAN KISIM DBCONTEXT KISMI YANİ
namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //EĞER BU KATMANDA DİĞER KATMANIN HER TÜRLÜ ELEMANLARINI KULLANMAK İSTİYORSAK SOLUTION EXPLORER'DA BU KATMANIN..
        //ALTINDA BULUNAN REFERENCES'A SAĞ TIKLA "ADD REFERENCES" SONRA SOL KISIMDA "PROJECTS" SEÇ HANGİ KATMANI..
        //KULLANMAK İSTİYORSAN ONU SEÇ VE BİTİR.

        //PLURALIZE OLAYI(S TAKISI ALMA): YALIN HALİ PROJEDE BULUNAN KISIM - S'TAKISI ALAN KISIM İSE SQL'E YANSIYAN KISIM
        //VE KARIŞMASIN DİYE ÖYLE OLUYOR.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
