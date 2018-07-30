using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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



namespace DandD_List
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
        
        }
        private MediaPlayer player = new MediaPlayer();
        private void Window_Activated(object sender, EventArgs e)
        {

            player.Open(new Uri(@"..\..\Sound\Core\Cover.mp3", UriKind.Relative));
            player.Play();

        }
    }
}
