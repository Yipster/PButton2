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


//Credits to stackoverflow code
//Used to loop gif within WPF

namespace PeterButton
{
    public class GifImage : Image
    {
        private GifBitmapDecoder _decoder;
        private Int32Animation _animation;

        #region FrameIndex

        public static readonly DependencyProperty FrameIndexProperty = DependencyProperty.Register("FrameIndex", typeof(int), typeof(GifImage), new UIPropertyMetadata(0, new PropertyChangedCallback(ChangingFrameIndex)));

        public int FrameIndex
        {
            get { return (int)GetValue(FrameIndexProperty); }
            set { SetValue(FrameIndexProperty, value); }
        }

        private static void ChangingFrameIndex(DependencyObject obj, DependencyPropertyChangedEventArgs ev)
        {
            GifImage gifImage = obj as GifImage;
            gifImage.ChangeFrameIndex((int)ev.NewValue);
        }

        private void ChangeFrameIndex(int index)
        {
            Source = _decoder.Frames[index];
        }

        #endregion

        #region GifSource

        public static readonly DependencyProperty GifSourceProperty = DependencyProperty.Register("GifSource", typeof(string), typeof(GifImage), new UIPropertyMetadata(String.Empty, new PropertyChangedCallback(GifSourceChanged)));
        public string GifSource
        {
            get { return (string)GetValue(GifSourceProperty); }
            set { SetValue(GifSourceProperty, value); }
        }

        private static void GifSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs ev)
        {
            GifImage gifImage = obj as GifImage;
            gifImage.GifSourceChanged(ev.NewValue.ToString());
        }

        private void GifSourceChanged(string newSource)
        {
            if (_animation != null)
                BeginAnimation(FrameIndexProperty, null);

            _decoder = new GifBitmapDecoder(new Uri(newSource), BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            Source = _decoder.Frames[0];

            int count = _decoder.Frames.Count;
            _animation = new Int32Animation(0, count - 1, new Duration(new TimeSpan(0, 0, 0, count / 10, (int)((count / 10.0 - count / 10) * 1000))));
            _animation.RepeatBehavior = RepeatBehavior.Forever;
            BeginAnimation(FrameIndexProperty, _animation);
        }

        #endregion
    }
}
