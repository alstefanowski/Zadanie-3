using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace FizzBuzzWeb.Forms
{
	public class FizzBuzzForm
	{
        [Display(Name = "Rok", Prompt = "Wpisz Rok")]
        [Required, Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} musi być z zakresu od {1} do {2}")]
        public int? Rok { get; set; }

        [Display(Name = "Imie", AutoGenerateField = false, Prompt = "Wpisz imie")]
        [Required, StringLength(100, ErrorMessage = "Wartosc slowa nie moze przekroczyc {1} liter")]
        public string? Imie { get; set; }

    }
}
