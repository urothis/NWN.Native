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

public unsafe class CExoArrayListCNetLayerPlayerCDKeyInfo : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<CNetLayerPlayerCDKeyInfo>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNetLayerPlayerCDKeyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNetLayerPlayerCDKeyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNetLayerPlayerCDKeyInfo() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNetLayerPlayerCDKeyInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNetLayerPlayerCDKeyInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNetLayerPlayerCDKeyInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNetLayerPlayerCDKeyInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNetLayerPlayerCDKeyInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNetLayerPlayerCDKeyInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNetLayerPlayerCDKeyInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNetLayerPlayerCDKeyInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNetLayerPlayerCDKeyInfo left, CExoArrayListCNetLayerPlayerCDKeyInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNetLayerPlayerCDKeyInfo left, CExoArrayListCNetLayerPlayerCDKeyInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoArrayListCNetLayerPlayerCDKeyInfo(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNetLayerPlayerCDKeyInfo element in c) {
      this.Add(element);
    }
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo(global::System.Collections.Generic.IEnumerable<CNetLayerPlayerCDKeyInfo> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CNetLayerPlayerCDKeyInfo element in c) {
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

  public CNetLayerPlayerCDKeyInfo this[int index] {
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

  public void CopyTo(CNetLayerPlayerCDKeyInfo[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CNetLayerPlayerCDKeyInfo[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void Clear()
  {
    SetSize(0);
  }

  public void CopyTo(int index, CNetLayerPlayerCDKeyInfo[] array, int arrayIndex, int count)
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

  public CNetLayerPlayerCDKeyInfo[] ToArray() {
    CNetLayerPlayerCDKeyInfo[] array = new CNetLayerPlayerCDKeyInfo[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<CNetLayerPlayerCDKeyInfo> global::System.Collections.Generic.IEnumerable<CNetLayerPlayerCDKeyInfo>.GetEnumerator() {
    return new CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator(this);
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator GetEnumerator() {
    return new CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CNetLayerPlayerCDKeyInfo>
  {
    private CExoArrayListCNetLayerPlayerCDKeyInfo collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CExoArrayListCNetLayerPlayerCDKeyInfoEnumerator(CExoArrayListCNetLayerPlayerCDKeyInfo collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CNetLayerPlayerCDKeyInfo Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CNetLayerPlayerCDKeyInfo)currentObject;
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
      NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_num_get(swigCPtr);
      return retVal;
    }

  }

  private int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public void Add(CNetLayerPlayerCDKeyInfo t) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Add(swigCPtr, CNetLayerPlayerCDKeyInfo.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Pack(swigCPtr);
  }

  private void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_SetSize(swigCPtr, s);
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_0(s), true) {
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo() : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_1(), true) {
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo(CExoArrayListCNetLayerPlayerCDKeyInfo list) : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_2(CExoArrayListCNetLayerPlayerCDKeyInfo.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private CNetLayerPlayerCDKeyInfo InternalGetItem(int index) {
    CNetLayerPlayerCDKeyInfo ret = new CNetLayerPlayerCDKeyInfo(NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_InternalGetItem(swigCPtr, index), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CNetLayerPlayerCDKeyInfo InternalGetItemCopy(int index) {
    CNetLayerPlayerCDKeyInfo ret = new CNetLayerPlayerCDKeyInfo(NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_InternalGetItemCopy(swigCPtr, index), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetItem(int index, CNetLayerPlayerCDKeyInfo val) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_InternalSetItem(swigCPtr, index, CNetLayerPlayerCDKeyInfo.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(int index, CNetLayerPlayerCDKeyInfo x) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Insert(swigCPtr, index, CNetLayerPlayerCDKeyInfo.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
