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

public unsafe class CNWSCreatureStats_ClassInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSCreatureStats_ClassInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCreatureStats_ClassInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCreatureStats_ClassInfo() {
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
          NWNXLibPINVOKE.delete_CNWSCreatureStats_ClassInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCreatureStats_ClassInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSCreatureStats_ClassInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSCreatureStats_ClassInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSCreatureStats_ClassInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSCreatureStats_ClassInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSCreatureStats_ClassInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCreatureStats_ClassInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCreatureStats_ClassInfo left, CNWSCreatureStats_ClassInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCreatureStats_ClassInfo left, CNWSCreatureStats_ClassInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListUInt32Array m_pKnownSpellList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pKnownSpellList_set(swigCPtr, CExoArrayListUInt32Array.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pKnownSpellList_get(swigCPtr);;
        CExoArrayListUInt32Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32Array(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListCNWSStatsSpellPtrArray m_pMemorizedSpellList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pMemorizedSpellList_set(swigCPtr, CExoArrayListCNWSStatsSpellPtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pMemorizedSpellList_get(swigCPtr);;
        CExoArrayListCNWSStatsSpellPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSStatsSpellPtrArray(cPtr, false);
        return ret;
    }

  }

  public NativeArray<uint> m_nBonusSpellsList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nBonusSpellsList_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nBonusSpellsList_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 10);

