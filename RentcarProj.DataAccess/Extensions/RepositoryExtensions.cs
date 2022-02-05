using RentcarProj.DataAccess.Repositories;

namespace RentcarProj.DataAccess.Extensions;

public static class RepositoryExtensions
{
    //TODO: Добавить фильтры
    
    /// <summary>
    /// Получить страницу записей типа T
    /// </summary>
    /// <param name="repository">текущий репозиторий(не указывается)</param>
    /// <param name="pageNumber">Номер страницы</param>
    /// <param name="pageSize">Количество элементов на странице</param>
    /// <typeparam name="T">Шаблонный тип</typeparam>
    /// <returns></returns>
    /// <exception cref="Exception">Исключение, воз</exception>
    public static async Task<List<T>> GetPageList<T>(this IRepository<T> repository, int pageNumber, int pageSize)
    {
        if (pageNumber < 0)
            throw new Exception("Номер страницы не может быть меньше нуля");
        
        if (pageSize < 0)
            throw new Exception("Размер страницы не может быть меньше нуля");

        var skip = (-1 + pageNumber) * pageSize;
        
        return (await repository.GetAllAsNoTracking()).Skip(skip).Take(pageSize).ToList();
    }
}