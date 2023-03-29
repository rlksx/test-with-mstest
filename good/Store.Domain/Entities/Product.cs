namespace Store.Domain.Entities;

public class Product
{
   public Product(string title, decimal price, bool activity)
   {
      this.Title = title;
      this.Price = price;
      this.Activity = activity;
   }

   public string Title { get; private set; }
   public decimal Price { get; set; }
   public bool Activity { get; private set; }
}
