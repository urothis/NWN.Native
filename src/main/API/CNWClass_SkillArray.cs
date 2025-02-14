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

public unsafe class CNWClass_SkillArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWClass_SkillArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWClass_SkillArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWClass_SkillArray() {
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
          NWNXLibPINVOKE.delete_CNWClass_SkillArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWClass_SkillArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWClass_SkillArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWClass_SkillArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWClass_SkillArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWClass_SkillArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWClass_SkillArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWClass_SkillArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWClass_SkillArray left, CNWClass_SkillArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWClass_SkillArray left, CNWClass_SkillArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWClass_Skill this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWClass_SkillArray(int nElements) : this(NWNXLibPINVOKE.new_CNWClass_SkillArray(nElements), true) {
  }

  public CNWClass_Skill GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_SkillArray_GetItem(swigCPtr, index);
    CNWClass_Skill ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass_Skill(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWClass_Skill value) {
    NWNXLibPINVOKE.CNWClass_SkillArray_SetItem(swigCPtr, index, CNWClass_Skill.getCPtr(value));
  }

  public static CNWClass_SkillArray FromPointer(CNWClass_Skill ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_SkillArray_FromPointer(CNWClass_Skill.getCPtr(ptr));
    CNWClass_SkillArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass_SkillArray(cPtr, false);
    return ret;
  }

}

}
