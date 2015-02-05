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

public class btCollisionConfiguration : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionConfiguration(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCollisionConfiguration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionConfiguration() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCollisionConfiguration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual SWIGTYPE_p_btPoolAllocator getPersistentManifoldPool() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionConfiguration_getPersistentManifoldPool(swigCPtr);
    SWIGTYPE_p_btPoolAllocator ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btPoolAllocator(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_btPoolAllocator getCollisionAlgorithmPool() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionConfiguration_getCollisionAlgorithmPool(swigCPtr);
    SWIGTYPE_p_btPoolAllocator ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btPoolAllocator(cPtr, false);
    return ret;
  }

  public virtual btCollisionAlgorithmCreateFunc getCollisionAlgorithmCreateFunc(int proxyType0, int proxyType1) {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionConfiguration_getCollisionAlgorithmCreateFunc(swigCPtr, proxyType0, proxyType1);
    btCollisionAlgorithmCreateFunc ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionAlgorithmCreateFunc(cPtr, false);
    return ret;
  }

}

}