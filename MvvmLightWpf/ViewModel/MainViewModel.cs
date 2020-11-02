

using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;
using MvvmLightWpf.Model;

namespace MvvmLightWpf.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : VMBase
    {

        public ObservableCollection<Person> Persons { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            Persons = new ObservableCollection<Person>();

            

            Persons.Add(new Person() { Name = "张三", Age = 18 });
            Persons.Add(new Person() { Name = "李四", Age = 18 });


        }
    }
}