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

public class btAxisSweep3 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btAxisSweep3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btAxisSweep3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btAxisSweep3() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btAxisSweep3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btAxisSweep3(btVector3 worldAabbMin, btVector3 worldAabbMax, ushort maxHandles, btOverlappingPairCache pairCache, bool disableRaycastAccelerator) : this(BulletPINVOKE.new_btAxisSweep3__SWIG_0(btVector3.getCPtr(worldAabbMin), btVector3.getCPtr(worldAabbMax), maxHandles, btOverlappingPairCache.getCPtr(pairCache), disableRaycastAccelerator), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(btVector3 worldAabbMin, btVector3 worldAabbMax, ushort maxHandles, btOverlappingPairCache pairCache) : this(BulletPINVOKE.new_btAxisSweep3__SWIG_1(btVector3.getCPtr(worldAabbMin), btVector3.getCPtr(worldAabbMax), maxHandles, btOverlappingPairCache.getCPtr(pairCache)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(btVector3 worldAabbMin, btVector3 worldAabbMax, ushort maxHandles) : this(BulletPINVOKE.new_btAxisSweep3__SWIG_2(btVector3.getCPtr(worldAabbMin), btVector3.getCPtr(worldAabbMax), maxHandles), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(btVector3 worldAabbMin, btVector3 worldAabbMax) : this(BulletPINVOKE.new_btAxisSweep3__SWIG_3(btVector3.getCPtr(worldAabbMin), btVector3.getCPtr(worldAabbMax)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
