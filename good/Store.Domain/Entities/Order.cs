using Store.Domain.Enums;

namespace Store.Domain.Entities;

public class Order
{
   public Order(Customer customer, decimal deliveryFee, Discount discount)
   {
      Customer = customer;
      Date = DateTime.Now;
      Number = Guid.NewGuid().ToString().Substring(0, 8);
      Status = EOrderStatus.WaittingPayment;
      Items = new List<OrderItem>();
      DeliveryFee = deliveryFee;
      Discount = discount;
   }

   public Customer Customer { get; private set; }
   public DateTime Date { get; private set; }
   public string Number { get; private set; }
   public List<OrderItem> Items { get; private set; }
   public decimal DeliveryFee { get; private set; }
   public Discount Discount { get; private set; }
   public EOrderStatus Status { get; private set; }

   public void AddItem(Product product, int quantity)
   {
      var item = new OrderItem(product, quantity);
   }

   public decimal Total()
   {
      decimal total = 0;
      foreach (var item in Items)
         total += item.Total();

      total += DeliveryFee;
      total -= Discount != null ? Discount.Value() : 0;

      return total;
   }

   public void Pay(decimal amount)
   {
      if (amount == Total())
         this.Status = EOrderStatus.WaittingDelivery;
   }

   public void Cancel()
      => Status = EOrderStatus.Canceled;
   
}
