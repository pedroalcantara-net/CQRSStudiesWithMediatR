namespace ColdQuackRealSystem.Repository.Interface.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAllRecords();
        bool InsertRecord(TEntity obj);
        bool UpdateRecord(TEntity obj);
        bool RemoveRecord(TEntity obj);
        TEntity GetRecordById(int id);
    }
}
