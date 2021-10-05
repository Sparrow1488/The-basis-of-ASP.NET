using LearnEnglish.Database;
using LearnEnglish.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearnEnglish.Pages
{
    public class SignupModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public SignupModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnPostAsync(string email, string login, string password)
        {
            IActionResult actionResult = new PageResult();
            var profile = new Profile
            {
                Login = login,
                Email = email,
                Password = password
            };
            await _db.Profiles.AddAsync(profile);
            await _db.SaveChangesAsync();
            Response.Cookies.Append("Login", login);
            actionResult = new RedirectToPageResult("Profile");
            return actionResult;
        }
    }
}