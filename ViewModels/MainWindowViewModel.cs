using System.Windows.Input;
using ReactiveUI;

namespace BasicAvaloniaTemplate.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _currentPage;
        private ViewModelBase[] _pages = {
                                            new FirstPageViewModel(),
                                            new SecondPageViewModel(),
                                            new ThirdPageViewModel(),
                                         };

        private ViewModelBase _pageOne = new FirstPageViewModel();
        private ViewModelBase _pageTwo = new SecondPageViewModel();
        private ViewModelBase _pageThree = new ThirdPageViewModel();

        public ViewModelBase CurrentPage
        {
            get { return _currentPage; }
            private set { this.RaiseAndSetIfChanged(ref _currentPage, value); }
        }

        #region Constructor

        public MainWindowViewModel()
        {
            _currentPage = _pages[0];

            NavigateToPageOneCommand = ReactiveCommand.Create(NavigateToPageOne);
            NavigateToPageTwoCommand = ReactiveCommand.Create(NavigateToPageTwo);
            NavigateToPageThreeCommand = ReactiveCommand.Create(NavigateToPageThree);
        }

        #endregion

        public ICommand NavigateToPageOneCommand { get; }

        private void NavigateToPageOne()
        {
            CurrentPage = _pages[0];
        }

        public ICommand NavigateToPageTwoCommand { get; }

        private void NavigateToPageTwo()
        {
            CurrentPage = _pages[1];
        }

        public ICommand NavigateToPageThreeCommand { get; }

        private void NavigateToPageThree()
        {
            CurrentPage = _pages[2];
        }
    }
}