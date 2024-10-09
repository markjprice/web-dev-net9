using Microsoft.AspNetCore.Identity; // To use RoleManager, UserManager.
using Microsoft.AspNetCore.Mvc; // To use Controller, IActionResult.

namespace Northwind.Mvc.Controllers;

public class RolesController : Controller
{
  private string AdminRole = "Administrators";
  private string UserEmail = "test@example.com";
  private readonly RoleManager<IdentityRole> _roleManager;
  private readonly UserManager<IdentityUser> _userManager;
  private readonly ILogger<HomeController> _logger;

  public RolesController(ILogger<HomeController> logger, 
    RoleManager<IdentityRole> roleManager,
    UserManager<IdentityUser> userManager)
  {
    _logger = logger;
    _roleManager = roleManager;
    _userManager = userManager;
  }

  public async Task<IActionResult> Index()
  {
    if (!(await _roleManager.RoleExistsAsync(AdminRole)))
    {
      await _roleManager.CreateAsync(new IdentityRole(AdminRole));
    }
    IdentityUser? user = await _userManager.FindByEmailAsync(UserEmail);

    if (user == null)
    {
      user = new();
      user.UserName = UserEmail;
      user.Email = UserEmail;

      IdentityResult result = await _userManager.CreateAsync(
        user, "Pa$$w0rd");

      if (result.Succeeded)
      {
        _logger.LogInformation($"User {user.UserName} created successfully.");
      }
      else
      {
        foreach (IdentityError error in result.Errors)
        {
          _logger.LogError(error.Description);
        }
      }
    }

    if (!user.EmailConfirmed)
    {
      string token = await _userManager
        .GenerateEmailConfirmationTokenAsync(user);

      IdentityResult result = await _userManager
        .ConfirmEmailAsync(user, token);

      if (result.Succeeded)
      {
        _logger.LogInformation($"User {user.UserName} email confirmed successfully.");
      }
      else
      {
        foreach (IdentityError error in result.Errors)
        {
          _logger.LogError(error.Description);
        }
      }
    }

    if (!(await _userManager.IsInRoleAsync(user, AdminRole)))
    {
      IdentityResult result = await _userManager
        .AddToRoleAsync(user, AdminRole);

      if (result.Succeeded)
      {
        _logger.LogInformation($"User {user.UserName} added to {AdminRole} successfully.");
      }
      else
      {
        foreach (IdentityError error in result.Errors)
        {
          _logger.LogError(error.Description);
        }
      }
    }
    return Redirect("/");
  }
}
