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

public class btTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTransform() : this(BulletPINVOKE.new_btTransform__SWIG_0(), true) {
  }

  public btTransform(btQuaternion q, btVector3 c) : this(BulletPINVOKE.new_btTransform__SWIG_1(btQuaternion.getCPtr(q), btVector3.getCPtr(c)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btQuaternion q) : this(BulletPINVOKE.new_btTransform__SWIG_2(btQuaternion.getCPtr(q)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btMatrix3x3 b, btVector3 c) : this(BulletPINVOKE.new_btTransform__SWIG_3(btMatrix3x3.getCPtr(b), btVector3.getCPtr(c)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btMatrix3x3 b) : this(BulletPINVOKE.new_btTransform__SWIG_4(btMatrix3x3.getCPtr(b)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btTransform other) : this(BulletPINVOKE.new_btTransform__SWIG_5(btTransform.getCPtr(other)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void mult(btTransform t1, btTransform t2) {
    BulletPINVOKE.btTransform_mult(swigCPtr, btTransform.getCPtr(t1), btTransform.getCPtr(t2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btMatrix3x3 getBasis() {
    btMatrix3x3 ret = new btMatrix3x3(BulletPINVOKE.btTransform_getBasis__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btVector3 getOrigin() {
    btVector3 ret = new btVector3(BulletPINVOKE.btTransform_getOrigin__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btQuaternion getRotation() {
    btQuaternion ret = new btQuaternion(BulletPINVOKE.btTransform_getRotation(swigCPtr), true);
    return ret;
  }

  public void setFromOpenGLMatrix(SWIGTYPE_p_float m) {
    BulletPINVOKE.btTransform_setFromOpenGLMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void getOpenGLMatrix(SWIGTYPE_p_float m) {
    BulletPINVOKE.btTransform_getOpenGLMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void setOrigin(btVector3 origin) {
    BulletPINVOKE.btTransform_setOrigin(swigCPtr, btVector3.getCPtr(origin));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btVector3 invXform(btVector3 inVec) {
    btVector3 ret = new btVector3(BulletPINVOKE.btTransform_invXform(swigCPtr, btVector3.getCPtr(inVec)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBasis(btMatrix3x3 basis) {
    BulletPINVOKE.btTransform_setBasis(swigCPtr, btMatrix3x3.getCPtr(basis));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRotation(btQuaternion q) {
    BulletPINVOKE.btTransform_setRotation(swigCPtr, btQuaternion.getCPtr(q));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setIdentity() {
    BulletPINVOKE.btTransform_setIdentity(swigCPtr);
  }

  public btTransform inverse() {
    btTransform ret = new btTransform(BulletPINVOKE.btTransform_inverse(swigCPtr), true);
    return ret;
  }

  public btTransform inverseTimes(btTransform t) {
    btTransform ret = new btTransform(BulletPINVOKE.btTransform_inverseTimes(swigCPtr, btTransform.getCPtr(t)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btTransform getIdentity() {
    btTransform ret = new btTransform(BulletPINVOKE.btTransform_getIdentity(), false);
    return ret;
  }

  public void serialize(btTransformFloatData dataOut) {
    BulletPINVOKE.btTransform_serialize(swigCPtr, btTransformFloatData.getCPtr(dataOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void serializeFloat(btTransformFloatData dataOut) {
    BulletPINVOKE.btTransform_serializeFloat(swigCPtr, btTransformFloatData.getCPtr(dataOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerialize(btTransformFloatData dataIn) {
    BulletPINVOKE.btTransform_deSerialize(swigCPtr, btTransformFloatData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeDouble(btTransformDoubleData dataIn) {
    BulletPINVOKE.btTransform_deSerializeDouble(swigCPtr, btTransformDoubleData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeFloat(btTransformFloatData dataIn) {
    BulletPINVOKE.btTransform_deSerializeFloat(swigCPtr, btTransformFloatData.getCPtr(dataIn));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
