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

public class btHingeConstraintFloatData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btHingeConstraintFloatData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btHingeConstraintFloatData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btHingeConstraintFloatData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btHingeConstraintFloatData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTypedConstraintData m_typeConstraintData {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_typeConstraintData_set(swigCPtr, btTypedConstraintData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintFloatData_m_typeConstraintData_get(swigCPtr);
      btTypedConstraintData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTypedConstraintData(cPtr, false);
      return ret;
    } 
  }

  public btTransformFloatData m_rbAFrame {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_rbAFrame_set(swigCPtr, btTransformFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintFloatData_m_rbAFrame_get(swigCPtr);
      btTransformFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformFloatData(cPtr, false);
      return ret;
    } 
  }

  public btTransformFloatData m_rbBFrame {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_rbBFrame_set(swigCPtr, btTransformFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintFloatData_m_rbBFrame_get(swigCPtr);
      btTransformFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformFloatData(cPtr, false);
      return ret;
    } 
  }

  public int m_useReferenceFrameA {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_useReferenceFrameA_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintFloatData_m_useReferenceFrameA_get(swigCPtr);
      return ret;
    } 
  }

  public int m_angularOnly {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_angularOnly_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintFloatData_m_angularOnly_get(swigCPtr);
      return ret;
    } 
  }

  public int m_enableAngularMotor {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_enableAngularMotor_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintFloatData_m_enableAngularMotor_get(swigCPtr);
      return ret;
    } 
  }

  public float m_motorTargetVelocity {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_motorTargetVelocity_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_motorTargetVelocity_get(swigCPtr);
      return ret;
    } 
  }

  public float m_maxMotorImpulse {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_maxMotorImpulse_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_maxMotorImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public float m_lowerLimit {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_lowerLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_lowerLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float m_upperLimit {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_upperLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_upperLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float m_limitSoftness {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_limitSoftness_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_limitSoftness_get(swigCPtr);
      return ret;
    } 
  }

  public float m_biasFactor {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_biasFactor_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_biasFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float m_relaxationFactor {
    set {
      BulletPINVOKE.btHingeConstraintFloatData_m_relaxationFactor_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btHingeConstraintFloatData_m_relaxationFactor_get(swigCPtr);
      return ret;
    } 
  }

  public btHingeConstraintFloatData() : this(BulletPINVOKE.new_btHingeConstraintFloatData(), true) {
  }

}

}