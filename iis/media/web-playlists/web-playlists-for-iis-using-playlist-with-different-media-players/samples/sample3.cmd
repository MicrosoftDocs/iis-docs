import mx.utils.Delegate;
import mx.events.EventDispatcher;
import sampleplayer.communication.PlaylistEntry;
class sampleplayer.communication.Playlist {
 public var addEventListener:Function, removeEventListener:Function;
 private var dispatchEvent:Function;
 private var _xml:XML;
 private var _title:String;
 public var _entries:Array;
 function Playlist() {
  trace("Playlist instantiated");
  _xml = new XML();
  mx.events.EventDispatcher.initialize(this);
 }
 public function load(sServerPath:String):Void {
  _entries = new Array();
  _xml.onLoad = Delegate.create(this, onLoad);
  _xml.load(sServerPath);
 }
 
 public function clear()
 {
  _entries.length = 0;
 }
 private function onLoad(success:Boolean):Void {
  if (success) {
   var index:Number = 0;
   //trace(_xml.childNodes);
   for (var node:XMLNode = _xml.firstChild.firstChild; node != null; node=node.nextSibling) {
    switch (node.nodeName) {
     case "ENTRY" :
      var entry:PlaylistEntry = new PlaylistEntry(node);
      _entries[index++]= entry ;
      break;
     case "TITLE" :
     //process the playlist title - sample code
      _title = node.nodeValue;
      break;
    }
   }
   trace("Entry count:"+ _entries.length);
   trace(_entries);
  }
  dispatchEvent({type:"onPlaylistLoaded", target:this, status:success});
 }
} 
class sampleplayer.communication.PlaylistEntry {
 public var title:String;
 public var path:String;
 public var canSeek:Boolean;
 public var canSkipForward:Boolean;
 public var canSkipBackward:Boolean;

 function PlaylistEntry(node:XMLNode) {
  trace("Entry instantiated");
  canSeek = true;
  canSkipForward = true;
  canSkipBackward = true;
  load(node);
 }
 private function load(node:XMLNode) {
  for (var temp:XMLNode = node.firstChild; temp != null; temp=temp.nextSibling) {
   switch (temp.nodeName) {
    case "REF" :
     path = temp.attributes.HREF;
     break;
    case "PARAM" :
     var name = temp.attributes.NAME;
     var value = temp.attributes.VALUE;
     switch (name) {
      case "CANSKIPBACK" :
       canSkipBackward = (value == "NO");
       break;
      case "CANSKIPFORWARD" :
       canSkipForward = (value == "NO");
       break;
      case "CANSEEK" :
       canSeek = (value == "NO");
     }
     break;
   }
  }
  
  if(node.attributes.CLIENTSKIP == "NO")
  {
   canSeek = false;
   canSkipForward = false;
   canSkipBackward = false;
  }
 }
 
 public function toString():String
 {
  return "Entry ref=" + path + " canSeek=" + canSeek + " canSkipF="+ canSkipForward + " canSkipB=" + canSkipBackward;
 }
}