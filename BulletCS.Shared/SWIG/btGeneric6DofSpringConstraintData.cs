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

public class btGeneric6DofSpringConstraintData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGeneric6DofSpringConstraintData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btGeneric6DofSpringConstraintData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGeneric6DofSpringConstraintData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btGeneric6DofSpringConstraintData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btGeneric6DofConstraintData m_6dofData {
    set {
      BulletPINVOKE.btGeneric6DofSpringConstraintData_m_6dofData_set(swigCPtr, btGeneric6DofConstraintData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofSpringConstraintData_m_6dofData_get(swigCPtr);
      btGeneric6DofConstraintData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btGeneric6DofConstraintData(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_springEnabled {
    set {
      BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springEnabled_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springEnabled_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float m_equilibriumPoint {
    set {
      BulletPINVOKE.btGeneric6DofSpringConstraintData_m_equilibriumPoint_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofSpringConstraintData_m_equilibriumPoint_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float m_springStiffness {
    set {
      BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springStiffness_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springStiffness_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float m_springDamping {
    set {
      BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springDamping_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofSpringConstraintData_m_springDamping_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public btGeneric6DofSpringConstraintData() : this(BulletPINVOKE.new_btGeneric6DofSpringConstraintData(), true) {
  }

}

}
