using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListViewTest
{
    internal class NeedHostelClass : INotifyPropertyChanged
    {
        private int _count;
        public int Count 
        {
            get { return _count; }
            set { _count = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count))); }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
