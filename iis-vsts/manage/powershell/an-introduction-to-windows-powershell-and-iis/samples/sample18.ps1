# file: Deploy-Application.ps1

$sourceMachine = "DemoServer1"
$farmList = get-content '.\RestOfFarm.txt'
$filesToCopy = get-content '.\AppManifest.txt'

foreach ($targetMachine in $farmList)
{
   foreach ($file in $filesToCopy)
   {
      $sourcePath = "\\" + (join-path $sourceMachine $file)
      $destPath   = "\\" + (join-path $targetMachine $file)
      write-host -for yellow "$targetMachine : Copying files from
        $sourcePath"

      copy-item $sourcePath $destPath
        -recurse -force
   }
}