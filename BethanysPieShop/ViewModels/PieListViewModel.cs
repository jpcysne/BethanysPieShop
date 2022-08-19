using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CurrentCatergory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string? currentCatergory)
        {
            Pies = pies;
            CurrentCatergory = currentCatergory;
        }
    }
}
