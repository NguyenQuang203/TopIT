using Microsoft.AspNetCore.Mvc;
using TopIT.Models;

namespace TopIT.Controllers
{
    public class JobManagementController : Controller
    {
        TblVieclam vl = new TblVieclam();
        public IActionResult ListJob(string filter)
        {
            
            if (filter != null)
            {
                List<TblVieclam> lsst=vl.SearchIob(filter);
                return View(lsst);
            }
            List<TblVieclam> lsstl = vl.GetAllJob();
            return View(lsstl);
        }


        public IActionResult DeleteJob(string Id)
        {
            vl.DelJob(Id);
            return RedirectToAction("ListJob");
        }

        public IActionResult DetailsJob(string Id)
        {
            TblVieclam uv = vl.DetailJob(Id);
            return View(uv);
        }

    }
}
