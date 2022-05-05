using MVCnewModel.Models;

namespace MVCnewModel.ViewModel
{
    public class CostViewModelWithBag
    {
        public Cost CostData = new();
        public string Title { get; set; }
    }
}
