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

public class btSliderConstraintData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSliderConstraintData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btSliderConstraintData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSliderConstraintData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btSliderConstraintData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTypedConstraintData m_typeConstraintData {
    set {
      BulletPINVOKE.btSliderConstraintData_m_typeConstraintData_set(swigCPtr, btTypedConstraintData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btSliderConstraintData_m_typeConstraintData_get(swigCPtr);
      btTypedConstraintData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTypedConstraintData(cPtr, false);
      return ret;
    } 
  }

  public btTransformFloatData m_rbAFrame {
    set {
      BulletPINVOKE.btSliderConstraintData_m_rbAFrame_set(swigCPtr, btTransformFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btSliderConstraintData_m_rbAFrame_get(swigCPtr);
      btTransformFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformFloatData(cPtr, false);
      return ret;
    } 
  }

  public btTransformFloatData m_rbBFrame {
    set {
      BulletPINVOKE.btSliderConstraintData_m_rbBFrame_set(swigCPtr, btTransformFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btSliderConstraintData_m_rbBFrame_get(swigCPtr);
      btTransformFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransformFloatData(cPtr, false);
      return ret;
    } 
  }

  public float m_linearUpperLimit {
    set {
      BulletPINVOKE.btSliderConstraintData_m_linearUpperLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btSliderConstraintData_m_linearUpperLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float m_linearLowerLimit {
    set {
      BulletPINVOKE.btSliderConstraintData_m_linearLowerLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btSliderConstraintData_m_linearLowerLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float m_angularUpperLimit {
    set {
      BulletPINVOKE.btSliderConstraintData_m_angularUpperLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btSliderConstraintData_m_angularUpperLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float m_angularLowerLimit {
    set {
      BulletPINVOKE.btSliderConstraintData_m_angularLowerLimit_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btSliderConstraintData_m_angularLowerLimit_get(swigCPtr);
      return ret;
    } 
  }

  public int m_useLinearReferenceFrameA {
    set {
      BulletPINVOKE.btSliderConstraintData_m_useLinearReferenceFrameA_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btSliderConstraintData_m_useLinearReferenceFrameA_get(swigCPtr);
      return ret;
    } 
  }

  public int m_useOffsetForConstraintFrame {
    set {
      BulletPINVOKE.btSliderConstraintData_m_useOffsetForConstraintFrame_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btSliderConstraintData_m_useOffsetForConstraintFrame_get(swigCPtr);
      return ret;
    } 
  }

  public btSliderConstraintData() : this(BulletPINVOKE.new_btSliderConstraintData(), true) {
  }

}

}
