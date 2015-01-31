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

public class btTriangleMeshShape : btConcaveShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btTriangleMeshShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btTriangleMeshShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTriangleMeshShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleMeshShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTriangleMeshShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual btVector3 localGetSupportingVertex(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btTriangleMeshShape_localGetSupportingVertex(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual btVector3 localGetSupportingVertexWithoutMargin(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btTriangleMeshShape_localGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void recalcLocalAabb() {
    BulletPINVOKE.btTriangleMeshShape_recalcLocalAabb(swigCPtr);
  }

  public override void getAabb(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btTriangleMeshShape_getAabb(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void processAllTriangles(btTriangleCallback callback, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btTriangleMeshShape_processAllTriangles(swigCPtr, btTriangleCallback.getCPtr(callback), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void calculateLocalInertia(float mass, btVector3 inertia) {
    BulletPINVOKE.btTriangleMeshShape_calculateLocalInertia(swigCPtr, mass, btVector3.getCPtr(inertia));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btTriangleMeshShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override btVector3 getLocalScaling() {
    btVector3 ret = new btVector3(BulletPINVOKE.btTriangleMeshShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public btStridingMeshInterface getMeshInterface() {
    global::System.IntPtr cPtr = BulletPINVOKE.btTriangleMeshShape_getMeshInterface__SWIG_0(swigCPtr);
    btStridingMeshInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new btStridingMeshInterface(cPtr, false);
    return ret;
  }

  public btVector3 getLocalAabbMin() {
    btVector3 ret = new btVector3(BulletPINVOKE.btTriangleMeshShape_getLocalAabbMin(swigCPtr), false);
    return ret;
  }

  public btVector3 getLocalAabbMax() {
    btVector3 ret = new btVector3(BulletPINVOKE.btTriangleMeshShape_getLocalAabbMax(swigCPtr), false);
    return ret;
  }

  public override string getName() {
    string ret = BulletPINVOKE.btTriangleMeshShape_getName(swigCPtr);
    return ret;
  }

}

}