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

public class btCapsuleShapeX : btCapsuleShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btCapsuleShapeX(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btCapsuleShapeX_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCapsuleShapeX obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCapsuleShapeX() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCapsuleShapeX(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btCapsuleShapeX(float radius, float height) : this(BulletPINVOKE.new_btCapsuleShapeX(radius, height), true) {
  }

  public override string getName() {
    string ret = BulletPINVOKE.btCapsuleShapeX_getName(swigCPtr);
    return ret;
  }

}

}
