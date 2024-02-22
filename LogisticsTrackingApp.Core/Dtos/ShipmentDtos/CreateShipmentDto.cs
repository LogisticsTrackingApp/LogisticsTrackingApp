using LogisticsTrackingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Dtos.ShipmentDtos
{
	public class CreateShipmentDto :BaseDto
	{
      
        public string TrackingNumber { get; set; }

		public DateTime DeliverDate { get; set; }
		public string Status { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public int StationId { get; set; }
		public Station Station { get; set; }
	}
}
