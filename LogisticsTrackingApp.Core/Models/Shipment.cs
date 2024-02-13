using LogisticsTrackingApp.Core.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Models
{
	public class Shipment :BaseEntity
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
