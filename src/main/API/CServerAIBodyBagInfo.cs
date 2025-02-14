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

public unsafe class CServerAIBodyBagInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIBodyBagInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIBodyBagInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIBodyBagInfo() {
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
          NWNXLibPINVOKE.delete_CServerAIBodyBagInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CServerAIBodyBagInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CServerAIBodyBagInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CServerAIBodyBagInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CServerAIBodyBagInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CServerAIBodyBagInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CServerAIBodyBagInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerAIBodyBagInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerAIBodyBagInfo left, CServerAIBodyBagInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerAIBodyBagInfo left, CServerAIBodyBagInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_oidBodyBag {
    set {
      NWNXLibPINVOKE.CServerAIBodyBagInfo_m_oidBodyBag_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIBodyBagInfo_m_oidBodyBag_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vPosition {
    set {
      NWNXLibPINVOKE.CServerAIBodyBagInfo_m_vPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIBodyBagInfo_m_vPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int SaveBodyBag(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIBodyBagInfo_SaveBodyBag(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadBodyBag(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIBodyBagInfo_LoadBodyBag(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public CServerAIBodyBagInfo() : this(NWNXLibPINVOKE.new_CServerAIBodyBagInfo(), true) {
  }

}

}
