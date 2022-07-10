using ClassFly.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFlyXaml.ViewModels;


public partial class CourseViewModel : ObservableObject
{
	private Course course;

	public CourseViewModel(Course course) => this.course = course;

    public string Name
    {
        get => course.Name;
        set => SetProperty(course.Name, value, course, (u, n) => u.Name = n);
    }
    
}
