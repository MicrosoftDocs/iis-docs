0:000> !heap -p -a 42ae5b28
    address 42ae5b28 found in
    _HEAP @ 6690000
      HEAP_ENTRY Size Prev Flags    UserPtr UserSize - state
        42ae5b28 0541 0000  [00]   42ae5b40    02800 - (busy)
        77e9df42 ntdll!RtlAllocateHeap+0x00000274
        75133db8 msvcr90!malloc+0x00000079
        513f3cc7 LeakTrack!CCRTMemoryLT::R90mallocDetour+0x00000067
        75933cef oleaut32!CTypeInfo2::Invoke+0x0000023f
        61f527b8 leakcom!ATL::IDispatchImpl::Invoke+0x00000058
        f05cb4d vbscript!IDispatchInvoke+0x00000059
        f053f40 vbscript!InvokeDispatch+0x000001a5
        f060795 vbscript!InvokeByName+0x00000043
        f06080d vbscript!CScriptRuntime::RunNoEH+0x000022cf
        f054122 vbscript!CScriptRuntime::Run+0x00000064
        f054099 vbscript!CScriptEntryPoint::Call+0x00000074
        f054279 vbscript!CSession::Execute+0x000000c8
        f0544c0 vbscript!COleScript::ExecutePendingScripts+0x00000146
        f052013 vbscript!COleScript::SetScriptState+0x0000014d
        513023c0 asp!CActiveScriptEngine::TryCall+0x00000019
        513027b3 asp!CActiveScriptEngine::Call+0x000000e7
        513022c7 asp!CallScriptFunctionOfEngine+0x0000003e
        513063d5 asp!ExecuteRequest+0x0000014a
        51302676 asp!Execute+0x000001c4
        513028f2 asp!CHitObj::ViperAsyncCallback+0x000003fc
        51302030 asp!CViperAsyncRequest::OnCall+0x0000006a
        563de19 comsvcs!CSTAActivityWork::STAActivityWorkHelper+0x00000032
        771304fb ole32!EnterForCallback+0x000000f4
        771284c7 ole32!SwitchForCallback+0x000001a8
        77126964 ole32!PerformCallback+0x000000a3
        7713df32 ole32!CObjectContext::InternalContextCallback+0x0000015b
        771f47ef ole32!CObjectContext::DoCallback+0x0000001c
        563dfbd comsvcs!CSTAActivityWork::DoWork+0x0000012f
        563e51b comsvcs!CSTAThread::DoWork+0x00000018
        563f24d comsvcs!CSTAThread::ProcessQueueWork+0x00000037
        563f4c0 comsvcs!CSTAThread::WorkerLoop+0x00000135
        773a1287 msvcrt!_endthreadex+0x00000044