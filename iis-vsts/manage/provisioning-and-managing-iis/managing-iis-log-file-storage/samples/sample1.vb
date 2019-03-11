sLogFolder = "c:\inetpub\logs\LogFiles"
iMaxAge = 30   'in days
Set objFSO = CreateObject("Scripting.FileSystemObject")
set colFolder = objFSO.GetFolder(sLogFolder)
For Each colSubfolder in colFolder.SubFolders
        Set objFolder = objFSO.GetFolder(colSubfolder.Path)
        Set colFiles = objFolder.Files
        For Each objFile in colFiles
                iFileAge = now-objFile.DateCreated
                if iFileAge > (iMaxAge+1)  then
                        objFSO.deletefile objFile, True
                end if
        Next
Next