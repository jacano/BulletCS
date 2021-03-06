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

public class btDispatcherInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDispatcherInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btDispatcherInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDispatcherInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btDispatcherInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btDispatcherInfo() : this(BulletPINVOKE.new_btDispatcherInfo(), true) {
  }

  public float m_timeStep {
    set {
      BulletPINVOKE.btDispatcherInfo_m_timeStep_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btDispatcherInfo_m_timeStep_get(swigCPtr);
      return ret;
    } 
  }

  public int m_stepCount {
    set {
      BulletPINVOKE.btDispatcherInfo_m_stepCount_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btDispatcherInfo_m_stepCount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_dispatchFunc {
    set {
      BulletPINVOKE.btDispatcherInfo_m_dispatchFunc_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btDispatcherInfo_m_dispatchFunc_get(swigCPtr);
      return ret;
    } 
  }

  public float m_timeOfImpact {
    set {
      BulletPINVOKE.btDispatcherInfo_m_timeOfImpact_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btDispatcherInfo_m_timeOfImpact_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_useContinuous {
    set {
      BulletPINVOKE.btDispatcherInfo_m_useContinuous_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btDispatcherInfo_m_useContinuous_get(swigCPtr);
      return ret;
    } 
  }

  public btIDebugDraw m_debugDraw {
    set {
      BulletPINVOKE.btDispatcherInfo_m_debugDraw_set(swigCPtr, btIDebugDraw.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btDispatcherInfo_m_debugDraw_get(swigCPtr);
      btIDebugDraw ret = (cPtr == global::System.IntPtr.Zero) ? null : new btIDebugDraw(cPtr, false);
      return ret;
    } 
  }

  public bool m_enableSatConvex {
    set {
      BulletPINVOKE.btDispatcherInfo_m_enableSatConvex_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btDispatcherInfo_m_enableSatConvex_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_enableSPU {
    set {
      BulletPINVOKE.btDispatcherInfo_m_enableSPU_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btDispatcherInfo_m_enableSPU_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_useEpa {
    set {
      BulletPINVOKE.btDispatcherInfo_m_useEpa_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btDispatcherInfo_m_useEpa_get(swigCPtr);
      return ret;
    } 
  }

  public float m_allowedCcdPenetration {
    set {
      BulletPINVOKE.btDispatcherInfo_m_allowedCcdPenetration_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btDispatcherInfo_m_allowedCcdPenetration_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_useConvexConservativeDistanceUtil {
    set {
      BulletPINVOKE.btDispatcherInfo_m_useConvexConservativeDistanceUtil_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btDispatcherInfo_m_useConvexConservativeDistanceUtil_get(swigCPtr);
      return ret;
    } 
  }

  public float m_convexConservativeDistanceThreshold {
    set {
      BulletPINVOKE.btDispatcherInfo_m_convexConservativeDistanceThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btDispatcherInfo_m_convexConservativeDistanceThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public enum DispatchFunc {
    DISPATCH_DISCRETE = 1,
    DISPATCH_CONTINUOUS
  }

}

}
