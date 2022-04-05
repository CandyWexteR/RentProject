using MediatR;

namespace RentcarProj.BuildingBlocks.CommandBus;

/// <inheritdoc/>
public class CommandBus:ICommandBus
{
    private readonly IMediator _mediator;

    public CommandBus(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <inheritdoc/>
    public async Task SendAsync(ICommandBase command)
    {
        await _mediator.Send(command);
    }
}