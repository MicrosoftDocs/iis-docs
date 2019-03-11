nc = new NetConnection();    //create a connection
nc.connect( null );     //null connection for progressive download
ns = new NetStream(nc);//create a stream 
video.attachVideo(ns); //pipe stream to this video object
ns.setBufferTime("10"); // Sets the initial buffer
ns.play("a.flv");