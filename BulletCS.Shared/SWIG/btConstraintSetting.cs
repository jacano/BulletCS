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

public class btConstraintSetting : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btConstraintSetting(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btConstraintSetting obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConstraintSetting() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btConstraintSetting(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btConstraintSetting() : this(BulletPINVOKE.new_btConstraintSetting(), true) {
  }

  public float m_tau {
    set {
      BulletPINVOKE.btConstraintSetting_m_tau_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btConstraintSetting_m_tau_get(swigCPtr);
      return ret;
    } 
  }

  public float m_damping {
    set {
      BulletPINVOKE.btConstraintSetting_m_damping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btConstraintSetting_m_damping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_impulseClamp {
    set {
      BulletPINVOKE.btConstraintSetting_m_impulseClamp_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btConstraintSetting_m_impulseClamp_get(swigCPtr);
      return ret;
    } 
  }

}

}
