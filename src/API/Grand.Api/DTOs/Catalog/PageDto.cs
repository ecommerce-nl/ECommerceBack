using Grand.Api.Models;
using System;

namespace Grand.Api.DTOs.Catalog
{
	public partial class PageDto : BaseApiEntityModel
    {
        public PageDto()
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string SystemName { get; set; }
        public string SeName { get; set; }
        public bool IncludeInSitemap { get; set; }
        public bool IncludeInMenu { get; set; }

        public bool IncludeInFooterRow1 { get; set; }
        public bool IncludeInFooterRow2 { get; set; }
        public bool IncludeInFooterRow3 { get; set; }
        public int DisplayOrder { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public bool Published { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}
