using System;

namespace nhcore
{
    public class Product
    {
        protected Product() { }
        
        public Product(string title, decimal price, int quantityOnHand)
        {
            Id = Guid.NewGuid();
            Title = title;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public virtual Guid Id { get; protected set; }
        public virtual string Title { get; protected set; }
        public virtual decimal Price { get; protected set; }
        public virtual int QuantityOnHand { get; protected set; }
    }
}