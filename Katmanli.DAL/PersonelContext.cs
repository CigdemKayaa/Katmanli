namespace Katmanli.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using static Katmanli.ENT.Entities;

    public class PersonelContext : DbContext
    {
        public static PersonelContext db = new PersonelContext();
        // Your context has been configured to use a 'PersonelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Katmanli.DAL.PersonelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonelContext' 
        // connection string in the application configuration file.
        public PersonelContext()
            : base("name=Baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Personel> Personel { get; set; } // personel shwpottan add referans
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Il> Il { get; set; }
        public virtual DbSet<KanGrup> KanGrup { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}