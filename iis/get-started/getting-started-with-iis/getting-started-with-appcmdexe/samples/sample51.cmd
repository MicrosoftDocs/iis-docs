APPPOOL
  APPPOOL.NAME: MyAppPool
  managedPipelineMode: Integrated
  managedRuntimeVersion: v2.0
  state: Started
  [add]
    name:"MyAppPool"
    queueLength:"1000"
    autoStart:"true"
    enable32BitAppOnWin64:"false"
    managedRuntimeVersion:"v2.0"
    managedPipelineMode:"Integrated"
    passAnonymousToken:"true"
    [processModel]
      identityType:"NetworkService"
      userName:""
      password:""