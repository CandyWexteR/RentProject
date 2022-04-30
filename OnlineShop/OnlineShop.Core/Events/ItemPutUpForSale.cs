namespace OnlineShop.Core.Events;
//TODO:Дополнить сущность объектов выставленных на продажу.

/// <summary>
/// Событие выставления товаров на продажу.
/// </summary>
public class ItemPutUpForSale:ItemStateEventBase
{
    protected ItemPutUpForSale(Guid id, DateTimeOffset timestamp,Guid itemid, Guid userid) : base(id, timestamp, itemid, userid)
    {
        ///
    }
}