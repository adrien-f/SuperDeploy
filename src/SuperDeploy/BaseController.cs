using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace SuperDeploy
{
    public enum AlertTypes 
    {
        Success, Danger
    }

    public class BaseController : Controller
    {
        public void Success(string message)
        {
            AddAlert(AlertTypes.Success, message);
        }

        public void Danger(string message)
        {
            AddAlert(AlertTypes.Danger, message);
        }

        private void AddAlert(AlertTypes alertType, string message)
        {
            var ErrorsAlerts = TempData.ContainsKey("ErrorsAlerts") ? (Dictionary<string, string>) TempData["Errors"] : new Dictionary<string, string>();
            var SuccessAlerts = TempData.ContainsKey("SuccessAlerts") ? (Dictionary<string, string>) TempData["Errors"] : new Dictionary<string, string>();
            
            if (alertType == AlertTypes.Success)
            {
                SuccessAlerts.Add(Guid.NewGuid().ToString("N"), message);
            } else {
                ErrorsAlerts.Add(Guid.NewGuid().ToString("N"), message);
            }
            TempData["ErrorsAlert"] = ErrorsAlerts;
            TempData["SuccessAlerts"] = SuccessAlerts;
        }

    }
}
