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

public class btConvexHullShapeData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btConvexHullShapeData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btConvexHullShapeData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConvexHullShapeData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btConvexHullShapeData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btConvexInternalShapeData m_convexInternalShapeData {
    set {
      BulletPINVOKE.btConvexHullShapeData_m_convexInternalShapeData_set(swigCPtr, btConvexInternalShapeData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btConvexHullShapeData_m_convexInternalShapeData_get(swigCPtr);
      btConvexInternalShapeData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btConvexInternalShapeData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_unscaledPointsFloatPtr {
    set {
      BulletPINVOKE.btConvexHullShapeData_m_unscaledPointsFloatPtr_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btConvexHullShapeData_m_unscaledPointsFloatPtr_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3DoubleData m_unscaledPointsDoublePtr {
    set {
      BulletPINVOKE.btConvexHullShapeData_m_unscaledPointsDoublePtr_set(swigCPtr, btVector3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btConvexHullShapeData_m_unscaledPointsDoublePtr_get(swigCPtr);
      btVector3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public int m_numUnscaledPoints {
    set {
      BulletPINVOKE.btConvexHullShapeData_m_numUnscaledPoints_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btConvexHullShapeData_m_numUnscaledPoints_get(swigCPtr);
      return ret;
    } 
  }

  public string m_padding3 {
    set {
      BulletPINVOKE.btConvexHullShapeData_m_padding3_set(swigCPtr, value);
    } 
    get {
      string ret = BulletPINVOKE.btConvexHullShapeData_m_padding3_get(swigCPtr);
      return ret;
    } 
  }

  public btConvexHullShapeData() : this(BulletPINVOKE.new_btConvexHullShapeData(), true) {
  }

}

}