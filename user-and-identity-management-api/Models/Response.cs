using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace user_and_identity_management_api.Models
{
	public class Response
	{
		public string? Status { get; set; }

		public string? Message { get; set; }
	}
}
