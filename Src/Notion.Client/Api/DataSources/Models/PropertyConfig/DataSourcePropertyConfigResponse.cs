using System.Collections.Generic;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(CheckboxDataSourcePropertyConfigResponse), DataSourcePropertyType.Checkbox)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(CreatedByDataSourcePropertyConfigResponse), DataSourcePropertyType.CreatedBy)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(CreatedTimeDataSourcePropertyConfigResponse), DataSourcePropertyType.CreatedTime)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DateDataSourcePropertyConfigResponse), DataSourcePropertyType.Date)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(EmailDataSourcePropertyConfigResponse), DataSourcePropertyType.Email)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(FilesDataSourcePropertyConfigResponse), DataSourcePropertyType.Files)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(FormulaDataSourcePropertyConfigResponse), DataSourcePropertyType.Formula)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(LastEditedByDataSourcePropertyConfigResponse), DataSourcePropertyType.LastEditedBy)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(LastEditedTimeDataSourcePropertyConfigResponse), DataSourcePropertyType.LastEditedTime)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(MultiSelectDataSourcePropertyConfigResponse), DataSourcePropertyType.MultiSelect)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(NumberDataSourcePropertyConfigResponse), DataSourcePropertyType.Number)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(PeopleDataSourcePropertyConfigResponse), DataSourcePropertyType.People)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(PhoneNumberDataSourcePropertyConfigResponse), DataSourcePropertyType.PhoneNumber)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(RelationDataSourcePropertyConfigResponse), DataSourcePropertyType.Relation)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(RichTextDataSourcePropertyConfigResponse), DataSourcePropertyType.RichText)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(RollupDataSourcePropertyConfigResponse), DataSourcePropertyType.Rollup)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(SelectDataSourcePropertyConfigResponse), DataSourcePropertyType.Select)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(StatusDataSourcePropertyConfigResponse), DataSourcePropertyType.Status)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(TitleDataSourcePropertyConfigResponse), DataSourcePropertyType.Title)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(UrlDataSourcePropertyConfigResponse), DataSourcePropertyType.Url)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(UniqueIdDataSourcePropertyConfigResponse), DataSourcePropertyType.UniqueId)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(ButtonDataSourcePropertyConfigResponse), DataSourcePropertyType.Button)]
    public class DataSourcePropertyConfigResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
