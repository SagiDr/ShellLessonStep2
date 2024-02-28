namespace ShellLessonStep2.Views;
using ShellLessonStep2.ViewModels;

public partial class Dogs : ContentPage
{
	public Dogs(DogsViewModel dvm)
	{
		InitializeComponent();
        this.BindingContext = dvm;
    }
}