using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarHelper.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private BlueViewModel blueViewModel = new BlueViewModel();
        private RedViewModel redViewModel = new RedViewModel();

        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch(destination)
            {
                case "redView":
                    CurrentViewModel = redViewModel;
                    break;
                case "blueView":
                    CurrentViewModel = blueViewModel;
                    break;
            }
        }
    }
}
