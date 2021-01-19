using System.Collections.ObjectModel;
using Cars.Model;
using Microsoft.UI.Xaml;

namespace Cars.View
{
	public sealed partial class MainWindow : Window
	{
		public ObservableCollection<CarMake>? Cars { get; set; } =
			new ()
			{
				new CarMake { Name = "Chevrolet", CarModels = { new CarModel { Name = "Camaro" }, new CarModel { Name = "Blazer" }, new CarModel { Name = "Beretta" } } },
				new CarMake { Name = "Land Rover", CarModels = { new CarModel { Name = "Discovery" }, new CarModel { Name = "LR3" }, new CarModel { Name = "Range Rover" } } },
				new CarMake { Name = "Quadra", CarModels = { new CarModel { Name = "Turbo-R 740" }, new CarModel { Name = "Type-66 Avenger" }} },
				new CarMake { Name = "Powell Motors", CarModels = { new CarModel { Name = "The Homer" }}}
			};

		public MainWindow()
		{
			this.InitializeComponent();
		}
	}
}