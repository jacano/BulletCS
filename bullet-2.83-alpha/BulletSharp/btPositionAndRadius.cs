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

public class btPositionAndRadius : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btPositionAndRadius(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btPositionAndRadius obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPositionAndRadius() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btPositionAndRadius(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btVector3FloatData m_pos {
    set {
      BulletPINVOKE.btPositionAndRadius_m_pos_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btPositionAndRadius_m_pos_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public float m_radius {
    set {
      BulletPINVOKE.btPositionAndRadius_m_radius_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btPositionAndRadius_m_radius_get(swigCPtr);
      return ret;
    } 
  }

  public btPositionAndRadius() : this(BulletPINVOKE.new_btPositionAndRadius(), true) {
  }

}

}