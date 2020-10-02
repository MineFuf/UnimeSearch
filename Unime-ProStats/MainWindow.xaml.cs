using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using JikanDotNet;

namespace Unime_ProStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        ICollectionView collectionView;

        public Profile CurrentProfile { set
            {
                if (value != currentProfile)
                {
                    currentProfile = value;
                    OnPropertyChanged("CurrentProfile");
                }
            } get { return currentProfile; } }

        private Profile currentProfile;

        public MainWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            DataContext = this;
            AddDoubleClickEventStyle(FullAnimeListBox, new MouseButtonEventHandler((obj1, obj2) => { OpenAnime((ListBoxItem)obj1); }));
        }


        private void OpenAnime(ListBoxItem Item)
        {
            AnimeInfoWindows win = new AnimeInfoWindows((Anime)Item.DataContext);
            win.Show();
        }


        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            var t = ProfileName_TxtBx.Text;
            Load_Btn.IsEnabled = false;
            new Thread(() => { updateProfile(t); }).Start();
        }

        private void updateProfile(string name)
        {
            var p = Profile.ProfileCons(name).Result;
            //MessageBox.Show("0");
            Dispatcher.Invoke(() =>
            {
                CurrentProfile = p;
                Load_Btn.IsEnabled = true;
                FilterChanged();
            });
            //MessageBox.Show("1");
            
            //MessageBox.Show("2");
            //FullAnimeListBox.Items.SortDescriptions.Clear();
            //FullAnimeListBox.Items.SortDescriptions.Add(new SortDescription("TotalEpisodes", ListSortDirection.Descending));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            FilterChanged();
        }

        private void FilterChanged(object sender, TextChangedEventArgs e)
        {
            FilterChanged();
        }

        private void FilterChanged()
        {
            if (FullAnimeListBox != null)
            {
                collectionView = CollectionViewSource.GetDefaultView(FullAnimeListBox.ItemsSource);
                if (collectionView != null)
                {
                    collectionView.Filter = anime =>
                            (Keyword_TB.Text.Length == 0 || ((Anime)anime).Title.ToLower().Contains(Keyword_TB.Text.ToLower()));
                }

                if (FullAnimeListBox.Items != null && FullAnimeListBox.ItemsSource != null)
                {
                    FullAnimeListBox.Items.SortDescriptions.Clear();
                    FullAnimeListBox.Items.SortDescriptions.Add(new SortDescription(
                        Title_RB.IsChecked == true ? "Title" :
                        TotalEpisodes_RB.IsChecked == true ? "TotalEpisodes" :
                        WathcedEpisodes_RB.IsChecked == true ? "WatchedEpisodes" :
                        Rating_RB.IsChecked == true ? "Rating" : "Score",
                        Ascending_RB.IsChecked == true ? ListSortDirection.Ascending : ListSortDirection.Descending));
                }
            }
        }

        private void AddDoubleClickEventStyle(ListBox listBox, MouseButtonEventHandler mouseButtonEventHandler)
        {
            if (listBox.ItemContainerStyle == null)
                listBox.ItemContainerStyle = new Style(typeof(ListBoxItem));
            listBox.ItemContainerStyle.Setters.Add(new EventSetter()
            {
                Event = MouseDoubleClickEvent,
                Handler = mouseButtonEventHandler
            });
        }

        private void MainWinClosing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
