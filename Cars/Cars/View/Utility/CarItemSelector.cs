using System;
using Cars.Model;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Cars.View.Utility
{
	public class CarItemSelector : DataTemplateSelector
	{
		public DataTemplate? CarMakeTemplate { get; set; }
		public DataTemplate? CarModelTemplate { get; set; }

		protected override DataTemplate? SelectTemplateCore(object item)
		{
			if (item is CarMake)
			{
				return CarMakeTemplate;
			}
			else if (item is CarModel)
			{
				return CarModelTemplate;
			}
			else
			{
				throw new ArgumentException("Unknown type of item passed to CarItemSelector");
			}
		}
	}
}