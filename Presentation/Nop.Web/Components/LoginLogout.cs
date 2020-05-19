using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Customers;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class LoginLogout : NopViewComponent
    {
        private readonly IWorkContext _workContext;

        public LoginLogout(IWorkContext workContext)
        {
            _workContext = workContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.isLogin = _workContext.CurrentCustomer.IsRegistered();
            return View();
        }
    }
}
