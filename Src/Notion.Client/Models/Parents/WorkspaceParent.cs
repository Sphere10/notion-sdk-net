namespace Notion.Client
{
    public class WorkspaceParent : IParentOfPage, IDatabaseParent, IParentOfBlock
    {
        /// <summary>
        ///     Always "workspace".
        /// </summary>
        public string Type { get; set; }
    }
}
