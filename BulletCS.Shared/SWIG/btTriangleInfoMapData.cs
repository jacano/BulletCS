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

public class btTriangleInfoMapData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTriangleInfoMapData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTriangleInfoMapData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleInfoMapData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTriangleInfoMapData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_int m_hashTablePtr {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_hashTablePtr_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTriangleInfoMapData_m_hashTablePtr_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_nextPtr {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_nextPtr_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTriangleInfoMapData_m_nextPtr_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public btTriangleInfoData m_valueArrayPtr {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_valueArrayPtr_set(swigCPtr, btTriangleInfoData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTriangleInfoMapData_m_valueArrayPtr_get(swigCPtr);
      btTriangleInfoData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTriangleInfoData(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_keyArrayPtr {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_keyArrayPtr_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTriangleInfoMapData_m_keyArrayPtr_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public float m_convexEpsilon {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_convexEpsilon_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoMapData_m_convexEpsilon_get(swigCPtr);
      return ret;
    } 
  }

  public float m_planarEpsilon {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_planarEpsilon_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoMapData_m_planarEpsilon_get(swigCPtr);
      return ret;
    } 
  }

  public float m_equalVertexThreshold {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_equalVertexThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoMapData_m_equalVertexThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public float m_edgeDistanceThreshold {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_edgeDistanceThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoMapData_m_edgeDistanceThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public float m_zeroAreaThreshold {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_zeroAreaThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btTriangleInfoMapData_m_zeroAreaThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nextSize {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_nextSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btTriangleInfoMapData_m_nextSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_hashTableSize {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_hashTableSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btTriangleInfoMapData_m_hashTableSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_numValues {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_numValues_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btTriangleInfoMapData_m_numValues_get(swigCPtr);
      return ret;
    } 
  }

  public int m_numKeys {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_numKeys_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btTriangleInfoMapData_m_numKeys_get(swigCPtr);
      return ret;
    } 
  }

  public string m_padding {
    set {
      BulletPINVOKE.btTriangleInfoMapData_m_padding_set(swigCPtr, value);
    } 
    get {
      string ret = BulletPINVOKE.btTriangleInfoMapData_m_padding_get(swigCPtr);
      return ret;
    } 
  }

  public btTriangleInfoMapData() : this(BulletPINVOKE.new_btTriangleInfoMapData(), true) {
  }

}

}
