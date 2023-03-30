using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.ComponentModel;

namespace FizzBuzzWeb.Pages
{
	public class ZapisaneModel : PageModel
    {
        public FizzBuzzForm FizzBuzz { get; set; }
       //public Key Message = new Key();
        
		public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if(Data != null)
            {
				Key.Msg.Add(HttpContext.Session.GetString("Data"));
			}
        }
    }
}
