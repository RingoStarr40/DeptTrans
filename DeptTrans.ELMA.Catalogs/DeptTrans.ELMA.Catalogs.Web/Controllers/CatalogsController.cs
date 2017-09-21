using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeptTrans.ELMA.Catalogs.Models;
using EleWise.ELMA.BPM.Web.Common;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using Orchard.UI.Notify;

namespace DeptTrans.ELMA.Catalogs.Web.Controllers
{
    public class CatalogsController : EntityBaseController
    {
        /// <summary>
        /// Сохранение записи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Save(CatalogItemModel model)
        {
            /*
             * Нужно выводить информацию при ошибках в серверной валидации. Сейчас почему-то не выводится. Поэтому серверная валидация убрана.
            if (!ModelState.IsValid)
            {
                if (model.InPopUp)
                {
                    return Json(new { error = SR.T("Не заполнены все обязательные поля") }, JsonRequestBehavior.AllowGet);
                }
                Notifier.Information(SR.T("Не заполнены все обязательные поля"));
                var template = "Add";
                return View(template, model);
            }
             */
            var entityType = IMetadataRuntimeService.GetTypeByUid(model.TypeUid);
            var manager = ModelHelper.GetEntityManager(entityType);
            try
            {
                manager.Save(model.Entity);
            }
            catch (Exception ex)
            {
                Locator.GetServiceNotNull<IUnitOfWorkManager>().RollbackCurrent("");
                Notifier.Error(ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message) ? ex.InnerException.Message : ex.Message);
                return !IsCreatorRequest() ? View("Add", model) : CreatorJson(model.Entity, ex.Message);
            }
            if (IsCreatorRequest())
                return CreatorJson(model.Entity);
            if (model.InPopUp)
                return Json(new { model.Continue }, JsonRequestBehavior.AllowGet);
            if (!string.IsNullOrEmpty(model.BackUrl))
            {
                var filter = InterfaceActivator.Create<IDeptTrans_CatalogFilter>();
                var entityType1 = new ReferenceOnEntityType { TypeUid = model.TypeUid };
                filter.Spravochnik = entityType1;
                //filter.TypeUidSpravochnika = model.TypeUid;
                var listMyEntity = EntityManager<IDeptTrans_Catalog>.Instance.Find(filter, null);
                if (listMyEntity.Any())
                {
                    var newUrl = GenerateViewItemUrl(model.TypeUid, model.Entity.GetId(), null, null);
                    return Redirect(newUrl);
                }
                else
                {
                    return Redirect(model.BackUrl);
                }
            }
            return RedirectToAction("View", new { area = CommonAreaRegistration.AREA_NAME, uid = model.TypeUid });
        }

        private string GenerateViewItemUrl(Guid uid, object objectId, object parentId, long? filterId)
        {
            return Url.Action("ViewItem", "Catalogs", new
            {
                area = "EleWise.ELMA.BPM.Web.Common",
                uid,
                id = objectId,
                backUrl = Url.Action("View", "Catalogs", new { area = "EleWise.ELMA.BPM.Web.Common", uid, parentId, filterId })
            });
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
