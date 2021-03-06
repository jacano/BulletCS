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

public class btConcaveShape : btCollisionShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btConcaveShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btConcaveShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btConcaveShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConcaveShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btConcaveShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void processAllTriangles(btTriangleCallback callback, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btConcaveShape_processAllTriangles(swigCPtr, btTriangleCallback.getCPtr(callback), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override float getMargin() {
    float ret = BulletPINVOKE.btConcaveShape_getMargin(swigCPtr);
    return ret;
  }

  public override void setMargin(float collisionMargin) {
    BulletPINVOKE.btConcaveShape_setMargin(swigCPtr, collisionMargin);
  }

}

}
