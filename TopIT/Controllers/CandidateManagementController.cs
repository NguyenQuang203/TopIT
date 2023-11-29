using Microsoft.AspNetCore.Mvc;
using TopIT.Models;

namespace TopIT.Controllers
{
    public class CandidateManagementController : Controller
    {
        TblUngvien uv=new TblUngvien();
        public IActionResult ListCandidate()
        {
            List<TblUngvien> lst=uv.GetAllCandidate();
            return View(lst);
        }

        public IActionResult DeleteCandidate(string Id)
        {
            uv.DelCandidate(Id);
            return RedirectToAction("ListCandidate");
        }

        public IActionResult DetailsCandidate(string Id)
        {
            TblUngvien uvv = uv.DetailCandidate(Id);
            return View(uvv);
        }


    }
}
