namespace RentcarProj.BuildingBlocks.CommandBus;

/// <summary>
/// Шина команд. Асинхронно отправляет на исполнение посредником команды.
/// </summary>
public interface ICommandBus
{
    /// <summary>
    /// Отправить команду асинхронно
    /// </summary>
    /// <param name="command">Команда</param>
    public Task SendAsync(ICommandBase command);
}