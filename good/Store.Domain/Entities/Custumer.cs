namespace Store.Domain.Entities;

class Custumer : Entity
{
   public Custumer(string nome, string email)
   {
      nome = nome;
      Email = email;
   }

   public string Name { get; private set; }
   public string Email { get; private set; }
}