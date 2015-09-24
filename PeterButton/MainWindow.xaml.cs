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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeterButton
{
    /// The primary window of Peter's Button
    /// Interaction logic for MainWindow.xaml
    /// Author: Brandon Yip
    public partial class MainWindow : Window
    {

        Storyboard s;
        cloud cloud1;
        cloud cloud2;
        cloud cloud3;
        public MainWindow()
        {
            InitializeComponent();
            KeyUp += Escape;

            var sb = this.Resources["ClassroomStoryboard"];
            s = sb as Storyboard;
            s.Begin();

            makeCloud(cloud1);
            helper(cloud2);
        }

        public void helper(cloud cloud2)
        {
            makeCloud(cloud2);
            makeCloud(cloud3);
        }

        //Event: Escape KeyUp causes application to close
        private void Escape(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            s.Seek(TimeSpan.Zero);
        }

        public void makeCloud(cloud cloud)
        {
            
            DoubleAnimation da = new DoubleAnimation(-100, 800, new Duration(new TimeSpan(0, 0, RandomIntGenerator(3))));
            Storyboard story = new Storyboard { /*RepeatBehavior = RepeatBehavior.Forever*/ };
            Storyboard.SetTargetProperty(da, new PropertyPath("(Canvas.Left)"));
            story.Children.Add(da);

            cloud = new cloud();
            try {
                picSelector(RandomIntGenerator(2), cloud);
            }
            catch (Exception e) { }
            int y = RandomIntGenerator(1);
            Canvas.SetTop(cloud, y);
            Container.Children.Add(cloud);
            story.Completed += (s,  eArgs) =>
            {
                Container.Children.Remove(cloud);
                makeCloud(cloud);
            };
            
            cloud.BeginStoryboard(story);
            
        }

        private void PlaySound(Uri source)
        {
            Uri uri = source;
            var player = new MediaPlayer();
            player.Open(uri);
            player.Play();
        }

        //Selects which picture to be used as the cloud
        public void picSelector(int i, cloud cloud)
        {
            Uri uri;
            switch (i)
            {
                case 1:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/nexuscloud.png"));
                    
                    break;
                case 2:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/honkscloud.png"));
                    
                    break;
                case 3:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/catcloud.png"));
                    uri = new Uri(@"../../Resources/kitten.wav", UriKind.Relative);
                    PlaySound(uri);
                    break;

                case 4:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/snoocloud.png"));
                    break;

                case 5:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/suzuyacloud.png"));
                    uri = new Uri(@"../../Resources/Suzuya.wav", UriKind.Relative);
                    PlaySound(uri);
                    break;

                case 6:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/yuicloud.png"));
                    uri = new Uri(@"../../Resources/Yahallo.wav", UriKind.Relative);
                    PlaySound(uri);
                    break;
                case 7:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/UX.png"));
                    break;
                case 8:
                    cloud.Img.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/pc.png"));
                    break;
                
            } 
        }

        public int RandomIntGenerator(int i)
        {
            Random rnd = new Random();
            int num = 0;
            if (i == 1)
            {
                num = rnd.Next(0, 300);
            }
            if (i == 2)
            {
                num = rnd.Next(1, 9);
            }
            if (i == 3)
            {
                num = rnd.Next(8, 20);
            }
            return num;
        }
      
    }
}
