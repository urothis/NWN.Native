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

public unsafe class CExtendedServerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExtendedServerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExtendedServerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExtendedServerInfo() {
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
          NWNXLibPINVOKE.delete_CExtendedServerInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CExtendedServerInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExtendedServerInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExtendedServerInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExtendedServerInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExtendedServerInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CExtendedServerInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExtendedServerInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExtendedServerInfo left, CExtendedServerInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExtendedServerInfo left, CExtendedServerInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bPasswordRequired {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bPasswordRequired_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bPasswordRequired_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMinLevel {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nMinLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nMinLevel_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMaxLevel {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nMaxLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nMaxLevel_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nPlayerCount {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nPlayerCount_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nPlayerCount_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMaxPlayers {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nMaxPlayers_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nMaxPlayers_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sModuleName {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_sModuleName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo_m_sModuleName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bAllowLocalVaultChars {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bAllowLocalVaultChars_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bAllowLocalVaultChars_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPauseAndPlay {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bPauseAndPlay_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bPauseAndPlay_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bMultiplayerEnabled {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bMultiplayerEnabled_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bMultiplayerEnabled_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nPVPSetting {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nPVPSetting_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nPVPSetting_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nExpansionPacksRequired {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nExpansionPacksRequired_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nExpansionPacksRequired_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sServerName {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_sServerName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo_m_sServerName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sModuleDescription {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_sModuleDescription_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo_m_sModuleDescription_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sGameDetails {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_sGameDetails_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo_m_sGameDetails_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sBuild {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_sBuild_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo_m_sBuild_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public short m_nGameType {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_nGameType_set(swigCPtr, value);
    } 
    get {
      short retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_nGameType_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bOnePartyOnly {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bOnePartyOnly_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bOnePartyOnly_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLegalChars {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bLegalChars_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bLegalChars_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bItemRestrict {
    set {
      NWNXLibPINVOKE.CExtendedServerInfo_m_bItemRestrict_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExtendedServerInfo_m_bItemRestrict_get(swigCPtr);
      return retVal;
    }

  }

  public CExtendedServerInfo _OpAssign(CNetLayerSessionInfo pIn) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExtendedServerInfo__OpAssign(swigCPtr, CNetLayerSessionInfo.getCPtr(pIn));
    CExtendedServerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExtendedServerInfo(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExtendedServerInfo() : this(NWNXLibPINVOKE.new_CExtendedServerInfo(), true) {
  }

}

}
