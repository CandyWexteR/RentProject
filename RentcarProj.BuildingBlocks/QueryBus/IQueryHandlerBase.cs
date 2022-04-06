using MediatR;

namespace RentcarProj.BuildingBlocks.QueryBus;

/// <summary>
/// Базовый обработчик запроса
/// </summary>
/// <typeparam name="TRequest">Тип запроса</typeparam>
/// <typeparam name="TResponse">Тип ожидаемого ответа</typeparam>
public interface IQueryHandlerBase<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQueryBase<TResponse>
    where TResponse : class
{
}