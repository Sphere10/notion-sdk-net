using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PagesCreateParameters : IPagesCreateBodyParameters, IPagesCreateQueryParameters
    {
        public IParentOfPageRequest Parent { get; set; }

        public IDictionary<string, PropertyValue> Properties { get; set; }

        public IList<IBlock> Children { get; set; }

        public IPageIcon Icon { get; set; }

        public FileObject Cover { get; set; }
    }
}
