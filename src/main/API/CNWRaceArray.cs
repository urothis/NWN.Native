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

public unsafe class CNWRaceArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWRaceArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWRaceArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWRaceArray() {
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
          NWNXLibPINVOKE.delete_CNWRaceArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWRaceArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWRaceArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWRaceArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWRaceArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWRaceArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWRaceArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWRaceArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWRaceArray left, CNWRaceArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWRaceArray left, CNWRaceArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWRace this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWRaceArray(int nElements) : this(NWNXLibPINVOKE.new_CNWRaceArray(nElements), true) {
  }

  public CNWRace GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRaceArray_GetItem(swigCPtr, index);
    CNWRace ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWRace(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWRace value) {
    NWNXLibPINVOKE.CNWRaceArray_SetItem(swigCPtr, index, CNWRace.getCPtr(value));
  }

  public static CNWRaceArray FromPointer(CNWRace ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRaceArray_FromPointer(CNWRace.getCPtr(ptr));
    CNWRaceArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWRaceArray(cPtr, false);
    return ret;
  }

}

}
