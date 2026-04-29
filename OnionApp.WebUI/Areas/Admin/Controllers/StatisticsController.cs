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

            ViewBag.v = carCountTask.Result.Data;
            ViewBag.locationCount = locationCountTask.Result.Data;
            ViewBag.authorCount = authorCountTask.Result.Data;
            ViewBag.blogCount = blogCountTask.Result.Data;
            ViewBag.brandCount = brandCountTask.Result.Data;

            ViewBag.avgRentPriceForDaily = avgDailyTask.Result.Data;
            ViewBag.avgRentPriceForWeekly = avgWeeklyTask.Result.Data;
            ViewBag.avgRentPriceForMonthly = avgMonthlyTask.Result.Data;

            ViewBag.carCountByTranmissionIsAuto = autoCarTask.Result.Data;
            ViewBag.brandNameByMaxCar = maxBrandTask.Result.Data;
            ViewBag.blogTitleByMaxBlogComment = maxBlogTask.Result.Data;

            ViewBag.carCountByKmSmallerThen1000 = kmTask.Result.Data;
            ViewBag.carCountByFuelGasolineOrDiesel = fuelTask.Result.Data;
            ViewBag.carCountByFuelElectric = electricTask.Result.Data;

            ViewBag.carBrandAndModelByRentPriceDailyMax = maxPriceTask.Result.Data;
            ViewBag.carBrandAndModelByRentPriceDailyMin = minPriceTask.Result.Data;

            return View();
        }
    }
}