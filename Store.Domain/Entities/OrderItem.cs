namespace Store.Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;

public class OrderItem : Entity
{
   public OrderItem(Product product, int quantity)
   {
      this.Quantity = quantity; 
      this.Price = product != null ? product.Price : 0;

      AddNotifications(
         new Contract<Notification>()
            .Requires()
            .IsNotNull(product, "Product", "Produto inválido")
            .IsGreaterThan(quantity, 0, "Quantity", "Quantidade inválida")
      );
   }

   public decimal Price { get; private set; }
   public Product Product { get; private set; }
   public int Quantity { get; private set; }

   public decimal Total() 
      => Price * Quantity;
     
}
