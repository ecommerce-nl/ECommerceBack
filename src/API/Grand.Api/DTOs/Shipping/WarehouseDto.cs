using Grand.Api.DTOs.Customers;
using Grand.Api.Models;
using Grand.Domain.Common;

namespace Grand.Api.DTOs.Shipping
{
    public partial class WarehouseDto : BaseApiEntityModel
    {
        public WarehouseDto()
        {
            Address = new AddressDto();
        }
        /// <summary>
        /// Gets or sets the warehouse name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the GeoCoordinate.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the GeoCoordinate.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the address identifier of the warehouse
        /// </summary>
        public AddressDto Address { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
