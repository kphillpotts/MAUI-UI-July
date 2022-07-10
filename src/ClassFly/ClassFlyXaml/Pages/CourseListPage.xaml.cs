using ClassFly.Core.Models;

namespace ClassFlyXaml.Pages;

public partial class CourseListPage : ContentPage
{
	public CourseListPage()
	{
		InitializeComponent();
        
	}

	private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

		var vm = this.BindingContext as ViewModels.ClassListViewModel;
        
        if (vm.SelectedCourse != null)
		{
            await Navigation.PushAsync(new CoursePage(vm.SelectedCourse));
			vm.SelectedCourse = null;
        }
        

		//Course selectedCourse = e.CurrentSelection.FirstOrDefault() as Course;
		//if (selectedCourse != null)
		//{
		//	CourseCollectionView.SelectedItem = null;
		//	await Navigation.PushAsync(new CoursePage(selectedCourse));
		//}
	}
}