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

public class btDbvtAabbMm : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDbvtAabbMm(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btDbvtAabbMm obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDbvtAabbMm() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btDbvtAabbMm(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btVector3 Center() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_Center(swigCPtr), true);
    return ret;
  }

  public btVector3 Lengths() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_Lengths(swigCPtr), true);
    return ret;
  }

  public btVector3 Extents() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_Extents(swigCPtr), true);
    return ret;
  }

  public btVector3 Mins() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_Mins(swigCPtr), false);
    return ret;
  }

  public btVector3 Maxs() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_Maxs(swigCPtr), false);
    return ret;
  }

  public static btDbvtAabbMm FromCE(btVector3 c, btVector3 e) {
    btDbvtAabbMm ret = new btDbvtAabbMm(BulletPINVOKE.btDbvtAabbMm_FromCE(btVector3.getCPtr(c), btVector3.getCPtr(e)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btDbvtAabbMm FromCR(btVector3 c, float r) {
    btDbvtAabbMm ret = new btDbvtAabbMm(BulletPINVOKE.btDbvtAabbMm_FromCR(btVector3.getCPtr(c), r), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btDbvtAabbMm FromMM(btVector3 mi, btVector3 mx) {
    btDbvtAabbMm ret = new btDbvtAabbMm(BulletPINVOKE.btDbvtAabbMm_FromMM(btVector3.getCPtr(mi), btVector3.getCPtr(mx)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btDbvtAabbMm FromPoints(btVector3 pts, int n) {
    btDbvtAabbMm ret = new btDbvtAabbMm(BulletPINVOKE.btDbvtAabbMm_FromPoints__SWIG_0(btVector3.getCPtr(pts), n), true);
    return ret;
  }

  public static btDbvtAabbMm FromPoints(SWIGTYPE_p_p_btVector3 ppts, int n) {
    btDbvtAabbMm ret = new btDbvtAabbMm(BulletPINVOKE.btDbvtAabbMm_FromPoints__SWIG_1(SWIGTYPE_p_p_btVector3.getCPtr(ppts), n), true);
    return ret;
  }

  public void Expand(btVector3 e) {
    BulletPINVOKE.btDbvtAabbMm_Expand(swigCPtr, btVector3.getCPtr(e));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SignedExpand(btVector3 e) {
    BulletPINVOKE.btDbvtAabbMm_SignedExpand(swigCPtr, btVector3.getCPtr(e));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contain(btDbvtAabbMm a) {
    bool ret = BulletPINVOKE.btDbvtAabbMm_Contain(swigCPtr, btDbvtAabbMm.getCPtr(a));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Classify(btVector3 n, float o, int s) {
    int ret = BulletPINVOKE.btDbvtAabbMm_Classify(swigCPtr, btVector3.getCPtr(n), o, s);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ProjectMinimum(btVector3 v, uint signs) {
    float ret = BulletPINVOKE.btDbvtAabbMm_ProjectMinimum(swigCPtr, btVector3.getCPtr(v), signs);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btVector3 tMins() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_tMins(swigCPtr), false);
    return ret;
  }

  public btVector3 tMaxs() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDbvtAabbMm_tMaxs(swigCPtr), false);
    return ret;
  }

  public btDbvtAabbMm() : this(BulletPINVOKE.new_btDbvtAabbMm(), true) {
  }

}

}
