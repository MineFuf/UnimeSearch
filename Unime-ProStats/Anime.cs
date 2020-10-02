using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Drawing;
using JikanDotNet;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;

namespace Unime_ProStats
{
    public class Anime : AnimeListEntry, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public async static Task<Anime> AnimeConsAsync(AnimeListEntry entry)
        {
            var jikan = new Jikan(true);
            return await AnimeConsAsync(entry, jikan);
        }
        public async static Task<Anime> AnimeConsAsync(AnimeListEntry entry, Jikan jikan)
        {
            var anime = new Anime(entry);
            //MessageBox.Show(anime.Title + ": got the info");
            return anime;
        }

        public static Anime AnimeCons(AnimeListEntry entry, Jikan jikan)
        {
            var anime = new Anime(entry);
            JikanDotNet.Anime _anime = jikan.GetAnime(anime.MalId).Result;
            return anime;
        }

        public Anime(AnimeListEntry entry)
        {

            Priority        = entry.Priority;
            Days            = entry.Days;
            WatchEndDate    = entry.WatchEndDate;
            WatchStartDate  = entry.WatchStartDate;
            EndDate         = entry.EndDate;
            StartDate       = entry.StartDate;
            Rating          = entry.Rating ;
            IsRewatching    = entry.IsRewatching;
            HasVideo        = entry.HasVideo;
            AiringStatus    = entry.AiringStatus;
            HasPromoVideo   = entry.HasPromoVideo;
            Score           = entry.Score;
            TotalEpisodes   = entry.TotalEpisodes;
            WatchedEpisodes = entry.WatchedEpisodes;
            this.Type       = entry.Type;
            VideoUrl        = entry.VideoUrl;
            URL             = entry.URL;
            ImageURL        = entry.ImageURL;
            Title           = entry.Title;
            MalId           = entry.MalId;
            HasEpisodeVideo = entry.HasEpisodeVideo;
            WatchingStatus  = entry.WatchingStatus;
        }
    }
}
