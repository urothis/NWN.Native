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

public unsafe class KEYFILE_RESFILENAME : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KEYFILE_RESFILENAME(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KEYFILE_RESFILENAME obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KEYFILE_RESFILENAME() {
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
          NWNXLibPINVOKE.delete_KEYFILE_RESFILENAME(swigCPtr);
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

  public static unsafe implicit operator void*(KEYFILE_RESFILENAME self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe KEYFILE_RESFILENAME FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new KEYFILE_RESFILENAME((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static KEYFILE_RESFILENAME FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new KEYFILE_RESFILENAME(pointer, memoryOwn) : null;
  }

  public bool Equals(KEYFILE_RESFILENAME other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is KEYFILE_RESFILENAME other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(KEYFILE_RESFILENAME left, KEYFILE_RESFILENAME right) {
    return Equals(left, right);
  }

  public static bool operator !=(KEYFILE_RESFILENAME left, KEYFILE_RESFILENAME right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nFileSize {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileSize_get(swigCPtr);
      return retVal;
    }

  }

  public uint nFileNameOffset {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameOffset_get(swigCPtr);
      return retVal;
    }

  }

  public ushort nFileNameSize {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameSize_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameSize_get(swigCPtr);
      return retVal;
    }

  }

  public ushort bDrives {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_bDrives_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.KEYFILE_RESFILENAME_bDrives_get(swigCPtr);
      return retVal;
    }

  }

  public KEYFILE_RESFILENAME() : this(NWNXLibPINVOKE.new_KEYFILE_RESFILENAME(), true) {
  }

}

}
