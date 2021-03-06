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

public class btBroadphaseInterface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btBroadphaseInterface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btBroadphaseInterface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btBroadphaseInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btBroadphaseInterface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual btBroadphaseProxy createProxy(btVector3 aabbMin, btVector3 aabbMax, int shapeType, SWIGTYPE_p_void userPtr, short collisionFilterGroup, short collisionFilterMask, btDispatcher dispatcher, SWIGTYPE_p_void multiSapProxy) {
    global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseInterface_createProxy(swigCPtr, btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), shapeType, SWIGTYPE_p_void.getCPtr(userPtr), collisionFilterGroup, collisionFilterMask, btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_void.getCPtr(multiSapProxy));
    btBroadphaseProxy ret = (cPtr == global::System.IntPtr.Zero) ? null : new btBroadphaseProxy(cPtr, false);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void destroyProxy(btBroadphaseProxy proxy, btDispatcher dispatcher) {
    BulletPINVOKE.btBroadphaseInterface_destroyProxy(swigCPtr, btBroadphaseProxy.getCPtr(proxy), btDispatcher.getCPtr(dispatcher));
  }

  public virtual void setAabb(btBroadphaseProxy proxy, btVector3 aabbMin, btVector3 aabbMax, btDispatcher dispatcher) {
    BulletPINVOKE.btBroadphaseInterface_setAabb(swigCPtr, btBroadphaseProxy.getCPtr(proxy), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), btDispatcher.getCPtr(dispatcher));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getAabb(btBroadphaseProxy proxy, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btBroadphaseInterface_getAabb(swigCPtr, btBroadphaseProxy.getCPtr(proxy), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(btVector3 rayFrom, btVector3 rayTo, btBroadphaseRayCallback rayCallback, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btBroadphaseInterface_rayTest__SWIG_0(swigCPtr, btVector3.getCPtr(rayFrom), btVector3.getCPtr(rayTo), btBroadphaseRayCallback.getCPtr(rayCallback), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(btVector3 rayFrom, btVector3 rayTo, btBroadphaseRayCallback rayCallback, btVector3 aabbMin) {
    BulletPINVOKE.btBroadphaseInterface_rayTest__SWIG_1(swigCPtr, btVector3.getCPtr(rayFrom), btVector3.getCPtr(rayTo), btBroadphaseRayCallback.getCPtr(rayCallback), btVector3.getCPtr(aabbMin));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(btVector3 rayFrom, btVector3 rayTo, btBroadphaseRayCallback rayCallback) {
    BulletPINVOKE.btBroadphaseInterface_rayTest__SWIG_2(swigCPtr, btVector3.getCPtr(rayFrom), btVector3.getCPtr(rayTo), btBroadphaseRayCallback.getCPtr(rayCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void aabbTest(btVector3 aabbMin, btVector3 aabbMax, btBroadphaseAabbCallback callback) {
    BulletPINVOKE.btBroadphaseInterface_aabbTest(swigCPtr, btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), btBroadphaseAabbCallback.getCPtr(callback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void calculateOverlappingPairs(btDispatcher dispatcher) {
    BulletPINVOKE.btBroadphaseInterface_calculateOverlappingPairs(swigCPtr, btDispatcher.getCPtr(dispatcher));
  }

  public virtual btOverlappingPairCache getOverlappingPairCache() {
    global::System.IntPtr cPtr = BulletPINVOKE.btBroadphaseInterface_getOverlappingPairCache__SWIG_0(swigCPtr);
    btOverlappingPairCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new btOverlappingPairCache(cPtr, false);
    return ret;
  }

  public virtual void getBroadphaseAabb(btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btBroadphaseInterface_getBroadphaseAabb(swigCPtr, btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resetPool(btDispatcher dispatcher) {
    BulletPINVOKE.btBroadphaseInterface_resetPool(swigCPtr, btDispatcher.getCPtr(dispatcher));
  }

  public virtual void printStats() {
    BulletPINVOKE.btBroadphaseInterface_printStats(swigCPtr);
  }

}

}
