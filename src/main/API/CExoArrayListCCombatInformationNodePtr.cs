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

public unsafe class CExoArrayListCCombatInformationNodePtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CCombatInformationNode>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCCombatInformationNodePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCCombatInformationNodePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCCombatInformationNodePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCCombatInformationNodePtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCCombatInformationNodePtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCCombatInformationNodePtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCCombatInformationNodePtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCCombatInformationNodePtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCCombatInformationNodePtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCCombatInformationNodePtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCCombatInformationNodePtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCCombatInformationNodePtr left, CExoArrayListCCombatInformationNodePtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCCombatInformationNodePtr left, CExoArrayListCCombatInformationNodePtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCCombatInformationNodePtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CCombatInformationNode element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCCombatInformationNodePtr(global::System.Collections.Generic.IEnumerable<CCombatInformationNode> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CCombatInformationNode element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public CCombatInformationNode this[int index] {
    get {
      return InternalGetItem(index);
    }
    set {
      InternalSetItem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)array_size;
    }
    set {
      if (value < num)
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      SetSize(value);
    }
  }

  public int Count {
    get {
      return (int)num;
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(CCombatInformationNode[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CCombatInformationNode[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CCombatInformationNode[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(InternalGetItemCopy(index+i), arrayIndex+i);
  }

  public CCombatInformationNode[] ToArray() {
    CCombatInformationNode[] array = new CCombatInformationNode[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CCombatInformationNode> global::System.Collections.Generic.IEnumerable<CCombatInformationNode>.GetEnumerator() {
    return new CExoArrayListCCombatInformationNodePtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCCombatInformationNodePtrEnumerator(this);
  }

  public CExoArrayListCCombatInformationNodePtrEnumerator GetEnumerator() {
    return new CExoArrayListCCombatInformationNodePtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCCombatInformationNodePtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CCombatInformationNode>
  {
    private CExoArrayListCCombatInformationNodePtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCCombatInformationNodePtrEnumerator(CExoArrayListCCombatInformationNodePtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CCombatInformationNode Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CCombatInformationNode)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  private int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CCombatInformationNode t) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Add(swigCPtr, CCombatInformationNode.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCCombatInformationNodePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_0(s), true) {
  }

  public CExoArrayListCCombatInformationNodePtr() : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_1(), true) {
  }

  public CExoArrayListCCombatInformationNodePtr(CExoArrayListCCombatInformationNodePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCCombatInformationNodePtr__SWIG_2(CExoArrayListCCombatInformationNodePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CCombatInformationNode t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_IndexOf(swigCPtr, CCombatInformationNode.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CCombatInformationNode t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_AddUnique(swigCPtr, CCombatInformationNode.getCPtr(t));
    return retVal;
  }

  private CCombatInformationNode InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_InternalGetItem(swigCPtr, index);
    CCombatInformationNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CCombatInformationNode(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CCombatInformationNode InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_InternalGetItemCopy(swigCPtr, index);
    CCombatInformationNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CCombatInformationNode(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CCombatInformationNode val) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_InternalSetItem(swigCPtr, index, CCombatInformationNode.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CCombatInformationNode x) {
    NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Insert(swigCPtr, index, CCombatInformationNode.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CCombatInformationNode value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Contains(swigCPtr, CCombatInformationNode.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CCombatInformationNode value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_LastIndexOf(swigCPtr, CCombatInformationNode.getCPtr(value));
    return retVal;
  }

  public bool Remove(CCombatInformationNode value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCCombatInformationNodePtr_Remove(swigCPtr, CCombatInformationNode.getCPtr(value));
    return ret;
  }

}

}
