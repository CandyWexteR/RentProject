using Newtonsoft.Json.Linq;
using NJsonSchema.Converters;

namespace OnlineShop.Application.JsonConverters;

public class InheritanceConverter:JsonInheritanceConverter
{
    public InheritanceConverter(Type baseType, string discriminatorPropertyName):base(baseType, discriminatorPropertyName)
    {
    }
    
    protected override Type GetDiscriminatorType(JObject jObject, Type objectType, string discriminatorValue)
    {
        return objectType.Assembly.GetTypes()
            .FirstOrDefault(f => f.Name == discriminatorValue && f.IsSubclassOf(objectType)) 
               ?? base.GetDiscriminatorType(jObject, objectType, discriminatorValue);
    }
}