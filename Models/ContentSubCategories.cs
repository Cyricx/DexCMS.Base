using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class ContentSubCategories
    {
        public ContentSubCategories()
        {
            PageContents = new HashSet<PageContents>();
        }

        public int ContentSubCategoryId { get; set; }
        public string Name { get; set; }
        public string UrlSegment { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageContents> PageContents { get; set; }
    }
}
