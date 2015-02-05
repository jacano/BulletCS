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

public class btBoxShape : btPolyhedralConvexShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btBoxShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btBoxShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btBoxShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btBoxShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btBoxShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btVector3 getHalfExtentsWithMargin() {
    btVector3 ret = new btVector3(BulletPINVOKE.btBoxShape_getHalfExtentsWithMargin(swigCPtr), true);
    return ret;
  }

  public btVector3 getHalfExtentsWithoutMargin() {
    btVector3 ret = new btVector3(BulletPINVOKE.btBoxShape_getHalfExtentsWithoutMargin(swigCPtr), false);
    return ret;
  }

  public override btVector3 localGetSupportingVertex(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btBoxShape_localGetSupportingVertex(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override btVector3 localGetSupportingVertexWithoutMargin(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btBoxShape_localGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void batchedUnitVectorGetSupportingVertexWithoutMargin(btVector3 vectors, btVector3 supportVerticesOut, int numVectors) {
    BulletPINVOKE.btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vectors), btVector3.getCPtr(supportVerticesOut), numVectors);
  }

  public btBoxShape(btVector3 boxHalfExtents) : this(BulletPINVOKE.new_btBoxShape(btVector3.getCPtr(boxHalfExtents)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setMargin(float collisionMargin) {
    BulletPINVOKE.btBoxShape_setMargin(swigCPtr, collisionMargin);
  }

  public override void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btBoxShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getAabb(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btBoxShape_getAabb(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void calculateLocalInertia(float mass, btVector3 inertia) {
    BulletPINVOKE.btBoxShape_calculateLocalInertia(swigCPtr, mass, btVector3.getCPtr(inertia));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getPlane(btVector3 planeNormal, btVector3 planeSupport, int i) {
    BulletPINVOKE.btBoxShape_getPlane(swigCPtr, btVector3.getCPtr(planeNormal), btVector3.getCPtr(planeSupport), i);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int getNumPlanes() {
    int ret = BulletPINVOKE.btBoxShape_getNumPlanes(swigCPtr);
    return ret;
  }

  public override int getNumVertices() {
    int ret = BulletPINVOKE.btBoxShape_getNumVertices(swigCPtr);
    return ret;
  }

  public override int getNumEdges() {
    int ret = BulletPINVOKE.btBoxShape_getNumEdges(swigCPtr);
    return ret;
  }

  public override void getVertex(int i, btVector3 vtx) {
    BulletPINVOKE.btBoxShape_getVertex(swigCPtr, i, btVector3.getCPtr(vtx));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getPlaneEquation(btVector4 plane, int i) {
    BulletPINVOKE.btBoxShape_getPlaneEquation(swigCPtr, btVector4.getCPtr(plane), i);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getEdge(int i, btVector3 pa, btVector3 pb) {
    BulletPINVOKE.btBoxShape_getEdge(swigCPtr, i, btVector3.getCPtr(pa), btVector3.getCPtr(pb));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isInside(btVector3 pt, float tolerance) {
    bool ret = BulletPINVOKE.btBoxShape_isInside(swigCPtr, btVector3.getCPtr(pt), tolerance);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string getName() {
    string ret = BulletPINVOKE.btBoxShape_getName(swigCPtr);
    return ret;
  }

  public override int getNumPreferredPenetrationDirections() {
    int ret = BulletPINVOKE.btBoxShape_getNumPreferredPenetrationDirections(swigCPtr);
    return ret;
  }

  public override void getPreferredPenetrationDirection(int index, btVector3 penetrationVector) {
    BulletPINVOKE.btBoxShape_getPreferredPenetrationDirection(swigCPtr, index, btVector3.getCPtr(penetrationVector));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}