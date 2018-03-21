using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory;
using Inventory.Models;

namespace Machine.Controllers
{
    [Authorize]
    public class MachineController : Controller
    {
        public void SetupViewBag()
        {
            using (var machineContext = new InventoryContext())
            {
                ViewBag.MachineTypes = new SelectList(
                    machineContext.MachineTypes.ToList(),
                    "TypeId",
                    "TypeName"
                );
            }
        }
        //List
        public ActionResult Index()
        {
            using (var machineContext = new InventoryContext())
            {
                var machineList = new MachineListViewModel
                {
                    Machines = machineContext.Machines.Select(m => new MachineViewModel
                    {
                        MachineId = m.MachineId,
                        MachineNum = m.MachineNum,
                        MachineMake = m.MachineMake,
                        MachineModel = m.MachineModel,
                        TypeName = m.MachineType.TypeName,
                        TypeId = m.TypeId,
                        Hours = m.Hours,
                        Notes = m.Notes,
                        Status = m.Status,
                        Photo = m.Photo
                    }).ToList()
                };

                return View(machineList);
            }


        }
        //Detail
        public ActionResult MachineDetail(int id)
        {
            using (var machineContext = new InventoryContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == id);
                if (machine != null)
                {
                    var machineViewModel = new MachineViewModel
                    {
                        MachineId = machine.MachineId,
                        MachineNum = machine.MachineNum,
                        MachineMake = machine.MachineMake,
                        MachineModel = machine.MachineModel,
                        TypeId = machine.TypeId,
                        Hours = machine.Hours,
                        Notes = machine.Notes,
                        Status = machine.Status,
                        Photo = machine.Photo
                    };
                    return View(machineViewModel);
                }
            }

            return new HttpNotFoundResult();
        }
        //Add
        public ActionResult MachineAdd()
        {
            SetupViewBag();

            var machineViewModel = new MachineViewModel();

            return View("AddEditMachine", machineViewModel);
        }
        //Add Post
        [HttpPost]
        public ActionResult AddMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var machine = new Inventory.Models.Machine
                {
                    MachineNum = machineViewModel.MachineNum.Value,
                    MachineMake = machineViewModel.MachineMake,
                    MachineModel = machineViewModel.MachineModel,
                    TypeId = machineViewModel.TypeId,
                    Hours = machineViewModel.Hours.Value,
                    Notes = machineViewModel.Notes,
                    Status = machineViewModel.Status,
                    Photo = machineViewModel.Photo
                };

                machineContext.Machines.Add(machine);
                machineContext.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        //Edit
        public ActionResult MachineEdit(int id)
        {
            SetupViewBag();
            using (var machineContext = new InventoryContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == id);
                if (machine != null)
                {
                    var machineViewModel = new MachineViewModel
                    {
                        MachineId = machine.MachineId,
                        MachineNum = machine.MachineNum,
                        MachineMake = machine.MachineMake,
                        MachineModel = machine.MachineModel,
                        TypeId = machine.TypeId,
                        Hours = machine.Hours,
                        Notes = machine.Notes,
                        Status = machine.Status,
                        Photo = machine.Photo

                    };

                    return View("AddEditMachine", machineViewModel);
                }

                return new HttpNotFoundResult();
            }

        }
        //Edit Post
        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

                if (machine != null)
                {
                    machine.MachineNum = machineViewModel.MachineNum.Value;
                    machine.MachineMake = machineViewModel.MachineMake;
                    machine.MachineModel = machineViewModel.MachineModel;
                    machine.TypeId = machineViewModel.TypeId;
                    machine.Hours = machineViewModel.Hours.Value;
                    machine.Notes = machineViewModel.Notes;
                    machine.Status = machineViewModel.Status;
                    machine.Photo = machineViewModel.Photo;
                    machineContext.SaveChanges();


                    return RedirectToAction("Index");
                }

                return new HttpNotFoundResult();
            }

        }
        //Delete
        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(m => m.MachineId == machineViewModel.MachineId);

                if (machine != null)
                {
                    machineContext.Machines.Remove(machine);

                    machineContext.SaveChanges();

                    return RedirectToAction("Index");

                }

                return new HttpNotFoundResult();

            }

        }
    }
}