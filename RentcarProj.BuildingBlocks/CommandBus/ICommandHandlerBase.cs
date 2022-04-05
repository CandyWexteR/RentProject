using MediatR;

namespace RentcarProj.BuildingBlocks.CommandBus;

/// <summary>
/// Интерфейс базового обработчика команд.
/// </summary>
/// <typeparam name="T">Тип команды, которую необходимо обработать</typeparam>
public interface ICommandHandlerBase<T>:IRequestHandler<T> where T:ICommandBase
{
}