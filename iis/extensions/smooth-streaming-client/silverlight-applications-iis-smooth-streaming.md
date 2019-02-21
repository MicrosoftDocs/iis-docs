---
title: Silverlight Applications (IIS Smooth Streaming)
TOCTitle: Silverlight Applications (IIS Smooth Streaming)
ms:assetid: 70f30e39-c466-48cc-a81a-356690730bac
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee958032(v=VS.90)
ms:contentKeyID: 28407134
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Silverlight Applications (IIS Smooth Streaming)

You can build a Silverlight application that displays and interacts with IIS Smooth Streaming media content by using the [Microsoft® Silverlight™ 4 SDK](http://go.microsoft.com/fwlink/?linkid=230684) and Microsoft Visual Studio® or Visual Studio Web Developer Edition®. The media client for this type of application is an instance of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) class. Interaction with the data stream uses other classes from the [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md) namespace. The DLL that contains the libraries is installed with the [IIS Smooth Streaming Client](http://go.microsoft.com/fwlink/?linkid=181828). [Internet Information Services® (IIS)](http://go.microsoft.com/fwlink/?linkid=230682) and [IIS Media Services](http://go.microsoft.com/fwlink/?linkid=230683) must be installed on the Web server computer.


> [!NOTE]  
> Most Silverlight 4 applications will work with Silverlight 5 without any changes. For more information, see [Ensuring That Your Silverlight Applications Work with Silverlight 5](http://go.microsoft.com/fwlink/?linkid=251018).


## Development Environment

To get a Smooth Streaming client application running, turn on Internet Information Services (IIS) from the Control Panel of your development computer and add the multiple-bit-rate files and the manifest files of the Smooth Streaming content to the default Web site in IIS. After you have built the project shown in this topic, copy the Silverlight .xap file and the TestPage.html file that hosts the application to the default Web site that contains the Smooth Streaming files. This enables the Silverlight application to run in the same domain and on the same port as the Smooth Streaming media.

For basic information about installing Silverlight and the Microsoft Web Platform, see [Get Started with Silverlight](http://go.microsoft.com/fwlink/?linkid=181839). You can create Smooth Streaming content with [Expression Encoder®](http://go.microsoft.com/fwlink/?linkid=230685) or other tools that are provided by [Smooth Streaming Partners](http://go.microsoft.com/fwlink/?linkid=230686).


> [!NOTE]  
> Setting up the development environment for a Smooth Streaming client requires attention to the domain requirements of Silverlight applications. A Silverlight application that uses Smooth Streaming media data will not run on the Visual Studio ASP.NET development server without cross-domain configuration. (For information about running cross-domain applications, see [HTTP Communication and Security with Silverlight](http://go.microsoft.com/fwlink/?linkid=181829) and [Test and Debug Applications (IIS Smooth Streaming)](test-and-debug-applications.md). The example in the current topic does not require cross-domain configuration unless you have to run the sample with the ASP.NET development server.


## Project Workspace

Create a new Silverlight project In Visual Studio or Visual Studio Web Developer. Clear the check box that indicates the option to host the Silverlight application in a new Web site. Instead, let the build process generate a test page. This page will be named TestPage.html and can be copied with the .xap file to the IIS default Web site.

When the template completes and the project opens, you should see a display that looks like the following MainPage.xaml example.

    <UserControl x:Class="SlvLt_SmoothStreamApp.MainPage"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
                 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
        mc:Ignorable="d" d:DesignWidth="640" d:DesignHeight="480">
      <Grid x:Name="LayoutRoot">
    
      </Grid>
    </UserControl>

## Smooth Streaming Media Element

Silverlight supports both the [System.Windows.Controls.MediaElement](http://go.microsoft.com/fwlink/?linkid=230687) and [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md). To use Smooth Streaming, add a reference to the Microsoft.Web.Media.SmoothStreaming.dll. You can find the DLL in the folder where the [IIS Smooth Streaming Client](http://go.microsoft.com/fwlink/?linkid=181828) is installed. All other libraries needed for this application are supplied by the Visual Studio Silverlight template.

Add the following line to MainPage.xaml to include the N:Microsoft.Web.Media.SmoothStreaming namespace.

    xmlns:SSME="clr-namespace:Microsoft.Web.Media.SmoothStreaming;assembly=Microsoft.Web.Media.SmoothStreaming"

With the reference in place, all you need is a line that adds the media element to the page and assignment of the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property to a file with the file name extension .ism. The .ism file is the server manifest that contains a list of multiple-bit-rate media files and an identifier that points to the client manifest. The client manifest has the file name extension .ismc. The client manifest contains metadata about audio, video, and text streams. To run the example in this topic, set the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property to the .ism file on your IIS default Web site as shown in the following example.

    <SSME:SmoothStreamingMediaElement AutoPlay="True" x:Name="SmoothPlayer"
     SmoothStreamingSource="http://<ServerName>/BigBuckBunny.ism/Manifest" Grid.Row="0" />

Build the application, and copy TestPage.html and \<AppName\>.xap to \<drive\>:\\inetpub\\wwwroot (You will need administrator credentials to add files to inetpub\\wwwroot).

When the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is set to true as in this example, the few lines of XAML shown above are sufficient to run Smooth Streaming media from any Silverlight-enabled Web browser. You don't have to add anything to the code-behind file to start the stream.


> [!NOTE]  
> It is preferable to not specify height and width dimensions for the media element. Instead, allow the video display to run at the size it was encoded. This avoids reformatting that will unnecessarily consume processor resources.


## Silverlight Controls

Silverlight controls can interact with Smooth Streaming media as needed for applications. The following XAML syntax includes buttons that start, stop, and pause the media stream, and a slider bar that is data-bound to the [Volume](smoothstreamingmediaelement-volume-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md). A combo box supports a list of options to play media from several Smooth Streaming sources.

``` 
  <SSME:SmoothStreamingMediaElement AutoPlay="False"
                           x:Name="SmoothPlayer" Grid.Row="0"/>
    <StackPanel Orientation="Horizontal" Grid.Row="1">
        <TextBlock x:Name="Volume" VerticalAlignment="Center"
                             Text="Volume" Width="50" />
        <Slider x:Name="VolumeBar" Width="60"
                   Value="{Binding Path=Volume,
                   ElementName=SmoothPlayer, Mode=TwoWay}" />
        <Button x:Name="PlayButton" Width="50" Click="PlayButton_Click"
                   Loaded="PlayButton_Loaded"/>
        <Button x:Name="StopButton" Content="Stop" Width="50"
                   Click="StopButton_Click" /> 
    </StackPanel>
```

### Code-Behind

The logic for **Play** and **Stop** is shown in the following excerpt from the MainPage.xaml.cs code file. You will need a reference to the Smooth Streaming assembly.

``` 
using Microsoft.Web.Media.SmoothStreaming;
    private void PlayButton_Loaded(object sender, RoutedEventArgs e)
    {
        switch (SmoothPlayer.AutoPlay)
        {
            case false:
                PlayButton.Content = "Play";
                break;
            case true:
                PlayButton.Content = "Pause";
                break;
        }
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
        switch (SmoothPlayer.CurrentState)
        {
            case SmoothStreamingMediaElementState.Playing:
                SmoothPlayer.Pause();
                PlayButton.Content = "Play";
                break;

            case SmoothStreamingMediaElementState.Paused:
                SmoothPlayer.Play();
                PlayButton.Content = "Pause";
                break;

            case SmoothStreamingMediaElementState.Stopped:
                SmoothPlayer.Play();
                PlayButton.Content = "Pause";
                break;
        }
    }

    // This method resets the button.  For more information,
    // see the following topic: Events (IIS Smooth Streaming).
    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        SmoothPlayer.Stop();
        PlayButton.Content = "Play";
    }
    void SmoothPlayer_CurrentStateChanged(object sender, RoutedEventArgs e)
    {
        switch (SmoothPlayer.CurrentState)
        {
            case SmoothStreamingMediaElementState.Playing:
                PlayButton.Content = "Pause";
                break;

            case SmoothStreamingMediaElementState.Paused:
                PlayButton.Content = "Play";
                break;

            case SmoothStreamingMediaElementState.Stopped:
                PlayButton.Content = "Play";
                break;
        }
    }


```

### Multiple Smooth Streaming Source URI Options

The following line in MainPage.xaml specifies a combo box named SourceList that will contain URI options for Smooth Streaming media sources.

``` 
  <ComboBox x:Name="SourceList" SelectionChanged="SourceList_SelectionChanged" Width="375" />
```

The following combined XAML specification includes all previous markup in a layout grid that locates controls on the page.

``` 
  <Grid x:Name="LayoutRoot">
      <Grid.RowDefinitions>
            <RowDefinition Height="0.90*"></RowDefinition>
            <RowDefinition Height="0.05*"></RowDefinition>
            <RowDefinition Height="0.05*"></RowDefinition>
        </Grid.RowDefinitions>
        <SSME:SmoothStreamingMediaElement AutoPlay="False" x:Name="SmoothPlayer" Grid.Row="0"/>
        <StackPanel Orientation="Horizontal" Grid.Row="1">
            <TextBlock x:Name="Volume" VerticalAlignment="Center" Text="Volume" Width="50" />
            <Slider x:Name="VolumeBar" Width="60" Value="{Binding Path=Volume, ElementName=SmoothPlayer, Mode=TwoWay}" />
            <Button x:Name="PlayButton" Width="50" Click="PlayButton_Click" Loaded="PlayButton_Loaded"/>
            <Button x:Name="StopButton" Content="Stop" Width="50" Click="StopButton_Click" />
            <ComboBox x:Name="SourceList" SelectionChanged="SourceList_SelectionChanged" Width="375" > 
                <ComboBoxItem Content="Big Buck Bunny" />
                <ComboBoxItem Content="Media Two" />
                <ComboBoxItem Content="Media Three" />
                <ComboBoxItem Content="Media Four" />
                <ComboBoxItem Content="Media Five"/>
            </ComboBox>
        </StackPanel>
        <TextBlock x:Name="OutputText" VerticalAlignment="Center"
                             Width="850" Grid.Row="2"/>
                  <!--OutputText is not used in the current example.-->
  </Grid>
```

The logic for the combo box control is shown in the following excerpt from the MainPage.xaml.cs code file.

The selection-changed event occurs when the user clicks an option in the combo box. The URI addresses of the Smooth Streaming media sources contained in these code segments are never displayed to the user.

``` 
        private void SourceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item = ((sender as ComboBox).SelectedItem as ListBoxItem);
            string selection = item.Content as string;

            switch (selection)
            {
                case "Big Buck Bunny":
                    SmoothPlayer.SmoothStreamingSource =
                        new Uri("http://<serverName>/ BigBuckBunny.ism/Manifest");
                    break;
                case "Media Two":
                    SmoothPlayer.SmoothStreamingSource =
                        new Uri("http://<serverName>/media2.ism/Manifest");
                    break;
                case "Media Three":
                    SmoothPlayer.SmoothStreamingSource =
                        new Uri("http://<serverName>/media3.ism/Manifest");
                    break;
                case "Media Four":
                    SmoothPlayer.SmoothStreamingSource =
                        new Uri("http://<serverName>/media4.ism/Manifest");
                    break;

            }
        }
```

With these controls on the page, the user can select from four options to play Smooth Streaming media sources and to start, stop, or pause the playback and adjust the volume of the audio playback.

Media files for use in this example can be created from .wmv files found at the [WMV HD Content Showcase](http://go.microsoft.com/fwlink/?linkid=181843) by using Expression Encoder.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)

### Other Resources

[Smooth Streaming Deployment Guide](http://go.microsoft.com/fwlink/?linkid=181836)

[Getting Started with IIS Smooth Streaming](http://go.microsoft.com/fwlink/?linkid=230688)

[Getting Started with IIS Live Smooth Streaming](http://go.microsoft.com/fwlink/?linkid=181835)

[Building your first Smooth Streaming Player using SSME](http://go.microsoft.com/fwlink/?linkid=181845)

[IIS Smooth Streaming Sample Application](http://go.microsoft.com/fwlink/?linkid=182167)

