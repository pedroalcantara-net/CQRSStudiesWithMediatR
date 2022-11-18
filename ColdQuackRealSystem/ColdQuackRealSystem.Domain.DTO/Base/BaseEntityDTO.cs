namespace ColdQuackRealSystem.Domain.DTO.Base
{
    public class BaseEntityDTO
    {

        public BaseEntityDTO(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
