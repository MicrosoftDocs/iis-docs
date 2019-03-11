using System;
using Microsoft.Web.Media.Playlist.Provider;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Management.Media.Playlist.ProviderSample 
{
    public class PlaylistEntryInfo : IPlaylistEntryInfo
    {
        public PlaylistEntryInfo(string name, bool canSeekOrSkip)
        {
            _name = name;
            _canSeekOrSkip = canSeekOrSkip;
        }

        ENTRY_TYPE IPlaylistEntryInfo.EntryType
        {
            get
            {
                return ENTRY_TYPE.EntryTypePhysicalFile;
            }
        }

        string IPlaylistEntryInfo.Uri
        {
            get
            {
                return PlaylistProvider.MediaDirectory + _name;
            }
        }

        Object IPlaylistEntryInfo.GetProperty(PLAYLIST_ENTRY_PROPERTY_TYPE propertyName)
        {
            switch (propertyName)
            {
                case PLAYLIST_ENTRY_PROPERTY_TYPE.PlaylistEntryProperty_CanSeek:
                case PLAYLIST_ENTRY_PROPERTY_TYPE.PlaylistEntryProperty_CanSkipBackward:
                case PLAYLIST_ENTRY_PROPERTY_TYPE.PlaylistEntryProperty_CanSkipForward:
                    return _canSeekOrSkip;
                default:
                    return null;
            }
        }

        private string _name;
        private bool _canSeekOrSkip;
    }

    public class PlaylistInfo : IPlaylistInfo, IPlaylistEntryInfoCollection
    {
        public PlaylistInfo(string adname, string filename)
        {
            _entries = new IPlaylistEntryInfo[2];
            _entries[0] = new PlaylistEntryInfo(adname, false);
            _entries[1] = new PlaylistEntryInfo(filename, true);
        }

        IPlaylistEntryInfoCollection IPlaylistInfo.Entries
        {
            get
            {
                return this;
            }
        }

        uint IPlaylistEntryInfoCollection.Count
        {
            get
            {
                return 2;
            }
        }

        IPlaylistEntryInfo IPlaylistEntryInfoCollection.this[uint index]
        {
            get
            {
                return _entries[index];
            }
        }

        Object IPlaylistInfo.GetProperty(PLAYLIST_PROPERTY_TYPE propertyName)
        {
            if (propertyName == PLAYLIST_PROPERTY_TYPE.PlaylistProperty_Title)
            {
                return "Wrapper Playlist";
            }
            return null;
        }

        void IPlaylistInfo.EndRequestStatus(uint urlEntryId, uint status, int completionStatus, ulong bytesSent)
        {
            // No processing for EndRequest
        }

        private IPlaylistEntryInfo[] _entries;
    }

    [Guid("D5178953-96A0-4ebd-B511-024897DA2C09")]
    [ProgId("SamplePlaylistProvider.ProviderSample")]
    [ComVisible(true)]
    public class PlaylistProvider : IPlaylistProvider
    {
        IPlaylistInfo IPlaylistProvider.GetPlaylistInfo(IPlaylistRequestInfo requestInfo)
        {
            String path = requestInfo.Path;
            String name = path.Substring(path.LastIndexOf('/') + 1);
            name = name.Substring(0, name.LastIndexOf(".")) + FileExtension;
            return new PlaylistInfo(Advertisement + FileExtension, name);
        }

        void IPlaylistProvider.Initialize() 
        {
            //Load defaults for this provider... from config/xml etc
            MediaDirectory = @"C:\Test\Media\";
            Advertisement = "advertisement";
            FileExtension = ".flv";
        }

        void IPlaylistProvider.Shutdown() { }

        public static String MediaDirectory;
        public static String Advertisement;
        public static String FileExtension;
    }
}