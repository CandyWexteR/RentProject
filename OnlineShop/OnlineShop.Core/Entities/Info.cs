using OnlineShop.Core.Configurations;

namespace OnlineShop.Core.Entities;

public class Info
{
    private List<Field> _fields;

    protected Info(List<Field> fields)
    {
        _fields = fields;
    }

    public IReadOnlyList<Field> Fields
    {
        get => _fields;
        protected set
        {
            _fields = new List<Field>();
            _fields.AddRange(value);
        }
    }

    public static Info Create(InfoConfiguration configuration, Dictionary<string, string> fieldValues)
    {
        //TODO: Exception на свой тип
        var exceptions = new List<Exception>();

        var selectedFieldNames = fieldValues.Keys.Select(f => f);

        //Выборка обязательных полей, не вошедших в словарь
        var requiredFieldsWithoutValue =
            configuration.Fields
                .Where(f => f.IsRequired && !selectedFieldNames.Contains(f.Name) && f.DefaultValue == null).ToArray();
        if (requiredFieldsWithoutValue.Any())
        {
            foreach (var item in requiredFieldsWithoutValue)
            {
                exceptions.Add(new Exception("В переданном списке не содержится"));
            }
        }

        if (exceptions.Any())
            throw new AggregateException(exceptions);

        var fieldsList = new List<Field>();

        foreach (var fieldConfiguration in configuration.Fields)
        {
            var field = new Field()
            {
                Name = fieldConfiguration.Name,
                Value = fieldConfiguration.DefaultValue ?? throw new Exception("Попытка установки NULL-значения")
            };

            if (fieldValues.ContainsKey(fieldConfiguration.Name))
                field.Value = fieldValues[fieldConfiguration.Name];
            
            fieldsList.Add(field);
        }

        return new Info(fieldsList);
    }
}