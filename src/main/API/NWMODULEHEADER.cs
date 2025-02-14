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

public unsafe class NWMODULEHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NWMODULEHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWMODULEHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWMODULEHEADER() {
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
          NWNXLibPINVOKE.delete_NWMODULEHEADER(swigCPtr);
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

  public static unsafe implicit operator void*(NWMODULEHEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe NWMODULEHEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new NWMODULEHEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static NWMODULEHEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new NWMODULEHEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(NWMODULEHEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is NWMODULEHEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(NWMODULEHEADER left, NWMODULEHEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(NWMODULEHEADER left, NWMODULEHEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<byte> pModuleID {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_pModuleID_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.NWMODULEHEADER_pModuleID_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 32);

      return retVal; // byte[32]
    }

  }

  public int nModuleCreatorID {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_nModuleCreatorID_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.NWMODULEHEADER_nModuleCreatorID_get(swigCPtr);
      return retVal;
    }

  }

  public uint nModuleVersion {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_nModuleVersion_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.NWMODULEHEADER_nModuleVersion_get(swigCPtr);
      return retVal;
    }

  }

  public NWMODULEHEADER() : this(NWNXLibPINVOKE.new_NWMODULEHEADER(), true) {
  }

}

}
