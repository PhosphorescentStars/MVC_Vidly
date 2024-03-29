﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255, ErrorMessage = "Length must not exceede 255 characters")]
		public string Name { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		public MembershipType MembershipType { get; set; } //Navigation property		
		public byte? MembershipTypeId { get; set; } //FK		
		public DateTime? Birthday { get; set; }
	}
}