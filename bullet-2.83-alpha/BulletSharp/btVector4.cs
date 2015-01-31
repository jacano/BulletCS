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

public class btVector4 : btVector3 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btVector4(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btVector4_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btVector4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btVector4() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btVector4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btVector4() : this(BulletPINVOKE.new_btVector4__SWIG_0(), true) {
  }

  public btVector4(float _x, float _y, float _z, float _w) : this(BulletPINVOKE.new_btVector4__SWIG_1(_x, _y, _z, _w), true) {
  }

  public btVector4 absolute4() {
    btVector4 ret = new btVector4(BulletPINVOKE.btVector4_absolute4(swigCPtr), true);
    return ret;
  }

  public float getW() {
    float ret = BulletPINVOKE.btVector4_getW(swigCPtr);
    return ret;
  }

  public int maxAxis4() {
    int ret = BulletPINVOKE.btVector4_maxAxis4(swigCPtr);
    return ret;
  }

  public int minAxis4() {
    int ret = BulletPINVOKE.btVector4_minAxis4(swigCPtr);
    return ret;
  }

  public int closestAxis4() {
    int ret = BulletPINVOKE.btVector4_closestAxis4(swigCPtr);
    return ret;
  }

  public void setValue(float _x, float _y, float _z, float _w) {
    BulletPINVOKE.btVector4_setValue(swigCPtr, _x, _y, _z, _w);
  }

}

}
