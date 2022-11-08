using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Учет_отпусков.Comand;
using Microsoft.EntityFrameworkCore;
using Учет_отпусков.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Учет_отпусков.ViewModels
{
    internal class WorkerViewModel : INotifyPropertyChanged
    {
        ApplicationContext db = new ApplicationContext();
        RelayCommand? addCommand;
        RelayCommand? editCommand;
        RelayCommand? deleteCommand;

        public event PropertyChangedEventHandler? PropertyChanged;
        Worker? _Worker;
        public ObservableCollection<Worker> Workers { get; set; }
        public Worker? Worker {
            get { return _Worker; }
            set
            {
                _Worker = value;
                OnPropertyChanged("Worker");
            }
        }
        public WorkerViewModel()
        {
            Worker = new Worker();            
            db.Workers.Load();
            Workers = db.Workers.Local.ToObservableCollection();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      if(Worker is not null)
                        db.Workers.Add((Worker)Worker.Clone());
                      db.SaveChangesAsync();    
                      
                  }));
            }
        }
        // команда редактирования
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {

                      db.SaveChangesAsync();

                      //// получаем выделенный объект
                      //User? user = selectedItem as User;
                      //if (user == null) return;

                      //User vm = new User
                      //{
                      //    Id = user.Id,
                      //    Name = user.Name,
                      //    Age = user.Age
                      //};
                      //UserWindow userWindow = new UserWindow(vm);


                      //if (userWindow.ShowDialog() == true)
                      //{
                      //    user.Name = userWindow.User.Name;
                      //    user.Age = userWindow.User.Age;
                      //    db.Entry(user).State = EntityState.Modified;
                      //    db.SaveChanges();
                      //}
                  }));
            }
        }
        // команда удаления
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      db.Workers.Remove(Worker);
                      db.SaveChangesAsync();
                      Worker = new Worker();
                     // Workers = db.Workers.Local.ToObservableCollection();
                      //// получаем выделенный объект
                      //User? user = selectedItem as User;
                      //if (user == null) return;
                      //db.Users.Remove(user);
                      //db.SaveChanges();
                  }));
            }
        }
    }
}
