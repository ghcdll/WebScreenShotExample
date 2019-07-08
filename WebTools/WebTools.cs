using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WebTools
{
    public class AlxWeb
    {
        //https://www.codeproject.com/Articles/1020939/Take-screenshots-of-websites-for-different-screen
        /// <summary>
        /// Take screenshot of a page
        /// </summary>
        /// <param name="url">target url</param>
        /// <param name="pngSaveLocation">save path</param>
        /// <returns>status of saving file</returns>
        public bool CreateWebsiteScreenshot(string url, string pngSaveLocation)
        {
            try
            {  
                Alx.Web.Screenshot.Save(url, pngSaveLocation, System.Drawing.Imaging.ImageFormat.Png, Alx.Web.Devices.Desktop);
                if (File.Exists(pngSaveLocation))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                return false;
            }

        }
    }

    public class FreezerLib
    {
        //https://github.com/haga-rak/Freezer/wiki
        /// <summary>
        /// Take screenshot of a page
        /// </summary>
        /// <param name="url">target url</param>
        /// <param name="pngSaveLocation">save path</param>
        /// <returns>status of saving file</returns>
        public bool CreateWebsiteScreenshot(string url, string pngSaveLocation)
        {
            try
            {
                var screenshotJob = Freezer.Core.ScreenshotJobBuilder.Create(url)
               .SetBrowserSize(1920, 1080) // Screen size for Dell XPS12
               .SetCaptureZone(Freezer.Core.CaptureZone.FullPage) // Set what should be captured
               .SetTrigger(new Freezer.Core.WindowLoadTrigger()); // Set when the picture is taken

                File.WriteAllBytes(pngSaveLocation, screenshotJob.Freeze());
                if (File.Exists(pngSaveLocation))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {
                return false;
            }

        }
    }
}
