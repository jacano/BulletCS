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

public class btJointFeedback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btJointFeedback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btJointFeedback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btJointFeedback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btJointFeedback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btVector3 m_appliedForceBodyA {
    set {
      BulletPINVOKE.btJointFeedback_m_appliedForceBodyA_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btJointFeedback_m_appliedForceBodyA_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_appliedTorqueBodyA {
    set {
      BulletPINVOKE.btJointFeedback_m_appliedTorqueBodyA_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btJointFeedback_m_appliedTorqueBodyA_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_appliedForceBodyB {
    set {
      BulletPINVOKE.btJointFeedback_m_appliedForceBodyB_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btJointFeedback_m_appliedForceBodyB_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_appliedTorqueBodyB {
    set {
      BulletPINVOKE.btJointFeedback_m_appliedTorqueBodyB_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btJointFeedback_m_appliedTorqueBodyB_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btJointFeedback() : this(BulletPINVOKE.new_btJointFeedback(), true) {
  }

}

}
