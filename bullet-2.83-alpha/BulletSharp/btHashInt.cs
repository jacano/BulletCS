//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace BulletSharp {

public class btHashInt : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btHashInt(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btHashInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btHashInt() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btHashInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btHashInt(int uid) : this(BulletPINVOKE.new_btHashInt(uid), true) {
  }

  public int getUid1() {
    int ret = BulletPINVOKE.btHashInt_getUid1(swigCPtr);
    return ret;
  }

  public void setUid1(int uid) {
    BulletPINVOKE.btHashInt_setUid1(swigCPtr, uid);
  }

  public bool equals(btHashInt other) {
    bool ret = BulletPINVOKE.btHashInt_equals(swigCPtr, btHashInt.getCPtr(other));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getHash() {
    uint ret = BulletPINVOKE.btHashInt_getHash(swigCPtr);
    return ret;
  }

}

}
