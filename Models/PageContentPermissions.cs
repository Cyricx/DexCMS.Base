using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class PageContentPermissions
    {
        public int PageContentId { get; set; }
        public string Id { get; set; }

        public virtual PageContents PageContent { get; set; }
    }
}
