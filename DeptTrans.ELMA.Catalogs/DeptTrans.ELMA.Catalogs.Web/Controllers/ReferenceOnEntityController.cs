using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace DeptTrans.ELMA.Catalogs.Web.Controllers
{
    public class ReferenceOnEntityController : Controller
    {
        //
        // GET: /ReferenceOnEntity/
        public ActionResult GetAllTypes(string text)
        {
            var metadataList = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
                .OfType<EntityMetadata>()
                .Where(m => (m.Type == EntityMetadataType.Interface || m.Type == EntityMetadataType.Entity)
                            && (string.IsNullOrEmpty(text) || m.DisplayName.ToUpper().Contains(text.ToUpper())))
                .Select(m => new
                {
                    DropDownText = m.DisplayName,
                    Value = m.ImplementationUid,
                    ViewText = m.DisplayName,
                    Text = m.DisplayName
                }).ToList();
            return new JsonResult { Data = metadataList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
