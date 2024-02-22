//using FluentValidation;
//using LogisticsTrackingApp.Core.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LogisticsTrackingApp.Service.Validations
//{
//	public class AboutValidator :AbstractValidator<About>
//	{
//		public AboutValidator()
//		{
//			RuleFor(x => x.Title).NotEmpty().WithMessage("{PropertyName} is required");
//			RuleFor(x => x.Description).NotEmpty().WithMessage("{PropertyName} is required").MaximumLength(100);
//			RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("{PropertyName} is required").MaximumLength(100);

//		}

//	}
//}
