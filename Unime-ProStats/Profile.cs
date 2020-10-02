using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using JikanDotNet;
using System.Drawing;
using System.Net;
using System.IO;
using System.Windows.Controls;
using System.Linq;
using System.Collections.ObjectModel;

namespace Unime_ProStats
{
    public class Profile
    {
        public UserProfile profile { set; get; }
        public IEnumerable<Anime> animeList { set; get; }

        public Profile()
        {

        }

        public static async Task<Profile> ProfileCons(string Name)
        {
            var p = new Profile();
            var jikan = new Jikan(true);
            UserAnimeList _animeList;
            //p.profile = await jikan.GetUserProfile(Name);

            //_animeList = await jikan.GetUserAnimeList(Name);
            //p.animeList = _animeList.Anime.Select(anime => new Anime(anime));
            //return p;
            try
            {
                p.profile = await jikan.GetUserProfile(Name);

                _animeList = await jikan.GetUserAnimeList(Name);
                //var models = _animeList.Anime.Select(async (anime) => { return await Anime.AnimeCons(anime, jikan); });
                //p.animeList = (await Task.WhenAll(models)).ToList();
                var models = _animeList.Anime.Select((anime) => { return Anime.AnimeConsAsync(anime, jikan); });
                p.animeList = await Task.WhenAll(models);
                //MessageBox.Show(string.Join(',', p.animeList.Select(o => o.Title)));
                return p;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            //MessageBox.Show(string.Join("\n", p.animeList.Select(o => o.MalId + ".....")));

        }
    }
}
