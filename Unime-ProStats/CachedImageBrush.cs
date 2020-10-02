using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Unime_ProStats
{
    public class CachedImage : Image
    {
        static CachedImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CachedImage),
                     new FrameworkPropertyMetadata(typeof(CachedImage)));
        }

        public readonly static DependencyProperty ImageUrlProperty = DependencyProperty.Register(
          "ImageUrl", typeof(string), typeof(CachedImage),
          new PropertyMetadata("", ImageUrlPropertyChanged));

        public string ImageUrl
        {
            get
            {
                return (string)GetValue(ImageUrlProperty);
            }
            set
            {
                SetValue(ImageUrlProperty, value);
            }
        }

        private static readonly object SafeCopy = new object();

        private static void ImageUrlPropertyChanged(DependencyObject obj,
                DependencyPropertyChangedEventArgs e)
        {
            var url = (String)e.NewValue;
            if (String.IsNullOrEmpty(url))
                return;

            var uri = new Uri(url);
            var localFile = String.Format(Path.Combine
                           (Path.GetTempPath(), uri.Segments[uri.Segments.Length - 1]));
            var tempFile = String.Format(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));

            if (File.Exists(localFile))
            {
                SetSource((CachedImage)obj, localFile);
            }
            else
            {
                var webClient = new WebClient();
                webClient.DownloadFileCompleted += (sender, args) =>
                {
                    if (args.Error != null)
                    {
                        File.Delete(tempFile);
                        return;
                    }
                    if (File.Exists(localFile))
                        return;
                    lock (SafeCopy)
                    {
                        File.Move(tempFile, localFile);
                    }
                    SetSource((CachedImage)obj, localFile);
                };

                webClient.DownloadFileAsync(uri, tempFile);
            }
        }

        private static void SetSource(Image inst, String path)
        {
            inst.Source = new BitmapImage(new Uri(path));
        }
    }
}
