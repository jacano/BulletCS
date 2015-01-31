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

public class btCollisionShape : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionShape(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCollisionShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCollisionShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void getAabb(btTransform t, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btCollisionShape_getAabb(swigCPtr, btTransform.getCPtr(t), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getBoundingSphere(btVector3 center, SWIGTYPE_p_float radius) {
    BulletPINVOKE.btCollisionShape_getBoundingSphere(swigCPtr, btVector3.getCPtr(center), SWIGTYPE_p_float.getCPtr(radius));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getAngularMotionDisc() {
    float ret = BulletPINVOKE.btCollisionShape_getAngularMotionDisc(swigCPtr);
    return ret;
  }

  public virtual float getContactBreakingThreshold(float defaultContactThresholdFactor) {
    float ret = BulletPINVOKE.btCollisionShape_getContactBreakingThreshold(swigCPtr, defaultContactThresholdFactor);
    return ret;
  }

  public void calculateTemporalAabb(btTransform curTrans, btVector3 linvel, btVector3 angvel, float timeStep, btVector3 temporalAabbMin, btVector3 temporalAabbMax) {
    BulletPINVOKE.btCollisionShape_calculateTemporalAabb(swigCPtr, btTransform.getCPtr(curTrans), btVector3.getCPtr(linvel), btVector3.getCPtr(angvel), timeStep, btVector3.getCPtr(temporalAabbMin), btVector3.getCPtr(temporalAabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isPolyhedral() {
    bool ret = BulletPINVOKE.btCollisionShape_isPolyhedral(swigCPtr);
    return ret;
  }

  public bool isConvex2d() {
    bool ret = BulletPINVOKE.btCollisionShape_isConvex2d(swigCPtr);
    return ret;
  }

  public bool isConvex() {
    bool ret = BulletPINVOKE.btCollisionShape_isConvex(swigCPtr);
    return ret;
  }

  public bool isNonMoving() {
    bool ret = BulletPINVOKE.btCollisionShape_isNonMoving(swigCPtr);
    return ret;
  }

  public bool isConcave() {
    bool ret = BulletPINVOKE.btCollisionShape_isConcave(swigCPtr);
    return ret;
  }

  public bool isCompound() {
    bool ret = BulletPINVOKE.btCollisionShape_isCompound(swigCPtr);
    return ret;
  }

  public bool isSoftBody() {
    bool ret = BulletPINVOKE.btCollisionShape_isSoftBody(swigCPtr);
    return ret;
  }

  public bool isInfinite() {
    bool ret = BulletPINVOKE.btCollisionShape_isInfinite(swigCPtr);
    return ret;
  }

  public virtual void setLocalScaling(btVector3 scaling) {
    BulletPINVOKE.btCollisionShape_setLocalScaling(swigCPtr, btVector3.getCPtr(scaling));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual btVector3 getLocalScaling() {
    btVector3 ret = new btVector3(BulletPINVOKE.btCollisionShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public virtual void calculateLocalInertia(float mass, btVector3 inertia) {
    BulletPINVOKE.btCollisionShape_calculateLocalInertia(swigCPtr, mass, btVector3.getCPtr(inertia));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getName() {
    string ret = BulletPINVOKE.btCollisionShape_getName(swigCPtr);
    return ret;
  }

  public int getShapeType() {
    int ret = BulletPINVOKE.btCollisionShape_getShapeType(swigCPtr);
    return ret;
  }

  public virtual btVector3 getAnisotropicRollingFrictionDirection() {
    btVector3 ret = new btVector3(BulletPINVOKE.btCollisionShape_getAnisotropicRollingFrictionDirection(swigCPtr), true);
    return ret;
  }

  public virtual void setMargin(float margin) {
    BulletPINVOKE.btCollisionShape_setMargin(swigCPtr, margin);
  }

  public virtual float getMargin() {
    float ret = BulletPINVOKE.btCollisionShape_getMargin(swigCPtr);
    return ret;
  }

  public void setUserPointer(SWIGTYPE_p_void userPtr) {
    BulletPINVOKE.btCollisionShape_setUserPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(userPtr));
  }

  public SWIGTYPE_p_void getUserPointer() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionShape_getUserPointer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletPINVOKE.btCollisionShape_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, btSerializer serializer) {
    string ret = BulletPINVOKE.btCollisionShape_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), btSerializer.getCPtr(serializer));
    return ret;
  }

  public virtual void serializeSingleShape(btSerializer serializer) {
    BulletPINVOKE.btCollisionShape_serializeSingleShape(swigCPtr, btSerializer.getCPtr(serializer));
  }

}

}