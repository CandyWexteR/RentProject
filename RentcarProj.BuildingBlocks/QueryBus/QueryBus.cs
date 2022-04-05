using MediatR;

namespace RentcarProj.BuildingBlocks.QueryBus;

/// <inheritdoc/>
public class QueryBus : IQueryBus
{
    private readonly IMediator _mediator;

    public QueryBus(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <inheritdoc/>
    public async Task<TResponse> Send<TRequest, TResponse>(TRequest request)
        where TRequest : IQueryBase<TResponse>
        where TResponse : class
    {
        return await _mediator.Send(request);
    }
}