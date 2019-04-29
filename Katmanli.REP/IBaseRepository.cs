using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Katmanli.REP
{
    public interface IBaseRepository<T> where T : class, new()
    {
        DbSet<T> Set();
        void Ekle(T entity);
        void Sil(T entity);
        void Guncel();//db.savechanges olduğu için herhangi bir veri döndürmüyor o yüden T entity yazmdk.
        T Bul(int Id);
        T Bul(string Id);
        List<T> Liste();
        IQueryable<T> GenelListe();

    }
}
