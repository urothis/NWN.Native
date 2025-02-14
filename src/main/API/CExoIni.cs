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

public unsafe class CExoIni : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoIni(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoIni obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoIni() {
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
          NWNXLibPINVOKE.delete_CExoIni(swigCPtr);
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

  public static unsafe implicit operator void*(CExoIni self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoIni FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoIni((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoIni FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoIni(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoIni other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoIni other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoIni left, CExoIni right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoIni left, CExoIni right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoIniInternal m_pcExoIniInternal {
    set {
      NWNXLibPINVOKE.CExoIni_m_pcExoIniInternal_set(swigCPtr, CExoIniInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoIni_m_pcExoIniInternal_get(swigCPtr);
      CExoIniInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoIniInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoIni(CExoString sUserDirectory) : this(NWNXLibPINVOKE.new_CExoIni(CExoString.getCPtr(sUserDirectory)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int ReadIniEntry(CExoString sValue, int idxIniFile, CExoString sSection, CExoString sEntry) {
    int retVal = NWNXLibPINVOKE.CExoIni_ReadIniEntry(swigCPtr, CExoString.getCPtr(sValue), idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteIniEntry(CExoString sValue, int idxIniFile, CExoString sSection, CExoString sEntry, int stripIfEmpty) {
    int retVal = NWNXLibPINVOKE.CExoIni_WriteIniEntry__SWIG_0(swigCPtr, CExoString.getCPtr(sValue), idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry), stripIfEmpty);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteIniEntry(CExoString sValue, int idxIniFile, CExoString sSection, CExoString sEntry) {
    int retVal = NWNXLibPINVOKE.CExoIni_WriteIniEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sValue), idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetIntOr(int idxIniFile, CExoString sSection, CExoString sEntry, int nOtherwise) {
    int retVal = NWNXLibPINVOKE.CExoIni_GetIntOr(swigCPtr, idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry), nOtherwise);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public float GetFloatOr(int idxIniFile, CExoString sSection, CExoString sEntry, float nOtherwise) {
    float retVal = NWNXLibPINVOKE.CExoIni_GetFloatOr(swigCPtr, idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry), nOtherwise);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

}

}
