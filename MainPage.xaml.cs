using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


using System.Collections.ObjectModel;


namespace CompiledBindingsDemo
{

    public sealed partial class MainPage : Page
    {

        ObservableCollection<Employee> manager = new ObservableCollection<Employee>();

        public MainPage()
        {
            this.InitializeComponent();

            manager.Add(new Employee { Age = 45, Name = "Ольга", Organization = "ООО Рога и Копыта" });
            manager.Add(new Employee { Age = 25, Name = "Татьяна", Organization = "ОАО Шаркон" });
            manager.Add(new Employee { Age = 22, Name = "Анна", Organization = "ООО Рога и Копыта" });

        }

    }




}
