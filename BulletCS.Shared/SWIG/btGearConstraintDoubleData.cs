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

public class btGearConstraintDoubleData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGearConstraintDoubleData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btGearConstraintDoubleData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGearConstraintDoubleData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btGearConstraintDoubleData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTypedConstraintDoubleData m_typeConstraintData {
    set {
      BulletPINVOKE.btGearConstraintDoubleData_m_typeConstraintData_set(swigCPtr, btTypedConstraintDoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGearConstraintDoubleData_m_typeConstraintData_get(swigCPtr);
      btTypedConstraintDoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTypedConstraintDoubleData(cPtr, false);
      return ret;
    } 
  }

  public btVector3DoubleData m_axisInA {
    set {
      BulletPINVOKE.btGearConstraintDoubleData_m_axisInA_set(swigCPtr, btVector3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGearConstraintDoubleData_m_axisInA_get(swigCPtr);
      btVector3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public btVector3DoubleData m_axisInB {
    set {
      BulletPINVOKE.btGearConstraintDoubleData_m_axisInB_set(swigCPtr, btVector3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGearConstraintDoubleData_m_axisInB_get(swigCPtr);
      btVector3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public double m_ratio {
    set {
      BulletPINVOKE.btGearConstraintDoubleData_m_ratio_set(swigCPtr, value);
    } 
    get {
      double ret = BulletPINVOKE.btGearConstraintDoubleData_m_ratio_get(swigCPtr);
      return ret;
    } 
  }

  public btGearConstraintDoubleData() : this(BulletPINVOKE.new_btGearConstraintDoubleData(), true) {
  }

}

}
