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

public unsafe class CRes2DA : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CRes2DA(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CRes2DA_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CRes2DA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CRes2DA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CRes2DA self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CRes2DA FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CRes2DA((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CRes2DA FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CRes2DA(pointer, memoryOwn) : null;
  }

  public bool Equals(CRes2DA other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CRes2DA other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CRes2DA left, CRes2DA right) {
    return Equals(left, right);
  }

  public static bool operator !=(CRes2DA left, CRes2DA right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CRes2DA_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CRes2DA_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_n2DANormalSize {
    set {
      NWNXLibPINVOKE.CRes2DA_m_n2DANormalSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CRes2DA_m_n2DANormalSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_p2DAData {
    set {
      NWNXLibPINVOKE.CRes2DA_m_p2DAData_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CRes2DA_m_p2DAData_get(swigCPtr);
      return retVal;
    }

  }

  public EXO2DAHEADER m_p2DAHeader {
    set {
      NWNXLibPINVOKE.CRes2DA_m_p2DAHeader_set(swigCPtr, EXO2DAHEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes2DA_m_p2DAHeader_get(swigCPtr);
      EXO2DAHEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXO2DAHEADER(cPtr, false);
      return ret;
    } 
  }

  public CRes2DA() : this(NWNXLibPINVOKE.new_CRes2DA(), true) {
  }

  public byte* Get2DADataPtr() {
    byte* retVal = NWNXLibPINVOKE.CRes2DA_Get2DADataPtr(swigCPtr);
    return retVal;
  }

  public EXO2DAHEADER Get2DAHeaderPtr() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes2DA_Get2DAHeaderPtr(swigCPtr);
    EXO2DAHEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new EXO2DAHEADER(cPtr, false);
    return ret;
  }

  public uint Get2DASize() {
    uint retVal = NWNXLibPINVOKE.CRes2DA_Get2DASize(swigCPtr);
    return retVal;
  }

  public int IsLoaded() {
    int retVal = NWNXLibPINVOKE.CRes2DA_IsLoaded(swigCPtr);
    return retVal;
  }

  public override int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CRes2DA_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public override int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CRes2DA_OnResourceServiced(swigCPtr);
    return retVal;
  }

}

}
