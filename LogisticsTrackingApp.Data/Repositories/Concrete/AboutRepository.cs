﻿using LogisticsTrackingApp.Core.Models;
using LogisticsTrackingApp.Data.Context;
using LogisticsTrackingApp.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Data.Repositories.Concrete
{
	public class AboutRepository : GenericRepository<About>, IAboutRepository
	{
		public AboutRepository(LogisticsDbContext dbContext) : base(dbContext)
		{
		}
	}
}
