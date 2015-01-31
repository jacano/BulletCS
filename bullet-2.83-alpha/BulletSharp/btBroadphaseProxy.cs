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

public class btBroadphaseProxy : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btBroadphaseProxy(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btBroadphaseProxy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btBroadphaseProxy() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btBroadphaseProxy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_void m_clientObject {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_clientObject_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseProxy_m_clientObject_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public short m_collisionFilterGroup {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_collisionFilterGroup_set(swigCPtr, value);
    } 
    get {
      short ret = BulletPINVOKE.btBroadphaseProxy_m_collisionFilterGroup_get(swigCPtr);
      return ret;
    } 
  }

  public short m_collisionFilterMask {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_collisionFilterMask_set(swigCPtr, value);
    } 
    get {
      short ret = BulletPINVOKE.btBroadphaseProxy_m_collisionFilterMask_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void m_multiSapParentProxy {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_multiSapParentProxy_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseProxy_m_multiSapParentProxy_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public int m_uniqueId {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_uniqueId_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btBroadphaseProxy_m_uniqueId_get(swigCPtr);
      return ret;
    } 
  }

  public btVector3 m_aabbMin {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_aabbMin_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseProxy_m_aabbMin_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_aabbMax {
    set {
      BulletPINVOKE.btBroadphaseProxy_m_aabbMax_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseProxy_m_aabbMax_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public int getUid() {
    int ret = BulletPINVOKE.btBroadphaseProxy_getUid(swigCPtr);
    return ret;
  }

  public btBroadphaseProxy() : this(BulletPINVOKE.new_btBroadphaseProxy__SWIG_0(), true) {
  }

  public btBroadphaseProxy(btVector3 aabbMin, btVector3 aabbMax, SWIGTYPE_p_void userPtr, short collisionFilterGroup, short collisionFilterMask, SWIGTYPE_p_void multiSapParentProxy) : this(BulletPINVOKE.new_btBroadphaseProxy__SWIG_1(btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), SWIGTYPE_p_void.getCPtr(userPtr), collisionFilterGroup, collisionFilterMask, SWIGTYPE_p_void.getCPtr(multiSapParentProxy)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btBroadphaseProxy(btVector3 aabbMin, btVector3 aabbMax, SWIGTYPE_p_void userPtr, short collisionFilterGroup, short collisionFilterMask) : this(BulletPINVOKE.new_btBroadphaseProxy__SWIG_2(btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), SWIGTYPE_p_void.getCPtr(userPtr), collisionFilterGroup, collisionFilterMask), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool isPolyhedral(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isPolyhedral(proxyType);
    return ret;
  }

  public static bool isConvex(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isConvex(proxyType);
    return ret;
  }

  public static bool isNonMoving(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isNonMoving(proxyType);
    return ret;
  }

  public static bool isConcave(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isConcave(proxyType);
    return ret;
  }

  public static bool isCompound(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isCompound(proxyType);
    return ret;
  }

  public static bool isSoftBody(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isSoftBody(proxyType);
    return ret;
  }

  public static bool isInfinite(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isInfinite(proxyType);
    return ret;
  }

  public static bool isConvex2d(int proxyType) {
    bool ret = BulletPINVOKE.btBroadphaseProxy_isConvex2d(proxyType);
    return ret;
  }

  public enum CollisionFilterGroups {
    DefaultFilter = 1,
    StaticFilter = 2,
    KinematicFilter = 4,
    DebrisFilter = 8,
    SensorTrigger = 16,
    CharacterFilter = 32,
    AllFilter = -1
  }

}

}
