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

public unsafe class CNWSDoor : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSDoor(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSDoor_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDoor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSDoor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/DotNETExtensions.i,1,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSDoor self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDoor FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDoor((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDoor FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDoor(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDoor other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDoor other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDoor left, CNWSDoor right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDoor left, CNWSDoor right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoStringArray m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sScripts_set(swigCPtr, CExoStringArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sScripts_get(swigCPtr);;
        CExoStringArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringArray(cPtr, false);
        return ret;
    }

  }

  public uint m_nAppearanceType {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nAppearanceType_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_nAppearanceType_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nGenericType {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nGenericType_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_nGenericType_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_cDialog {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_cDialog_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_cDialog_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public float m_fBearing {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_fBearing_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSDoor_m_fBearing_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nFactionId {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nFactionId_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_nFactionId_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nFortitudeSave {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nFortitudeSave_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nFortitudeSave_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nReflexSave {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nReflexSave_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nReflexSave_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nWillSave {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nWillSave_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nWillSave_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nOpenLockDC {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nOpenLockDC_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nOpenLockDC_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nLockDC {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nLockDC_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nLockDC_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSecretDoorDC {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nSecretDoorDC_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nSecretDoorDC_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nHardness {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nHardness_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nHardness_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLocked {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bLocked_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bLocked_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLockable {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bLockable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bLockable_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nOpenState {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nOpenState_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nOpenState_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sKeyName {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sKeyName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sKeyName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sKeyRequiredFeedbackMessage {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sKeyRequiredFeedbackMessage_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sKeyRequiredFeedbackMessage_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bKeyRequired {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bKeyRequired_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bKeyRequired_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListUInt32 m_poidCreatures {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_poidCreatures_set(swigCPtr, CExoArrayListUInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_poidCreatures_get(swigCPtr);
      CExoArrayListUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidTrapCreator {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidTrapCreator_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidTrapCreator_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bTrapped {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bTrapped_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bTrapped_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDisarmDC {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nDisarmDC_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nDisarmDC_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDetectDC {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nDetectDC_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nDetectDC_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bAutoRemoveKey {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bAutoRemoveKey_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bAutoRemoveKey_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFlagged {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bFlagged_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bFlagged_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nBaseType {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nBaseType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDoor_m_nBaseType_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDisarmable {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bDisarmable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bDisarmable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDetectable {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bDetectable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bDetectable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bOneShot {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bOneShot_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bOneShot_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bRecoverable {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bRecoverable_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bRecoverable_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bTrapIsActive {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bTrapIsActive_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bTrapIsActive_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nTrapFactionId {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nTrapFactionId_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_nTrapFactionId_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bVisibleModel {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_bVisibleModel_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_bVisibleModel_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastLocked {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastLocked_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastLocked_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastUnlocked {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastUnlocked_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastUnlocked_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastOpened {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastOpened_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastOpened_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastClosed {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastClosed_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastClosed_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastTriggered {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastTriggered_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastTriggered_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastDisarmed {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_oidLastDisarmed_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDoor_m_oidLastDisarmed_get(swigCPtr);
      return retVal;
    }

  }

  public CNWDoorSurfaceMesh m_pWalkMesh {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_pWalkMesh_set(swigCPtr, CNWDoorSurfaceMesh.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_pWalkMesh_get(swigCPtr);
      CNWDoorSurfaceMesh ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWDoorSurfaceMesh(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vBoundingBoxMin {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_vBoundingBoxMin_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_vBoundingBoxMin_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vBoundingBoxMax {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_vBoundingBoxMax_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_vBoundingBoxMax_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sLocName {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sLocName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sLocName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sDescription {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sDescription_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sDescription_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDescriptionOverride {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sDescriptionOverride_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sDescriptionOverride_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDisplayName {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_sDisplayName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_m_sDisplayName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nUpdateDisplayNameSeq {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nUpdateDisplayNameSeq_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDoor_m_nUpdateDisplayNameSeq_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nLoadScreenID {
    set {
      NWNXLibPINVOKE.CNWSDoor_m_nLoadScreenID_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSDoor_m_nLoadScreenID_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSDoor(uint oidId) : this(NWNXLibPINVOKE.new_CNWSDoor__SWIG_0(oidId), true) {
  }

  public CNWSDoor() : this(NWNXLibPINVOKE.new_CNWSDoor__SWIG_1(), true) {
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSDoor_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSDoor_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSDoor_AIUpdate(swigCPtr);
  }

  public override CNWSDoor AsNWSDoor() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDoor_AsNWSDoor(swigCPtr);
    CNWSDoor ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDoor(cPtr, false);
    return ret;
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSDoor_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public int LoadDoor(CResGFF pRes, CResStruct cItemStruct) {
    int retVal = NWNXLibPINVOKE.CNWSDoor_LoadDoor(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cItemStruct));
    return retVal;
  }

  public int SaveDoor(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWSDoor_SaveDoor(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public void PostProcess() {
    NWNXLibPINVOKE.CNWSDoor_PostProcess(swigCPtr);
  }

  public override void DoDamage(int nDamage) {
    NWNXLibPINVOKE.CNWSDoor_DoDamage(swigCPtr, nDamage);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSDoor_RemoveFromArea(swigCPtr);
  }

  public void SetOpenState(byte nOpenState) {
    NWNXLibPINVOKE.CNWSDoor_SetOpenState(swigCPtr, nOpenState);
  }

  public byte GetOpenState() {
    byte retVal = NWNXLibPINVOKE.CNWSDoor_GetOpenState(swigCPtr);
    return retVal;
  }

  public int NoNonWalkPolysInDoor(float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace) {
    int retVal = NWNXLibPINVOKE.CNWSDoor_NoNonWalkPolysInDoor(swigCPtr, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace);
    return retVal;
  }

  public Vector GetActionPoint(int nAnimation, byte nPositionNumber) {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSDoor_GetActionPoint(swigCPtr, nAnimation, nPositionNumber), true);
    return ret;
  }

  public Vector GetNearestActionPoint(Vector vCloseTo, int bPretendDoorIsClosed) {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSDoor_GetNearestActionPoint__SWIG_0(swigCPtr, Vector.getCPtr(vCloseTo), bPretendDoorIsClosed), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector GetNearestActionPoint(Vector vCloseTo) {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSDoor_GetNearestActionPoint__SWIG_1(swigCPtr, Vector.getCPtr(vCloseTo)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
