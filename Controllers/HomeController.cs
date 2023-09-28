using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Vhenuz Lagasca", StudentId = "S001", StudentAge = "21" },
            new StudentInfoModel { Name = "Vhincent Lagasca", StudentId = "S002", StudentAge = "23" },
            new StudentInfoModel { Name = "Sasuke", StudentId = "S003", StudentAge = "5" },
            new StudentInfoModel { Name = "Sachi", StudentId = "S004", StudentAge = "3" },
            new StudentInfoModel { Name = "Pancho", StudentId = "S005", StudentAge = "3" },
            new StudentInfoModel { Name = "Tigrous", StudentId = "S006", StudentAge = "2" },
        };

        return View(studentInfoArray);
    }
}
