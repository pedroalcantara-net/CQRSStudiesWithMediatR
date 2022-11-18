namespace ColdQuackRealSystem.Domain.Entities.Base
{
    public class BaseEntity
    {
        public BaseEntity(int id)        {
            Id = id;

        }

        public int Id { get; private set; }
    }
}
