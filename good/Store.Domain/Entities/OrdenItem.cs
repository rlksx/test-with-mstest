namespace Store.Domain.Entities;

public class OrdenItem : Entity
{
   public OrdenItem(int qunatity, Product product)
   {
      this.Quantity = qunatity; 
      this.Price = product != null ? product.Price : 0;
   }

   public decimal Price { get; private set; }
   public Product Product { get; private set; }
   public int Quantity { get; private set; }

   public decimal Total() 
      => Price * Quantity;
     
}
