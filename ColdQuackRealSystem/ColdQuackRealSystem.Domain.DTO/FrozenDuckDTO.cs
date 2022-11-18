using ColdQuackRealSystem.Domain.DTO.Base;

namespace ColdQuackRealSystem.Domain.DTO
{
    public class FrozenDuckDTO : BaseEntityDTO
    {
        public FrozenDuckDTO(int id, string breed, decimal price) : base(id)
        {
            Breed = breed;
            Price = price;
        }

        public string Breed { get; set; }
        public decimal Price { get; set; }
    }
}
