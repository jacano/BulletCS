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

public class btIndexedMesh : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btIndexedMesh(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btIndexedMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btIndexedMesh() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btIndexedMesh(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int m_numTriangles {
    set {
      BulletPINVOKE.btIndexedMesh_m_numTriangles_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btIndexedMesh_m_numTriangles_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_triangleIndexBase {
    set {
      BulletPINVOKE.btIndexedMesh_m_triangleIndexBase_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btIndexedMesh_m_triangleIndexBase_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public int m_triangleIndexStride {
    set {
      BulletPINVOKE.btIndexedMesh_m_triangleIndexStride_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btIndexedMesh_m_triangleIndexStride_get(swigCPtr);
      return ret;
    } 
  }

  public int m_numVertices {
    set {
      BulletPINVOKE.btIndexedMesh_m_numVertices_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btIndexedMesh_m_numVertices_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_vertexBase {
    set {
      BulletPINVOKE.btIndexedMesh_m_vertexBase_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btIndexedMesh_m_vertexBase_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public int m_vertexStride {
    set {
      BulletPINVOKE.btIndexedMesh_m_vertexStride_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btIndexedMesh_m_vertexStride_get(swigCPtr);
      return ret;
    } 
  }

  public PHY_ScalarType m_indexType {
    set {
      BulletPINVOKE.btIndexedMesh_m_indexType_set(swigCPtr, (int)value);
    } 
    get {
      PHY_ScalarType ret = (PHY_ScalarType)BulletPINVOKE.btIndexedMesh_m_indexType_get(swigCPtr);
      return ret;
    } 
  }

  public PHY_ScalarType m_vertexType {
    set {
      BulletPINVOKE.btIndexedMesh_m_vertexType_set(swigCPtr, (int)value);
    } 
    get {
      PHY_ScalarType ret = (PHY_ScalarType)BulletPINVOKE.btIndexedMesh_m_vertexType_get(swigCPtr);
      return ret;
    } 
  }

  public btIndexedMesh() : this(BulletPINVOKE.new_btIndexedMesh(), true) {
  }

}

}