using System;
namespace WebApplication1.Models.ViewModels
{
	public static class FilterSettings
	{
		public static string Ageatdeath { get; set; }
		public static string Haircolor { get; set; }
		public static string Sex { get; set; }
		public static string Wrapping { get; set; }
		public static string Depth { get; set; }
        public static string Northsouth { get; set; }
		public static string Squarenorthsouth { get; set; }
		public static string Eastwest { get; set; }
		public static string Squareeastwest { get; set; }
		public static string Area { get; set; }

		static FilterSettings()
		{
            Ageatdeath  = "";
            Haircolor  = "";
            Sex  = "";
            Wrapping  = "";
            Depth  = "";
            Northsouth  = "";
            Squarenorthsouth  = "";
            Eastwest  = "";
            Squareeastwest  = "";
            Area  = "";
    }
    }
}

