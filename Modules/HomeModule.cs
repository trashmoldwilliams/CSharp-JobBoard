using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];

      // Get["/view_all_jobs"] = _ => {
      //   List<string> allTasks = JobOpening.GetAll();
      //   return View["view_all_jobs.cshtml", allJobs];
      // };
      // Post["/tasks_cleared"] = _ => {
      //   Task.ClearAll();
      //   return View["tasks_cleared.cshtml"];
      // };

      Post["/job_added"] = _ => {
        contactInfo newContact = new contactInfo();
        newContact.Contact(Request.Form["name"], Request.Form["email"], Request.Form["phone-number"]);
        JobOpening newJobOpening = new JobOpening();
        newJobOpening.Job(Request.Form["title"], Request.Form["description"], newContact);
        newJobOpening.Save();
        return View["job_added.cshtml", newJobOpening];
      };
    }
  }
}
