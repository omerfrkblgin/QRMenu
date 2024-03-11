﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace QRMenu.Models
{
	public class Food
	{
		public int Id { get; set; }

		[StringLength(100, MinimumLength = 3 )]
		[Column(TypeName = "nvarchar(100)")]
		public string Name { get; set; } = "";

		[Range(0,float.MaxValue)]
		public float Price { get; set; }

		[Column(TypeName = "nvarchar(200)")]
		public string? Description { get; set; }

		public byte StateId { get; set; }
		[ForeignKey("StateId")]
		public State? State { get; set; }

		public int CategoryId { get; set; }
		[ForeignKey(nameof(CategoryId))]
		public Category? Category { get; set; }
    }
}

