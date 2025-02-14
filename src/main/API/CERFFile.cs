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

public unsafe class CERFFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CERFFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CERFFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CERFFile() {
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
          NWNXLibPINVOKE.delete_CERFFile(swigCPtr);
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

  public static unsafe implicit operator void*(CERFFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CERFFile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CERFFile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CERFFile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CERFFile(pointer, memoryOwn) : null;
  }

  public bool Equals(CERFFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CERFFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CERFFile left, CERFFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CERFFile left, CERFFile right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NWERFHEADER m_stHeader {
    set {
      NWNXLibPINVOKE.CERFFile_m_stHeader_set(swigCPtr, NWERFHEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CERFFile_m_stHeader_get(swigCPtr);
      NWERFHEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWERFHEADER(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCERFString m_lstStringList {
    set {
      NWNXLibPINVOKE.CERFFile_m_lstStringList_set(swigCPtr, CExoLinkedListCERFString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CERFFile_m_lstStringList_get(swigCPtr);
      CExoLinkedListCERFString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCERFString(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCERFKey m_lstKeyList {
    set {
      NWNXLibPINVOKE.CERFFile_m_lstKeyList_set(swigCPtr, CExoLinkedListCERFKey.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CERFFile_m_lstKeyList_get(swigCPtr);
      CExoLinkedListCERFKey ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCERFKey(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCERFRes m_lstResList {
    set {
      NWNXLibPINVOKE.CERFFile_m_lstResList_set(swigCPtr, CExoLinkedListCERFRes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CERFFile_m_lstResList_get(swigCPtr);
      CExoLinkedListCERFRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCERFRes(cPtr, false);
      return ret;
    } 
  }

  public CExoFile m_pOutFile {
    set {
      NWNXLibPINVOKE.CERFFile_m_pOutFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CERFFile_m_pOutFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public uint m_nStringOffset {
    set {
      NWNXLibPINVOKE.CERFFile_m_nStringOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFFile_m_nStringOffset_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nKeyOffset {
    set {
      NWNXLibPINVOKE.CERFFile_m_nKeyOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFFile_m_nKeyOffset_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nResOffset {
    set {
      NWNXLibPINVOKE.CERFFile_m_nResOffset_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFFile_m_nResOffset_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nEntries {
    set {
      NWNXLibPINVOKE.CERFFile_m_nEntries_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFFile_m_nEntries_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nCurEntries {
    set {
      NWNXLibPINVOKE.CERFFile_m_nCurEntries_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFFile_m_nCurEntries_get(swigCPtr);
      return retVal;
    }

  }

  public CERFFile() : this(NWNXLibPINVOKE.new_CERFFile(), true) {
  }

  public void SetVersion(byte* sVersion) {
    NWNXLibPINVOKE.CERFFile_SetVersion(swigCPtr, sVersion);
  }

  public int AddResource(CExoString sResourceName) {
    int retVal = NWNXLibPINVOKE.CERFFile_AddResource__SWIG_0(swigCPtr, CExoString.getCPtr(sResourceName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int AddResource(byte* szResName, ushort rtResType, CRes pRes) {
    int retVal = NWNXLibPINVOKE.CERFFile_AddResource__SWIG_1(swigCPtr, szResName, rtResType, CRes.getCPtr(pRes));
    return retVal;
  }

  public int RemoveResource(CExoString sResourceName, ushort a_wResourceType) {
    int retVal = NWNXLibPINVOKE.CERFFile_RemoveResource__SWIG_0(swigCPtr, CExoString.getCPtr(sResourceName), a_wResourceType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int RemoveResource(CERFRes pData) {
    int retVal = NWNXLibPINVOKE.CERFFile_RemoveResource__SWIG_1(swigCPtr, CERFRes.getCPtr(pData));
    return retVal;
  }

  public int AddString(CERFString pString) {
    int retVal = NWNXLibPINVOKE.CERFFile_AddString(swigCPtr, CERFString.getCPtr(pString));
    return retVal;
  }

  public int Read() {
    int retVal = NWNXLibPINVOKE.CERFFile_Read(swigCPtr);
    return retVal;
  }

  public int Reset() {
    int retVal = NWNXLibPINVOKE.CERFFile_Reset(swigCPtr);
    return retVal;
  }

  public int Write(CExoString sFilename) {
    int retVal = NWNXLibPINVOKE.CERFFile_Write(swigCPtr, CExoString.getCPtr(sFilename));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void RecalculateOffsets() {
    NWNXLibPINVOKE.CERFFile_RecalculateOffsets(swigCPtr);
  }

  public int Create(CExoString sOutFile) {
    int retVal = NWNXLibPINVOKE.CERFFile_Create(swigCPtr, CExoString.getCPtr(sOutFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteHeader() {
    int retVal = NWNXLibPINVOKE.CERFFile_WriteHeader(swigCPtr);
    return retVal;
  }

  public int WriteStringTable() {
    int retVal = NWNXLibPINVOKE.CERFFile_WriteStringTable(swigCPtr);
    return retVal;
  }

  public int SetNumEntries(uint nEntries) {
    int retVal = NWNXLibPINVOKE.CERFFile_SetNumEntries(swigCPtr, nEntries);
    return retVal;
  }

  public int WriteResource(byte* szResName, ushort rtResType, CRes pRes, int bIsGFF) {
    int retVal = NWNXLibPINVOKE.CERFFile_WriteResource__SWIG_0(swigCPtr, szResName, rtResType, CRes.getCPtr(pRes), bIsGFF);
    return retVal;
  }

  public int WriteResource(byte* szResName, ushort rtResType, CRes pRes) {
    int retVal = NWNXLibPINVOKE.CERFFile_WriteResource__SWIG_1(swigCPtr, szResName, rtResType, CRes.getCPtr(pRes));
    return retVal;
  }

  public int Finish() {
    int retVal = NWNXLibPINVOKE.CERFFile_Finish(swigCPtr);
    return retVal;
  }

}

}
