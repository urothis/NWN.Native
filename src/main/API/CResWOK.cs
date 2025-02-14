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

public unsafe class CResWOK : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResWOK(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResWOK_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResWOK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResWOK(swigCPtr);
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

  public static unsafe implicit operator void*(CResWOK self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResWOK FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResWOK((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResWOK FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResWOK(pointer, memoryOwn) : null;
  }

  public bool Equals(CResWOK other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResWOK other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResWOK left, CResWOK right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResWOK left, CResWOK right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResWOK_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResWOK_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nWOKNormalSize {
    set {
      NWNXLibPINVOKE.CResWOK_m_nWOKNormalSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResWOK_m_nWOKNormalSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pWOKData {
    set {
      NWNXLibPINVOKE.CResWOK_m_pWOKData_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResWOK_m_pWOKData_get(swigCPtr);
      return retVal;
    }

  }

  public CResWOK() : this(NWNXLibPINVOKE.new_CResWOK(), true) {
  }

  public byte* GetWOKDataPtr() {
    byte* retVal = NWNXLibPINVOKE.CResWOK_GetWOKDataPtr(swigCPtr);
    return retVal;
  }

  public uint GetWOKSize() {
    uint retVal = NWNXLibPINVOKE.CResWOK_GetWOKSize(swigCPtr);
    return retVal;
  }

  public int IsLoaded() {
    int retVal = NWNXLibPINVOKE.CResWOK_IsLoaded(swigCPtr);
    return retVal;
  }

  public override int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CResWOK_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public override int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CResWOK_OnResourceServiced(swigCPtr);
    return retVal;
  }

}

}
