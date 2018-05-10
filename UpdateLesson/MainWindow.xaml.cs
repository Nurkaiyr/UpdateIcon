using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace UpdateLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Timer timer = new Timer(UpdateIcon, null, 1000, 1000);


        }
        public void UpdateIcon(object paths)
        {
            string[] path = Directory.GetFiles(@"C:\Users\едиген\source\repos\UpdateLesson\UpdateLesson\Icon");
            string iconToLoad = "";

            foreach (string withPath in path)
            {
                iconToLoad = path + iconToLoad;
            }
            Dispatcher.Invoke(()=>{
                Process.GetCurrentProcess().CloseMainWindow();

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                mainWindow.Icon = BitmapFrame.Create(new Uri(iconToLoad));
            });

            
        }
    }
}
