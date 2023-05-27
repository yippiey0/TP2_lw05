using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TP2_lw05.Controllers
{
    public class DatabaseController : Controller
    {
        private static DatabaseModel[] _data = new DatabaseModel[0];

        public IActionResult Index()
        {
            return View(_data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DatabaseModel model)
        {
            if (ModelState.IsValid)
            {
                Array.Resize(ref _data, _data.Length + 1);
                _data[_data.Length - 1] = model;
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Details(int id)
        {
            if (id >= 0 && id < _data.Length)
            {
                var model = _data[id];
                return View(model);
            }
            return NotFound();
        }

        public IActionResult Edit(int id)
        {
            if (id >= 0 && id < _data.Length)
            {
                var model = _data[id];
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(int id, DatabaseModel updatedModel)
        {
            if (ModelState.IsValid)
            {
                if (id >= 0 && id < _data.Length)
                {
                    _data[id] = updatedModel;
                    return RedirectToAction("Index");
                }
                return NotFound();
            }
            return View(updatedModel);
        }
    }


}
