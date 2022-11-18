namespace ColdQuackRealSystem.Services.Interface.Base
{
    public interface IBaseService<TEntity, TEntityDTO> where TEntity : class where TEntityDTO : class
    {
        bool InsertRecord(TEntityDTO objeto);
        bool UpdateRecord(TEntityDTO objeto);
        IEnumerable<TEntityDTO> GetAllRecords();
        TEntityDTO GetRecordById(int id);
        bool RemoveRecord(TEntityDTO registro);
    }
}
