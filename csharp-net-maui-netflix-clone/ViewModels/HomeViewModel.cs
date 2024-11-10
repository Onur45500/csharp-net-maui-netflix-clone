using CommunityToolkit.Mvvm.ComponentModel;
using csharp_net_maui_netflix_clone.Models;
using csharp_net_maui_netflix_clone.Services;
using System.Collections.ObjectModel;

namespace csharp_net_maui_netflix_clone.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        TmdbService _tmdbService;

        public HomeViewModel(TmdbService tmdbService)
        {
            _tmdbService = tmdbService;
        }
        [ObservableProperty]
        private Media trendingMedia;

        public ObservableCollection<Media> Trending { get; set; } = new();
        public ObservableCollection<Media> TopRated { get; set; } = new();
        public ObservableCollection<Media> NetflixOriginals { get; set; } = new();
        public ObservableCollection<Media> ActionMovies { get; set; } = new();

        public async Task InitializeAsync()
        {
            var trendingList = await _tmdbService.GetTrendingAsync();
            if(trendingList?.Any() == true)
            {
                foreach(var trending in trendingList)
                {
                    Trending.Add(trending);
                }
            }

            var topRatedList = await _tmdbService.GetTopRatedAsync();
            if(topRatedList?.Any() == true)
            {
                foreach(var topRated in topRatedList)
                {
                    TopRated.Add(topRated);
                }
            }

            var netflixOriginalsList = await _tmdbService.GetNetflixOriginalsAsync();
            if(netflixOriginalsList?.Any() == true)
            {
                foreach(var netflixOriginal in netflixOriginalsList)
                {
                    NetflixOriginals.Add(netflixOriginal);
                }
            }

            var actionMoviesList = await _tmdbService.GetActionMoviesAsync();
            if(actionMoviesList?.Any() == true)
            {
                foreach(var actionMovie in actionMoviesList)
                {
                    ActionMovies.Add(actionMovie);
                }
            }
        }
    }
}