      return retVal; // uint[10]
    }

  }

  public NativeArray<byte> m_nSpellsPerDayLeft {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSpellsPerDayLeft_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSpellsPerDayLeft_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 10);

      return retVal; // byte[10]
    }

  }

  public NativeArray<byte> m_nMaxSpellsPerDayLeft {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nMaxSpellsPerDayLeft_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nMaxSpellsPerDayLeft_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 10);

      return retVal; // byte[10]
    }

  }

  public byte m_nClass {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nClass_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nClass_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nLevel {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nLevel_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nNegativeLevels {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nNegativeLevels_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nNegativeLevels_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSchool {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSchool_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSchool_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_nDomain {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nDomain_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nDomain_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 2);

      return retVal; // byte[2]
    }

  }

  public int m_bHasLostClassAbilities {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_bHasLostClassAbilities_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_bHasLostClassAbilities_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSCreatureStats_ClassInfo() : this(NWNXLibPINVOKE.new_CNWSCreatureStats_ClassInfo(), true) {
  }

  public void SetMemorizedSpellSlot(byte nSpellLevel, byte nSpellSlot, uint nSpellId, int bDomainSpell, byte nMetaType) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMemorizedSpellSlot(swigCPtr, nSpellLevel, nSpellSlot, nSpellId, bDomainSpell, nMetaType);
  }

  public void ClearMemorizedSpellSlot(byte nSpellLevel, byte nSpellSlot) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ClearMemorizedSpellSlot(swigCPtr, nSpellLevel, nSpellSlot);
  }

  public void ClearMemorizedKnownSpells(uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ClearMemorizedKnownSpells(swigCPtr, nSpellId);
  }

  public void AddKnownSpell(byte nSpellLevel, uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_AddKnownSpell(swigCPtr, nSpellLevel, nSpellId);
  }

  public void RemoveKnownSpell(byte nSpellLevel, uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_RemoveKnownSpell(swigCPtr, nSpellLevel, nSpellId);
  }

  public uint GetKnownSpell(byte nSpellLevel, byte nSpellListIndex) {
    uint retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetKnownSpell(swigCPtr, nSpellLevel, nSpellListIndex);
    return retVal;
  }

  public uint GetMemorizedSpellInSlot(byte nSpellLevel, byte nSpellSlot) {
    uint retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlot(swigCPtr, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public int GetIsDomainSpell(byte nSpellLevel, byte nSpellSlot) {
    int retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetIsDomainSpell(swigCPtr, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public int ConfirmDomainSpell(byte nSpellLevel, uint nSpellID) {
    int retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ConfirmDomainSpell(swigCPtr, nSpellLevel, nSpellID);
    return retVal;
  }

  public CNWSStats_Spell GetMemorizedSpellInSlotDetails(byte nSpellLevel, byte nSpellSlot) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotDetails(swigCPtr, nSpellLevel, nSpellSlot);
    CNWSStats_Spell ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_Spell(cPtr, false);
    return ret;
  }

  public ushort GetNumberKnownSpells(byte nSpellLevel) {
    ushort retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberKnownSpells(swigCPtr, nSpellLevel);
    return retVal;
  }

  public byte GetNumberMemorizedSpellSlots(byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberMemorizedSpellSlots(swigCPtr, nSpellLevel);
    return retVal;
  }

  public void SetNumberMemorizedSpellSlots(byte nSpellLevel, byte nNumSlots, int bClear) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetNumberMemorizedSpellSlots__SWIG_0(swigCPtr, nSpellLevel, nNumSlots, bClear);
  }

  public void SetNumberMemorizedSpellSlots(byte nSpellLevel, byte nNumSlots) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetNumberMemorizedSpellSlots__SWIG_1(swigCPtr, nSpellLevel, nNumSlots);
  }

  public byte GetNumberBonusSpells(byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberBonusSpells(swigCPtr, nSpellLevel);
    return retVal;
  }

  public void ModifyNumberBonusSpells(byte nSpellLevel, int nDelta) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ModifyNumberBonusSpells(swigCPtr, nSpellLevel, nDelta);
  }

  public int GetMemorizedSpellInSlotReady(byte nSpellLevel, byte nSpellSlot) {
    int retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotReady(swigCPtr, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public void SetMemorizedSpellInSlotReady(byte nSpellLevel, byte nSpellSlot, int bReady) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMemorizedSpellInSlotReady(swigCPtr, nSpellLevel, nSpellSlot, bReady);
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte* nMinSpellLevel, byte* nMinSpellSlot, byte nRequestedMetaType) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_0(swigCPtr, nSpellID, nMinSpellLevel, nMinSpellSlot, nRequestedMetaType);
    return retVal;
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte* nMinSpellLevel, byte* nMinSpellSlot) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_1(swigCPtr, nSpellID, nMinSpellLevel, nMinSpellSlot);
    return retVal;
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_2(swigCPtr, nSpellID, nSpellLevel);
    return retVal;
  }

  public byte GetMemorizedSpellInSlotMetaType(byte nSpellLevel, byte nSpellSlot) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotMetaType(swigCPtr, nSpellLevel, nSpellSlot);
    return retVal;
  }

  public byte GetSpellsPerDayLeft(byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetSpellsPerDayLeft(swigCPtr, nSpellLevel);
    return retVal;
  }

  public void SetSpellsPerDayLeft(byte nSpellLevel, byte nNumSpells) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetSpellsPerDayLeft(swigCPtr, nSpellLevel, nNumSpells);
  }

  public byte GetMaxSpellsPerDayLeft(byte nSpellLevel) {
    byte retVal = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMaxSpellsPerDayLeft(swigCPtr, nSpellLevel);
    return retVal;
  }

  public void SetMaxSpellsPerDayLeft(byte nSpellLevel, byte nNumSpells) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMaxSpellsPerDayLeft(swigCPtr, nSpellLevel, nNumSpells);
  }

  public void DecrementSpellsPerDayLeft(byte nSpellLevel) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_DecrementSpellsPerDayLeft(swigCPtr, nSpellLevel);
  }

  public void IncrementSpellsPerDayLeft(byte nSpellLevel) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_IncrementSpellsPerDayLeft(swigCPtr, nSpellLevel);
  }

  public void ResetSpellsPerDayLeft(byte nSpellLevel, byte nSpellGain) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ResetSpellsPerDayLeft(swigCPtr, nSpellLevel, nSpellGain);
  }

}

}
