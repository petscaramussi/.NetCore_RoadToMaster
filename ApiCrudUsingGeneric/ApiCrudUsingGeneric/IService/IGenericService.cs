namespace ApiCrudUsingGeneric.IService
{
    public interface IGenericService<T>
    {
        List<T> getAll();
        T GetById(int id);
        List<T> Insert(T item);
        List<T> Delete(int id);

    }
}
