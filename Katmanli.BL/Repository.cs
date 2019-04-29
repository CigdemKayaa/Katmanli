using Katmanli.REP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Katmanli.ENT.Entities;

namespace Katmanli.BL
{
    public class BusinessClasses
    {
        public class PersonelRepository : BaseRepository<Personel>
        {
            public override ComboBox GetComboBox(ComboBox cmBox)
            {
                cmBox.DataSource = Liste().Select(x => new
                {
                    x.PersonelId,
                    FullName = x.Ad + x.Soyad
                }).ToList();
                cmBox.DisplayMember = "FullName";
                cmBox.ValueMember = "PersonelId";
                return cmBox;
            }
        }
        public class EgitimRepository : BaseRepository<Egitim>
        {

        }
        public class UnvanRepository : BaseRepository<Unvan>
        {

        }
        public class IlRepository : BaseRepository<Il>
        {

        }
        public class IlceRepository : BaseRepository<Ilce>
        {

        }
        public class KanGrupRepository : BaseRepository<KanGrup>
        {

        }


    }
}
