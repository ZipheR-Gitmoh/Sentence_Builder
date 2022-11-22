using Microsoft.AspNetCore.Mvc;
using Sentence_Builder.Models;
using System.Diagnostics;
using Sentence_Builder_Backend;
//using Sentence_Builder.Models;

namespace Sentence_Builder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public Sentence SentenceBL = new Sentence();
        public string sentence = string.Empty;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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


        [HttpGet]
        public IActionResult GetWordList(int wordType)
        {
            List<string> wordTypes = SentenceBL.GetWordsByType(wordType);

            return View();
        }

        public string AddWordToSentence(string word) => sentence = sentence + " " + word;

        public IActionResult OnSubmitSentence(string sentence)
        {
            List<string> sentences = SentenceBL.SaveSentence(sentence);

            return View();
        }
    }
}