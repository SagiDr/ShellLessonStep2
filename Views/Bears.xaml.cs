namespace ShellLessonStep2.Views;
using ShellLessonStep2.ViewModels;

public partial class Bears : ContentPage
{
	public Bears(BearsViewModel bvm)
	{
		InitializeComponent();
        this.BindingContext = bvm;
    }
}