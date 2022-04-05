using MediatR;

namespace RentcarProj.BuildingBlocks.QueryBus;

public class QueryBus : IQueryBus
{
    private readonly IMediator _mediator;

    public QueryBus(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<TResponse> Send<TRequest, TResponse>(TRequest request)
        where TRequest : IQueryBase<TResponse>
        where TResponse : class
    {
        return await _mediator.Send(request);
    }
}