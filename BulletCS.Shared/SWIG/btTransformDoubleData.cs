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

public class btTransformDoubleData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTransformDoubleData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTransformDoubleData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTransformDoubleData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTransformDoubleData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btMatrix3x3DoubleData m_basis {
    set {
      BulletPINVOKE.btTransformDoubleData_m_basis_set(swigCPtr, btMatrix3x3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTransformDoubleData_m_basis_get(swigCPtr);
      btMatrix3x3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btMatrix3x3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public btVector3DoubleData m_origin {
    set {
      BulletPINVOKE.btTransformDoubleData_m_origin_set(swigCPtr, btVector3DoubleData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btTransformDoubleData_m_origin_get(swigCPtr);
      btVector3DoubleData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3DoubleData(cPtr, false);
      return ret;
    } 
  }

  public btTransformDoubleData() : this(BulletPINVOKE.new_btTransformDoubleData(), true) {
  }

}

}
