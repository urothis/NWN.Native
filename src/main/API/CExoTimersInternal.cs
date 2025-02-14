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

public unsafe class CExoTimersInternal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoTimersInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoTimersInternal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoTimersInternal() {
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
          NWNXLibPINVOKE.delete_CExoTimersInternal(swigCPtr);
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

  public static unsafe implicit operator void*(CExoTimersInternal self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoTimersInternal FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoTimersInternal((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoTimersInternal FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoTimersInternal(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoTimersInternal other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoTimersInternal other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoTimersInternal left, CExoTimersInternal right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoTimersInternal left, CExoTimersInternal right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bQPCActive {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_bQPCActive_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoTimersInternal_m_bQPCActive_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bQPCAlgorithm2 {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_bQPCAlgorithm2_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoTimersInternal_m_bQPCAlgorithm2_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nQPFrequency {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_nQPFrequency_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoTimersInternal_m_nQPFrequency_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nQPCMicroSecFrequency {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_nQPCMicroSecFrequency_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoTimersInternal_m_nQPCMicroSecFrequency_get(swigCPtr);
      return retVal;
    }

  }

  public double m_fQPCMicroSecFrequency {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_fQPCMicroSecFrequency_set(swigCPtr, value);
    } 
    get {
      double ret = NWNXLibPINVOKE.CExoTimersInternal_m_fQPCMicroSecFrequency_get(swigCPtr);
      return ret;
    } 
  }

  public ulong m_nHighResTimerValue {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_nHighResTimerValue_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CExoTimersInternal_m_nHighResTimerValue_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLowResTimerValue {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_nLowResTimerValue_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CExoTimersInternal_m_nLowResTimerValue_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bShutdown {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_bShutdown_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoTimersInternal_m_bShutdown_get(swigCPtr);
      return retVal;
    }

  }

  public void* m_pTimerThread {
    set {
      NWNXLibPINVOKE.CExoTimersInternal_m_pTimerThread_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoTimersInternal_m_pTimerThread_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public CExoTimersInternal() : this(NWNXLibPINVOKE.new_CExoTimersInternal(), true) {
  }

  public uint GetLowResolutionTimerReal() {
    uint retVal = NWNXLibPINVOKE.CExoTimersInternal_GetLowResolutionTimerReal(swigCPtr);
    return retVal;
  }

  public ulong GetHighResolutionTimerReal() {
    ulong retVal = NWNXLibPINVOKE.CExoTimersInternal_GetHighResolutionTimerReal(swigCPtr);
    return retVal;
  }

  public uint GetLowResolutionTimer() {
    uint retVal = NWNXLibPINVOKE.CExoTimersInternal_GetLowResolutionTimer(swigCPtr);
    return retVal;
  }

  public ulong GetHighResolutionTimer() {
    ulong retVal = NWNXLibPINVOKE.CExoTimersInternal_GetHighResolutionTimer(swigCPtr);
    return retVal;
  }

}

}
