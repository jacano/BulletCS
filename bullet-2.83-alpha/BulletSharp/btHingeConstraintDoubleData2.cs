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

public class btHingeConstraintDoubleData2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btHingeConstraintDoubleData2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btHingeConstraintDoubleData2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btHingeConstraintDoubleData2() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btHingeConstraintDoubleData2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTypedConstraintDoubleData m_typeConstraintData {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_typeConstraintData_set(swigCPtr, btTypedConstraintDoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintDoubleData2_m_typeConstraintData_get(swigCPtr);
      btTypedConstraintDoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTypedConstraintDoubleData(cPtr, false);
      return ret;
    } 
  }

  public btTransformDoubleData m_rbAFrame {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_rbAFrame_set(swigCPtr, btTransformDoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintDoubleData2_m_rbAFrame_get(swigCPtr);
      btTransformDoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformDoubleData(cPtr, false);
      return ret;
    } 
  }

  public btTransformDoubleData m_rbBFrame {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_rbBFrame_set(swigCPtr, btTransformDoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btHingeConstraintDoubleData2_m_rbBFrame_get(swigCPtr);
      btTransformDoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformDoubleData(cPtr, false);
      return ret;
    } 
  }

  public int m_useReferenceFrameA {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_useReferenceFrameA_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_useReferenceFrameA_get(swigCPtr);
      return ret;
    } 
  }

  public int m_angularOnly {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_angularOnly_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_angularOnly_get(swigCPtr);
      return ret;
    } 
  }

  public int m_enableAngularMotor {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_enableAngularMotor_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_enableAngularMotor_get(swigCPtr);
      return ret;
    } 
  }

  public double m_motorTargetVelocity {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_motorTargetVelocity_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_motorTargetVelocity_get(swigCPtr);
      return ret;
    } 
  }

  public double m_maxMotorImpulse {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_maxMotorImpulse_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_maxMotorImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public double m_lowerLimit {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_lowerLimit_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_lowerLimit_get(swigCPtr);
      return ret;
    } 
  }

  public double m_upperLimit {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_upperLimit_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_upperLimit_get(swigCPtr);
      return ret;
    } 
  }

  public double m_limitSoftness {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_limitSoftness_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_limitSoftness_get(swigCPtr);
      return ret;
    } 
  }

  public double m_biasFactor {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_biasFactor_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_biasFactor_get(swigCPtr);
      return ret;
    } 
  }

  public double m_relaxationFactor {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_relaxationFactor_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_relaxationFactor_get(swigCPtr);
      return ret;
    } 
  }

  public string m_padding1 {
    set {
      BulletPINVOKE.btHingeConstraintDoubleData2_m_padding1_set(swigCPtr, value);
    } 
    get {
      string ret = BulletPINVOKE.btHingeConstraintDoubleData2_m_padding1_get(swigCPtr);
      return ret;
    } 
  }

  public btHingeConstraintDoubleData2() : this(BulletPINVOKE.new_btHingeConstraintDoubleData2(), true) {
  }

}

}
