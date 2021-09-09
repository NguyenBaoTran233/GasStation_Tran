using GasStation_Tran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Repository
{
    public interface IUser
    {
        User Login(User user);
    }
    public interface IDistrict
    {
        List<District> GetAllDistrict();
    }
    public interface IRating
    {
        List<GasStationRating> GetAllRating();
    }
    public interface IGasStationType
    {
        List<GasStationType> GetGasStationTypes();
    }
    public interface IGasStationFeedback
    {
        List<GasStationFeedback> GetStationFeedback();
    }
    public interface IGasStationList
    {
        List<GasStationList> GetStationLists();
        List<GasStationTable> GetAllStationtable();
        long Add(ViewModels.GasStationViewModels stationViewModels);
        long Update(ViewModels.GasStationViewModels stationViewModels , int id);
        long Remove(ViewModels.GasStationViewModels stationViewModels, int id);
        List<GasStationTable> GetAllStationtableSearch(ViewModels.GasStationViewModels stationViewModels);
    }
    public interface IGasStationListFeedback
    {
        List<GasStationListFeedback> GetAllListFeedback();
    }
    public interface IGasStationAdd
    {
        List<GasStationAdd> GetAllGasStationAdd();
    }
    public interface IGasStationEdit
    {
        List<GasStationEdit> GetAllGasStationEdit();
    }
    public interface IGasStationSearch
    {
        List<GasStationSearch> GetAllGasStationSearch();
    }
}
