using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;
using Shopping.Client.Models;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient("ShoppingAPI");
        }

        public async Task<IActionResult> Index()
        {
            // need to call the api
            var response = await _httpClient.GetAsync("/product");
            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Failed to fetch products from API.");
                return View("Error");
            }
            var products = await response.Content.ReadAsStringAsync();
            var productList = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Product>>(products, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
