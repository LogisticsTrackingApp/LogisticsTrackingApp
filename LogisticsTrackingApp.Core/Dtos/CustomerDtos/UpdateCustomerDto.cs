﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Dtos.CustomerDtos
{
	public class UpdateCustomerDto
	{
        public int Id { get; set; }
        public int FullName { get; set; }
		public string City { get; set; }
	}
}
