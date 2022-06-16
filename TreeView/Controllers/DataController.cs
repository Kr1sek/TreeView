using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using TreeView.Models;
using Microsoft.AspNetCore.Mvc;
using TreeView.Repositories;

namespace TreeView.Controllers
{
    public class DataController : Controller
    {
        private readonly IDataRepository _dataRepository;
        public DataController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: DataController
        public ActionResult Index()
        {
            
            return View(_dataRepository.GetAll());
        }


        public ActionResult Create()
        {
            return View(new DataModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataModel data)
        {
            _dataRepository.Add(data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            return View(_dataRepository.Get(id));
        }


        [HttpPost]
        public ActionResult Edit(int id, DataModel oldData)
        {
            _dataRepository.Update(id, oldData);

            return RedirectToAction(nameof(Index));

        }

        public ActionResult Delete(int id)
        {
            return View(_dataRepository.Get(id));
        }

        // POST: test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DataModel oldData)
        {
            _dataRepository.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
