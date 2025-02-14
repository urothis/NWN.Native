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

public unsafe class CNWSSpellScriptData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSSpellScriptData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSSpellScriptData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSSpellScriptData() {
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
          NWNXLibPINVOKE.delete_CNWSSpellScriptData(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSSpellScriptData self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSSpellScriptData FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSSpellScriptData((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSSpellScriptData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSSpellScriptData(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSSpellScriptData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSSpellScriptData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSSpellScriptData left, CNWSSpellScriptData right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSSpellScriptData left, CNWSSpellScriptData right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_nSpellId_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nFeatId {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_nFeatId_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_nFeatId_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidCaster {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_oidCaster_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_oidCaster_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidTarget {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_oidTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_oidTarget_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidItem {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_oidItem_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_oidItem_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vTargetPosition {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_vTargetPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSSpellScriptData_m_vTargetPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sScript {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_sScript_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSSpellScriptData_m_sScript_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidArea {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_oidArea_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_oidArea_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nItemCastLevel {
    set {
      NWNXLibPINVOKE.CNWSSpellScriptData_m_nItemCastLevel_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSSpellScriptData_m_nItemCastLevel_get(swigCPtr);
      return retVal;
    }

  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSSpellScriptData_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSSpellScriptData_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public CNWSSpellScriptData() : this(NWNXLibPINVOKE.new_CNWSSpellScriptData(), true) {
  }

}

}
