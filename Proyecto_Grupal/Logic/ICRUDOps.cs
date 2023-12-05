using System.Data;

namespace Logic
{
    public interface ICRUDOps<T> where T : class
    {
        bool Add();
        bool Delete();
        bool Delete(int id);
        bool Update();
        List<T> GetAll();

        T Map(IDataRecord record);
    }
}
