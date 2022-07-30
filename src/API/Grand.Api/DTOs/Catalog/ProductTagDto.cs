using Grand.Api.Models;

namespace Grand.Api.DTOs.Catalog
{
	public partial class ProductTagDto : BaseApiEntityModel
    {
        public string Name { get; set; }
        public string SeName { get; set; }
        public int Count { get; set; }
    }
}
