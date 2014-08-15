using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GifLibrary
{
	public class Gif
	{
		public String type { get; set; }
		public String id { get; set; }
		public String url { get; set; }
	}

	public class FixedHeight
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
		public string mp4 { get; set; }
	}

	public class FixedHeightStill
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
	}

	public class FixedHeightDownsampled
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
	}

	public class FixedWidth
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
		public string mp4 { get; set; }
	}

	public class FixedWidthStill
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
	}

	public class FixedWidthDownsampled
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
	}

	public class Original
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
		public string size { get; set; }
		public string frames { get; set; }
		public string mp4 { get; set; }
	}

	public class OriginalStill
	{
		public string url { get; set; }
		public string width { get; set; }
		public string height { get; set; }
	}

	public class Images
	{
		public FixedHeight fixed_height { get; set; }
		public FixedHeightStill fixed_height_still { get; set; }
		public FixedHeightDownsampled fixed_height_downsampled { get; set; }
		public FixedWidth fixed_width { get; set; }
		public FixedWidthStill fixed_width_still { get; set; }
		public FixedWidthDownsampled fixed_width_downsampled { get; set; }
		public Original original { get; set; }
		public OriginalStill original_still { get; set; }
	}

	public class Datum
	{
		public string type { get; set; }
		public string id { get; set; }
		public string url { get; set; }
		public string bitly_gif_url { get; set; }
		public string bitly_url { get; set; }
		public string embed_url { get; set; }
		public string username { get; set; }
		public string source { get; set; }
		public string rating { get; set; }
		public string caption { get; set; }
		public string trending_datetime { get; set; }
		public Images images { get; set; }
	}

	public class Pagination
	{
		public int total_count { get; set; }
		public int count { get; set; }
		public int offset { get; set; }
	}

	public class Meta
	{
		public int status { get; set; }
		public string msg { get; set; }
	}

	public class RootObject
	{
		public List<Datum> data { get; set; }
		public Pagination pagination { get; set; }
		public Meta meta { get; set; }
	}
}

