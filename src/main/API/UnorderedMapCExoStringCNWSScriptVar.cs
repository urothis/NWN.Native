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

public unsafe class UnorderedMapCExoStringCNWSScriptVar : global::System.IDisposable, global::System.Collections.Generic.IDictionary<CExoString, CNWSScriptVar> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnorderedMapCExoStringCNWSScriptVar(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnorderedMapCExoStringCNWSScriptVar obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnorderedMapCExoStringCNWSScriptVar() {
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
          NWNXLibPINVOKE.delete_UnorderedMapCExoStringCNWSScriptVar(swigCPtr);
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

  public static unsafe implicit operator void*(UnorderedMapCExoStringCNWSScriptVar self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe UnorderedMapCExoStringCNWSScriptVar FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new UnorderedMapCExoStringCNWSScriptVar((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static UnorderedMapCExoStringCNWSScriptVar FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new UnorderedMapCExoStringCNWSScriptVar(pointer, memoryOwn) : null;
  }

  public bool Equals(UnorderedMapCExoStringCNWSScriptVar other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is UnorderedMapCExoStringCNWSScriptVar other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(UnorderedMapCExoStringCNWSScriptVar left, UnorderedMapCExoStringCNWSScriptVar right) {
    return Equals(left, right);
  }

  public static bool operator !=(UnorderedMapCExoStringCNWSScriptVar left, UnorderedMapCExoStringCNWSScriptVar right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public bool IsReadOnly
  {
    get => false;
  }

  public int Count
  {
    get => (int)size();
  }

  public CNWSScriptVar this[CExoString key]
  {
    get
    {
      Iterator iterator = find(key);
      if (iterator.IsEqual(end()))
      {
         throw new global::System.Collections.Generic.KeyNotFoundException("The given key was not present in the UnorderedMap.");
      }

      return iterator.GetValue();
    }

    set => InternalSetValue(key, value);
  }

  public bool Remove(CExoString key)
  {
    Iterator iterator = find(key);
    if (!iterator.IsEqual(end()))
    {
      InternalRemove(iterator);
      return true;
    }

    return false;
  }

  public bool TryGetValue(CExoString key, out CNWSScriptVar value)
  {
      Iterator iterator = find(key);
      if (iterator.IsEqual(end()))
      {
         value = default;
         return false;
      }

      value = iterator.GetValue();
      return true;
  }

  public global::System.Collections.Generic.ICollection<CExoString> Keys
  {
    get
    {
      int startCount = Count;
      Iterator iterator = begin();
      Iterator endIterator = end();

      global::System.Collections.Generic.ICollection<CExoString> keys = new global::System.Collections.Generic.List<CExoString>();

      while (!iterator.IsEqual(endIterator))
      {
        if (Count != startCount)
        {
          throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        keys.Add(iterator.GetKey());
        iterator = iterator.MoveNext();
      }

      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<CNWSScriptVar> Values
  {
    get
    {
      int startCount = Count;
      Iterator iterator = begin();
      Iterator endIterator = end();

      global::System.Collections.Generic.ICollection<CNWSScriptVar> values = new global::System.Collections.Generic.List<CNWSScriptVar>();

      while (!iterator.IsEqual(endIterator))
      {
        if (Count != startCount)
        {
          throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        values.Add(iterator.GetValue());
        iterator = iterator.MoveNext();
      }

      return values;
    }
  }

  public void Add(CExoString key, CNWSScriptVar value)
  {
    if (ContainsKey(key))
    {
      throw new global::System.ArgumentException(nameof(key), "An item with the same key has already been added.");
    }

    InternalSetValue(key, value);
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar> item)
  {
    Add(item.Key, item.Value);
  }

  bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>>.Contains(global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar> keyValuePair)
  {
    return TryGetValue(keyValuePair.Key, out CNWSScriptVar value) && value == keyValuePair.Value;
  }

  bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>>.Remove(global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar> keyValuePair)
  {
    Iterator iterator = find(keyValuePair.Key);
    if (!iterator.IsEqual(end()) && iterator.GetValue() == keyValuePair.Value)
    {
      InternalRemove(iterator);
      return true;
    }

    return false;
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>[] array)
  {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>[] array, int arrayIndex)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    int startCount = Count;
    Iterator iterator = begin();
    Iterator endIterator = end();

    for (int i = 0; i < Count && !iterator.IsEqual(endIterator); i++, iterator = iterator.MoveNext())
    {
      if (Count != startCount)
      {
        throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
      }

      array.SetValue(new global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>(iterator.GetKey(), iterator.GetValue()), arrayIndex+i);
    }
  }

  public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>> GetEnumerator()
  {
    int startCount = Count;
    Iterator iterator = begin();
    Iterator endIterator = end();

    while (!iterator.IsEqual(endIterator))
    {
      if (Count != startCount)
      {
        throw new System.InvalidOperationException("Collection was modified; enumeration operation may not execute.");
      }

      yield return new global::System.Collections.Generic.KeyValuePair<CExoString, CNWSScriptVar>(iterator.GetKey(), iterator.GetValue());
      iterator = iterator.MoveNext();
    }
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public UnorderedMapCExoStringCNWSScriptVar() : this(NWNXLibPINVOKE.new_UnorderedMapCExoStringCNWSScriptVar__SWIG_0(), true) {
  }

  public UnorderedMapCExoStringCNWSScriptVar(UnorderedMapCExoStringCNWSScriptVar other) : this(NWNXLibPINVOKE.new_UnorderedMapCExoStringCNWSScriptVar__SWIG_1(UnorderedMapCExoStringCNWSScriptVar.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private class Iterator : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Iterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Iterator obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Iterator() {
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
            NWNXLibPINVOKE.delete_UnorderedMapCExoStringCNWSScriptVar_Iterator(swigCPtr);
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
  
    public static unsafe implicit operator void*(Iterator self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe Iterator FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new Iterator((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static Iterator FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new Iterator(pointer, memoryOwn) : null;
    }
  
    public bool Equals(Iterator other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is Iterator other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(Iterator left, Iterator right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(Iterator left, Iterator right) {
      return !Equals(left, right);
    }
  /*@SWIG@*/
    public UnorderedMapCExoStringCNWSScriptVar.Iterator MoveNext() {
      UnorderedMapCExoStringCNWSScriptVar.Iterator ret = new UnorderedMapCExoStringCNWSScriptVar.Iterator(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Iterator_MoveNext(swigCPtr), true);
      return ret;
    }
  
    internal bool IsEqual(UnorderedMapCExoStringCNWSScriptVar.Iterator other) {
      bool ret = NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Iterator_IsEqual(swigCPtr, UnorderedMapCExoStringCNWSScriptVar.Iterator.getCPtr(other));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    internal CExoString GetKey() {
      CExoString ret = new CExoString(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Iterator_GetKey(swigCPtr), true);
      return ret;
    }
  
    internal CNWSScriptVar GetValue() {
      CNWSScriptVar ret = new CNWSScriptVar(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Iterator_GetValue(swigCPtr), true);
      return ret;
    }
  
    internal void SetValue(CNWSScriptVar newValue) {
      NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Iterator_SetValue(swigCPtr, CNWSScriptVar.getCPtr(newValue));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  private uint size() {
    uint ret = NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_size(swigCPtr);
    return ret;
  }

  public void Clear() {
    NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_Clear(swigCPtr);
  }

  private UnorderedMapCExoStringCNWSScriptVar.Iterator find(CExoString key) {
    UnorderedMapCExoStringCNWSScriptVar.Iterator ret = new UnorderedMapCExoStringCNWSScriptVar.Iterator(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_find(swigCPtr, CExoString.getCPtr(key)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private UnorderedMapCExoStringCNWSScriptVar.Iterator begin() {
    UnorderedMapCExoStringCNWSScriptVar.Iterator ret = new UnorderedMapCExoStringCNWSScriptVar.Iterator(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_begin(swigCPtr), true);
    return ret;
  }

  private UnorderedMapCExoStringCNWSScriptVar.Iterator end() {
    UnorderedMapCExoStringCNWSScriptVar.Iterator ret = new UnorderedMapCExoStringCNWSScriptVar.Iterator(NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_end(swigCPtr), true);
    return ret;
  }

  public bool ContainsKey(CExoString key) {
    bool ret = NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_ContainsKey(swigCPtr, CExoString.getCPtr(key));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void InternalSetValue(CExoString key, CNWSScriptVar value) {
    NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_InternalSetValue(swigCPtr, CExoString.getCPtr(key), CNWSScriptVar.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void InternalRemove(UnorderedMapCExoStringCNWSScriptVar.Iterator itr) {
    NWNXLibPINVOKE.UnorderedMapCExoStringCNWSScriptVar_InternalRemove(swigCPtr, UnorderedMapCExoStringCNWSScriptVar.Iterator.getCPtr(itr));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
