using System.Collections.ObjectModel;

namespace Cars.Model
{
	public class CarMake
	{
		public string? Name { get; set; }
		public ObservableCollection<CarModel> CarModels { get; }= new();
	}
}