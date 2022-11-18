using ColdQuackRealSystem.Domain.Entities.Base;

namespace ColdQuackRealSystem.Domain.Entities
{
    public class FrozenDuck : BaseEntity
    {
        public FrozenDuck(int id, string breed, decimal price) : base(id)
        {
            Breed = breed;
            Price = price;
        }

        public string Breed { get; private set; }
        public decimal Price { get; private set; }
    }
}
