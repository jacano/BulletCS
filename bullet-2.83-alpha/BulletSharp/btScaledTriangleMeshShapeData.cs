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

public class btScaledTriangleMeshShapeData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btScaledTriangleMeshShapeData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btScaledTriangleMeshShapeData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btScaledTriangleMeshShapeData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btScaledTriangleMeshShapeData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTriangleMeshShapeData m_trimeshShapeData {
    set {
      BulletPINVOKE.btScaledTriangleMeshShapeData_m_trimeshShapeData_set(swigCPtr, btTriangleMeshShapeData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btScaledTriangleMeshShapeData_m_trimeshShapeData_get(swigCPtr);
      btTriangleMeshShapeData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTriangleMeshShapeData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_localScaling {
    set {
      BulletPINVOKE.btScaledTriangleMeshShapeData_m_localScaling_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btScaledTriangleMeshShapeData_m_localScaling_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btScaledTriangleMeshShapeData() : this(BulletPINVOKE.new_btScaledTriangleMeshShapeData(), true) {
  }

}

}
