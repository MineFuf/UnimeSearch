using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Unime_ProStats
{
    /// <summary>
    /// Interaction logic for AnimeInfoWindows.xaml
    /// </summary>
    public partial class AnimeInfoWindows : Window
    {
        Anime anime;
        public AnimeInfoWindows(Anime anime)
        {
            InitializeComponent();
            this.anime = anime;
            DataContext = anime;
        }
    }
}
