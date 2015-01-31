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

public class btTriangleIndexVertexArray : btStridingMeshInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btTriangleIndexVertexArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btTriangleIndexVertexArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTriangleIndexVertexArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleIndexVertexArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTriangleIndexVertexArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btTriangleIndexVertexArray() : this(BulletPINVOKE.new_btTriangleIndexVertexArray__SWIG_0(), true) {
  }

  public btTriangleIndexVertexArray(int numTriangles, SWIGTYPE_p_int triangleIndexBase, int triangleIndexStride, int numVertices, SWIGTYPE_p_float vertexBase, int vertexStride) : this(BulletPINVOKE.new_btTriangleIndexVertexArray__SWIG_1(numTriangles, SWIGTYPE_p_int.getCPtr(triangleIndexBase), triangleIndexStride, numVertices, SWIGTYPE_p_float.getCPtr(vertexBase), vertexStride), true) {
  }

  public void addIndexedMesh(btIndexedMesh mesh, PHY_ScalarType indexType) {
    BulletPINVOKE.btTriangleIndexVertexArray_addIndexedMesh__SWIG_0(swigCPtr, btIndexedMesh.getCPtr(mesh), (int)indexType);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addIndexedMesh(btIndexedMesh mesh) {
    BulletPINVOKE.btTriangleIndexVertexArray_addIndexedMesh__SWIG_1(swigCPtr, btIndexedMesh.getCPtr(mesh));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getLockedVertexIndexBase(SWIGTYPE_p_p_unsigned_char vertexbase, SWIGTYPE_p_int numverts, SWIGTYPE_p_PHY_ScalarType type, SWIGTYPE_p_int vertexStride, SWIGTYPE_p_p_unsigned_char indexbase, SWIGTYPE_p_int indexstride, SWIGTYPE_p_int numfaces, SWIGTYPE_p_PHY_ScalarType indicestype, int subpart) {
    BulletPINVOKE.btTriangleIndexVertexArray_getLockedVertexIndexBase__SWIG_0(swigCPtr, SWIGTYPE_p_p_unsigned_char.getCPtr(vertexbase), SWIGTYPE_p_int.getCPtr(numverts), SWIGTYPE_p_PHY_ScalarType.getCPtr(type), SWIGTYPE_p_int.getCPtr(vertexStride), SWIGTYPE_p_p_unsigned_char.getCPtr(indexbase), SWIGTYPE_p_int.getCPtr(indexstride), SWIGTYPE_p_int.getCPtr(numfaces), SWIGTYPE_p_PHY_ScalarType.getCPtr(indicestype), subpart);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getLockedVertexIndexBase(SWIGTYPE_p_p_unsigned_char vertexbase, SWIGTYPE_p_int numverts, SWIGTYPE_p_PHY_ScalarType type, SWIGTYPE_p_int vertexStride, SWIGTYPE_p_p_unsigned_char indexbase, SWIGTYPE_p_int indexstride, SWIGTYPE_p_int numfaces, SWIGTYPE_p_PHY_ScalarType indicestype) {
    BulletPINVOKE.btTriangleIndexVertexArray_getLockedVertexIndexBase__SWIG_1(swigCPtr, SWIGTYPE_p_p_unsigned_char.getCPtr(vertexbase), SWIGTYPE_p_int.getCPtr(numverts), SWIGTYPE_p_PHY_ScalarType.getCPtr(type), SWIGTYPE_p_int.getCPtr(vertexStride), SWIGTYPE_p_p_unsigned_char.getCPtr(indexbase), SWIGTYPE_p_int.getCPtr(indexstride), SWIGTYPE_p_int.getCPtr(numfaces), SWIGTYPE_p_PHY_ScalarType.getCPtr(indicestype));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getLockedReadOnlyVertexIndexBase(SWIGTYPE_p_p_unsigned_char vertexbase, SWIGTYPE_p_int numverts, SWIGTYPE_p_PHY_ScalarType type, SWIGTYPE_p_int vertexStride, SWIGTYPE_p_p_unsigned_char indexbase, SWIGTYPE_p_int indexstride, SWIGTYPE_p_int numfaces, SWIGTYPE_p_PHY_ScalarType indicestype, int subpart) {
    BulletPINVOKE.btTriangleIndexVertexArray_getLockedReadOnlyVertexIndexBase__SWIG_0(swigCPtr, SWIGTYPE_p_p_unsigned_char.getCPtr(vertexbase), SWIGTYPE_p_int.getCPtr(numverts), SWIGTYPE_p_PHY_ScalarType.getCPtr(type), SWIGTYPE_p_int.getCPtr(vertexStride), SWIGTYPE_p_p_unsigned_char.getCPtr(indexbase), SWIGTYPE_p_int.getCPtr(indexstride), SWIGTYPE_p_int.getCPtr(numfaces), SWIGTYPE_p_PHY_ScalarType.getCPtr(indicestype), subpart);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getLockedReadOnlyVertexIndexBase(SWIGTYPE_p_p_unsigned_char vertexbase, SWIGTYPE_p_int numverts, SWIGTYPE_p_PHY_ScalarType type, SWIGTYPE_p_int vertexStride, SWIGTYPE_p_p_unsigned_char indexbase, SWIGTYPE_p_int indexstride, SWIGTYPE_p_int numfaces, SWIGTYPE_p_PHY_ScalarType indicestype) {
    BulletPINVOKE.btTriangleIndexVertexArray_getLockedReadOnlyVertexIndexBase__SWIG_1(swigCPtr, SWIGTYPE_p_p_unsigned_char.getCPtr(vertexbase), SWIGTYPE_p_int.getCPtr(numverts), SWIGTYPE_p_PHY_ScalarType.getCPtr(type), SWIGTYPE_p_int.getCPtr(vertexStride), SWIGTYPE_p_p_unsigned_char.getCPtr(indexbase), SWIGTYPE_p_int.getCPtr(indexstride), SWIGTYPE_p_int.getCPtr(numfaces), SWIGTYPE_p_PHY_ScalarType.getCPtr(indicestype));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void unLockVertexBase(int subpart) {
    BulletPINVOKE.btTriangleIndexVertexArray_unLockVertexBase(swigCPtr, subpart);
  }

  public override void unLockReadOnlyVertexBase(int subpart) {
    BulletPINVOKE.btTriangleIndexVertexArray_unLockReadOnlyVertexBase(swigCPtr, subpart);
  }

  public override int getNumSubParts() {
    int ret = BulletPINVOKE.btTriangleIndexVertexArray_getNumSubParts(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_btIndexedMesh_t getIndexedMeshArray() {
    SWIGTYPE_p_btAlignedObjectArrayT_btIndexedMesh_t ret = new SWIGTYPE_p_btAlignedObjectArrayT_btIndexedMesh_t(BulletPINVOKE.btTriangleIndexVertexArray_getIndexedMeshArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override void preallocateVertices(int numverts) {
    BulletPINVOKE.btTriangleIndexVertexArray_preallocateVertices(swigCPtr, numverts);
  }

  public override void preallocateIndices(int numindices) {
    BulletPINVOKE.btTriangleIndexVertexArray_preallocateIndices(swigCPtr, numindices);
  }

  public override bool hasPremadeAabb() {
    bool ret = BulletPINVOKE.btTriangleIndexVertexArray_hasPremadeAabb(swigCPtr);
    return ret;
  }

  public override void setPremadeAabb(btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btTriangleIndexVertexArray_setPremadeAabb(swigCPtr, btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getPremadeAabb(btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btTriangleIndexVertexArray_getPremadeAabb(swigCPtr, btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
  }

}

}
