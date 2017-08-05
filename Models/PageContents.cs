using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class PageContents
    {
        public PageContents()
        {
            ContentBlocks = new HashSet<ContentBlocks>();
            ContentScripts = new HashSet<ContentScripts>();
            ContentStyles = new HashSet<ContentStyles>();
            PageContentImages = new HashSet<PageContentImages>();
            PageContentPermissions = new HashSet<PageContentPermissions>();
            PageContentRedirects = new HashSet<PageContentRedirects>();
        }

        public int PageContentId { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public int ContentAreaId { get; set; }
        public int? ContentCategoryId { get; set; }
        public int? ContentSubCategoryId { get; set; }
        public string UrlSegment { get; set; }
        public string Body { get; set; }
        public int? MaximumImages { get; set; }
        public int ChangeFrequency { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public double? Priority { get; set; }
        public bool AddToSitemap { get; set; }
        public int? LayoutTypeId { get; set; }
        public bool IsDisabled { get; set; }
        public bool RequiresLogin { get; set; }
        public int PageTypeId { get; set; }

        public virtual ICollection<ContentBlocks> ContentBlocks { get; set; }
        public virtual ICollection<ContentScripts> ContentScripts { get; set; }
        public virtual ICollection<ContentStyles> ContentStyles { get; set; }
        public virtual Events Events { get; set; }
        public virtual ICollection<PageContentImages> PageContentImages { get; set; }
        public virtual ICollection<PageContentPermissions> PageContentPermissions { get; set; }
        public virtual ICollection<PageContentRedirects> PageContentRedirects { get; set; }
        public virtual ContentAreas ContentArea { get; set; }
        public virtual ContentCategories ContentCategory { get; set; }
        public virtual ContentSubCategories ContentSubCategory { get; set; }
        public virtual LayoutTypes LayoutType { get; set; }
        public virtual PageTypes PageType { get; set; }
    }
}
