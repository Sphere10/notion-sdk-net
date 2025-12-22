namespace Notion.Client
{
    public class WorkspaceParent : IPageParent, IDatabaseParent, IParentOfBlock
    {
        /// <summary>
        ///     Always "workspace".
        /// </summary>
        public string Type { get; set; }
    }
}
