/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RakNetListDatabaseFilter : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListDatabaseFilter(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListDatabaseFilter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListDatabaseFilter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetListDatabaseFilter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public DatabaseFilter this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListDatabaseFilter() : this(RakNetPINVOKE.new_RakNetListDatabaseFilter__SWIG_0(), true) {
  }

  public RakNetListDatabaseFilter(RakNetListDatabaseFilter original_copy) : this(RakNetPINVOKE.new_RakNetListDatabaseFilter__SWIG_1(RakNetListDatabaseFilter.getCPtr(original_copy)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListDatabaseFilter CopyData(RakNetListDatabaseFilter original_copy) {
    RakNetListDatabaseFilter ret = new RakNetListDatabaseFilter(RakNetPINVOKE.RakNetListDatabaseFilter_CopyData(swigCPtr, RakNetListDatabaseFilter.getCPtr(original_copy)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DatabaseFilter Get(uint position) {
    DatabaseFilter ret = new DatabaseFilter(RakNetPINVOKE.RakNetListDatabaseFilter_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(DatabaseFilter input, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Push(swigCPtr, DatabaseFilter.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public DatabaseFilter Pop() {
    DatabaseFilter ret = new DatabaseFilter(RakNetPINVOKE.RakNetListDatabaseFilter_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(DatabaseFilter input, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Insert__SWIG_0(swigCPtr, DatabaseFilter.getCPtr(input), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(DatabaseFilter input, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Insert__SWIG_1(swigCPtr, DatabaseFilter.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(DatabaseFilter input, DatabaseFilter filler, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Replace__SWIG_0(swigCPtr, DatabaseFilter.getCPtr(input), DatabaseFilter.getCPtr(filler), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(DatabaseFilter input) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Replace__SWIG_1(swigCPtr, DatabaseFilter.getCPtr(input));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    RakNetPINVOKE.RakNetListDatabaseFilter_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    RakNetPINVOKE.RakNetListDatabaseFilter_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    RakNetPINVOKE.RakNetListDatabaseFilter_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    RakNetPINVOKE.RakNetListDatabaseFilter_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.RakNetListDatabaseFilter_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    RakNetPINVOKE.RakNetListDatabaseFilter_Compress(swigCPtr, file, line);
  }

}
