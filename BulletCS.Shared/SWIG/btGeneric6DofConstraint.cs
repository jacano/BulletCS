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

public class btGeneric6DofConstraint : btTypedConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btGeneric6DofConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btGeneric6DofConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btGeneric6DofConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGeneric6DofConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btGeneric6DofConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool m_useSolveConstraintObsolete {
    set {
      BulletPINVOKE.btGeneric6DofConstraint_m_useSolveConstraintObsolete_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btGeneric6DofConstraint_m_useSolveConstraintObsolete_get(swigCPtr);
      return ret;
    } 
  }

  public btGeneric6DofConstraint(btRigidBody rbA, btRigidBody rbB, btTransform frameInA, btTransform frameInB, bool useLinearReferenceFrameA) : this(BulletPINVOKE.new_btGeneric6DofConstraint__SWIG_0(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInA), btTransform.getCPtr(frameInB), useLinearReferenceFrameA), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btGeneric6DofConstraint(btRigidBody rbB, btTransform frameInB, bool useLinearReferenceFrameB) : this(BulletPINVOKE.new_btGeneric6DofConstraint__SWIG_1(btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInB), useLinearReferenceFrameB), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calculateTransforms(btTransform transA, btTransform transB) {
    BulletPINVOKE.btGeneric6DofConstraint_calculateTransforms__SWIG_0(swigCPtr, btTransform.getCPtr(transA), btTransform.getCPtr(transB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calculateTransforms() {
    BulletPINVOKE.btGeneric6DofConstraint_calculateTransforms__SWIG_1(swigCPtr);
  }

  public btTransform getCalculatedTransformA() {
    btTransform ret = new btTransform(BulletPINVOKE.btGeneric6DofConstraint_getCalculatedTransformA(swigCPtr), false);
    return ret;
  }

  public btTransform getCalculatedTransformB() {
    btTransform ret = new btTransform(BulletPINVOKE.btGeneric6DofConstraint_getCalculatedTransformB(swigCPtr), false);
    return ret;
  }

  public btTransform getFrameOffsetA() {
    btTransform ret = new btTransform(BulletPINVOKE.btGeneric6DofConstraint_getFrameOffsetA__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btTransform getFrameOffsetB() {
    btTransform ret = new btTransform(BulletPINVOKE.btGeneric6DofConstraint_getFrameOffsetB__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override void buildJacobian() {
    BulletPINVOKE.btGeneric6DofConstraint_buildJacobian(swigCPtr);
  }

  public override void getInfo1(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btGeneric6DofConstraint_getInfo1(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public void getInfo1NonVirtual(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btGeneric6DofConstraint_getInfo1NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public override void getInfo2(btTypedConstraint.btConstraintInfo2 info) {
    BulletPINVOKE.btGeneric6DofConstraint_getInfo2(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info));
  }

  public void getInfo2NonVirtual(btTypedConstraint.btConstraintInfo2 info, btTransform transA, btTransform transB, btVector3 linVelA, btVector3 linVelB, btVector3 angVelA, btVector3 angVelB) {
    BulletPINVOKE.btGeneric6DofConstraint_getInfo2NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info), btTransform.getCPtr(transA), btTransform.getCPtr(transB), btVector3.getCPtr(linVelA), btVector3.getCPtr(linVelB), btVector3.getCPtr(angVelA), btVector3.getCPtr(angVelB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updateRHS(float timeStep) {
    BulletPINVOKE.btGeneric6DofConstraint_updateRHS(swigCPtr, timeStep);
  }

  public btVector3 getAxis(int axis_index) {
    btVector3 ret = new btVector3(BulletPINVOKE.btGeneric6DofConstraint_getAxis(swigCPtr, axis_index), true);
    return ret;
  }

  public float getAngle(int axis_index) {
    float ret = BulletPINVOKE.btGeneric6DofConstraint_getAngle(swigCPtr, axis_index);
    return ret;
  }

  public float getRelativePivotPosition(int axis_index) {
    float ret = BulletPINVOKE.btGeneric6DofConstraint_getRelativePivotPosition(swigCPtr, axis_index);
    return ret;
  }

  public void setFrames(btTransform frameA, btTransform frameB) {
    BulletPINVOKE.btGeneric6DofConstraint_setFrames(swigCPtr, btTransform.getCPtr(frameA), btTransform.getCPtr(frameB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool testAngularLimitMotor(int axis_index) {
    bool ret = BulletPINVOKE.btGeneric6DofConstraint_testAngularLimitMotor(swigCPtr, axis_index);
    return ret;
  }

  public void setLinearLowerLimit(btVector3 linearLower) {
    BulletPINVOKE.btGeneric6DofConstraint_setLinearLowerLimit(swigCPtr, btVector3.getCPtr(linearLower));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getLinearLowerLimit(btVector3 linearLower) {
    BulletPINVOKE.btGeneric6DofConstraint_getLinearLowerLimit(swigCPtr, btVector3.getCPtr(linearLower));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLinearUpperLimit(btVector3 linearUpper) {
    BulletPINVOKE.btGeneric6DofConstraint_setLinearUpperLimit(swigCPtr, btVector3.getCPtr(linearUpper));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getLinearUpperLimit(btVector3 linearUpper) {
    BulletPINVOKE.btGeneric6DofConstraint_getLinearUpperLimit(swigCPtr, btVector3.getCPtr(linearUpper));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAngularLowerLimit(btVector3 angularLower) {
    BulletPINVOKE.btGeneric6DofConstraint_setAngularLowerLimit(swigCPtr, btVector3.getCPtr(angularLower));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getAngularLowerLimit(btVector3 angularLower) {
    BulletPINVOKE.btGeneric6DofConstraint_getAngularLowerLimit(swigCPtr, btVector3.getCPtr(angularLower));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAngularUpperLimit(btVector3 angularUpper) {
    BulletPINVOKE.btGeneric6DofConstraint_setAngularUpperLimit(swigCPtr, btVector3.getCPtr(angularUpper));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getAngularUpperLimit(btVector3 angularUpper) {
    BulletPINVOKE.btGeneric6DofConstraint_getAngularUpperLimit(swigCPtr, btVector3.getCPtr(angularUpper));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btRotationalLimitMotor getRotationalLimitMotor(int index) {
    global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofConstraint_getRotationalLimitMotor(swigCPtr, index);
    btRotationalLimitMotor ret = (cPtr == global::System.IntPtr.Zero) ? null : new btRotationalLimitMotor(cPtr, false);
    return ret;
  }

  public btTranslationalLimitMotor getTranslationalLimitMotor() {
    global::System.IntPtr cPtr = BulletPINVOKE.btGeneric6DofConstraint_getTranslationalLimitMotor(swigCPtr);
    btTranslationalLimitMotor ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTranslationalLimitMotor(cPtr, false);
    return ret;
  }

  public void setLimit(int axis, float lo, float hi) {
    BulletPINVOKE.btGeneric6DofConstraint_setLimit(swigCPtr, axis, lo, hi);
  }

  public bool isLimited(int limitIndex) {
    bool ret = BulletPINVOKE.btGeneric6DofConstraint_isLimited(swigCPtr, limitIndex);
    return ret;
  }

  public virtual void calcAnchorPos() {
    BulletPINVOKE.btGeneric6DofConstraint_calcAnchorPos(swigCPtr);
  }

  public int get_limit_motor_info2(btRotationalLimitMotor limot, btTransform transA, btTransform transB, btVector3 linVelA, btVector3 linVelB, btVector3 angVelA, btVector3 angVelB, btTypedConstraint.btConstraintInfo2 info, int row, btVector3 ax1, int rotational, int rotAllowed) {
    int ret = BulletPINVOKE.btGeneric6DofConstraint_get_limit_motor_info2__SWIG_0(swigCPtr, btRotationalLimitMotor.getCPtr(limot), btTransform.getCPtr(transA), btTransform.getCPtr(transB), btVector3.getCPtr(linVelA), btVector3.getCPtr(linVelB), btVector3.getCPtr(angVelA), btVector3.getCPtr(angVelB), btTypedConstraint.btConstraintInfo2.getCPtr(info), row, btVector3.getCPtr(ax1), rotational, rotAllowed);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_limit_motor_info2(btRotationalLimitMotor limot, btTransform transA, btTransform transB, btVector3 linVelA, btVector3 linVelB, btVector3 angVelA, btVector3 angVelB, btTypedConstraint.btConstraintInfo2 info, int row, btVector3 ax1, int rotational) {
    int ret = BulletPINVOKE.btGeneric6DofConstraint_get_limit_motor_info2__SWIG_1(swigCPtr, btRotationalLimitMotor.getCPtr(limot), btTransform.getCPtr(transA), btTransform.getCPtr(transB), btVector3.getCPtr(linVelA), btVector3.getCPtr(linVelB), btVector3.getCPtr(angVelA), btVector3.getCPtr(angVelB), btTypedConstraint.btConstraintInfo2.getCPtr(info), row, btVector3.getCPtr(ax1), rotational);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getUseFrameOffset() {
    bool ret = BulletPINVOKE.btGeneric6DofConstraint_getUseFrameOffset(swigCPtr);
    return ret;
  }

  public void setUseFrameOffset(bool frameOffsetOnOff) {
    BulletPINVOKE.btGeneric6DofConstraint_setUseFrameOffset(swigCPtr, frameOffsetOnOff);
  }

  public override void setParam(int num, float value, int axis) {
    BulletPINVOKE.btGeneric6DofConstraint_setParam__SWIG_0(swigCPtr, num, value, axis);
  }

  public override void setParam(int num, float value) {
    BulletPINVOKE.btGeneric6DofConstraint_setParam__SWIG_1(swigCPtr, num, value);
  }

  public override float getParam(int num, int axis) {
    float ret = BulletPINVOKE.btGeneric6DofConstraint_getParam__SWIG_0(swigCPtr, num, axis);
    return ret;
  }

  public override float getParam(int num) {
    float ret = BulletPINVOKE.btGeneric6DofConstraint_getParam__SWIG_1(swigCPtr, num);
    return ret;
  }

  public void setAxis(btVector3 axis1, btVector3 axis2) {
    BulletPINVOKE.btGeneric6DofConstraint_setAxis(swigCPtr, btVector3.getCPtr(axis1), btVector3.getCPtr(axis2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int calculateSerializeBufferSize() {
    int ret = BulletPINVOKE.btGeneric6DofConstraint_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public override string serialize(SWIGTYPE_p_void dataBuffer, btSerializer serializer) {
    string ret = BulletPINVOKE.btGeneric6DofConstraint_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
