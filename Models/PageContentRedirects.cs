using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class PageContentRedirects
    {
        public int PageContentRedirectId { get; set; }
        public int PageContentId { get; set; }
        public string Url { get; set; }

        public virtual PageContents PageContent { get; set; }
    }
}
