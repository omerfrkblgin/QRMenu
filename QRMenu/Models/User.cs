using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRMenu.Models
{
	public class User
	{
		public int Id { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[StringLength(100,MinimumLength =5)]
		public string Username { get; set; } = "";

		[Column(TypeName = "nvarchar(128)")]
		[StringLength(128,MinimumLength =8)]
		public string Password { get; set; } = "";

		[Column(TypeName = "nvarchar(100)")]
		[StringLength(100,MinimumLength =3)]
		public string Name { get; set; } = "";

		[EmailAddress]
		[Column(TypeName = "varchar(100)")]
		public string Email { get; set; } = "";

		public byte StateId { get; set; }
		[ForeignKey(nameof(StateId))]
		public State? State { get; set; }

		public int CompanyId { get; set; }
		[ForeignKey(nameof(CompanyId))]
		public Company? Company { get; set; }

		public virtual List<Restaurant>? Restaurants { get; set; }
	}
}

