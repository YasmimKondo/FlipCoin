using CommunityToolkit.Mvvm.ComponentModel;
using FlipCoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlipCoin.ViewModel
{
    internal partial class FlipViewModel : ObservableObject
    {
        [ObservableProperty]
        private String _selectedCoin;

        [ObservableProperty]
        private String _resultText;

        [ObservableProperty]
        public String _imageName;

        public ICommand flipCmd { get; }

        public FlipViewModel()
        {
            ImageName = "cara.jpg";
            SelectedCoin = "Cara";
            flipCmd = new Command(flipCoin);
        }

        public void flipCoin()
        {
            Flip flipModel = new((SelectedCoin == "Cara") ? true : false);

            flipModel.flipCoin();

            ResultText = flipModel.result;
            ImageName = flipModel.imageName;
        }
    }
}
