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

public class btTranslationalLimitMotor : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTranslationalLimitMotor(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTranslationalLimitMotor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTranslationalLimitMotor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTranslationalLimitMotor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btVector3 m_lowerLimit {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_lowerLimit_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_lowerLimit_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_upperLimit {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_upperLimit_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_upperLimit_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_accumulatedImpulse {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_accumulatedImpulse_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_accumulatedImpulse_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public float m_limitSoftness {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_limitSoftness_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTranslationalLimitMotor_m_limitSoftness_get(swigCPtr);
      return ret;
    } 
  }

  public float m_damping {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_damping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTranslationalLimitMotor_m_damping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_restitution {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_restitution_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTranslationalLimitMotor_m_restitution_get(swigCPtr);
      return ret;
    } 
  }

  public btVector3 m_normalCFM {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_normalCFM_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_normalCFM_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_stopERP {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_stopERP_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_stopERP_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_stopCFM {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_stopCFM_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_stopCFM_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool m_enableMotor {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_enableMotor_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_enableMotor_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_targetVelocity {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_targetVelocity_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_targetVelocity_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_maxMotorForce {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_maxMotorForce_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_maxMotorForce_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_currentLimitError {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_currentLimitError_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_currentLimitError_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_currentLinearDiff {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_currentLinearDiff_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_currentLinearDiff_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_currentLimit {
    set {
      BulletPINVOKE.btTranslationalLimitMotor_m_currentLimit_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTranslationalLimitMotor_m_currentLimit_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public btTranslationalLimitMotor() : this(BulletPINVOKE.new_btTranslationalLimitMotor__SWIG_0(), true) {
  }

  public btTranslationalLimitMotor(btTranslationalLimitMotor other) : this(BulletPINVOKE.new_btTranslationalLimitMotor__SWIG_1(btTranslationalLimitMotor.getCPtr(other)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isLimited(int limitIndex) {
    bool ret = BulletPINVOKE.btTranslationalLimitMotor_isLimited(swigCPtr, limitIndex);
    return ret;
  }

  public bool needApplyForce(int limitIndex) {
    bool ret = BulletPINVOKE.btTranslationalLimitMotor_needApplyForce(swigCPtr, limitIndex);
    return ret;
  }

  public int testLimitValue(int limitIndex, float test_value) {
    int ret = BulletPINVOKE.btTranslationalLimitMotor_testLimitValue(swigCPtr, limitIndex, test_value);
    return ret;
  }

  public float solveLinearAxis(float timeStep, float jacDiagABInv, btRigidBody body1, btVector3 pointInA, btRigidBody body2, btVector3 pointInB, int limit_index, btVector3 axis_normal_on_a, btVector3 anchorPos) {
    float ret = BulletPINVOKE.btTranslationalLimitMotor_solveLinearAxis(swigCPtr, timeStep, jacDiagABInv, btRigidBody.getCPtr(body1), btVector3.getCPtr(pointInA), btRigidBody.getCPtr(body2), btVector3.getCPtr(pointInB), limit_index, btVector3.getCPtr(axis_normal_on_a), btVector3.getCPtr(anchorPos));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
