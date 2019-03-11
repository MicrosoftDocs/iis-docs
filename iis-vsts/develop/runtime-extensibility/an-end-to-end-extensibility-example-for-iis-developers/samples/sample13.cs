#region Using directives
using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.Web.Administration;
#endregion
  
namespace IIS7Demos
{
    public class imageCopyrightHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            ConfigurationSection imageCopyrightHandlerSection = 
                WebConfigurationManager.GetSection("system.webServer/imageCopyright");
  
            HandleImage(    context,
                            (bool)imageCopyrightHandlerSection.Attributes["enabled"].Value,
                            (string)imageCopyrightHandlerSection.Attributes["message"].Value,
                            (string)imageCopyrightHandlerSection.Attributes["color"].Value                            
                        );
        }
  
        void HandleImage(   HttpContext context,
                            bool enabled,
                            string copyrightText,
                            string color
                        )           
        {
            try
            {
                string strPath = context.Request.PhysicalPath;
                if (enabled)
                {
                    Bitmap bitmap = new Bitmap(strPath);
                    // add copyright message
                    Graphics g = Graphics.FromImage(bitmap);
                    Font f = new Font("Arial", 50, GraphicsUnit.Pixel);
                    SolidBrush sb = new SolidBrush(Color.FromName(color));
                    g.DrawString(   copyrightText,
                                    f,
                                    sb,
                                    5,
                                    bitmap.Height - f.Height - 5
                                );
                    f.Dispose();
                    g.Dispose();
                    // slow, but good looking resize for large images
                    context.Response.ContentType = "image/jpeg";
                    bitmap.Save(
                                        context.Response.OutputStream,
                                        System.Drawing.Imaging.ImageFormat.Jpeg
                                     );
                    bitmap.Dispose();
                }
                else
                {
                    context.Response.WriteFile(strPath);
                }
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
            }
        }
  
        public bool IsReusable
        {
            get { return true; }
        }
    }
}