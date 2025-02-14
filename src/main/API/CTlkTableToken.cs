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

public unsafe class CTlkTableToken : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CTlkTableToken(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkTableToken obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkTableToken() {
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
          NWNXLibPINVOKE.delete_CTlkTableToken(swigCPtr);
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

  public static unsafe implicit operator void*(CTlkTableToken self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CTlkTableToken FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CTlkTableToken((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CTlkTableToken FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CTlkTableToken(pointer, memoryOwn) : null;
  }

  public bool Equals(CTlkTableToken other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkTableToken other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkTableToken left, CTlkTableToken right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkTableToken left, CTlkTableToken right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nHash {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nHash_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CTlkTableToken_m_nHash_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sToken {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_sToken_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableToken_m_sToken_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nActionCode {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nActionCode_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CTlkTableToken_m_nActionCode_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<uint> m_nStrRef {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nStrRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CTlkTableToken_m_nStrRef_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 4);

      return retVal; // uint[4]
    }

  }

  public uint m_nStrRefDefault {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nStrRefDefault_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CTlkTableToken_m_nStrRefDefault_get(swigCPtr);
      return retVal;
    }

  }

  public CTlkTableToken() : this(NWNXLibPINVOKE.new_CTlkTableToken(), true) {
  }

}

}
