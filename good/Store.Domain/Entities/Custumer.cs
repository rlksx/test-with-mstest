namespace Store.Domain.Entities;

class Custumer : Entity
{
   public Custumer(string name, string email)
   {
      Name = name;
      Email = email;
   }

   public string Name { get; private set; }
   public string Email { get; private set; }
}