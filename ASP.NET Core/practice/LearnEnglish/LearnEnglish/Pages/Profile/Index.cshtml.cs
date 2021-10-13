using LearnEnglish.Database;
using LearnEnglish.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnEnglish.Pages.Profile
{
    public class IndexModel : PageModel
    {
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        private readonly ApplicationDbContext _db;

        public List<WordsDictionary> UserDictionaries { get; set; } = new List<WordsDictionary>();
        public string UserLogin { get; set; } = string.Empty;

        public IActionResult OnGet()
        {
            string cookie = Request.Cookies["Login"];
            var view = new PageResult();
            IActionResult result = view;
            if (string.IsNullOrWhiteSpace(cookie))
                result = RedirectToPage("Login");
            else
            {
                UserLogin = cookie;
                UserDictionaries = GetUserDictionaries();
            }
            return result;
        }

        public async Task<IActionResult> OnPostAsync(string dictionaryTitle)
        {
            IActionResult output = new RedirectToPageResult("Profile");
            var userLogin = GetUserLoginFromCookie();
            if (!string.IsNullOrWhiteSpace(dictionaryTitle) &&
               !string.IsNullOrWhiteSpace(userLogin))
            {
                var profile = _db.Profiles.Where(profile => profile.Login == userLogin).FirstOrDefault();
                if (profile != null)
                {
                    await _db.Dictionaries.AddAsync(new WordsDictionary() { Title = dictionaryTitle, Profile = profile });
                    await _db.SaveChangesAsync();
                }
            }
            return output;
        }

        public IActionResult ShowDictionaryOnPost(int dictionaryId)
        {
            return null;
        }

        private List<WordsDictionary> GetUserDictionaries()
        {
            var findDictionaries = new List<WordsDictionary>();
            var dictionary = _db.Dictionaries.Where(d => d.Profile.Login == UserLogin).ToList();
            if (dictionary != null)
                findDictionaries = dictionary;
            return findDictionaries;
        }

        private string GetUserLoginFromCookie()
        {
            string output = string.Empty;
            var cookieExists = Request.Cookies.TryGetValue("Login", out string login);
            if (cookieExists)
                output = login;
            return output;
        }
    }
}