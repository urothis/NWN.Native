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

public unsafe class CExoArrayListCNWSStatsSpellPtr : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<CNWSStats_Spell>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSStatsSpellPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSStatsSpellPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSStatsSpellPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSStatsSpellPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSStatsSpellPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSStatsSpellPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSStatsSpellPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSStatsSpellPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSStatsSpellPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSStatsSpellPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSStatsSpellPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSStatsSpellPtr left, CExoArrayListCNWSStatsSpellPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSStatsSpellPtr left, CExoArrayListCNWSStatsSpellPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCNWSStatsSpellPtr(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSStats_Spell element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCNWSStatsSpellPtr(global::System.Collections.Generic.IEnumerable<CNWSStats_Spell> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNWSStats_Spell element in c) {
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

  public CNWSStats_Spell this[int index] {
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

  public void CopyTo(CNWSStats_Spell[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CNWSStats_Spell[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CNWSStats_Spell[] array, int arrayIndex, int count)
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

  public CNWSStats_Spell[] ToArray() {
    CNWSStats_Spell[] array = new CNWSStats_Spell[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CNWSStats_Spell> global::System.Collections.Generic.IEnumerable<CNWSStats_Spell>.GetEnumerator() {
    return new CExoArrayListCNWSStatsSpellPtrEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCNWSStatsSpellPtrEnumerator(this);
  }

  public CExoArrayListCNWSStatsSpellPtrEnumerator GetEnumerator() {
    return new CExoArrayListCNWSStatsSpellPtrEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCNWSStatsSpellPtrEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CNWSStats_Spell>
  {
    private CExoArrayListCNWSStatsSpellPtr collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCNWSStatsSpellPtrEnumerator(CExoArrayListCNWSStatsSpellPtr collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CNWSStats_Spell Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CNWSStats_Spell)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CNWSStats_Spell t) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Add(swigCPtr, CNWSStats_Spell.getCPtr(t));
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_SetSize(swigCPtr, s);
  }

  public CExoArrayListCNWSStatsSpellPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSStatsSpellPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSStatsSpellPtr(CExoArrayListCNWSStatsSpellPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellPtr__SWIG_2(CExoArrayListCNWSStatsSpellPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IndexOf(CNWSStats_Spell t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_IndexOf(swigCPtr, CNWSStats_Spell.getCPtr(t));
    return retVal;
  }

  public int AddUnique(CNWSStats_Spell t) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_AddUnique(swigCPtr, CNWSStats_Spell.getCPtr(t));
    return retVal;
  }

  private CNWSStats_Spell InternalGetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_InternalGetItem(swigCPtr, index);
    CNWSStats_Spell ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_Spell(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CNWSStats_Spell InternalGetItemCopy(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_InternalGetItemCopy(swigCPtr, index);
    CNWSStats_Spell ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_Spell(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CNWSStats_Spell val) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_InternalSetItem(swigCPtr, index, CNWSStats_Spell.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CNWSStats_Spell x) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Insert(swigCPtr, index, CNWSStats_Spell.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CNWSStats_Spell value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Contains(swigCPtr, CNWSStats_Spell.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CNWSStats_Spell value) {
    int retVal = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_LastIndexOf(swigCPtr, CNWSStats_Spell.getCPtr(value));
    return retVal;
  }

  public bool Remove(CNWSStats_Spell value) {
    bool ret = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtr_Remove(swigCPtr, CNWSStats_Spell.getCPtr(value));
    return ret;
  }

}

}
