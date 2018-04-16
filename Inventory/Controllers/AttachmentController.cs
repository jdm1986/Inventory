﻿using Inventory.Models;
using System.Linq;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    [Authorize]
    public class AttachmentController : Controller
    {
        public void SetupViewBag()
        {
            using (var machineContext = new InventoryContext())
            {
                ViewBag.AttachmentTypes = new SelectList(
                    machineContext.AttachmentTypes.ToList(),
                    "TypeId",
                    "TypeName"
                );
            }
        }
        //List - view table laying out properties in each AttachmentViewModel
        public ActionResult Index()
        {
            using (var machineContext = new InventoryContext())
            {
                var attachmentList = new AttachmentListViewModel
                {
                    Attachments = machineContext.Attachments.Select(m => new AttachmentViewModel
                    {
                        AttachmentId = m.AttachmentId,
                        AttachmentNum = m.AttachmentNum,
                        AttachmentMake = m.AttachmentMake,
                        AttachmentModel = m.AttachmentModel,
                        TypeName = m.AttachmentType.TypeName,
                        TypeId = m.TypeId,
                        Notes = m.Notes,
                        Status = m.Status,
                        Photo = m.Photo
                    }).ToList()
                };

                return View(attachmentList);
            }


        }
        //Detail - grab Machine model where model Id == AttachmentViewModel Id
        public ActionResult AttachmentDetail(int id)
        {
            using (var machineContext = new InventoryContext())
            {
                var attachment = machineContext.Attachments.SingleOrDefault(m => m.AttachmentId == id);
                if (attachment != null)
                {
                    var attachmentViewModel = new AttachmentViewModel
                    {
                        AttachmentId = attachment.AttachmentId,
                        AttachmentNum = attachment.AttachmentNum,
                        AttachmentMake = attachment.AttachmentMake,
                        AttachmentModel = attachment.AttachmentModel,
                        TypeId = attachment.TypeId,
                        Notes = attachment.Notes,
                        Status = attachment.Status,
                        Photo = attachment.Photo
                    };
                    return View(attachmentViewModel);
                }
            }

            return new HttpNotFoundResult();
        }
        //Add AttachemntViewModel
        public ActionResult AttachmentAdd()
        {
            SetupViewBag();

            var attachmentViewModel = new AttachmentViewModel();

            return View("AddEditAttachment", attachmentViewModel);
        }
        //Add Post - add Attachment model where model Id == AttachemntViewModel
        [HttpPost]
        public ActionResult AddAttachment(AttachmentViewModel attachmentViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var attachment = new Inventory.Models.Attachment
                {
                    AttachmentNum = attachmentViewModel.AttachmentNum,
                    AttachmentMake = attachmentViewModel.AttachmentMake,
                    AttachmentModel = attachmentViewModel.AttachmentModel,
                    TypeId = attachmentViewModel.TypeId,
                    Notes = attachmentViewModel.Notes,
                    Status = attachmentViewModel.Status,
                    Photo = attachmentViewModel.Photo
                };

                machineContext.Attachments.Add(attachment);
                machineContext.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        //Edit AttachmentViewModel
        public ActionResult AttachmentEdit(int id)
        {
            SetupViewBag();
            using (var machineContext = new InventoryContext())
            {
                var attachment = machineContext.Attachments.SingleOrDefault(m => m.AttachmentId == id);
                if (attachment != null)
                {
                    var attachmentViewModel = new AttachmentViewModel
                    {
                        AttachmentId = attachment.AttachmentId,
                        AttachmentNum = attachment.AttachmentNum,
                        AttachmentMake = attachment.AttachmentMake,
                        AttachmentModel = attachment.AttachmentModel,
                        TypeId = attachment.TypeId,
                        Notes = attachment.Notes,
                        Status = attachment.Status,
                        Photo = attachment.Photo

                    };

                    return View("AddEditAttachment", attachmentViewModel);
                }

                return new HttpNotFoundResult();
            }

        }
        //Edit Post - Edit Attachment model where model Id == AttachmentViewModel Id
        [HttpPost]
        public ActionResult EditAttachment(AttachmentViewModel attachmentViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var attachment = machineContext.Attachments.SingleOrDefault(m => m.AttachmentId == attachmentViewModel.AttachmentId);

                if (attachment != null)
                {
                    attachment.AttachmentNum = attachmentViewModel.AttachmentNum;
                    attachment.AttachmentMake = attachmentViewModel.AttachmentMake;
                    attachment.AttachmentModel = attachmentViewModel.AttachmentModel;
                    attachment.TypeId = attachmentViewModel.TypeId;
                    attachment.Notes = attachmentViewModel.Notes;
                    attachment.Status = attachmentViewModel.Status;
                    attachment.Photo = attachmentViewModel.Photo;
                    machineContext.SaveChanges();


                    return RedirectToAction("Index");
                }

                return new HttpNotFoundResult();
            }

        }
        //Delete Attachment model where model Id == AttachmentViewModel Id
        [HttpPost]
        public ActionResult DeleteAttachment(AttachmentViewModel attachmentViewModel)
        {
            using (var machineContext = new InventoryContext())
            {
                var attachment = machineContext.Attachments.SingleOrDefault(m => m.AttachmentId == attachmentViewModel.AttachmentId);

                if (attachment != null)
                {
                    machineContext.Attachments.Remove(attachment);

                    machineContext.SaveChanges();

                    return RedirectToAction("Index");

                }

                return new HttpNotFoundResult();

            }

        }
    }
}