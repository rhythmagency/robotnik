namespace Robotnik.App.Controllers
{

    // Namespaces.
    using System.Net.Mime;
    using System.Web.Configuration;
    using System.Web.Mvc;
    using IoFile = System.IO.File;


    /// <summary>
    /// Controller for the robots.txt.
    /// </summary>
    public class RobotsController : Controller
    {

        #region Constants

        private const string Prefix = "robotnik-";
        private const string DefaultKey = "robotnik-default";
        private const string PlainText = MediaTypeNames.Text.Plain;

        #endregion


        #region Action Methods

        /// <summary>
        /// Returns the robots.txt for the current domain.
        /// </summary>
        /// <returns>The robots.txt file (or a 404 not found).</returns>
        public ActionResult Robots()
        {

            // Variables.
            var host = Request.Url.Host;
            var key = (Prefix + host).ToLowerInvariant();


            // Try to get the path.
            var path = GetValue(key) ?? GetValue(DefaultKey);
            if (!string.IsNullOrWhiteSpace(path))
            {
                var localPath = Request.MapPath(path);
                if (IoFile.Exists(localPath))
                {
                    return File(localPath, PlainText);
                }
            }


            // Return 404 not found.
            return HttpNotFound();

        }

        #endregion


        #region Helper Methods

        /// <summary>
        /// Attempts to get a value from the "appSettings" in the web.config.
        /// </summary>
        /// <param name="key">The key of the value.</param>
        /// <returns>The value, if found; otherwise, null.</returns>
        private string GetValue(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        #endregion

    }

}