using ClassFly.Core.Models;

namespace ClassFlyXaml.Pages;

public partial class CoursePage : ContentPage
{
	private Course selectedCourse;

	public CoursePage(Course selectedCourse)
	{
		InitializeComponent();
        this.selectedCourse = selectedCourse;
		this.BindingContext = selectedCourse;
    }
}