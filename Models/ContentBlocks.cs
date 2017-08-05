using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class ContentBlocks
    {
        public int ContentBlockId { get; set; }
        public string BlockTitle { get; set; }
        public bool ShowTitle { get; set; }
        public string BlockBody { get; set; }
        public int PageContentId { get; set; }
        public string CssClass { get; set; }
        public int DisplayOrder { get; set; }

        public virtual PageContents PageContent { get; set; }
    }
}
