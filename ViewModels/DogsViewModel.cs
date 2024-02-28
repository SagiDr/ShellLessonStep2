using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ShellLessonStep2.Services;
using ShellLessonStep2.Models;

namespace ShellLessonStep2.ViewModels
{
    public class DogsViewModel : ViewModelBase
    {
        private ObservableCollection<Animal> dogs;
        public ObservableCollection<Animal> Dogs
        {
            get
            {
                return this.dogs;
            }
            set
            {
                this.dogs = value;
                OnPropertyChanged();
            }
        }

        private AnimalService animalService;

        public DogsViewModel(AnimalService service)
        {
            this.animalService = service;
            Dogs = new ObservableCollection<Animal>(this.animalService.GetDogs());
            IsRefreshing = false;
        }

        #region Refresh View
        public ICommand RefreshCommand => new Command(Refresh);
        private async void Refresh()
        {

            Dogs = (ObservableCollection<Animal>)this.animalService.GetDogs();

            IsRefreshing = false;
        }

        private bool isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return this.isRefreshing;
            }
            set
            {
                this.isRefreshing = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
