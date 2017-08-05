using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class PageTypes
    {
        public PageTypes()
        {
            PageContents = new HashSet<PageContents>();
        }

        public int PageTypeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageContents> PageContents { get; set; }
    }
}
