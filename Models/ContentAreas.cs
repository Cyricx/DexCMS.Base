using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class ContentAreas
    {
        public ContentAreas()
        {
            PageContents = new HashSet<PageContents>();
        }

        public int ContentAreaId { get; set; }
        public string Name { get; set; }
        public string UrlSegment { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageContents> PageContents { get; set; }
    }
}
