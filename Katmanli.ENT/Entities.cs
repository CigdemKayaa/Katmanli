using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.ENT
{
    public class Entities
    {
        [Table("Personel")]
        public class Personel
        {
            [Key]
            public int PersonelId { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            //public Adres Adres { get; set; }
            public int IlceId { get; set; }

            public int EgitimId { get; set; }
            public int UnvanId { get; set; }
            public int KanGrupId { get; set; }
            public int YoneticiId { get; set; }
            public DateTime DogumTarih { get; set; }
            [ForeignKey("EgitimId")]
            public virtual Egitim Egitim { get; set; }
            [ForeignKey("UnvanId")]
            public virtual Unvan Unvan { get; set; }
            [ForeignKey("KanGrupId")]
            public virtual KanGrup KanGrup { get; set; }
            [ForeignKey("YoneticiId")]
            public virtual Personel Personel1 { get; set; } // yönetici
            public virtual List<Personel> Personel2 { get; set; } // yöneticinin altındaki elemanları görcez.
            [ForeignKey("IlceId")]
            public virtual Ilce Ilce { get; set; }
        }

        //public class Adres
        //{
        //    public string Cadde { get; set; }
        //    public string Sokak { get; set; }
        //    public string KapıNo { get; set; }
        //    public int PostaKod { get; set; }

        //    public int IlceId { get; set; }
        //    [ForeignKey("IlceId")]
        //    public virtual Ilce Ilce { get; set; }
        //}

        abstract public class Tanim // tekrar newlenmesin diye
        {
            [Key]
            public int Id { get; set; }
            public string Acıklama { get; set; }
        }

        [Table("Egitim")]
        public class Egitim : Tanim
        {
            public Egitim()
            {
                this.Personel = new HashSet<Personel>();
            }

            public virtual ICollection<Personel> Personel { get; set; }
        }

        [Table("Unvan")]
        public class Unvan : Tanim
        {
            public Unvan()
            {
                this.Personel = new HashSet<Personel>();
            }

            public virtual ICollection<Personel> Personel { get; set; }
        }

        [Table("KanGrup")]
        public class KanGrup : Tanim
        {
            public KanGrup()
            {
                this.Personel = new HashSet<Personel>();
            }

            public virtual ICollection<Personel> Personel { get; set; }

        }

        [Table("Ilce")]
        public class Ilce : Tanim
        {
            public Ilce()
            {
                this.Personel = new HashSet<Personel>();
            }
            public int IlId { get; set; }
            public virtual ICollection<Personel> Personel { get; set; }
            [ForeignKey("IlId")]
            public virtual Il Il { get; set; }

        }

        [Table("Il")]
        public class Il : Tanim
        {
            public Il()
            {
                this.Ilce = new HashSet<Ilce>();
            }
            public virtual ICollection<Ilce> Ilce { get; set; }
        }
    }
}
