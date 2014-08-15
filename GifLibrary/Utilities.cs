using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;



namespace GifLibrary
{
	public class Utilities
	{
		public Utilities ()
		{
		}
	    
		public void a(){


		}



		public static async Task<RootObject> GetGifList()
		{
			String GIPHY_URL = "http://api.giphy.com/v1/gifs/search?q=funny+cat&api_key=dc6zaTOxFJmzC";

			var client = new HttpClient();
			var msg = await client.GetAsync(GIPHY_URL);
			if (msg.IsSuccessStatusCode)
			{
				using (var stream = await msg.Content.ReadAsStreamAsync())
				{
					using (var streamReader = new StreamReader(stream))
					{
						var str = await streamReader.ReadToEndAsync();
						//var obj = await JsonConvert.DeserializeObjectAsync<RootObject>(str);
						var obj = await 
							Task.Factory.StartNew(() => JsonConvert.DeserializeObject<RootObject>(str));
						return obj;
					}
				}
			}
			return null;

		}




	}
}

