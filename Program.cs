using System;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace nhcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionFactory = Fluently
                .Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=localhost,1433;Database=products;User ID=SA;Password=!1q@2w#3e$4r"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory();
            var session = sessionFactory.OpenSession();

            var product = new Product("Produto 1", 199, 10);
            session.Save(product);
            session.Flush();

            var products = session.Query<Product>()
                .Where(p => p.Price < 1000)
                .ToList();

            
            products.ForEach(x => Console.WriteLine($"{x.Title}"));
            Console.Read();
            session.Close();
        }
    }
}
