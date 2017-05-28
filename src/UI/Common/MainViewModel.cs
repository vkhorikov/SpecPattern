using UI.Movies;


namespace UI.Common
{
    public class MainViewModel
    {
        public ViewModel ViewModel { get; }


        public MainViewModel()
        {
            ViewModel = new MovieListViewModel();
        }
    }
}
