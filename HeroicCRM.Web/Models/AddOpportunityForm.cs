using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Heroic.AutoMapper;
using HeroicCRM.Web.Core;

namespace HeroicCRM.Web.Models
{
	public class AddOpportunityForm : IMapTo<Opportunity>
	{
		[HiddenInput]
		public int CustomerId { get; set; }

		[Required]
		public string Title { get; set; }

		[DataType(DataType.MultilineText)]
		public string Description { get; set; }
	}
}