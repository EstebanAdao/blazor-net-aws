using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AWS_Blazor.Data
{
	public class WebMotorsService
	{
		HttpClient client = new HttpClient();
		public async Task<List<Category>> GetCategoriesAsync()
		{
			HttpResponseMessage response = await client.GetAsync("https://hportal.webmotors.com.br/api/category");

			if (response.IsSuccessStatusCode)
			{
				var contentRead = await response.Content.ReadAsStringAsync();
				var categories = JsonConvert.DeserializeObject<List<Category>>(contentRead);
				return categories;
			}
			return null;
		}

		public async Task<Search> GetSearchAsync(string marca, string modelo)
		{
			var path = $"https://hportal.webmotors.com.br/api/search/car?url=https://hportal.webmotors.com.br/carros%2Fsp%2F{marca}%2Fa10%3Festadocidade%3DS%25C3%25A3o%2520Paulo%26marca1%3D{marca}%26modelo1%3D{modelo}&actualPage=1&displayPerPage=24&order=1&showMenu=true&showCount=true&showBreadCrumb=true&testAB=false&returnUrl=false&showResult=true";

			HttpResponseMessage response = await client.GetAsync(path);

			if (response.IsSuccessStatusCode)
			{
				var contentRead = await response.Content.ReadAsStringAsync();
				var searchResult = JsonConvert.DeserializeObject<Search>(contentRead);
				return searchResult;
			}
			return null;
		}
	}
}
