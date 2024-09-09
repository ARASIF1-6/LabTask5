using LabTask5.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace LabTask5.Context
{
    public class AppContextModel : DbContext
    {
        // Your context has been configured to use a 'AppContextModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LabTask5.Context.AppContextModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AppContextModel' 
        // connection string in the application configuration file.
        public AppContextModel()
            : base("name=AppContextModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}