using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using architecture.Service;

namespace architecture.Controllers
{
    public class WeatherController : Controller
    {
        private ILocalWeatherService _localWeatherService;
        private IFaceBookManager _faceBookManager;


        public WeatherController(ILocalWeatherService localWeatherService,IFaceBookManager faceBookManager)
        {
            _localWeatherService = localWeatherService;
            _faceBookManager = faceBookManager;
        }


        // GET: Weather
        public ActionResult Index()
        {

            if (_faceBookManager.AuthenticateUser())
            {
                string weather = _localWeatherService.GetLocalWeatherByZip("12400");
            }

            return View();
        }
    }
}