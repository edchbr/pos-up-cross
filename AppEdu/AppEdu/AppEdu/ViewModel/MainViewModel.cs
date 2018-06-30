using AppEdu.Model;
using AppEdu.Service;
using AppEdu.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppEdu.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        readonly ISerieService _serieService;

        public ICommand ItemClickCommand { get; }

        public ObservableCollection<Serie> Itens { get; }

        public MainViewModel(ISerieService serieService) : base("Awesome Series")
        {
            _serieService = serieService;

            Itens = new ObservableCollection<Serie>();

            ItemClickCommand = new Command<Serie>(async (item) => await ItemClickCommandExecute(item));
        }

        async Task ItemClickCommandExecute(Serie serie)
        {
            if (serie != null)
            {
                await NavigationService.NavigateToAsync<DetailViewModel>(serie);
            }
        }

        public override async Task InitializeAsync(object navgationData)
        {
            await base.InitializeAsync(navgationData);
            await LoadDataAsync();
        }

        async Task LoadDataAsync()
        {
            var result = await _serieService.GetSeriesAsync();
            AddItens(result);
        }

        private void AddItens(SerieResponse result)
        {
            Itens.Clear();
            result.Series.ToList()?.ForEach(i => Itens.Add(i));
        }
    }
}