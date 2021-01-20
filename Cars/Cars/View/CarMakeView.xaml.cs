using Cars.Model;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Cars.View
{
	public partial class CarMakeView : StackPanel
	{
		public static readonly DependencyProperty CarMakeProperty = DependencyProperty.Register(
			nameof (CarMakeView.CarMake),
			typeof (CarMake),
			typeof (CarMakeView),
			new PropertyMetadata(null)
		);

		public CarMake CarMake
		{
			get { return (CarMake) GetValue(CarMakeProperty); }
			set { SetValue(CarMakeProperty, value); }
		}
		
		public CarMakeView()
		{
			this.InitializeComponent();
		}
	}
}