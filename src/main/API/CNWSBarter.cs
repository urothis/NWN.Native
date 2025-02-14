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

public unsafe class CNWSBarter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSBarter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSBarter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSBarter() {
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
          NWNXLibPINVOKE.delete_CNWSBarter(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSBarter self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSBarter FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSBarter((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSBarter FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSBarter(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSBarter other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSBarter other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSBarter left, CNWSBarter right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSBarter left, CNWSBarter right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CItemRepository m_pBarterList {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_pBarterList_set(swigCPtr, CItemRepository.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSBarter_m_pBarterList_get(swigCPtr);
      CItemRepository ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepository(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerLUOInventory m_pLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_pLastUpdate_set(swigCPtr, CNWSPlayerLUOInventory.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSBarter_m_pLastUpdate_get(swigCPtr);
      CNWSPlayerLUOInventory ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventory(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerLUOInventory m_pOtherLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_pOtherLastUpdate_set(swigCPtr, CNWSPlayerLUOInventory.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSBarter_m_pOtherLastUpdate_get(swigCPtr);
      CNWSPlayerLUOInventory ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventory(cPtr, false);
      return ret;
    } 
  }

  public int m_bListLocked {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_bListLocked_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSBarter_m_bListLocked_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bListAccepted {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_bListAccepted_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSBarter_m_bListAccepted_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bInitiator {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_bInitiator_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSBarter_m_bInitiator_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bWindowOpen {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_bWindowOpen_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSBarter_m_bWindowOpen_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidBarrator {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_oidBarrator_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSBarter_m_oidBarrator_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSCreature m_pOwner {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_pOwner_set(swigCPtr, CNWSCreature.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSBarter_m_pOwner_get(swigCPtr);
      CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
      return ret;
    } 
  }

  public int m_bDoReset {
    set {
      NWNXLibPINVOKE.CNWSBarter_m_bDoReset_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSBarter_m_bDoReset_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSBarter(CNWSCreature pCreature) : this(NWNXLibPINVOKE.new_CNWSBarter(CNWSCreature.getCPtr(pCreature)), true) {
  }

  public void Reset(uint oidBarrator, int bInitiator) {
    NWNXLibPINVOKE.CNWSBarter_Reset__SWIG_0(swigCPtr, oidBarrator, bInitiator);
  }

  public void Reset(uint oidBarrator) {
    NWNXLibPINVOKE.CNWSBarter_Reset__SWIG_1(swigCPtr, oidBarrator);
  }

  public void Reset() {
    NWNXLibPINVOKE.CNWSBarter_Reset__SWIG_2(swigCPtr);
  }

  public void CleanUp() {
    NWNXLibPINVOKE.CNWSBarter_CleanUp(swigCPtr);
  }

  public int AddItem(uint oidItem, byte* xPos, byte* yPos) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_AddItem(swigCPtr, oidItem, (global::System.IntPtr)xPos, (global::System.IntPtr)yPos);
    return retVal;
  }

  public int RemoveItem(uint oidItem, byte* xPos, byte* yPos) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_RemoveItem(swigCPtr, oidItem, (global::System.IntPtr)xPos, (global::System.IntPtr)yPos);
    return retVal;
  }

  public int MoveItem(uint oidItem, byte* xPos, byte* yPos) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_MoveItem(swigCPtr, oidItem, (global::System.IntPtr)xPos, (global::System.IntPtr)yPos);
    return retVal;
  }

  public int PullItemOut(uint oidItem) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_PullItemOut(swigCPtr, oidItem);
    return retVal;
  }

  public int SetListLocked(int bLocked) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_SetListLocked(swigCPtr, bLocked);
    return retVal;
  }

  public int SetListAccepted(int bAccepted) {
    int retVal = NWNXLibPINVOKE.CNWSBarter_SetListAccepted(swigCPtr, bAccepted);
    return retVal;
  }

  public byte GetState() {
    byte retVal = NWNXLibPINVOKE.CNWSBarter_GetState(swigCPtr);
    return retVal;
  }

}

}
