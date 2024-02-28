namespace ShellLessonStep2.Views;
using ShellLessonStep2.ViewModels;

public partial class Elephants : ContentPage
{
	public Elephants(ElephantsViewModel evm)
	{
		InitializeComponent();
        this.BindingContext = evm;
    }
}