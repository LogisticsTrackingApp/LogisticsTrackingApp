using LogisticsTrackingApp.Core.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Models
{
	public  class Customer :BaseEntity
	{
        public int FullName { get; set; }
		public string City { get; set; }
	

		public ICollection<Shipment> Shipments { get; set; }

	}
}
