using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace bikeStore
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptResourceDefinition myRef = new ScriptResourceDefinition();
            myRef.Path = "~/Script/jquery-3.6.0.min.js";
            myRef.DebugPath = "~/Script/jquery-3.6.0.js";
            myRef.CdnPath = "http://ajax.microsoft.com/ajax/jquery/jquery-3.6.0.min.js";
            myRef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jquery/jquery-3.6.0.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myRef);


        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}