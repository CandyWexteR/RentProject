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
    /// <typeparam name="TRequest">Тип запроса</typeparam>
    /// <typeparam name="TResponse">Тип ожидаемого ответа</typeparam>
    /// <returns>Объект с типом ожидаемого ответа</returns>
    public Task<TResponse> Send<TRequest, TResponse>(TRequest request)
        where TRequest : IQueryBase<TResponse>
        where TResponse : class;
}