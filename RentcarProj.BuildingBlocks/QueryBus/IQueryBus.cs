namespace RentcarProj.BuildingBlocks.QueryBus;

/// <summary>
/// Шина запросов. Исполняет запросы, возвращает необходимые данные.
/// </summary>
public interface IQueryBus
{
    /// <summary>
    /// Асинхронно исполнить запрос с возвращением необходимого типа данных
    /// </summary>
    /// <param name="request">Запрос</param>
    /// <typeparam name="TResponse">Тип ожидаемого ответа</typeparam>
    /// <returns>Объект с типом ожидаемого ответа</returns>
    public Task<TResponse> Send<TResponse>(IQueryBase<TResponse> request)
        where TResponse : class;
}