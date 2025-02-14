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

public static unsafe class NWNXLib {
  public static uint OBJECT_INVALID {
    get {
      uint retVal = NWNXLibPINVOKE.OBJECT_INVALID_get();
      return retVal;
    }

  }

  public static uint PLAYERID_ALL_SERVERADMINS {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_ALL_SERVERADMINS_get();
      return retVal;
    }

  }

  public static uint PLAYERID_ALL_GAMEMASTERS {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_ALL_GAMEMASTERS_get();
      return retVal;
    }

  }

  public static uint PLAYERID_ALL_PLAYERS {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_ALL_PLAYERS_get();
      return retVal;
    }

  }

  public static uint PLAYERID_SERVER {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_SERVER_get();
      return retVal;
    }

  }

  public static uint PLAYERID_INVALIDID {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_INVALIDID_get();
      return retVal;
    }

  }

  public static uint PLAYERID_ALL_CLIENTS {
    get {
      uint retVal = NWNXLibPINVOKE.PLAYERID_ALL_CLIENTS_get();
      return retVal;
    }

  }

  public static NWNXExportedGlobals ExportedGlobals {
    set {
      NWNXLibPINVOKE.ExportedGlobals_set(NWNXExportedGlobals.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.ExportedGlobals_get();
      NWNXExportedGlobals ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWNXExportedGlobals(cPtr, false);
      return ret;
    } 
  }

  public static CExoString BuildNumber() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.BuildNumber();
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public static CExoString BuildRevision() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.BuildRevision();
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public static CExoBase ExoBase() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.ExoBase();
    CExoBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoBase(cPtr, false);
    return ret;
  }

  public static CExoResMan ExoResMan() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.ExoResMan();
    CExoResMan ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoResMan(cPtr, false);
    return ret;
  }

  public static CVirtualMachine VirtualMachine() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.VirtualMachine();
    CVirtualMachine ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachine(cPtr, false);
    return ret;
  }

  public static CScriptCompiler ScriptCompiler() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.ScriptCompiler();
    CScriptCompiler ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptCompiler(cPtr, false);
    return ret;
  }

  public static CAppManager AppManager() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.AppManager();
    CAppManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAppManager(cPtr, false);
    return ret;
  }

  public static CTlkTable TlkTable() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.TlkTable();
    CTlkTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkTable(cPtr, false);
    return ret;
  }

  public static CNWRules Rules() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.Rules();
    CNWRules ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWRules(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_Task__CExoTaskManager TaskManager() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.TaskManager();
    SWIGTYPE_p_Task__CExoTaskManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Task__CExoTaskManager(cPtr, false);
    return ret;
  }

  public static int* EnableCombatDebugging() {
    int* retVal = NWNXLibPINVOKE.EnableCombatDebugging();
    return retVal;
  }

  public static int* EnableSavingThrowDebugging() {
    int* retVal = NWNXLibPINVOKE.EnableSavingThrowDebugging();
    return retVal;
  }

  public static int* EnableMovementSpeedDebugging() {
    int* retVal = NWNXLibPINVOKE.EnableMovementSpeedDebugging();
    return retVal;
  }

  public static int* EnableHitDieDebugging() {
    int* retVal = NWNXLibPINVOKE.EnableHitDieDebugging();
    return retVal;
  }

  public static int* ExitProgram() {
    int* retVal = NWNXLibPINVOKE.ExitProgram();
    return retVal;
  }

}

}
