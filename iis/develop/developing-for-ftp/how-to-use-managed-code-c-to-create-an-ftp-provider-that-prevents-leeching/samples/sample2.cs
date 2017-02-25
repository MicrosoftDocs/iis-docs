using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.Web.FtpServer;

public class FtpLeechPrevention :
  BaseProvider,
  IFtpPreprocessProvider,
  IFtpPostprocessProvider,
  IFtpLogProvider
{
  private static Dictionary<string, int> _sessionList = null;
  private static int _maxDownloads = 1;

  protected override void Initialize(StringDictionary config)
  {
    // Test if the dictionary has been created.
    if (_sessionList == null)
    {
      // Create the dictionary if it hasn't been created.
      _sessionList = new Dictionary<string, int>();
    }
    // Retrieve the max downloads from configuration.
    if (string.IsNullOrEmpty(config["MaxDownloads"]) == false)
      _maxDownloads = Convert.ToInt16(config["MaxDownloads"]);
  }

  public FtpProcessStatus HandlePreprocess(
    FtpPreprocessParameters preProcessParameters)
  {
    // Test if the command was a RETR command.
    if (preProcessParameters.Command.Equals(
      "RETR", StringComparison.InvariantCultureIgnoreCase))
    {
      // Test if the max download count was exceeded.
      if (_sessionList[preProcessParameters.SessionId].Equals(_maxDownloads))
      {
        // Reject the command if the max download count was exceeded.
        return FtpProcessStatus.FtpProcessRejectCommand;
      }
    }
    return FtpProcessStatus.FtpProcessContinue;
  }

  public FtpProcessStatus HandlePostprocess(
    FtpPostprocessParameters postProcessParameters)
  {
    // Test if the command was a successful RETR command.
    if (postProcessParameters.Command.Equals(
      "RETR", StringComparison.InvariantCultureIgnoreCase) &&
      postProcessParameters.FtpStatus == 226)
    {
      // Increment the download count.
      _sessionList[postProcessParameters.SessionId]++;
    }
    return FtpProcessStatus.FtpProcessContinue;
  }

  public void Log(FtpLogEntry logEntry)
  {
    // Test if the control channel was opened.
    if (logEntry.Command.Equals(
      "ControlChannelOpened",
      StringComparison.InvariantCultureIgnoreCase))
    {
      // Add the current session to the dictionary.
      _sessionList.Add(logEntry.SessionId, 0);
    }
    // Test if the control channel was closed.
    if (logEntry.Command.Equals(
      "ControlChannelClosed",
      StringComparison.InvariantCultureIgnoreCase))
    {
      // Remove the current session from the dictionary.
      _sessionList.Remove(logEntry.SessionId);
    }
  }
}