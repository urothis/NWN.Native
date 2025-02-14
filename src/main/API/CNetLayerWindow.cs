//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CNetLayerWindow : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNetLayerWindow(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNetLayerWindow obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNetLayerWindow() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNetLayerWindow(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNetLayerWindow self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNetLayerWindow FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNetLayerWindow((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNetLayerWindow FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNetLayerWindow(pointer, memoryOwn) : null;
  }

  public bool Equals(CNetLayerWindow other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNetLayerWindow other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNetLayerWindow left, CNetLayerWindow right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNetLayerWindow left, CNetLayerWindow right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bInitialized {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bInitialized_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bInitialized_get(swigCPtr);
      return retVal;
    }

  }

  public SWIGTYPE_p_CNetLayerInternal m_pNetLayer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pNetLayer_set(swigCPtr, SWIGTYPE_p_CNetLayerInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pNetLayer_get(swigCPtr);
      SWIGTYPE_p_CNetLayerInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNetLayerInternal(cPtr, false);
      return ret;
    } 
  }

  public int m_bWindowInUse {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bWindowInUse_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bWindowInUse_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPlayerId {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nPlayerId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nPlayerId_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nConnectionId {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nConnectionId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nConnectionId_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nAckExpected {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nAckExpected_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nAckExpected_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nNextFrameToSend {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nNextFrameToSend_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nNextFrameToSend_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nFrameExpected {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nFrameExpected_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nFrameExpected_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nTooFar {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nTooFar_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nTooFar_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nNumBuffered {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nNumBuffered_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nNumBuffered_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bNoNak {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bNoNak_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bNoNak_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPacketTimeOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nPacketTimeOut_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nPacketTimeOut_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nAckTimeOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nAckTimeOut_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nAckTimeOut_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nInFrameTimeOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameTimeOut_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameTimeOut_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nFauxNagleTimeOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleTimeOut_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleTimeOut_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nAckTimer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nAckTimer_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nAckTimer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAckTimerSet {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bAckTimerSet_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bAckTimerSet_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nFauxNagleRuns {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleRuns_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleRuns_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nFauxNagleTimer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleTimer_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nFauxNagleTimer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFauxNagleTimerSet {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bFauxNagleTimerSet_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bFauxNagleTimerSet_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nInFrameBaseTime {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameBaseTime_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameBaseTime_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nInFrameTimer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameTimer_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nInFrameTimer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bInFrameTimerSet {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bInFrameTimerSet_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bInFrameTimerSet_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<ushort> m_pOutgoingBuffers {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pOutgoingBuffers_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pOutgoingBuffers_get(swigCPtr);
      NativeArray<ushort> retVal = new NativeArray<ushort>(arrayPtr, 16);

      return retVal; // ushort[16]
    }

  }

  public NativeArray<int> m_pbTimeOutSet {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pbTimeOutSet_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pbTimeOutSet_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 16);

      return retVal; // int[16]
    }

  }

  public NativeArray<uint> m_pnTimeOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pnTimeOut_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pnTimeOut_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 16);

      return retVal; // uint[16]
    }

  }

  public NativeArray<int> m_pbTimeOutDelay {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pbTimeOutDelay_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pbTimeOutDelay_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 16);

      return retVal; // int[16]
    }

  }

  public NativeArray<ushort> m_pIncomingBuffers {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pIncomingBuffers_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pIncomingBuffers_get(swigCPtr);
      NativeArray<ushort> retVal = new NativeArray<ushort>(arrayPtr, 16);

      return retVal; // ushort[16]
    }

  }

  public NativeArray<int> m_pbArrived {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pbArrived_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pbArrived_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 16);

      return retVal; // int[16]
    }

  }

  public CExoArrayListUInt16 m_lQueueOutgoingHiFrames {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_lQueueOutgoingHiFrames_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_lQueueOutgoingHiFrames_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_lQueueOutgoingLoFrames {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_lQueueOutgoingLoFrames_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_lQueueOutgoingLoFrames_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_lQueueIncomingHiFrames {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_lQueueIncomingHiFrames_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_lQueueIncomingHiFrames_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_lQueueIncomingLoFrames {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_lQueueIncomingLoFrames_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_lQueueIncomingLoFrames_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public NativeArray<byte> m_pLowPriorityHoldBuffer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pLowPriorityHoldBuffer_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pLowPriorityHoldBuffer_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 960);

      return retVal; // byte[960]
    }

  }

  public NativeArray<byte> m_pHighPriorityHoldBuffer {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pHighPriorityHoldBuffer_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pHighPriorityHoldBuffer_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 960);

      return retVal; // byte[960]
    }

  }

  public uint m_nLowPriorityHoldBufferSize {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nLowPriorityHoldBufferSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nLowPriorityHoldBufferSize_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nHighPriorityHoldBufferSize {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nHighPriorityHoldBufferSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nHighPriorityHoldBufferSize_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCrapNetBandwidthNoSend {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bCrapNetBandwidthNoSend_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bCrapNetBandwidthNoSend_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nOutgoingNumBuffers {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingNumBuffers_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingNumBuffers_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nIncomingNumBuffers {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nIncomingNumBuffers_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nIncomingNumBuffers_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nOutgoingPacketsSinceResend {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingPacketsSinceResend_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingPacketsSinceResend_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nOutgoingPacketsTimedOut {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingPacketsTimedOut_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNetLayerWindow_m_nOutgoingPacketsTimedOut_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCutOutgoingNumBuffers {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bCutOutgoingNumBuffers_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bCutOutgoingNumBuffers_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bReceivedPacket {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bReceivedPacket_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bReceivedPacket_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAcknowledgeImmediately {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_bAcknowledgeImmediately_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNetLayerWindow_m_bAcknowledgeImmediately_get(swigCPtr);
      return retVal;
    }

  }

  public SWIGTYPE_p_z_stream m_pCompressionStream {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pCompressionStream_set(swigCPtr, SWIGTYPE_p_z_stream.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pCompressionStream_get(swigCPtr);
      SWIGTYPE_p_z_stream ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_z_stream(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_z_stream m_pDecompressionStream {
    set {
      NWNXLibPINVOKE.CNetLayerWindow_m_pDecompressionStream_set(swigCPtr, SWIGTYPE_p_z_stream.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerWindow_m_pDecompressionStream_get(swigCPtr);
      SWIGTYPE_p_z_stream ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_z_stream(cPtr, false);
      return ret;
    } 
  }

  public CNetLayerWindow() : this(NWNXLibPINVOKE.new_CNetLayerWindow(), true) {
  }

  public void Initialize(SWIGTYPE_p_CNetLayerInternal pNetLayer) {
    NWNXLibPINVOKE.CNetLayerWindow_Initialize(swigCPtr, SWIGTYPE_p_CNetLayerInternal.getCPtr(pNetLayer));
  }

  public void ShutDown() {
    NWNXLibPINVOKE.CNetLayerWindow_ShutDown(swigCPtr);
  }

  public void InitializeCompressionBuffers() {
    NWNXLibPINVOKE.CNetLayerWindow_InitializeCompressionBuffers(swigCPtr);
  }

  public int AddToHighOutgoingQueue(ushort nFrame) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_AddToHighOutgoingQueue(swigCPtr, nFrame);
    return retVal;
  }

  public int AddToLowOutgoingQueue(ushort nFrame) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_AddToLowOutgoingQueue(swigCPtr, nFrame);
    return retVal;
  }

  public void LoadWindowWithFrames() {
    NWNXLibPINVOKE.CNetLayerWindow_LoadWindowWithFrames(swigCPtr);
  }

  public void PlaceFrameInOutgoingBuffers(ushort nFrame) {
    NWNXLibPINVOKE.CNetLayerWindow_PlaceFrameInOutgoingBuffers(swigCPtr, nFrame);
  }

  public void FrameSend(byte nMessageType, ushort nFrameWindowNumber, ushort nFrameReference) {
    NWNXLibPINVOKE.CNetLayerWindow_FrameSend(swigCPtr, nMessageType, nFrameWindowNumber, nFrameReference);
  }

  public int FrameNumberBetween(uint a, uint b, uint c) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_FrameNumberBetween(swigCPtr, a, b, c);
    return retVal;
  }

  public int FrameReceive(byte* pData, uint dwSize) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_FrameReceive(swigCPtr, pData, dwSize);
    return retVal;
  }

  public int FrameTimeout(uint nApplicationType) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_FrameTimeout(swigCPtr, nApplicationType);
    return retVal;
  }

  public void SetOutFrameTimer(uint nBuffer) {
    NWNXLibPINVOKE.CNetLayerWindow_SetOutFrameTimer(swigCPtr, nBuffer);
  }

  public int TestOutFrameTimer(uint nBuffer, uint nCurrentTime) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_TestOutFrameTimer(swigCPtr, nBuffer, nCurrentTime);
    return retVal;
  }

  public void SetAckTimer() {
    NWNXLibPINVOKE.CNetLayerWindow_SetAckTimer(swigCPtr);
  }

  public int TestAckTimer(uint nCurrentTime) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_TestAckTimer(swigCPtr, nCurrentTime);
    return retVal;
  }

  public void SetFauxNagleTimer() {
    NWNXLibPINVOKE.CNetLayerWindow_SetFauxNagleTimer(swigCPtr);
  }

  public int TestFauxNagleTimer(uint nCurrentTime) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_TestFauxNagleTimer(swigCPtr, nCurrentTime);
    return retVal;
  }

  public int FauxNagle() {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_FauxNagle(swigCPtr);
    return retVal;
  }

  public void SetInFrameTimer() {
    NWNXLibPINVOKE.CNetLayerWindow_SetInFrameTimer(swigCPtr);
  }

  public int TestInFrameTimer(uint nCurrentTime) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_TestInFrameTimer(swigCPtr, nCurrentTime);
    return retVal;
  }

  public int UnpacketizeFullMessages(int bHighPriority) {
    int retVal = NWNXLibPINVOKE.CNetLayerWindow_UnpacketizeFullMessages(swigCPtr, bHighPriority);
    return retVal;
  }

  public void DoubleOutgoingBufferSize() {
    NWNXLibPINVOKE.CNetLayerWindow_DoubleOutgoingBufferSize(swigCPtr);
  }

  public void CutOutgoingBufferSize() {
    NWNXLibPINVOKE.CNetLayerWindow_CutOutgoingBufferSize(swigCPtr);
  }

}

}
