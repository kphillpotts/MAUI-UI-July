using ClassFly.Core.Models;

namespace ClassFlyXaml.Pages;

public partial class CourseListPage : ContentPage
{
	public CourseListPage()
	{
		InitializeComponent();

	}

	protected override void OnSizeAllocated(double width, double height)
	{
		base.OnSizeAllocated(width, height);

        // Fix for issue with search bar not sizing
        // https://github.com/dotnet/maui/issues/7137
        if (width > 0)
			CourseSearchBar.WidthRequest = width;
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