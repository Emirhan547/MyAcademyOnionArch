using Microsoft.AspNetCore.Mvc;
using OnionApp.WebUI.Dtos.StatisticsDtos;
using OnionApp.WebUI.Services.StatisticsServices;

namespace OnionApp.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        public async Task<IActionResult> Index()
        {
            var carCountTask = _statisticsService.GetCarCount();
            var locationCountTask = _statisticsService.GetLocationCount();
            var authorCountTask = _statisticsService.GetAuthorCount();
            var blogCountTask = _statisticsService.GetBlogCount();
            var brandCountTask = _statisticsService.GetBrandCount();
            var avgDailyTask = _statisticsService.GetAvgRentPriceForDaily();
            var avgWeeklyTask = _statisticsService.GetAvgRentPriceForWeekly();
            var avgMonthlyTask = _statisticsService.GetAvgRentPriceForMonthly();
            var autoCarTask = _statisticsService.GetCarCountByTranmissionIsAuto();
            var maxBrandTask = _statisticsService.GetBrandNameByMaxCar();
            var maxBlogTask = _statisticsService.GetBlogTitleByMaxBlogComment();
            var kmTask = _statisticsService.GetCarCountByKmSmallerThen1000();
            var fuelTask = _statisticsService.GetCarCountByFuelGasolineOrDiesel();
            var electricTask = _statisticsService.GetCarCountByFuelElectric();
            var maxPriceTask = _statisticsService.GetCarBrandAndModelByRentPriceDailyMax();
            var minPriceTask = _statisticsService.GetCarBrandAndModelByRentPriceDailyMin();

            await Task.WhenAll(
                carCountTask, locationCountTask, authorCountTask,
                blogCountTask, brandCountTask,
                avgDailyTask, avgWeeklyTask, avgMonthlyTask,
                autoCarTask, maxBrandTask, maxBlogTask,
                kmTask, fuelTask, electricTask,
                maxPriceTask, minPriceTask
            );

          
            ViewBag.v = carCountTask.Result;
            ViewBag.locationCount = locationCountTask.Result;
            ViewBag.authorCount = authorCountTask.Result;
            ViewBag.blogCount = blogCountTask.Result;
            ViewBag.brandCount = brandCountTask.Result;

            ViewBag.avgRentPriceForDaily = avgDailyTask.Result;
            ViewBag.avgRentPriceForWeekly = avgWeeklyTask.Result;
            ViewBag.avgRentPriceForMonthly = avgMonthlyTask.Result;

            ViewBag.carCountByTranmissionIsAuto = autoCarTask.Result;
            ViewBag.brandNameByMaxCar = maxBrandTask.Result;
            ViewBag.blogTitleByMaxBlogComment = maxBlogTask.Result;

            ViewBag.carCountByKmSmallerThen1000 = kmTask.Result;
            ViewBag.carCountByFuelGasolineOrDiesel = fuelTask.Result;
            ViewBag.carCountByFuelElectric = electricTask.Result;

            ViewBag.carBrandAndModelByRentPriceDailyMax = maxPriceTask.Result;
            ViewBag.carBrandAndModelByRentPriceDailyMin = minPriceTask.Result;

          

            return View();
        }
    }
}