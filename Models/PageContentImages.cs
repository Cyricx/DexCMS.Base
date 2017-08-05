using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class PageContentImages
    {
        public int PageContentId { get; set; }
        public int ImageId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Images Image { get; set; }
        public virtual PageContents PageContent { get; set; }
    }
}
