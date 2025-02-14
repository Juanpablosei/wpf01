using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf01
{
    public class Suma : INotifyPropertyChanged
    {
        private string num1;
        private string num2;
        private string resultado;

        public string Num1 
        {
            get
            { 
                return num1;
            }
            set
            {
                int numero;
                bool res = int.TryParse(value, out numero);
                if (res) num1=value;
                OnPropertyChanged("Num1");
                OnPropertyChanged("Resultado");

            }
        }
        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                int numero;
                bool res = int.TryParse(value, out numero);
                if (res) num2 = value;
                OnPropertyChanged("Num2");
                OnPropertyChanged("Resultado");

            }
        }
        public string Resultado
        {
            get
            {
                int res= int.Parse(num1) + int.Parse(num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(num1) + int.Parse(num2);
                resultado = res.ToString();
                OnPropertyChanged("Resultado");

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
