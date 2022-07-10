using ClassFly.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFlyXaml.ViewModels;

[INotifyPropertyChanged]
public partial class ClassListViewModel
{
    private DataService dataservice;

    [ObservableProperty]
    private ObservableCollection<Course> courses;

    [ObservableProperty]
    private Course selectedCourse;

    public ClassListViewModel()
	{
        //this.dataservice = new DataService();
        courses = new ObservableCollection<Course>(DataService.GetCourses());
    }
    
}
