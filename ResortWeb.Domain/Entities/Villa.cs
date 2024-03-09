﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortWeb.Domain.Entities
{
	public class Villa
	{
		[Key]
		public int Id { get; set; }
		public required string Name { get; set; }
		public string? Description { get; set; }
		public double Price { get; set; }
		public int Sqft { get; set; }
		public int Occupancy { get; set; }
		public string? ImageUrl { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}
