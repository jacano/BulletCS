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

public class btCollisionAlgorithmConstructionInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionAlgorithmConstructionInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCollisionAlgorithmConstructionInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionAlgorithmConstructionInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCollisionAlgorithmConstructionInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btCollisionAlgorithmConstructionInfo() : this(BulletPINVOKE.new_btCollisionAlgorithmConstructionInfo__SWIG_0(), true) {
  }

  public btCollisionAlgorithmConstructionInfo(btDispatcher dispatcher, int temp) : this(BulletPINVOKE.new_btCollisionAlgorithmConstructionInfo__SWIG_1(btDispatcher.getCPtr(dispatcher), temp), true) {
  }

  public btDispatcher m_dispatcher1 {
    set {
      BulletPINVOKE.btCollisionAlgorithmConstructionInfo_m_dispatcher1_set(swigCPtr, btDispatcher.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCollisionAlgorithmConstructionInfo_m_dispatcher1_get(swigCPtr);
      btDispatcher ret = (cPtr == global::System.IntPtr.Zero) ? null : new btDispatcher(cPtr, false);
      return ret;
    } 
  }

  public btPersistentManifold m_manifold {
    set {
      BulletPINVOKE.btCollisionAlgorithmConstructionInfo_m_manifold_set(swigCPtr, btPersistentManifold.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCollisionAlgorithmConstructionInfo_m_manifold_get(swigCPtr);
      btPersistentManifold ret = (cPtr == global::System.IntPtr.Zero) ? null : new btPersistentManifold(cPtr, false);
      return ret;
    } 
  }

}

}
