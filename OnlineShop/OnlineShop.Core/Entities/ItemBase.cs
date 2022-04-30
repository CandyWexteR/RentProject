namespace OnlineShop.Core.Entities;

public class ItemBase
{
    protected ItemBase(Guid id, ItemCategories category, Info info)
    {
        Id = id;
        Category = category;
        Info = info;
    }

    public Guid Id { get; set; }
    public ItemCategories Category { get; set; }
    public Info Info { get; set; }

    public static ItemBase Create(Guid id, ItemCategories category, Info info)
    {
        return new ItemBase(id, category, info);
    }

}