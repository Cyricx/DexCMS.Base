using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class VisitedPages
    {
        public int VisitedPageId { get; set; }
        public string Url { get; set; }
        public int VisitOrder { get; set; }
        public int ContactId { get; set; }

        public virtual Contacts Contact { get; set; }
    }
}
