// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmEntityContainerSchemaElementKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmEntityContainerSchemaElementKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "TypeDefinition")]
        TypeDefinition,
        [EnumMember(Value = "Term")]
        Term,
        [EnumMember(Value = "Action")]
        Action,
        [EnumMember(Value = "EntityContainer")]
        EntityContainer,
        [EnumMember(Value = "Function")]
        Function
    }
    internal static class IEdmEntityContainerSchemaElementKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmEntityContainerSchemaElementKind? value)
        {
            return value == null ? null : ((IEdmEntityContainerSchemaElementKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmEntityContainerSchemaElementKind value)
        {
            switch( value )
            {
                case IEdmEntityContainerSchemaElementKind.None:
                    return "None";
                case IEdmEntityContainerSchemaElementKind.TypeDefinition:
                    return "TypeDefinition";
                case IEdmEntityContainerSchemaElementKind.Term:
                    return "Term";
                case IEdmEntityContainerSchemaElementKind.Action:
                    return "Action";
                case IEdmEntityContainerSchemaElementKind.EntityContainer:
                    return "EntityContainer";
                case IEdmEntityContainerSchemaElementKind.Function:
                    return "Function";
            }
            return null;
        }

        internal static IEdmEntityContainerSchemaElementKind? ParseIEdmEntityContainerSchemaElementKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmEntityContainerSchemaElementKind.None;
                case "TypeDefinition":
                    return IEdmEntityContainerSchemaElementKind.TypeDefinition;
                case "Term":
                    return IEdmEntityContainerSchemaElementKind.Term;
                case "Action":
                    return IEdmEntityContainerSchemaElementKind.Action;
                case "EntityContainer":
                    return IEdmEntityContainerSchemaElementKind.EntityContainer;
                case "Function":
                    return IEdmEntityContainerSchemaElementKind.Function;
            }
            return null;
        }
    }
}
