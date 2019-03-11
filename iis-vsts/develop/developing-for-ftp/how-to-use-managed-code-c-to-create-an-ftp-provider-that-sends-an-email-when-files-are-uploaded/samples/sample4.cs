using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;
using Microsoft.Web.FtpServer;

public sealed class FtpMailDemo : BaseProvider, IFtpLogProvider
{
  private string smtpServerName;
  private string smtpFromAddress;
  private string smtpToAddress;
  private int smtpServerPort;

  // Override the default initialization method.
  protected override void Initialize(StringDictionary config)
  {
    // Retrieve the provider settings from configuration.
    smtpServerName = config["smtpServerName"];
    smtpFromAddress = config["smtpFromAddress"];
    smtpToAddress = config["smtpToAddress"];
    
    // Detect and handle any mis-configured settings.
    if (!int.TryParse(config["smtpServerPort"], out smtpServerPort))
    {
      smtpServerPort = 25;
    }
    if (string.IsNullOrEmpty(smtpServerName))
    {
      throw new ArgumentException(
        "Missing smtpServerName value in configuration.");
    }
    if (string.IsNullOrEmpty(smtpFromAddress))
    {
      throw new ArgumentException(
        "Missing smtpFromAddress value in configuration.");
    }
    if (string.IsNullOrEmpty(smtpToAddress))
    {
      throw new ArgumentException(
        "Missing smtpToAddress value in configuration.");
    }
  }

  // Implement the logging method.
  void IFtpLogProvider.Log(FtpLogEntry loggingParameters)
  {
    // Test for a file upload operation.
    if (loggingParameters.Command == "STOR")
    {
      // Create an SMTP message.
      SmtpClient smtpClient =
        new SmtpClient(smtpServerName, smtpServerPort);
      MailAddress mailFromAddress =
        new MailAddress(smtpFromAddress);
      MailAddress mailToAddress = new
        MailAddress(smtpToAddress);
      using (MailMessage mailMessage =
        new MailMessage(mailFromAddress, mailToAddress))
      {
        // Format the SMTP message as UTF8.
        mailMessage.BodyEncoding = Encoding.UTF8;
        // Test for a successful operation.
        if (loggingParameters.FtpStatus == 226)
        {
          // Create a customized message for a successful operation.
          mailMessage.Subject = "File Uploaded Successfully";
          mailMessage.Body = loggingParameters.UserName +
            " successfully uploaded a file to " +
            loggingParameters.FullPath;
        }
        else
        {
          // Create a customized message for a failed operation.
          mailMessage.Subject = "File Operation Status";
          mailMessage.Body =
            "The FTP service returned a status of " +
            loggingParameters.FtpStatus + "." +
            loggingParameters.FtpSubStatus +
            " when " + loggingParameters.UserName +
            " attempted to upload a file to " +
            loggingParameters.FullPath;
        }
        try
        {
          // Send the email message.
          smtpClient.Send(mailMessage);
        }
        catch (SmtpException ex)
        {
          // Send an exception message to the debug
          // channel if the email fails to send.
          Debug.WriteLine(ex.Message.ToString());
        }
      }
    }
  }
}