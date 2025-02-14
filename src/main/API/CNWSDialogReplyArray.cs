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

public unsafe class CNWSDialogReplyArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSDialogReplyArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogReplyArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogReplyArray() {
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
          NWNXLibPINVOKE.delete_CNWSDialogReplyArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSDialogReplyArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDialogReplyArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDialogReplyArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDialogReplyArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDialogReplyArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDialogReplyArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogReplyArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogReplyArray left, CNWSDialogReplyArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogReplyArray left, CNWSDialogReplyArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWSDialogReply this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWSDialogReplyArray(int nElements) : this(NWNXLibPINVOKE.new_CNWSDialogReplyArray(nElements), true) {
  }

  public CNWSDialogReply GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogReplyArray_GetItem(swigCPtr, index);
    CNWSDialogReply ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogReply(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWSDialogReply value) {
    NWNXLibPINVOKE.CNWSDialogReplyArray_SetItem(swigCPtr, index, CNWSDialogReply.getCPtr(value));
  }

  public static CNWSDialogReplyArray FromPointer(CNWSDialogReply ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogReplyArray_FromPointer(CNWSDialogReply.getCPtr(ptr));
    CNWSDialogReplyArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogReplyArray(cPtr, false);
    return ret;
  }

}

}
