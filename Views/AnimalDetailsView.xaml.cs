namespace ShellLessonStep2.Views;
using ShellLessonStep2.ViewModels;

public partial class AnimalDetailsView : ContentPage
{
	public AnimalDetailsView(AnimalDetailsViewModel advm)
	{
		InitializeComponent();
        this.BindingContext = advm;
    }
}