using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLoginScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int? NumberOne { get; set; }

        public int? NumberTwo { get; set; }
        public char? Operator { get; set; }
        public string Result { get; set; }

        public string Num { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NumberOne = null;
            NumberTwo = null;
            Operator = null;
           // Num = "";
            Result = NumberOne.ToString() + Operator + NumberTwo.ToString();
            OnPropertyChanged("Result");
            this.DataContext = this;
        }
      

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
             Num= Num + btn.Content.ToString();
            if(NumberOne==null || Operator==null)
            {
                NumberOne = Int32.Parse(Num);

            }
            else if(NumberOne!=null && Operator!=null)
            {
                NumberTwo = Int32.Parse(Num);

            }
            //RaisePropertyChanged(() => NumberOne);
            OnPropertyChanged("NumberOne");
            OnPropertyChanged("NumberTwo");
            Result = NumberOne.ToString() + Operator + NumberTwo.ToString();

             OnPropertyChanged("Result");

            //MessageBox.Show(NumberOne);

        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            if(Operator==null)
            {
                Button btn = (Button)sender;
                string a = btn.Content.ToString();
                //Operator = a;
                Operator = Char.Parse(a);
                //MessageBox.Show(Operator.ToString());
                OnPropertyChanged("NumberOne");
                OnPropertyChanged("NumberTwo");
                Result = NumberOne.ToString() + Operator + NumberTwo.ToString();

               OnPropertyChanged("Result");
                Num = null;

            }


        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                Button btn = (Button)sender;
                string a = btn.Content.ToString();
                Operator = Char.Parse(a);
                OnPropertyChanged("NumberOne");
                OnPropertyChanged("NumberTwo");
                Result = NumberOne.ToString() + Operator + NumberTwo.ToString();
                OnPropertyChanged("Result");

                Num = null;
            }


        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                Button btn = (Button)sender;
                string a = btn.Content.ToString();
                Operator = Char.Parse(a);
                OnPropertyChanged("NumberOne");
                OnPropertyChanged("NumberTwo");
                Result = NumberOne.ToString() + Operator + NumberTwo.ToString();
                OnPropertyChanged("Result");
                Num = null;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (Operator.ToString() == "*")
            {
                Result = (NumberOne * NumberTwo).ToString();
            }
            if (Operator.ToString() == "+")
            {
                Result = (NumberOne + NumberTwo).ToString();
            }
            if (Operator.ToString() == "/")
            {
                if(NumberTwo!=0)
                {
                    Result = ((float)NumberOne / (float)NumberTwo).ToString();

                }
                else
                {
                    Result ="Cannot Divide By Zero";

                }
            }
            if (Operator.ToString() == "-")
            {
                Result = (NumberOne - NumberTwo).ToString();
            }
            NumberTwo = null;
            NumberOne = null;
            Operator = null;
            //Result = null;
            Num = null;
            OnPropertyChanged("NumberOne");
            OnPropertyChanged("NumberTwo");
            OnPropertyChanged("Result");
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (Operator == null)
            {
                Button btn = (Button)sender;
                string a = btn.Content.ToString();
                Operator = Char.Parse(a);
                OnPropertyChanged("NumberOne");
                OnPropertyChanged("NumberTwo");
                Result = NumberOne.ToString() + Operator + NumberTwo.ToString();
                OnPropertyChanged("Result");
                Num = null;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberTwo = null;
            NumberOne = null;
            Operator = null;
            Result = null;
            Num = null;
            OnPropertyChanged("NumberOne");
            OnPropertyChanged("NumberTwo");
            Result = NumberOne.ToString() + Operator + NumberTwo.ToString();
            OnPropertyChanged("Result");
        }
    }
}
