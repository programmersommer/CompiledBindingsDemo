using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel; 


namespace CompiledBindingsDemo
{

    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _organization;
        private int? _age;

        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }

        public string Organization
        {
            get { return _organization; }
            set { _organization = value; }
        }

        public int? Age
        {
            get { return _age;  }
            set { _age = value;
                RaisePropertyChanged("Age");
            }
        }

       public void Poke()
        {
            this.Age = this.Age+1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }


}
