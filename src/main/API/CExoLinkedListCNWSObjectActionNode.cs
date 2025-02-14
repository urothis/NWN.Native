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

public unsafe class CExoLinkedListCNWSObjectActionNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCNWSObjectActionNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCNWSObjectActionNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCNWSObjectActionNode() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCNWSObjectActionNode(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCNWSObjectActionNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCNWSObjectActionNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCNWSObjectActionNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCNWSObjectActionNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCNWSObjectActionNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCNWSObjectActionNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCNWSObjectActionNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCNWSObjectActionNode left, CExoLinkedListCNWSObjectActionNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCNWSObjectActionNode left, CExoLinkedListCNWSObjectActionNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSObjectActionNode() : this(NWNXLibPINVOKE.new_CExoLinkedListCNWSObjectActionNode(), true) {
  }

  public CExoLinkedListNode AddHead(CNWSObjectActionNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddHead(swigCPtr, CNWSObjectActionNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CNWSObjectActionNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddTail(swigCPtr, CNWSObjectActionNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CNWSObjectActionNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddAfter(swigCPtr, CNWSObjectActionNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CNWSObjectActionNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddBefore(swigCPtr, CNWSObjectActionNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_Count(swigCPtr);
    return retVal;
  }

  public CNWSObjectActionNode GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetHead(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetTail(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_IsEmpty(swigCPtr);
    return retVal;
  }

  public CNWSObjectActionNode RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_RemoveHead(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_RemoveTail(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

}

}
