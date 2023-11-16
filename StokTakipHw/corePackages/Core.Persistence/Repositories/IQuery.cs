namespace Core.Persistence.Repositories;
internal interface IQuery<T>
{
    IQueryable<T> Query();
}
