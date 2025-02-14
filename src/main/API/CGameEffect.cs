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

public unsafe class CGameEffect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGameEffect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CGameEffect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGameEffect() {
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
          NWNXLibPINVOKE.delete_CGameEffect(swigCPtr);
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

  public static unsafe implicit operator void*(CGameEffect self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CGameEffect FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CGameEffect((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CGameEffect FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CGameEffect(pointer, memoryOwn) : null;
  }

  public bool Equals(CGameEffect other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CGameEffect other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CGameEffect left, CGameEffect right) {
    return Equals(left, right);
  }

  public static bool operator !=(CGameEffect left, CGameEffect right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public ulong m_nID {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nID_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CGameEffect_m_nID_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nType {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CGameEffect_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nSubType {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nSubType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CGameEffect_m_nSubType_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fDuration {
    set {
      NWNXLibPINVOKE.CGameEffect_m_fDuration_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CGameEffect_m_fDuration_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nExpiryCalendarDay {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nExpiryCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CGameEffect_m_nExpiryCalendarDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nExpiryTimeOfDay {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nExpiryTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CGameEffect_m_nExpiryTimeOfDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidCreator {
    set {
      NWNXLibPINVOKE.CGameEffect_m_oidCreator_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CGameEffect_m_oidCreator_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nSpellId {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CGameEffect_m_nSpellId_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bExpose {
    set {
      NWNXLibPINVOKE.CGameEffect_m_bExpose_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CGameEffect_m_bExpose_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bShowIcon {
    set {
      NWNXLibPINVOKE.CGameEffect_m_bShowIcon_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CGameEffect_m_bShowIcon_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nCasterLevel {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nCasterLevel_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CGameEffect_m_nCasterLevel_get(swigCPtr);
      return retVal;
    }

  }

  public CGameEffect m_pLinkLeft {
    set {
      NWNXLibPINVOKE.CGameEffect_m_pLinkLeft_set(swigCPtr, CGameEffect.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameEffect_m_pLinkLeft_get(swigCPtr);
      CGameEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffect(cPtr, false);
      return ret;
    } 
  }

  public CGameEffect m_pLinkRight {
    set {
      NWNXLibPINVOKE.CGameEffect_m_pLinkRight_set(swigCPtr, CGameEffect.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameEffect_m_pLinkRight_get(swigCPtr);
      CGameEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffect(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumIntegers {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nNumIntegers_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CGameEffect_m_nNumIntegers_get(swigCPtr);
      return retVal;
    }

  }

  public int* m_nParamInteger {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nParamInteger_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CGameEffect_m_nParamInteger_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<float> m_nParamFloat {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nParamFloat_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CGameEffect_m_nParamFloat_get(swigCPtr);
      NativeArray<float> retVal = new NativeArray<float>(arrayPtr, 4);

      return retVal; // float[4]
    }

  }

  public CExoStringArray m_sParamString {
    set {
      NWNXLibPINVOKE.CGameEffect_m_sParamString_set(swigCPtr, CExoStringArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameEffect_m_sParamString_get(swigCPtr);;
        CExoStringArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringArray(cPtr, false);
        return ret;
    }

  }

  public NativeArray<uint> m_oidParamObjectID {
    set {
      NWNXLibPINVOKE.CGameEffect_m_oidParamObjectID_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CGameEffect_m_oidParamObjectID_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 4);

      return retVal; // uint[4]
    }

  }

  public VectorArray m_vParamVector {
    set {
      NWNXLibPINVOKE.CGameEffect_m_vParamVector_set(swigCPtr, VectorArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameEffect_m_vParamVector_get(swigCPtr);;
        VectorArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorArray(cPtr, false);
        return ret;
    }

  }

  public int m_bSkipOnLoad {
    set {
      NWNXLibPINVOKE.CGameEffect_m_bSkipOnLoad_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CGameEffect_m_bSkipOnLoad_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nItemPropertySourceId {
    set {
      NWNXLibPINVOKE.CGameEffect_m_nItemPropertySourceId_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CGameEffect_m_nItemPropertySourceId_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sCustomTag {
    set {
      NWNXLibPINVOKE.CGameEffect_m_sCustomTag_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameEffect_m_sCustomTag_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CGameEffect(int bCreateNewID) : this(NWNXLibPINVOKE.new_CGameEffect__SWIG_0(bCreateNewID), true) {
  }

  public CGameEffect() : this(NWNXLibPINVOKE.new_CGameEffect__SWIG_1(), true) {
  }

  public CGameEffect(CGameEffect pParent, int bCopyIconVisibility) : this(NWNXLibPINVOKE.new_CGameEffect__SWIG_2(CGameEffect.getCPtr(pParent), bCopyIconVisibility), true) {
  }

  public CGameEffect(CGameEffect pParent) : this(NWNXLibPINVOKE.new_CGameEffect__SWIG_3(CGameEffect.getCPtr(pParent)), true) {
  }

  public CGameEffect _OpAssign(CGameEffect effect) {
    CGameEffect ret = new CGameEffect(NWNXLibPINVOKE.CGameEffect__OpAssign(swigCPtr, CGameEffect.getCPtr(effect)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetScriptEffectType() {
    int retVal = NWNXLibPINVOKE.CGameEffect_GetScriptEffectType(swigCPtr);
    return retVal;
  }

  public void SetCreator(uint oidCreator) {
    NWNXLibPINVOKE.CGameEffect_SetCreator(swigCPtr, oidCreator);
  }

  public int GetInteger(int nStorageLocation) {
    int retVal = NWNXLibPINVOKE.CGameEffect_GetInteger(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetInteger(int nStorageLocation, int nValue) {
    NWNXLibPINVOKE.CGameEffect_SetInteger(swigCPtr, nStorageLocation, nValue);
  }

  public void SetNumIntegers(int nNumIntegers) {
    NWNXLibPINVOKE.CGameEffect_SetNumIntegers(swigCPtr, nNumIntegers);
  }

  public void SetNumIntegersInitializeToNegativeOne(int nNumIntegers) {
    NWNXLibPINVOKE.CGameEffect_SetNumIntegersInitializeToNegativeOne(swigCPtr, nNumIntegers);
  }

  public float GetFloat(int nStorageLocation) {
    float retVal = NWNXLibPINVOKE.CGameEffect_GetFloat(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetFloat(int nStorageLocation, float fValue) {
    NWNXLibPINVOKE.CGameEffect_SetFloat(swigCPtr, nStorageLocation, fValue);
  }

  public uint GetObjectID(int nStorageLocation) {
    uint retVal = NWNXLibPINVOKE.CGameEffect_GetObjectID(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetObjectID(int nStorageLocation, uint oidValue) {
    NWNXLibPINVOKE.CGameEffect_SetObjectID(swigCPtr, nStorageLocation, oidValue);
  }

  public CExoString GetString(int nStorageLocation) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CGameEffect_GetString(swigCPtr, nStorageLocation), true);
    return ret;
  }

  public void SetString(int nStorageLocation, CExoString sString) {
    NWNXLibPINVOKE.CGameEffect_SetString(swigCPtr, nStorageLocation, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector GetVector(int nStorageLocation) {
    Vector ret = new Vector(NWNXLibPINVOKE.CGameEffect_GetVector(swigCPtr, nStorageLocation), true);
    return ret;
  }

  public void SetVector(int nStorageLocation, Vector vVector) {
    NWNXLibPINVOKE.CGameEffect_SetVector(swigCPtr, nStorageLocation, Vector.getCPtr(vVector));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int _OpEquals(CGameEffect effect) {
    int retVal = NWNXLibPINVOKE.CGameEffect__OpEquals(swigCPtr, CGameEffect.getCPtr(effect));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int _OpNotEquals(CGameEffect effect) {
    int retVal = NWNXLibPINVOKE.CGameEffect__OpNotEquals(swigCPtr, CGameEffect.getCPtr(effect));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void CopyEffect(CGameEffect pEffect, int bIgnoreArrayLists) {
    NWNXLibPINVOKE.CGameEffect_CopyEffect__SWIG_0(swigCPtr, CGameEffect.getCPtr(pEffect), bIgnoreArrayLists);
  }

  public void CopyEffect(CGameEffect pEffect) {
    NWNXLibPINVOKE.CGameEffect_CopyEffect__SWIG_1(swigCPtr, CGameEffect.getCPtr(pEffect));
  }

  public void SetExpiryTime(uint nCalendarDayExpiry, uint nTimeOfDayExpiry) {
    NWNXLibPINVOKE.CGameEffect_SetExpiryTime(swigCPtr, nCalendarDayExpiry, nTimeOfDayExpiry);
  }

  public void GetExpiryTime(uint* nCurrentCalendarDay, uint* nCurrentTimeOfDay) {
    NWNXLibPINVOKE.CGameEffect_GetExpiryTime(swigCPtr, nCurrentCalendarDay, nCurrentTimeOfDay);
  }

  public CExoString GetCustomTag() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CGameEffect_GetCustomTag(swigCPtr), true);
    return ret;
  }

  public void SetCustomTag(CExoString sTag) {
    NWNXLibPINVOKE.CGameEffect_SetCustomTag(swigCPtr, CExoString.getCPtr(sTag));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLinked(CGameEffect pLeft, CGameEffect pRight) {
    NWNXLibPINVOKE.CGameEffect_SetLinked(swigCPtr, CGameEffect.getCPtr(pLeft), CGameEffect.getCPtr(pRight));
  }

  public void UpdateLinked(int bUpdateIconVisibility) {
    NWNXLibPINVOKE.CGameEffect_UpdateLinked__SWIG_0(swigCPtr, bUpdateIconVisibility);
  }

  public void UpdateLinked() {
    NWNXLibPINVOKE.CGameEffect_UpdateLinked__SWIG_1(swigCPtr);
  }

  public void SaveGameEffect(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CGameEffect_SaveGameEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public void LoadGameEffect(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CGameEffect_LoadGameEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public ushort GetDurationType() {
    ushort retVal = NWNXLibPINVOKE.CGameEffect_GetDurationType(swigCPtr);
    return retVal;
  }

  public void SetDurationType(ushort nDurationType) {
    NWNXLibPINVOKE.CGameEffect_SetDurationType(swigCPtr, nDurationType);
  }

  public ushort GetSubType() {
    ushort retVal = NWNXLibPINVOKE.CGameEffect_GetSubType(swigCPtr);
    return retVal;
  }

  public void SetSubType(ushort nType) {
    NWNXLibPINVOKE.CGameEffect_SetSubType(swigCPtr, nType);
  }

  public int GetSubType_Magical() {
    int retVal = NWNXLibPINVOKE.CGameEffect_GetSubType_Magical(swigCPtr);
    return retVal;
  }

  public void SetSubType_Magical() {
    NWNXLibPINVOKE.CGameEffect_SetSubType_Magical(swigCPtr);
  }

  public int GetSubType_Supernatural() {
    int retVal = NWNXLibPINVOKE.CGameEffect_GetSubType_Supernatural(swigCPtr);
    return retVal;
  }

  public void SetSubType_Supernatural() {
    NWNXLibPINVOKE.CGameEffect_SetSubType_Supernatural(swigCPtr);
  }

  public int GetSubType_Extraordinary() {
    int retVal = NWNXLibPINVOKE.CGameEffect_GetSubType_Extraordinary(swigCPtr);
    return retVal;
  }

  public void SetSubType_Extraordinary() {
    NWNXLibPINVOKE.CGameEffect_SetSubType_Extraordinary(swigCPtr);
  }

}

}
