using System.EnterpriseServices;
using System.Linq;
using System.Web.Mvc;
using MusicDbFirst.DAL;

namespace MusicDbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusicRespository _repository;
        public HomeController(IMusicRespository respository)
        {
            _repository = respository;
        }

        public ActionResult Index()
        {
            return View(_repository.GetAllAlbums());
        }

        public ActionResult GetTracks(int albumId)
        {
            var tracks = _repository.GetTracksForAlbum(albumId);
            return PartialView("_Tracks", tracks);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
