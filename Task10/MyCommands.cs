using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task10
{
    class MyCommands
    {
        public static RoutedCommand GetIMG1 { get; set; }
        public static RoutedCommand GetIMG2 { get; set; }
        public static RoutedCommand GetIMG3 { get; set; }
        public static RoutedCommand GetIMG4 { get; set; }
        public static RoutedCommand GetIMG5 { get; set; }

        static MyCommands()
        {
            GetIMG1 = new RoutedCommand("GetIMG1", typeof(MyCommands));
            GetIMG2 = new RoutedCommand("GetIMG2", typeof(MyCommands));
            GetIMG3 = new RoutedCommand("GetIMG3", typeof(MyCommands));
            GetIMG4 = new RoutedCommand("GetIMG4", typeof(MyCommands));
            GetIMG5 = new RoutedCommand("GetIMG5", typeof(MyCommands));
        }
    }
}