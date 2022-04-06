using MediatR;

namespace RentcarProj.BuildingBlocks.CommandBus;

/// <summary>
/// Базовая команда. Исполняется посредником - шиной команд <see cref="ICommandBus"/>
/// </summary>
public interface ICommandBase:IRequest
{
}