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

public class btTriangleInfoData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTriangleInfoData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTriangleInfoData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleInfoData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTriangleInfoData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int m_flags {
    set {
      BulletPINVOKE.btTriangleInfoData_m_flags_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btTriangleInfoData_m_flags_get(swigCPtr);
      return ret;
    } 
  }

  public float m_edgeV0V1Angle {
    set {
      BulletPINVOKE.btTriangleInfoData_m_edgeV0V1Angle_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoData_m_edgeV0V1Angle_get(swigCPtr);
      return ret;
    } 
  }

  public float m_edgeV1V2Angle {
    set {
      BulletPINVOKE.btTriangleInfoData_m_edgeV1V2Angle_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoData_m_edgeV1V2Angle_get(swigCPtr);
      return ret;
    } 
  }

  public float m_edgeV2V0Angle {
    set {
      BulletPINVOKE.btTriangleInfoData_m_edgeV2V0Angle_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoData_m_edgeV2V0Angle_get(swigCPtr);
      return ret;
    } 
  }

  public btTriangleInfoData() : this(BulletPINVOKE.new_btTriangleInfoData(), true) {
  }

}

}
