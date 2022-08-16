using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Task10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window /*, INotifyPropertyChanged*/
    {
        public MainWindow()
        {
            InitializeComponent();
            //    ImagePath = "Data/IMG1.jpg";
            //}

            //public event PropertyChangedEventHandler PropertyChanged;
            //public void OnPropertyChanged([CallerMemberName] string prop = "")
            //{
            //    if (PropertyChanged != null)
            //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
            //}


            //private string imagePath;

            //public string ImagePath
            //{
            //    get { return imagePath; }
            //    set
            //    {
            //        imagePath = value;
            //        OnPropertyChanged("ImagePath");
            //    }
            //}

            //private void GetIMG1Executed(object sender, ExecutedRoutedEventArgs e)
            //{
            //    ImagePath = "Data/IMG1.jpg";
            //}
            //private void GetIMG2Executed(object sender, ExecutedRoutedEventArgs e)
            //{
            //    ImagePath = "Data/IMG2.jpg";
            //}
            //private void GetIMG3Executed(object sender, ExecutedRoutedEventArgs e)
            //{
            //    ImagePath = "Data/IMG3.jpg";
            //}
            //private void GetIMG4Executed(object sender, ExecutedRoutedEventArgs e)
            //{
            //    ImagePath = "Data/IMG4.jpg";
            //}
            //private void GetIMG5Executed(object sender, ExecutedRoutedEventArgs e)
            //{
            //    ImagePath = "Data/IMG5.jpg";
            //}

        }
    }
}
