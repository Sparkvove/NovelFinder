using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NovelFinder.Data;
using NovelFinder.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NovelFinder.Controllers
{
    public class NovelsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NovelsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Novels.ToList());
        }

        [HttpGet]
        public IActionResult RefreshNovels()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoadDataFromJson()
        {
            
            List<Novel> novels = new List<Novel>();
            using (StreamReader r = new StreamReader("LightNovelPubNovels.txt"))
            {
                string json = r.ReadToEnd();
                novels = JsonConvert.DeserializeObject<List<Novel>>(json);
            }
            foreach(var novel in novels)
            {
                _db.Add(novel);
                _db.SaveChanges();
            }
           
            
            return Redirect("Index");
        }
    }
}
