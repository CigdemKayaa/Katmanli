using Katmanli.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katmanli.REP
{
    public class BaseRepository<T> : IBaseRepository<T>, IComboRepository<T> where T : class, new()
    {
        DAL.PersonelContext db = PersonelContext.db;
        public T Bul(int Id)
        {
            return Set().Find(Id);
        }

        public T Bul(string Id)
        {
            return Set().Find(Id);
        }

        public void Ekle(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public virtual ComboBox GetComboBox(ComboBox cmBox)
        {
            cmBox.DataSource = Liste();
            cmBox.DisplayMember = "Aciklama";
            cmBox.ValueMember = "Id";
            return cmBox;
        }
        

        public void Guncel()
        {
            db.SaveChanges();
        }

        public List<T> Liste()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }

        DbSet<T> IBaseRepository<T>.Set()
        {
            throw new NotImplementedException();
        }
    }
}
