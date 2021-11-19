using IleriPersonel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace IleriPersonel.Context
{
    public class PersonelContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        // Your context has been configured to use a 'PersonelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IleriPersonel.Context.PersonelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonelContext' 
        // connection string in the application configuration file.
        public PersonelContext()
            : base("name=Baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Calisan> Calisan { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<Egitmen> Egitmen { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
    }

    
    public class Sehir : TemelTanimlar
    {
        public Sehir()
        {
            Ilceler = new List<Ilce>();
        }
        public virtual List<Ilce> Ilceler { get; set; }
    }
    public class Egitim : TemelTanimlar
    {
        public Egitim()
        {
            Ogrenciler = new List<Ogrenci>();
            Egitmenler = new List<Egitmen>();
            Calisanlar = new List<Calisan>();
        }
        public virtual List<Ogrenci> Ogrenciler { get; set; }
        public virtual List<Egitmen> Egitmenler { get; set; }
        public virtual List<Calisan> Calisanlar { get; set; }
    }
    public class Ilce : TemelTanimlar
    {
        public Ilce()
        {
            Ogrenciler = new List<Ogrenci>();
            Egitmenler = new List<Egitmen>();
            Calisanlar = new List<Calisan>();
        }
        public int SehirId { get; set; }
        [ForeignKey("SehirId")]
        public virtual Sehir Sehir { get; set; }
        public virtual List<Ogrenci> Ogrenciler { get; set; }
        public virtual List<Egitmen> Egitmenler { get; set; }
        public virtual List<Calisan> Calisanlar { get; set; }
    }
    public class Ogrenci : TemelInsan
    {
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }
    }
    public class Egitmen : TemelInsan
    {
        public decimal Maas { get; set; }
        public string Unvan { get; set; }
        public override string UnvanYaz()
        {
            return "Sn. " + Unvan + " " + Ad + " " + Soyad;
        }
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }
    }
    public class Calisan : TemelInsan
    {
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }
    }
}