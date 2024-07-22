﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVCRealEstate.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
