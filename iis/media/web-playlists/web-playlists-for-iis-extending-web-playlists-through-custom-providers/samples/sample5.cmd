tlbimp /out:<outputdirectory>\<outputproviderdll.dll> /namespace:<Provider Namespace> <path to playlist handler>\playlisthandler.dll

(E.g., tlbimp /out:E:\myprovider\playlistprovder.dll /namespace:Microsoft.Web.Media.Playlist.Provider E:\myprovider\playlisthandler.dll )