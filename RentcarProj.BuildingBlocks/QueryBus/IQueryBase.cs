using MediatR;

namespace RentcarProj.BuildingBlocks.QueryBus;

/// <summary>
/// Базовый запрос. Содержит информацию о запросе(пагинация, фильтры, идентификаторы сущностей).
/// </summary>
/// <typeparam name="TResponse">Тип ответа на команду</typeparam>
public interface IQueryBase<TResponse>:IRequest<TResponse> where TResponse:class
{
}