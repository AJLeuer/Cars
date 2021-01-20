using Cars.Model;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Cars.View
{
	public partial class CarModelView : StackPanel 
    {
	    public static readonly DependencyProperty CarModelProperty = DependencyProperty.Register(
		    nameof (CarModelView.CarModel),
		    typeof (CarModel),
		    typeof (CarModelView),
		    new PropertyMetadata(null)
	    );
	    
	    public CarModel CarModel
	    {
		    get { return (CarModel) GetValue(CarModelProperty); }
		    set { SetValue(CarModelProperty, value); }
	    }

	    public CarModelView()
	    {
		    InitializeComponent();
	    }
    }
}