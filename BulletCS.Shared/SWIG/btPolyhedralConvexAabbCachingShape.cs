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

public class btPolyhedralConvexAabbCachingShape : btPolyhedralConvexShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btPolyhedralConvexAabbCachingShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btPolyhedralConvexAabbCachingShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btPolyhedralConvexAabbCachingShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPolyhedralConvexAabbCachingShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btPolyhedralConvexAabbCachingShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void getNonvirtualAabb(btTransform trans, btVector3 aabbMin, btVector3 aabbMax, float margin) {
    BulletPINVOKE.btPolyhedralConvexAabbCachingShape_getNonvirtualAabb(swigCPtr, btTransform.getCPtr(trans), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), margin);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btPolyhedralConvexAabbCachingShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getAabb(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btPolyhedralConvexAabbCachingShape_getAabb(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void recalcLocalAabb() {
    BulletPINVOKE.btPolyhedralConvexAabbCachingShape_recalcLocalAabb(swigCPtr);
  }

}

}
