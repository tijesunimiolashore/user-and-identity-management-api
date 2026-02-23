using System.ComponentModel.DataAnnotations;

namespace user_and_identity_management_api.Models.Authentication.SignUp
{
	public class RegisterUser
	{
		[Required(ErrorMessage = "User Name is required")]
		public required string Username { get; set; }

		[EmailAddress]
		[Required(ErrorMessage = "Email is required")]
		public required string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public required string Password { get; set; }
	}
}
