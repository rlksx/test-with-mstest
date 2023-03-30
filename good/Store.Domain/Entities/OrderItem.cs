namespace Store.Domain.Entities;

public class OrderItem : Entity
{
   public OrderItem(Product product, int quantity)
   {
      this.Quantity = quantity; 
      this.Price = product != null ? product.Price : 0;
   }

   public decimal Price { get; private set; }
   public Product Product { get; private set; }
   public int Quantity { get; private set; }

   public decimal Total() 
      => Price * Quantity;
     
}
