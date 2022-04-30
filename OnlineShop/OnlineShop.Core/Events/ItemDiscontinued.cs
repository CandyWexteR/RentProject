namespace OnlineShop.Core.Events;
//TODO:Дополнить сущность товаров снятых с продажи.

/// <summary>
/// Событие снятия товаров с продажи.
/// </summary>
public class ItemDiscontinued:ItemStateEventBase
{
    protected ItemDiscontinued(Guid id, DateTimeOffset timestamp,Guid itemid, Guid userid) : base(id, timestamp, itemid, userid)
    {
        ///
    }
} 
