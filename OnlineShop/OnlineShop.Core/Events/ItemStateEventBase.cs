namespace OnlineShop.Core.Events;
//TODO:дополнить сущность.

/// <summary>
/// Класс описывающий базовое событие изменения состояния продаваемого предмета.
/// </summary>
public class ItemStateEventBase:BaseEvent
{
    public Guid Itemid { get; set; }
    public Guid Userid { get; set; }

    protected ItemStateEventBase(Guid id, DateTimeOffset timestamp,Guid itemid, Guid userid) : base(id, timestamp)

        {
        Itemid = itemid;
        Userid = userid;
    }
}