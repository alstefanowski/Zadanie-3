namespace FizzBuzzWeb.Pages
{
	public class Key
	{
		public static List<string> Msg = new List<string>();

		public IEnumerator<string> GetEnumerator()
		{
			return Key.Msg.GetEnumerator();
		}
	}
}
