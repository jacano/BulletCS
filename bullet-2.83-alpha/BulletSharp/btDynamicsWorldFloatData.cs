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

public class btDynamicsWorldFloatData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDynamicsWorldFloatData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btDynamicsWorldFloatData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDynamicsWorldFloatData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btDynamicsWorldFloatData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btContactSolverInfoFloatData m_solverInfo {
    set {
      BulletPINVOKE.btDynamicsWorldFloatData_m_solverInfo_set(swigCPtr, btContactSolverInfoFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btDynamicsWorldFloatData_m_solverInfo_get(swigCPtr);
      btContactSolverInfoFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btContactSolverInfoFloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_gravity {
    set {
      BulletPINVOKE.btDynamicsWorldFloatData_m_gravity_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btDynamicsWorldFloatData_m_gravity_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btDynamicsWorldFloatData() : this(BulletPINVOKE.new_btDynamicsWorldFloatData(), true) {
  }

}

}