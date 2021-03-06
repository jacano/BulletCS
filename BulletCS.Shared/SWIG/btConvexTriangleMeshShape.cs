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

public class btConvexTriangleMeshShape : btPolyhedralConvexAabbCachingShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btConvexTriangleMeshShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btConvexTriangleMeshShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btConvexTriangleMeshShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConvexTriangleMeshShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btConvexTriangleMeshShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btConvexTriangleMeshShape(btStridingMeshInterface meshInterface, bool calcAabb) : this(BulletPINVOKE.new_btConvexTriangleMeshShape__SWIG_0(btStridingMeshInterface.getCPtr(meshInterface), calcAabb), true) {
  }

  public btConvexTriangleMeshShape(btStridingMeshInterface meshInterface) : this(BulletPINVOKE.new_btConvexTriangleMeshShape__SWIG_1(btStridingMeshInterface.getCPtr(meshInterface)), true) {
  }

  public btStridingMeshInterface getMeshInterface() {
    global::System.IntPtr cPtr = BulletPINVOKE.btConvexTriangleMeshShape_getMeshInterface__SWIG_0(swigCPtr);
    btStridingMeshInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new btStridingMeshInterface(cPtr, false);
    return ret;
  }

  public override btVector3 localGetSupportingVertex(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexTriangleMeshShape_localGetSupportingVertex(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override btVector3 localGetSupportingVertexWithoutMargin(btVector3 vec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexTriangleMeshShape_localGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void batchedUnitVectorGetSupportingVertexWithoutMargin(btVector3 vectors, btVector3 supportVerticesOut, int numVectors) {
    BulletPINVOKE.btConvexTriangleMeshShape_batchedUnitVectorGetSupportingVertexWithoutMargin(swigCPtr, btVector3.getCPtr(vectors), btVector3.getCPtr(supportVerticesOut), numVectors);
  }

  public override string getName() {
    string ret = BulletPINVOKE.btConvexTriangleMeshShape_getName(swigCPtr);
    return ret;
  }

  public override int getNumVertices() {
    int ret = BulletPINVOKE.btConvexTriangleMeshShape_getNumVertices(swigCPtr);
    return ret;
  }

  public override int getNumEdges() {
    int ret = BulletPINVOKE.btConvexTriangleMeshShape_getNumEdges(swigCPtr);
    return ret;
  }

  public override void getEdge(int i, btVector3 pa, btVector3 pb) {
    BulletPINVOKE.btConvexTriangleMeshShape_getEdge(swigCPtr, i, btVector3.getCPtr(pa), btVector3.getCPtr(pb));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getVertex(int i, btVector3 vtx) {
    BulletPINVOKE.btConvexTriangleMeshShape_getVertex(swigCPtr, i, btVector3.getCPtr(vtx));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int getNumPlanes() {
    int ret = BulletPINVOKE.btConvexTriangleMeshShape_getNumPlanes(swigCPtr);
    return ret;
  }

  public override void getPlane(btVector3 planeNormal, btVector3 planeSupport, int i) {
    BulletPINVOKE.btConvexTriangleMeshShape_getPlane(swigCPtr, btVector3.getCPtr(planeNormal), btVector3.getCPtr(planeSupport), i);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isInside(btVector3 pt, float tolerance) {
    bool ret = BulletPINVOKE.btConvexTriangleMeshShape_isInside(swigCPtr, btVector3.getCPtr(pt), tolerance);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btConvexTriangleMeshShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override btVector3 getLocalScaling() {
    btVector3 ret = new btVector3(BulletPINVOKE.btConvexTriangleMeshShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public void calculatePrincipalAxisTransform(btTransform principal, btVector3 inertia, SWIGTYPE_p_float volume) {
    BulletPINVOKE.btConvexTriangleMeshShape_calculatePrincipalAxisTransform(swigCPtr, btTransform.getCPtr(principal), btVector3.getCPtr(inertia), SWIGTYPE_p_float.getCPtr(volume));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
