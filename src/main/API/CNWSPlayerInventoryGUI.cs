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

public unsafe class CNWSPlayerInventoryGUI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerInventoryGUI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerInventoryGUI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerInventoryGUI() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerInventoryGUI(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerInventoryGUI self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerInventoryGUI FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerInventoryGUI((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerInventoryGUI FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerInventoryGUI(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerInventoryGUI other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerInventoryGUI other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerInventoryGUI left, CNWSPlayerInventoryGUI right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerInventoryGUI left, CNWSPlayerInventoryGUI right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSPlayerLUOInventory m_pcLastUpdateInventory {
    set {
      NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_pcLastUpdateInventory_set(swigCPtr, CNWSPlayerLUOInventory.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_pcLastUpdateInventory_get(swigCPtr);
      CNWSPlayerLUOInventory ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventory(cPtr, false);
      return ret;
    } 
  }

  public int m_bGuiInventoryOpen {
    set {
      NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_bGuiInventoryOpen_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_bGuiInventoryOpen_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSelectedInventoryPanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_nSelectedInventoryPanel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_nSelectedInventoryPanel_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidInventoryOwner {
    set {
      NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_oidInventoryOwner_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_oidInventoryOwner_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerContainerGUI m_pContainerGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_pContainerGUI_set(swigCPtr, CNWSPlayerContainerGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerInventoryGUI_m_pContainerGUI_get(swigCPtr);
      CNWSPlayerContainerGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerContainerGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerInventoryGUI() : this(NWNXLibPINVOKE.new_CNWSPlayerInventoryGUI(), true) {
  }

  public void SetOpen(int bOpen, int bClientDirected) {
    NWNXLibPINVOKE.CNWSPlayerInventoryGUI_SetOpen__SWIG_0(swigCPtr, bOpen, bClientDirected);
  }

  public void SetOpen(int bOpen) {
    NWNXLibPINVOKE.CNWSPlayerInventoryGUI_SetOpen__SWIG_1(swigCPtr, bOpen);
  }

  public void SetPanel(CNWSPlayer pPlayer, byte nPanel) {
    NWNXLibPINVOKE.CNWSPlayerInventoryGUI_SetPanel(swigCPtr, CNWSPlayer.getCPtr(pPlayer), nPanel);
  }

  public void SetOwner(uint oidNewOwner) {
    NWNXLibPINVOKE.CNWSPlayerInventoryGUI_SetOwner(swigCPtr, oidNewOwner);
  }

}

}
