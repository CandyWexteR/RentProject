using MediatR;

namespace RentcarProj.BuildingBlocks.QueryBus;

public interface IQueryHandlerBase<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQueryBase<TResponse>
    where TResponse : class
{
}