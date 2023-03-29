namespace Store.Domain.Entities;

public class Discount : Entity
{
   public Discount(decimal amount, DateTime exprireDate)
   {
      Amount = amount;
      ExprireDate = exprireDate;
   }

   public decimal Amount { get; private set; }
   public DateTime ExprireDate { get; private set; }

   public bool IsValid() 
    => DateTime.Compare(DateTime.Now, ExprireDate) < 0;

    public decimal Valid() {
        if(IsValid())
            return Amount;
        else
            return 1;
    }
}
