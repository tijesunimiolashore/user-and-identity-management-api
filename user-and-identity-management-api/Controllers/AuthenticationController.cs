using System.Data;
using System.Numerics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using user_and_identity_management_api.Models;
using user_and_identity_management_api.Models.Authentication.SignUp;

namespace user_and_identity_management_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class AuthenticationController : ControllerBase {

		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IConfiguration _configuration;

		public AuthenticationController(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			IConfiguration configuration)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_configuration = configuration;
		}

		[HttpPost]
		public async Task<IActionResult> Register([FromBody] RegisterUser registerUser, string rule)
		{

			//1 Check User Exists
			var userExist = await _userManager.FindByEmailAsync(registerUser.Email);
			if (userExist != null)
			{
				return StatusCode(StatusCodes.Status403Forbidden,
					new Response { Status = "Error", Message = "User already exists!" });
			}

			// 2. Create User Object
			IdentityUser user = new()
			{
				Email = registerUser.Email,
				SecurityStamp = Guid.NewGuid().ToString(),
				UserName = registerUser.Username
			};

			// 3. Add User to Database
			if (await _roleManager.RoleExistsAsync(rule))
			{

				var result = await _userManager.CreateAsync(user, registerUser.Password);
				if (!result.Succeeded)
				{
					return StatusCode(StatusCodes.Status201Created,
						new Response { Status = "Success", Message = "User Failed to Create!" });
				}

				//Add role to the user
				await _userManager.AddToRoleAsync(user, rule);
				return StatusCode(StatusCodes.Status201Created,
						new Response { Status = "Success", Message = "User Created Successfully!" });
			}
			else
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
					new Response { Status = "Error", Message = "This Rule does not Exist!" });
			}
		}
	}
}
