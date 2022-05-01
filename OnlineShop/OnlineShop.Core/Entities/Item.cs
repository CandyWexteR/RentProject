using OnlineShop.Core.Configurations;

namespace OnlineShop.Core.Entities;

public class Item
{
    protected Item(Guid id, ItemCategories category, Info info)
    {
        Id = id;
        Category = category;
        Info = info;
    }

    public Guid Id { get; protected set; }
    public ItemCategories Category { get; protected set; }
    public Info Info { get; protected set; }

    public static Item Create(Guid id, ItemCategories category, InfoConfiguration infoConfiguration, Dictionary<string,string> fieldValues)
    {
        var info = Info.Create(infoConfiguration, fieldValues);

        if (!Enum.IsDefined(typeof(ItemCategories), category))
            throw new Exception("Несуществующая категория");

        if (id == Guid.Empty)
            throw new Exception("Идентификатор не может быть пустым");
        
        return new Item(id, category, info);
    }
}