using Newtonsoft.Json;

namespace Notion.Client
{
    public class DatabaseParent : IParentOfPage, IParentOfBlock, IDatabaseParent
    {
        /// <summary>
        ///     The ID of the database that this page belongs to.
        /// </summary>
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }

        /// <summary>
        ///     Always "database_id"
        /// </summary>
        public string Type { get; set; }
    }
}
