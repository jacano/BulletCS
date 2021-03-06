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

public class btMatrix3x3 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btMatrix3x3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btMatrix3x3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btMatrix3x3() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btMatrix3x3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btMatrix3x3() : this(BulletPINVOKE.new_btMatrix3x3__SWIG_0(), true) {
  }

  public btMatrix3x3(btQuaternion q) : this(BulletPINVOKE.new_btMatrix3x3__SWIG_1(btQuaternion.getCPtr(q)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btMatrix3x3(float xx, float xy, float xz, float yx, float yy, float yz, float zx, float zy, float zz) : this(BulletPINVOKE.new_btMatrix3x3__SWIG_2(xx, xy, xz, yx, yy, yz, zx, zy, zz), true) {
  }

  public btMatrix3x3(btMatrix3x3 other) : this(BulletPINVOKE.new_btMatrix3x3__SWIG_3(btMatrix3x3.getCPtr(other)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btVector3 getColumn(int i) {
    btVector3 ret = new btVector3(BulletPINVOKE.btMatrix3x3_getColumn(swigCPtr, i), true);
    return ret;
  }

  public btVector3 getRow(int i) {
    btVector3 ret = new btVector3(BulletPINVOKE.btMatrix3x3_getRow(swigCPtr, i), false);
    return ret;
  }

  public void setFromOpenGLSubMatrix(SWIGTYPE_p_float m) {
    BulletPINVOKE.btMatrix3x3_setFromOpenGLSubMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void setValue(float xx, float xy, float xz, float yx, float yy, float yz, float zx, float zy, float zz) {
    BulletPINVOKE.btMatrix3x3_setValue(swigCPtr, xx, xy, xz, yx, yy, yz, zx, zy, zz);
  }

  public void setRotation(btQuaternion q) {
    BulletPINVOKE.btMatrix3x3_setRotation(swigCPtr, btQuaternion.getCPtr(q));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setEulerYPR(float yaw, float pitch, float roll) {
    BulletPINVOKE.btMatrix3x3_setEulerYPR(swigCPtr, yaw, pitch, roll);
  }

  public void setEulerZYX(float eulerX, float eulerY, float eulerZ) {
    BulletPINVOKE.btMatrix3x3_setEulerZYX(swigCPtr, eulerX, eulerY, eulerZ);
  }

  public void setIdentity() {
    BulletPINVOKE.btMatrix3x3_setIdentity(swigCPtr);
  }

  public static btMatrix3x3 getIdentity() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_getIdentity(), false);
    return ret;
  }

  public void getOpenGLSubMatrix(SWIGTYPE_p_float m) {
    BulletPINVOKE.btMatrix3x3_getOpenGLSubMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void getRotation(btQuaternion q) {
    BulletPINVOKE.btMatrix3x3_getRotation(swigCPtr, btQuaternion.getCPtr(q));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getEulerYPR(SWIGTYPE_p_float yaw, SWIGTYPE_p_float pitch, SWIGTYPE_p_float roll) {
    BulletPINVOKE.btMatrix3x3_getEulerYPR(swigCPtr, SWIGTYPE_p_float.getCPtr(yaw), SWIGTYPE_p_float.getCPtr(pitch), SWIGTYPE_p_float.getCPtr(roll));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getEulerZYX(SWIGTYPE_p_float yaw, SWIGTYPE_p_float pitch, SWIGTYPE_p_float roll, uint solution_number) {
    BulletPINVOKE.btMatrix3x3_getEulerZYX__SWIG_0(swigCPtr, SWIGTYPE_p_float.getCPtr(yaw), SWIGTYPE_p_float.getCPtr(pitch), SWIGTYPE_p_float.getCPtr(roll), solution_number);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getEulerZYX(SWIGTYPE_p_float yaw, SWIGTYPE_p_float pitch, SWIGTYPE_p_float roll) {
    BulletPINVOKE.btMatrix3x3_getEulerZYX__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(yaw), SWIGTYPE_p_float.getCPtr(pitch), SWIGTYPE_p_float.getCPtr(roll));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btMatrix3x3 scaled(btVector3 s) {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_scaled(swigCPtr, btVector3.getCPtr(s)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float determinant() {
    float ret = BulletPINVOKE.btMatrix3x3_determinant(swigCPtr);
    return ret;
  }

  public btMatrix3x3 adjoint() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_adjoint(swigCPtr), true);
    return ret;
  }

  public btMatrix3x3 absolute() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_absolute(swigCPtr), true);
    return ret;
  }

  public btMatrix3x3 transpose() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_transpose(swigCPtr), true);
    return ret;
  }

  public btMatrix3x3 inverse() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_inverse(swigCPtr), true);
    return ret;
  }

  public btMatrix3x3 transposeTimes(btMatrix3x3 m) {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_transposeTimes(swigCPtr, btMatrix3x3.getCPtr(m)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btMatrix3x3 timesTranspose(btMatrix3x3 m) {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btMatrix3x3_timesTranspose(swigCPtr, btMatrix3x3.getCPtr(m)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float tdotx(btVector3 v) {
    float ret = BulletPINVOKE.btMatrix3x3_tdotx(swigCPtr, btVector3.getCPtr(v));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float tdoty(btVector3 v) {
    float ret = BulletPINVOKE.btMatrix3x3_tdoty(swigCPtr, btVector3.getCPtr(v));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float tdotz(btVector3 v) {
    float ret = BulletPINVOKE.btMatrix3x3_tdotz(swigCPtr, btVector3.getCPtr(v));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void diagonalize(btMatrix3x3 rot, float threshold, int maxSteps) {
    BulletPINVOKE.btMatrix3x3_diagonalize(swigCPtr, btMatrix3x3.getCPtr(rot), threshold, maxSteps);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public float cofac(int r1, int c1, int r2, int c2) {
    float ret = BulletPINVOKE.btMatrix3x3_cofac(swigCPtr, r1, c1, r2, c2);
    return ret;
  }

  public void serialize(btMatrix3x3FloatData dataOut) {
    BulletPINVOKE.btMatrix3x3_serialize(swigCPtr, btMatrix3x3FloatData.getCPtr(dataOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void serializeFloat(btMatrix3x3FloatData dataOut) {
    BulletPINVOKE.btMatrix3x3_serializeFloat(swigCPtr, btMatrix3x3FloatData.getCPtr(dataOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerialize(btMatrix3x3FloatData dataIn) {
    BulletPINVOKE.btMatrix3x3_deSerialize(swigCPtr, btMatrix3x3FloatData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeFloat(btMatrix3x3FloatData dataIn) {
    BulletPINVOKE.btMatrix3x3_deSerializeFloat(swigCPtr, btMatrix3x3FloatData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeDouble(btMatrix3x3DoubleData dataIn) {
    BulletPINVOKE.btMatrix3x3_deSerializeDouble(swigCPtr, btMatrix3x3DoubleData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
