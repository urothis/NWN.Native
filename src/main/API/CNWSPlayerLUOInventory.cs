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

public unsafe class CNWSPlayerLUOInventory : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerLUOInventory(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerLUOInventory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerLUOInventory() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerLUOInventory(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerLUOInventory self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerLUOInventory FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerLUOInventory((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerLUOInventory FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerLUOInventory(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerLUOInventory other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerLUOInventory other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerLUOInventory left, CNWSPlayerLUOInventory right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerLUOInventory left, CNWSPlayerLUOInventory right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<uint> m_oidInventorySlots {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_oidInventorySlots_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_oidInventorySlots_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 18);

      return retVal; // uint[18]
    }

  }

  public NativeArray<int> m_nStackSizes {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nStackSizes_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nStackSizes_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 18);

      return retVal; // int[18]
    }

  }

  public CExoLinkedListCNWSPlayerLUOInventoryItem m_pOldRepositoryItems {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldRepositoryItems_set(swigCPtr, CExoLinkedListCNWSPlayerLUOInventoryItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldRepositoryItems_get(swigCPtr);
      CExoLinkedListCNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCNWSPlayerLUOInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidContainer {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_oidContainer_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_oidContainer_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLinkedListCNWSPlayerLUOInventoryItem m_pOldContainerItems {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldContainerItems_set(swigCPtr, CExoLinkedListCNWSPlayerLUOInventoryItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldContainerItems_get(swigCPtr);
      CExoLinkedListCNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCNWSPlayerLUOInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public byte m_nOldContainerNumPages {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldContainerNumPages_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldContainerNumPages_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLinkedListCNWSPlayerLUOInventoryItem m_pOldBarterItems {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldBarterItems_set(swigCPtr, CExoLinkedListCNWSPlayerLUOInventoryItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldBarterItems_get(swigCPtr);
      CExoLinkedListCNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCNWSPlayerLUOInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSPlayerLUOInventoryItem m_pOldStoreItems {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldStoreItems_set(swigCPtr, CExoLinkedListCNWSPlayerLUOInventoryItem.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_pOldStoreItems_get(swigCPtr);
      CExoLinkedListCNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCNWSPlayerLUOInventoryItem(cPtr, false);
      return ret;
    } 
  }

  public byte m_nOldStoreNumPages {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldStoreNumPages_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldStoreNumPages_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nOldStoreCurrentPanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldStoreCurrentPanel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_m_nOldStoreCurrentPanel_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerLUOInventory() : this(NWNXLibPINVOKE.new_CNWSPlayerLUOInventory(), true) {
  }

  public void ClearSlots() {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ClearSlots(swigCPtr);
  }

  public void ClearRepository() {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ClearRepository(swigCPtr);
  }

  public void ClearContainer() {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ClearContainer(swigCPtr);
  }

  public void ClearBarter() {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ClearBarter(swigCPtr);
  }

  public void ClearStore() {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ClearStore(swigCPtr);
  }

  public void ItemListSetStart(void** pListPosition, byte nItemList) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListSetStart(swigCPtr, (global::System.IntPtr)pListPosition, nItemList);
  }

  public void ItemListSetEnd(void** pListPosition, byte nItemList) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListSetEnd(swigCPtr, (global::System.IntPtr)pListPosition, nItemList);
  }

  public CNWSItem ItemListGetItem(CExoLinkedListNode pListPosition, byte nItemList) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetItem(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition), nItemList);
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public uint ItemListGetItemObjectID(CExoLinkedListNode pListPosition, byte nItemList) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetItemObjectID(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition), nItemList);
    return retVal;
  }

  public CNWSPlayerLUOInventoryItem ItemListGetUpdateItem(CExoLinkedListNode pListPosition, byte nItemList) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetUpdateItem(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition), nItemList);
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public void ItemListGetNext(void** pListPosition, byte nItemList) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetNext(swigCPtr, (global::System.IntPtr)pListPosition, nItemList);
  }

  public void ItemListGetPrev(void** pListPosition, byte nItemList) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetPrev(swigCPtr, (global::System.IntPtr)pListPosition, nItemList);
  }

  public void ItemListRemove(CExoLinkedListNode pListPosition, byte nItemList) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListRemove(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition), nItemList);
  }

  public void ItemListAddHead(uint nID, byte nItemList, byte xPos, byte yPos, uint nStackSize, uint nCost) {
    NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListAddHead(swigCPtr, nID, nItemList, xPos, yPos, nStackSize, nCost);
  }

  public uint ItemListGetNumber(byte nItemList) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayerLUOInventory_ItemListGetNumber(swigCPtr, nItemList);
    return retVal;
  }

}

}
