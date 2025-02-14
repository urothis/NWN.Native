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

public unsafe class CExoArrayListCNWSFactionPtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CNWSFaction>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSFactionPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSFactionPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSFactionPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSFactionPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSFactionPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSFactionPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSFactionPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSFactionPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSFactionPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSFactionPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSFactionPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSFactionPtr left, CExoArrayListCNWSFactionPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSFactionPtr left, CExoArrayListCNWSFactionPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCNWSFactionPtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSFaction element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCNWSFactionPtr(global::System.Collections.Generic.IEnumerable<CNWSFaction> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSFaction element in c) {
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

  public CNWSFaction this[int index] {
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

  public void CopyTo(CNWSFaction[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CNWSFaction[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CNWSFaction[] array, int arrayIndex, int count)
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

  public CNWSFaction[] ToArray() {
    CNWSFaction[] array = new CNWSFaction[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CNWSFaction> global::System.Collections.Generic.IEnumerable<CNWSFaction>.GetEnumerator() {
    return new CExoArrayListCNWSFactionPtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCNWSFactionPtrEnumerator(this);
  }

  public CExoArrayListCNWSFactionPtrEnumerator GetEnumerator() {
    return new CExoArrayListCNWSFactionPtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCNWSFactionPtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CNWSFaction>
  {
    private CExoArrayListCNWSFactionPtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCNWSFactionPtrEnumerator(CExoArrayListCNWSFactionPtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CNWSFaction Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CNWSFaction)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CNWSFaction t) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Add(swigCPtr, CNWSFaction.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCNWSFactionPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSFactionPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSFactionPtr(CExoArrayListCNWSFactionPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_2(CExoArrayListCNWSFactionPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CNWSFaction t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_IndexOf(swigCPtr, CNWSFaction.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CNWSFaction t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_AddUnique(swigCPtr, CNWSFaction.getCPtr(t));
    return retVal;
  }

  private CNWSFaction InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_InternalGetItem(swigCPtr, index);
    CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CNWSFaction InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_InternalGetItemCopy(swigCPtr, index);
    CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CNWSFaction val) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_InternalSetItem(swigCPtr, index, CNWSFaction.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CNWSFaction x) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Insert(swigCPtr, index, CNWSFaction.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CNWSFaction value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Contains(swigCPtr, CNWSFaction.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CNWSFaction value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_LastIndexOf(swigCPtr, CNWSFaction.getCPtr(value));
    return retVal;
  }

  public bool Remove(CNWSFaction value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Remove(swigCPtr, CNWSFaction.getCPtr(value));
    return ret;
  }

}

}
