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

public class btConvexShape : btCollisionShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btConvexShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btConvexShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btConvexShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConvexShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btConvexShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual btVector3 localGetSupportingVertex(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexShape_localGetSupportingVertex(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual btVector3 localGetSupportingVertexWithoutMargin(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexShape_localGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btVector3 localGetSupportVertexWithoutMarginNonVirtual(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexShape_localGetSupportVertexWithoutMarginNonVirtual(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btVector3 localGetSupportVertexNonVirtual(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexShape_localGetSupportVertexNonVirtual(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getMarginNonVirtual() {
    float ret = BulletPINVOKE.btConvexShape_getMarginNonVirtual(swigCPtr);
    return ret;
  }

  public void getAabbNonVirtual(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btConvexShape_getAabbNonVirtual(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void project(btTransform trans, btVector3 dir, SWIGTYPE_p_float min, SWIGTYPE_p_float max) {
    BulletPINVOKE.btConvexShape_project(swigCPtr, btTransform.getCPtr(trans), btVector3.getCPtr(dir), SWIGTYPE_p_float.getCPtr(min), SWIGTYPE_p_float.getCPtr(max));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void batchedUnitVectorGetSupportingVertexWithoutMargin(btVector3 vectors, btVector3 supportVerticesOut, int numVectors) {
    BulletPINVOKE.btConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vectors), btVector3.getCPtr(supportVerticesOut), numVectors);
  }

  public override void getAabb(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btConvexShape_getAabb(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getAabbSlow(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btConvexShape_getAabbSlow(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btConvexShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override btVector3 getLocalScaling() {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public override void setMargin(float margin) {
    BulletPINVOKE.btConvexShape_setMargin(swigCPtr, margin);
  }

  public override float getMargin() {
    float ret = BulletPINVOKE.btConvexShape_getMargin(swigCPtr);
    return ret;
  }

  public virtual int getNumPreferredPenetrationDirections() {
    int ret = BulletPINVOKE.btConvexShape_getNumPreferredPenetrationDirections(swigCPtr);
    return ret;
  }

  public virtual void getPreferredPenetrationDirection(int index, btVector3 penetrationVector) {
    BulletPINVOKE.btConvexShape_getPreferredPenetrationDirection(swigCPtr, index, btVector3.getCPtr(penetrationVector));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
