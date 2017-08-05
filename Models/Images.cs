using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class Images
    {
        public Images()
        {
            PageContentImages = new HashSet<PageContentImages>();
        }

        public int ImageId { get; set; }
        public string Alt { get; set; }
        public string Credit { get; set; }
        public string Caption { get; set; }
        public string Thumbnail { get; set; }
        public string Slider { get; set; }
        public string Gallery { get; set; }
        public string Original { get; set; }

        public virtual ICollection<PageContentImages> PageContentImages { get; set; }
    }
}
