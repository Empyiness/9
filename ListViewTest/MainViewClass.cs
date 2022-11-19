using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ListViewTest
{
    internal class MainViewClass
    {
        public ObservableCollection<Student> Students { get; set; }
        public RelayCommand AddItemCommand { get; set; }
        public RelayCommand CalculateCommand { get; set; }
        public RelayCommand DeleteItemCommand { get; set; }
        public Student SelectedItem { get; set; }
        public NeedHostelClass NeedHostel { get; set; }
        public MainViewClass()
        {
            NeedHostel = new NeedHostelClass();
            NeedHostel.Count = 0;
            AddItemCommand = new RelayCommand(o => AddItem());
            CalculateCommand = new RelayCommand(o => Calculate());
            DeleteItemCommand = new RelayCommand(o => DeleteItem());
            Students = new();
        }
        public void AddItem()
        {
            Students.Add(new Student {Surname="Студент"});
        }
        public void Calculate()
        {
            NeedHostel.Count = 0;
            foreach (Student i in Students)
            {
                if (i.Hostel == "Да" || i.Hostel == "да" || i.Hostel == "д" || i.Hostel == "Д")
                {
                    NeedHostel.Count++;
                }
            }
        }
        public void DeleteItem()
        {
            Students.Remove(SelectedItem);
        }
    }
}
