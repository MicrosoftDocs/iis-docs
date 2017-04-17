using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
          
namespace IIS7Demos
{
    public class imageCopyrightHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string message = "Copyright © IIS 7.0 Team";
            try            {
                string languageHeader;
         languageHeader = context.Request.Headers["Accept-Language"].Substring(0,2).ToUpper();
                switch (languageHeader)
                {
                    case ("DE"):
                        message = "IIS 7.0 Team - Alle Rechte vorbehalten";
                        break;
                    case ("ES"):
                        message = "Marca Registrada IIS 7.0 Team";
                        break;
                    default:
                        break;
                }
            }
            catch 
           { 
                // if something fails, e.g. no Language-Accept header, we go with the english message 
           }
            InsertCopyrightMessage (   context, 
                            message, 
                            "yellow"                            
                        );
        }
        void InsertCopyrightMessage(
                            HttpContext context, 
                            string message, 
                            string color
                         )
        {
            try 
            {
                // get physical path of request 
                string strPath = context.Request.PhysicalPath;
                // load as bitmap 
                Bitmap jpgFile = new Bitmap(strPath);
                // add copyright message 
                Graphics g = Graphics.FromImage(jpgFile);
                Font f = new Font("Arial", 20, GraphicsUnit.Pixel);
                SolidBrush sb = new SolidBrush(Color.FromName(color));
                // write copyright message to bitmap 
                g.DrawString(   message, 
                                f, 
                                sb, 
                                5, 
                                jpgFile.Height - f.Height - 5
                            );
                f.Dispose();
                g.Dispose();

                // save it to response stream 
                jpgFile.Save(   context.Response.OutputStream, 
                                System.Drawing.Imaging.ImageFormat.Jpeg
                            );
                jpgFile.Dispose();
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