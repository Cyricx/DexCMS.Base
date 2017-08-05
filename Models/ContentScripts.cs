using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class ContentScripts
    {
        public int ContentScriptId { get; set; }
        public int PageContentId { get; set; }
        public string Path { get; set; }

        public virtual PageContents PageContent { get; set; }
    }
}
