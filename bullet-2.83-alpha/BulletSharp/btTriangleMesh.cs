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

public class btTriangleMesh : btTriangleIndexVertexArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btTriangleMesh(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btTriangleMesh_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTriangleMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleMesh() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTriangleMesh(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public float m_weldingThreshold {
    set {
      BulletPINVOKE.btTriangleMesh_m_weldingThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleMesh_m_weldingThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public btTriangleMesh(bool use32bitIndices, bool use4componentVertices) : this(BulletPINVOKE.new_btTriangleMesh__SWIG_0(use32bitIndices, use4componentVertices), true) {
  }

  public btTriangleMesh(bool use32bitIndices) : this(BulletPINVOKE.new_btTriangleMesh__SWIG_1(use32bitIndices), true) {
  }

  public btTriangleMesh() : this(BulletPINVOKE.new_btTriangleMesh__SWIG_2(), true) {
  }

  public bool getUse32bitIndices() {
    bool ret = BulletPINVOKE.btTriangleMesh_getUse32bitIndices(swigCPtr);
    return ret;
  }

  public bool getUse4componentVertices() {
    bool ret = BulletPINVOKE.btTriangleMesh_getUse4componentVertices(swigCPtr);
    return ret;
  }

  public void addTriangle(btVector3 vertex0, btVector3 vertex1, btVector3 vertex2, bool removeDuplicateVertices) {
    BulletPINVOKE.btTriangleMesh_addTriangle__SWIG_0(swigCPtr, btVector3.getCPtr(vertex0), btVector3.getCPtr(vertex1), btVector3.getCPtr(vertex2), removeDuplicateVertices);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addTriangle(btVector3 vertex0, btVector3 vertex1, btVector3 vertex2) {
    BulletPINVOKE.btTriangleMesh_addTriangle__SWIG_1(swigCPtr, btVector3.getCPtr(vertex0), btVector3.getCPtr(vertex1), btVector3.getCPtr(vertex2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getNumTriangles() {
    int ret = BulletPINVOKE.btTriangleMesh_getNumTriangles(swigCPtr);
    return ret;
  }

  public override void preallocateVertices(int numverts) {
    BulletPINVOKE.btTriangleMesh_preallocateVertices(swigCPtr, numverts);
  }

  public override void preallocateIndices(int numindices) {
    BulletPINVOKE.btTriangleMesh_preallocateIndices(swigCPtr, numindices);
  }

  public int findOrAddVertex(btVector3 vertex, bool removeDuplicateVertices) {
    int ret = BulletPINVOKE.btTriangleMesh_findOrAddVertex(swigCPtr, btVector3.getCPtr(vertex), removeDuplicateVertices);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addIndex(int index) {
    BulletPINVOKE.btTriangleMesh_addIndex(swigCPtr, index);
  }

}

}
