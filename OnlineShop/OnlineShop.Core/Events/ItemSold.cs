namespace OnlineShop.Core.Events;

//TODO:Дополнить сущность продажи товаров.

/// <summary>
/// Событие продажи товаров.
/// </summary>
public class ItemSold : ItemStateEventBase
{
    protected ItemSold(Guid id, DateTimeOffset timestamp,Guid itemid, Guid userid) : base(id, timestamp, itemid, userid)
    {
        ///
    }
}