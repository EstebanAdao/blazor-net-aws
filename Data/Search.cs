using System.Collections.Generic;

namespace AWS_Blazor.Data
{
	public class Search
	{
		public List<Advertise> SearchResults { get; set; }
	}

	public class Advertise
	{

		public long UniqueId { get; set; }

		public VehicleAdvertMedia Media { get; set; }

		public string PhotoPath { get; set; }

		public VehicleAdvertSpecification Specification { get; set; }

		public VehicleAdvertSeller Seller { get; set; }

		public VehicleAdvertPrices Prices { get; set; }

		public List<GenericModel> HotDeal { get; set; }

		public string ListingType { get; set; }

		public string ProductCode { get; set; }

		public List<VehicleAdvertSpecificationItem> Channels { get; set; }

		public string LongComment { get; set; }

	}
	public class VehicleAdvertMedia
	{

		public List<VehicleAdvertMediaPhotosPhoto> Photos { get; set; }

		public List<VehicleAdvertMediaVideosVideo> Videos { get; set; }
	}

	public class VehicleAdvertMediaVideosVideo
	{

		public string VideoPath { get; set; }
	}

	public class VehicleAdvertMediaPhotosPhoto
	{

		public string PhotoPath { get; set; }

		public uint Order { get; set; }
	}

	public class VehicleAdvertSpecification
	{

		public string Title { get; set; }

		public VehicleAdvertSpecificationItem Make { get; set; }

		public VehicleAdvertSpecificationItem Model { get; set; }

		public VehicleAdvertSpecificationItem Version { get; set; }

		public string YearFabrication { get; set; }

		public double? YearModel { get; set; }

		public double? Odometer { get; set; }

		public string Transmission { get; set; }

		public string NumberPorts { get; set; }

		public double? CubicCentimeter { get; set; }

		public string BodyType { get; set; }

		public List<VehicleAdvertVehicleAttributes> VehicleAttributes { get; set; }

		public string Armored { get; set; }

		public GenericModel Engine { get; set; }

		public GenericModel Break { get; set; }

		public GenericModel Charge { get; set; }

		public GenericModel Cooling { get; set; }

		public GenericModel Shift { get; set; }

		public GenericModel Starter { get; set; }

		public VehicleAdvertSpecificationColor Color { get; set; }
	}

	public class VehicleAdvertSpecificationItem
	{

		public uint id { get; set; }

		public string Value { get; set; }
	}

	public class VehicleAdvertSpecificationColor
	{

		public string IdPrimary { get; set; }

		public string Primary { get; set; }

		public string IdSecundary { get; set; }

		public string Secundary { get; set; }
	}

	public class VehicleAdvertSeller
	{

		public int Id { get; set; }

		public string SellerType { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public VehicleAdvertSellerAdType AdType { get; set; }

		public int BudgetInvestimento { get; set; }

		public int DealerScore { get; set; }
	}

	public class VehicleAdvertPrices
	{

		public double? OldPrice { get; set; }

		public double? Price { get; set; }

		public double? SearchPrice { get; set; }
	}

	public class VehicleAdvertSellerAdType
	{

		public uint id { get; set; }

		public string Value { get; set; }
	}

	public class GenericModel
	{

		public string Id { get; set; }

		public string Value { get; set; }
	}
	public class VehicleAdvertVehicleAttributes
	{

		public string Name { get; set; }
	}


	public class VehicleAdvertCertifiedVehicle
	{

		public string Id { get; set; }


		public string MakerCode { get; set; }


		public string SealName { get; set; }


		public string SealDescription { get; set; }


		public string SealFileName { get; set; }
	}
}
