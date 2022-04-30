using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace OnlineShop.Core;
//TODO:дополнить сущность.
/// <summary>
/// Класс описывающий базовое событие.
/// </summary>
public class BaseEvent
{
    public Guid Id { get; set; }
    public DateTimeOffset Timestamp { get; set; }

    protected BaseEvent(Guid id, DateTimeOffset timestamp)
    {
         Id = id;
         Timestamp = timestamp;
    }
}