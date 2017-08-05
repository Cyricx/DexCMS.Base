using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class LayoutTypes
    {
        public LayoutTypes()
        {
            PageContents = new HashSet<PageContents>();
        }

        public int LayoutTypeId { get; set; }
        public string Name { get; set; }
        public string CssClass { get; set; }
        public string ExampleImage { get; set; }

        public virtual ICollection<PageContents> PageContents { get; set; }
    }
}
