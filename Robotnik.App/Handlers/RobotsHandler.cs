namespace Robotnik.App.Handlers
{

    // Namespaces.
    using System.Web.Mvc;
    using System.Web.Routing;
    using Umbraco.Core;


    /// <summary>
    /// Handles events for the robots.txt.
    /// </summary>
    public class RobotsHandler : ApplicationEventHandler
    {

        #region Methods

        /// <summary>
        /// Application started.
        /// </summary>
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {

            // Variables.
            var routes = RouteTable.Routes;


            // Map routes.
            routes.MapRoute("Robotnik Robots.txt", "robots.txt", new
            {
                controller = "Robots",
                action = "Robots"
            });


            // Boilerplate.
            base.ApplicationStarted(umbracoApplication, applicationContext);

        }

        #endregion

    }

}