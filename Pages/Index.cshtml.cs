using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        public string gender = "_gender";
        private readonly ILogger<IndexModel> _logger;
        public string data;
        int i = 0;
        [BindProperty]
        public FizzBuzzForm FizzBuzz { get; set; }

        //public List<string> message { get; set; }
        //public Key Message = new Key();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if(FizzBuzz.Imie != null)
                {
					if (FizzBuzz.Imie[FizzBuzz.Imie.Length - 1] == 'a')
						gender = "urodziła";
					else
						gender = "urodził";
				}

                if ((FizzBuzz.Rok % 400 == 0))
                {
					HttpContext.Session.SetString("Data", FizzBuzz.Imie + ", " + FizzBuzz.Rok + " - " + "rok przystępny");
                    TempData[Constants.Komunikat_Index] = FizzBuzz.Imie + " " + gender + " się " + Convert.ToString(FizzBuzz.Rok) + "." + " To był rok przystępny";
                }
                else if (FizzBuzz.Rok % 100 == 0)
                {
					HttpContext.Session.SetString("Data", FizzBuzz.Imie + ", " + FizzBuzz.Rok + " - " + "rok nie jest przystepny");
					TempData[Constants.Komunikat_Index] = FizzBuzz.Imie + " " + gender + " się " + Convert.ToString(FizzBuzz.Rok) + " Nie jest rokiem przystępnym";
                }

                else if (FizzBuzz.Rok % 4 == 0)
                {
                    HttpContext.Session.SetString("Data", FizzBuzz.Imie + ", " + FizzBuzz.Rok + " - " + "rok przystepny");
                    TempData[Constants.Komunikat_Index] = FizzBuzz.Imie + " " + gender + " się " + Convert.ToString(FizzBuzz.Rok) + "." + " To był rok przystępny";
                }
                else
                {
					HttpContext.Session.SetString("Data", FizzBuzz.Imie + ", " + FizzBuzz.Rok + " - " + "rok nie jest przystepny");
					TempData[Constants.Komunikat_Index] = FizzBuzz.Imie + " " + gender + " się " + Convert.ToString(FizzBuzz.Rok) + "." + " Nie jest rokiem przystepnym";
                }
            }
            return Page();
        }
    }
}