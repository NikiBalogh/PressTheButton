using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using PressTheButton.Controller;

namespace PressTheButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.Controller controller = new Controller.Controller();
        TimeSpan AlwaysSpeed = new TimeSpan(10000);
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            btnPressMe.Margin = new Thickness(controller.X, controller.Y, 0, 0);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = AlwaysSpeed;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lblScore.Content = controller.Score;
            controller.UpdateStuffAlways();
            btnPressMe.Margin = new Thickness(controller.X, controller.Y, 0, 0);
            if (controller.Score >= 50)
            {
                gridGame.Visibility = Visibility.Collapsed;
                gridWin.Visibility = Visibility.Visible;
            }
        }

        private void btnPressMe_Click(object sender, RoutedEventArgs e)
        {
            controller.Score++;
        }

    }
}
