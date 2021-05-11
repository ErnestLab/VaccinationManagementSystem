using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.ORM
{
    using Entities;

    public class DataManager : DbContext
    {
        // Контекст настроен для использования строки подключения "DataManager" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "DAL.ORM.DataManager" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataManager" 
        // в файле конфигурации приложения.
        public DataManager()
            : base("name=DataManager")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}