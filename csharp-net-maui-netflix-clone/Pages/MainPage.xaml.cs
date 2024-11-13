using csharp_net_maui_netflix_clone.Services;

namespace csharp_net_maui_netflix_clone.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly TmdbService _tmdbService;
        int count = 0;

        public MainPage(TmdbService tmdbService)
        {
            
            InitializeComponent();
            _tmdbService = tmdbService;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                var trending = await _tmdbService.GetTrendingAsync();
                // Use the trending data as needed
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
