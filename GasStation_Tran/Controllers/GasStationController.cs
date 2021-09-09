using GasStation_Tran.Data;
using GasStation_Tran.Models;
using GasStation_Tran.Repository;
using GasStation_Tran.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Controllers
{
    public class GasStationController : Controller
    {
        private readonly IDistrict _district;
        private readonly IGasStationType _gasStationType;
        private readonly IGasStationFeedback _gasStationFeedback;
        private readonly IGasStationList _gasStationList;
        private readonly IGasStationListFeedback _gasStationListFeedback;
        private readonly IRating _rating;

        protected int PageSize = 10;
        protected int CurrentPage = 0;
        protected int CurrentPageView = 0;


        [BindProperty]
        public GasStationViewModels gasStationView { get; set; }


        public GasStationController(IDistrict district, IGasStationFeedback gasStationFeedback,  IGasStationType gasStationType, IGasStationList gasStationList, IGasStationListFeedback gasStationListFeedback,IRating rating )
        {
            _district = district;
            _gasStationFeedback = gasStationFeedback;
            _gasStationType = gasStationType;
            _gasStationList = gasStationList;
            _gasStationListFeedback = gasStationListFeedback;
            _rating = rating;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    var count = _gasStationList.GetAllStationtable().Count();
                    if (count == 0)
                    {
                        ViewData["MessageTable"] = "ガソリンスタンド{0}は削除されますか？";
                    }
                    ViewBag.CurrentPage = CurrentPage;
                    ViewBag.Page = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
                    gasStationView = new GasStationViewModels();
                    gasStationView.lstDistricts = _district.GetAllDistrict();
                    gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();
                    gasStationView.lstgasStationTables = _gasStationList.GetAllStationtable().Skip(CurrentPage*PageSize).Take(PageSize).ToList();
                    return View(gasStationView);
                }
            }
            else
            {
                return RedirectToAction("Login", "Home", "edit");
            }
            return RedirectToAction("Login", "Home", "Add","edit");
        }

        [HttpPost]
        public IActionResult Index(string SelectPage ="0")
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    var search = _gasStationList.GetAllStationtableSearch(gasStationView);
                    if (!string.IsNullOrEmpty(SelectPage))
                    {
                        var countsearch = search.Count();
                        CurrentPage = int.Parse(SelectPage);
                        ViewBag.CurrentPage = CurrentPage;
                        ViewBag.Page = (countsearch / PageSize) - (countsearch % PageSize == 0 ? 1 : 0);
                    }
                    if (search.Count() == 0)
                    {
                        ViewData["MessageTable"] = "ガソリンスタンド{0}は削除されますか？";
                    }
                    gasStationView = new GasStationViewModels();
                    gasStationView.lstgasStationTables = search.Skip(CurrentPage * PageSize).Take(PageSize).ToList();
                    if(gasStationView.lstDistricts == null)
                    {
                        gasStationView.lstDistricts = _district.GetAllDistrict();
                    }
                    if (gasStationView.lstGasStationType == null)
                    {
                        gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();

                    }
                    return View(gasStationView);
                }
            }
            else
            {
                return RedirectToAction("Login", "Home", "edit");
            }
            return RedirectToAction("Login", "Home", "Add", "edit");
        }

        [HttpGet]
        public IActionResult Feedback(int id)
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    gasStationView = new GasStationViewModels();
                    var result = _gasStationListFeedback.GetAllListFeedback().Where(x => x.GasStationId.Equals(id)).ToList(); // tìm id phù hợp
                    if (result.Count() == 0)
                    {
                        ViewData["MessageTable"] = "ガソリンスタンド{0}は削除されますか？";
                    }
                    ViewBag.CurrentPageView = CurrentPageView;
                    var countView = _gasStationListFeedback.GetAllListFeedback().Where(x => x.GasStationId == id).ToList().Count();
                    ViewBag.Page = (countView / PageSize) - (countView % PageSize == 0 ? 1 : 0);
                    gasStationView.GasStationFeedback = _gasStationList.GetAllStationtable().Where(x => x.GasStationId == id).FirstOrDefault();
                    gasStationView.lstGasStationFeedback = _gasStationListFeedback.GetAllListFeedback().Where(x => x.GasStationId.Equals(id)).Skip(CurrentPageView * PageSize).Take(PageSize).ToList();
                    return View(gasStationView);
                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult Feedback(int id,string SelectPage)
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    var result = _gasStationListFeedback.GetAllListFeedback().Where(x => x.GasStationId == id).ToList();
                    if (!string.IsNullOrEmpty(SelectPage))
                    {
                        var count = result.Count();
                        CurrentPageView = int.Parse(SelectPage);
                        ViewBag.CurrentPageView = CurrentPage;
                        ViewBag.Page = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
                    }
                    if(result.Count() == 0)
                    {
                        ViewData["MessageTable"] = "ガソリンスタンド{0}は削除されますか？";
                    }
                    ViewBag.CurrentPageView = CurrentPageView;
                    var countView = result.Count();
                    ViewBag.Page = (countView / PageSize) - (countView % PageSize == 0 ? 1 : 0);
                    gasStationView.GasStationFeedback = _gasStationList.GetAllStationtable().Where(x => x.GasStationId == id).FirstOrDefault();
                    gasStationView.lstGasStationFeedback = _gasStationListFeedback.GetAllListFeedback().Where(x => x.GasStationId.Equals(id)).Skip(CurrentPageView*PageSize).Take(PageSize).ToList();
                    return View(gasStationView);
                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
        public IActionResult Add()
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    if(gasStationView == null)
                    {
                        gasStationView = new GasStationViewModels();
                        gasStationView.lstDistricts = _district.GetAllDistrict();
                        gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();
                        gasStationView.lstRating = _rating.GetAllRating();
                        ViewBag.isCheckName = false;
                        return View(gasStationView);
                    }
                    else
                    {
                        gasStationView.GasStationAdd.InsertedBy = _session.Id;
                        ViewBag.isCheckName = _gasStationList.GetAllStationtable().Any(x => x.GasStationName.Equals(gasStationView.GasStationAdd.GasStationName));
                        if (ViewBag.isCheckName)
                        {
                            gasStationView.lstDistricts = _district.GetAllDistrict();
                            gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();
                            gasStationView.lstRating = _rating.GetAllRating();
                            return View(gasStationView);
                        }
                        var result = _gasStationList.Add(gasStationView);
                        if(result > 0)
                        {
                            return RedirectToAction("Index", "GasStation");
                        }
                    }
                    
                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Login", "Home");
        }

        public IActionResult Edit(int id)
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    if (gasStationView == null)
                    {
                        gasStationView = new GasStationViewModels();
                        gasStationView.GasStationAdd = _gasStationList.GetAllStationtable().Where(x => x.GasStationId == id).FirstOrDefault();
                        gasStationView.lstDistricts = _district.GetAllDistrict();
                        gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();
                        gasStationView.lstRating = _rating.GetAllRating();
                        ViewBag.isCheckName = false;
                        return View(gasStationView);
                    }
                    else
                    {
                        gasStationView.GasStationAdd.UpdatedBy = _session.Id;
                        var nameEdit = gasStationView.GasStationAdd.GasStationName;
                        var nameDB = _gasStationList.GetAllStationtable().Where(x => x.GasStationId == id).FirstOrDefault();
                        if(nameEdit == nameDB.GasStationName)
                        {
                            ViewBag.isCheckName = false;
                        }
                        else
                        {
                            ViewBag.isCheckName = _gasStationList.GetAllStationtable().Any(x => x.GasStationName.Equals(nameEdit));
                            if (ViewBag.isCheckName)
                            {
                                gasStationView.GasStationAdd = _gasStationList.GetAllStationtable().Where(x => x.GasStationId == id).FirstOrDefault();
                                gasStationView.lstDistricts = _district.GetAllDistrict();
                                gasStationView.lstGasStationType = _gasStationType.GetGasStationTypes();
                                gasStationView.lstRating = _rating.GetAllRating();
                                return View(gasStationView);
                            }
                        }
                        var result = _gasStationList.Update(gasStationView,id);
                        if (result > 0)
                        {
                            return RedirectToAction("Index", "GasStation");
                        }
                    }

                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
       
        public IActionResult Delete([FromQuery] int id)
        {
            var session = HttpContext.Session;
            String json = session.GetString(KeySession.KeyAccess);
            if (json != null)
            {
                var _session = JsonConvert.DeserializeObject<SessionModel>(json);
                if (_session != null && _session.UserName != null)
                {
                    if(id != null)
                    {
                        gasStationView = new GasStationViewModels();
                        gasStationView.DeleteBy = _session.Id.ToString();
                        _gasStationList.Remove(gasStationView, id);
                        return Content("ok");
                    }
                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
    }
}
