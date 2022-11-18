using ColdQuackRealSystem.DataAccess;
using ColdQuackRealSystem.Repository.Interface.Base;
using Microsoft.EntityFrameworkCore;

namespace ColdQuackRealSystem.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly ColdQuackContext Db;
        protected readonly DbSet<TEntity> DBSet;

        private readonly string _strConexao;

        public BaseRepository(ColdQuackContext db)
        {
            Db = db;
            if (db == null)
                throw new ArgumentNullException(nameof(db));

            DBSet = Db.Set<TEntity>();
            //_strConexao = Db.Database.GetDbConnection().ConnectionString;

        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        private void AlterarBanco()
        {
            Db.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetAllRecords()
        {
            var responses = DBSet.AsNoTracking().AsQueryable();
            return responses;
        }

        public virtual bool InsertRecord(TEntity entity)
        {
            var success = false;

            try
            {
                DBSet.Add(entity);
                AlterarBanco();
                success = true;
            }
            catch { }


            return success;
        }

        public virtual bool UpdateRecord(TEntity obj)
        {
            var success = false;

            try
            {
                DBSet.Update(obj);
                AlterarBanco();
                success = true;
            }
            catch
            {

            }


            return success;
        }

        public virtual bool RemoveRecord(TEntity obj)
        {

            var success = false;

            try
            {
                DBSet.Remove(obj);
                AlterarBanco();

                success = true;
            }
            catch (DbUpdateException /* ex */)
            {

            }

            return success;
        }

        public virtual TEntity GetRecordById(int id)
        {
            var response = DBSet.Find(id);

            return response;
        }
    }
}
