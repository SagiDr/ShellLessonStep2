namespace ShellLessonStep2.Views;
using ShellLessonStep2.ViewModels;

public partial class Cats : ContentPage
{
	public Cats(CatsViewModel cvm)
	{
		InitializeComponent();
        this.BindingContext = cvm;
    }
}