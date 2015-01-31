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

public class btMeshPartData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btMeshPartData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btMeshPartData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btMeshPartData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btMeshPartData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btVector3FloatData m_vertices3f {
    set {
      BulletPINVOKE.btMeshPartData_m_vertices3f_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_vertices3f_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3DoubleData m_vertices3d {
    set {
      BulletPINVOKE.btMeshPartData_m_vertices3d_set(swigCPtr, btVector3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_vertices3d_get(swigCPtr);
      btVector3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public btIntIndexData m_indices32 {
    set {
      BulletPINVOKE.btMeshPartData_m_indices32_set(swigCPtr, btIntIndexData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_indices32_get(swigCPtr);
      btIntIndexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btIntIndexData(cPtr, false);
      return ret;
    } 
  }

  public btShortIntIndexTripletData m_3indices16 {
    set {
      BulletPINVOKE.btMeshPartData_m_3indices16_set(swigCPtr, btShortIntIndexTripletData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_3indices16_get(swigCPtr);
      btShortIntIndexTripletData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btShortIntIndexTripletData(cPtr, false);
      return ret;
    } 
  }

  public btCharIndexTripletData m_3indices8 {
    set {
      BulletPINVOKE.btMeshPartData_m_3indices8_set(swigCPtr, btCharIndexTripletData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_3indices8_get(swigCPtr);
      btCharIndexTripletData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCharIndexTripletData(cPtr, false);
      return ret;
    } 
  }

  public btShortIntIndexData m_indices16 {
    set {
      BulletPINVOKE.btMeshPartData_m_indices16_set(swigCPtr, btShortIntIndexData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btMeshPartData_m_indices16_get(swigCPtr);
      btShortIntIndexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btShortIntIndexData(cPtr, false);
      return ret;
    } 
  }

  public int m_numTriangles {
    set {
      BulletPINVOKE.btMeshPartData_m_numTriangles_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btMeshPartData_m_numTriangles_get(swigCPtr);
      return ret;
    } 
  }

  public int m_numVertices {
    set {
      BulletPINVOKE.btMeshPartData_m_numVertices_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btMeshPartData_m_numVertices_get(swigCPtr);
      return ret;
    } 
  }

  public btMeshPartData() : this(BulletPINVOKE.new_btMeshPartData(), true) {
  }

}

}
