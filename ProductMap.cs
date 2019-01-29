using System;
using FluentNHibernate.Mapping;

namespace nhcore
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.Price);
            Map(x => x.QuantityOnHand);
        }
    }
}