using System.Web.Mvc;
using RadaCode.MVCx.App_Start;
using RadaCode.MVCx.Application;

[assembly: WebActivator.PreApplicationStartMethod(typeof(RadaCodeWebCommon), "Start")]

namespace RadaCode.MVCx.App_Start
{
    public class RadaCodeWebCommon
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RadaCodeViewEngine());
        }
    }
}