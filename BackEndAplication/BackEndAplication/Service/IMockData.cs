using System.Collections.ObjectModel;
using BackEndAplication.Models;

namespace BackEndAplication.Service
{
    public interface IMockData
    {
        ObservableCollection<Terminal> GenerateMockData();
    }
}