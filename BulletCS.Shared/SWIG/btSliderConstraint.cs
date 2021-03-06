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

public class btSliderConstraint : btTypedConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btSliderConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btSliderConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btSliderConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSliderConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btSliderConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btSliderConstraint(btRigidBody rbA, btRigidBody rbB, btTransform frameInA, btTransform frameInB, bool useLinearReferenceFrameA) : this(BulletPINVOKE.new_btSliderConstraint__SWIG_0(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInA), btTransform.getCPtr(frameInB), useLinearReferenceFrameA), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btSliderConstraint(btRigidBody rbB, btTransform frameInB, bool useLinearReferenceFrameA) : this(BulletPINVOKE.new_btSliderConstraint__SWIG_1(btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInB), useLinearReferenceFrameA), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getInfo1(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btSliderConstraint_getInfo1(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public void getInfo1NonVirtual(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btSliderConstraint_getInfo1NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public override void getInfo2(btTypedConstraint.btConstraintInfo2 info) {
    BulletPINVOKE.btSliderConstraint_getInfo2(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info));
  }

  public void getInfo2NonVirtual(btTypedConstraint.btConstraintInfo2 info, btTransform transA, btTransform transB, btVector3 linVelA, btVector3 linVelB, float rbAinvMass, float rbBinvMass) {
    BulletPINVOKE.btSliderConstraint_getInfo2NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info), btTransform.getCPtr(transA), btTransform.getCPtr(transB), btVector3.getCPtr(linVelA), btVector3.getCPtr(linVelB), rbAinvMass, rbBinvMass);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public new btRigidBody getRigidBodyA() {
    btRigidBody ret = new btRigidBody(BulletPINVOKE.btSliderConstraint_getRigidBodyA(swigCPtr), false);
    return ret;
  }

  public new btRigidBody getRigidBodyB() {
    btRigidBody ret = new btRigidBody(BulletPINVOKE.btSliderConstraint_getRigidBodyB(swigCPtr), false);
    return ret;
  }

  public btTransform getCalculatedTransformA() {
    btTransform ret = new btTransform(BulletPINVOKE.btSliderConstraint_getCalculatedTransformA(swigCPtr), false);
    return ret;
  }

  public btTransform getCalculatedTransformB() {
    btTransform ret = new btTransform(BulletPINVOKE.btSliderConstraint_getCalculatedTransformB(swigCPtr), false);
    return ret;
  }

  public btTransform getFrameOffsetA() {
    btTransform ret = new btTransform(BulletPINVOKE.btSliderConstraint_getFrameOffsetA__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btTransform getFrameOffsetB() {
    btTransform ret = new btTransform(BulletPINVOKE.btSliderConstraint_getFrameOffsetB__SWIG_0(swigCPtr), false);
    return ret;
  }

  public float getLowerLinLimit() {
    float ret = BulletPINVOKE.btSliderConstraint_getLowerLinLimit(swigCPtr);
    return ret;
  }

  public void setLowerLinLimit(float lowerLimit) {
    BulletPINVOKE.btSliderConstraint_setLowerLinLimit(swigCPtr, lowerLimit);
  }

  public float getUpperLinLimit() {
    float ret = BulletPINVOKE.btSliderConstraint_getUpperLinLimit(swigCPtr);
    return ret;
  }

  public void setUpperLinLimit(float upperLimit) {
    BulletPINVOKE.btSliderConstraint_setUpperLinLimit(swigCPtr, upperLimit);
  }

  public float getLowerAngLimit() {
    float ret = BulletPINVOKE.btSliderConstraint_getLowerAngLimit(swigCPtr);
    return ret;
  }

  public void setLowerAngLimit(float lowerLimit) {
    BulletPINVOKE.btSliderConstraint_setLowerAngLimit(swigCPtr, lowerLimit);
  }

  public float getUpperAngLimit() {
    float ret = BulletPINVOKE.btSliderConstraint_getUpperAngLimit(swigCPtr);
    return ret;
  }

  public void setUpperAngLimit(float upperLimit) {
    BulletPINVOKE.btSliderConstraint_setUpperAngLimit(swigCPtr, upperLimit);
  }

  public bool getUseLinearReferenceFrameA() {
    bool ret = BulletPINVOKE.btSliderConstraint_getUseLinearReferenceFrameA(swigCPtr);
    return ret;
  }

  public float getSoftnessDirLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessDirLin(swigCPtr);
    return ret;
  }

  public float getRestitutionDirLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionDirLin(swigCPtr);
    return ret;
  }

  public float getDampingDirLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingDirLin(swigCPtr);
    return ret;
  }

  public float getSoftnessDirAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessDirAng(swigCPtr);
    return ret;
  }

  public float getRestitutionDirAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionDirAng(swigCPtr);
    return ret;
  }

  public float getDampingDirAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingDirAng(swigCPtr);
    return ret;
  }

  public float getSoftnessLimLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessLimLin(swigCPtr);
    return ret;
  }

  public float getRestitutionLimLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionLimLin(swigCPtr);
    return ret;
  }

  public float getDampingLimLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingLimLin(swigCPtr);
    return ret;
  }

  public float getSoftnessLimAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessLimAng(swigCPtr);
    return ret;
  }

  public float getRestitutionLimAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionLimAng(swigCPtr);
    return ret;
  }

  public float getDampingLimAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingLimAng(swigCPtr);
    return ret;
  }

  public float getSoftnessOrthoLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessOrthoLin(swigCPtr);
    return ret;
  }

  public float getRestitutionOrthoLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionOrthoLin(swigCPtr);
    return ret;
  }

  public float getDampingOrthoLin() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingOrthoLin(swigCPtr);
    return ret;
  }

  public float getSoftnessOrthoAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getSoftnessOrthoAng(swigCPtr);
    return ret;
  }

  public float getRestitutionOrthoAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getRestitutionOrthoAng(swigCPtr);
    return ret;
  }

  public float getDampingOrthoAng() {
    float ret = BulletPINVOKE.btSliderConstraint_getDampingOrthoAng(swigCPtr);
    return ret;
  }

  public void setSoftnessDirLin(float softnessDirLin) {
    BulletPINVOKE.btSliderConstraint_setSoftnessDirLin(swigCPtr, softnessDirLin);
  }

  public void setRestitutionDirLin(float restitutionDirLin) {
    BulletPINVOKE.btSliderConstraint_setRestitutionDirLin(swigCPtr, restitutionDirLin);
  }

  public void setDampingDirLin(float dampingDirLin) {
    BulletPINVOKE.btSliderConstraint_setDampingDirLin(swigCPtr, dampingDirLin);
  }

  public void setSoftnessDirAng(float softnessDirAng) {
    BulletPINVOKE.btSliderConstraint_setSoftnessDirAng(swigCPtr, softnessDirAng);
  }

  public void setRestitutionDirAng(float restitutionDirAng) {
    BulletPINVOKE.btSliderConstraint_setRestitutionDirAng(swigCPtr, restitutionDirAng);
  }

  public void setDampingDirAng(float dampingDirAng) {
    BulletPINVOKE.btSliderConstraint_setDampingDirAng(swigCPtr, dampingDirAng);
  }

  public void setSoftnessLimLin(float softnessLimLin) {
    BulletPINVOKE.btSliderConstraint_setSoftnessLimLin(swigCPtr, softnessLimLin);
  }

  public void setRestitutionLimLin(float restitutionLimLin) {
    BulletPINVOKE.btSliderConstraint_setRestitutionLimLin(swigCPtr, restitutionLimLin);
  }

  public void setDampingLimLin(float dampingLimLin) {
    BulletPINVOKE.btSliderConstraint_setDampingLimLin(swigCPtr, dampingLimLin);
  }

  public void setSoftnessLimAng(float softnessLimAng) {
    BulletPINVOKE.btSliderConstraint_setSoftnessLimAng(swigCPtr, softnessLimAng);
  }

  public void setRestitutionLimAng(float restitutionLimAng) {
    BulletPINVOKE.btSliderConstraint_setRestitutionLimAng(swigCPtr, restitutionLimAng);
  }

  public void setDampingLimAng(float dampingLimAng) {
    BulletPINVOKE.btSliderConstraint_setDampingLimAng(swigCPtr, dampingLimAng);
  }

  public void setSoftnessOrthoLin(float softnessOrthoLin) {
    BulletPINVOKE.btSliderConstraint_setSoftnessOrthoLin(swigCPtr, softnessOrthoLin);
  }

  public void setRestitutionOrthoLin(float restitutionOrthoLin) {
    BulletPINVOKE.btSliderConstraint_setRestitutionOrthoLin(swigCPtr, restitutionOrthoLin);
  }

  public void setDampingOrthoLin(float dampingOrthoLin) {
    BulletPINVOKE.btSliderConstraint_setDampingOrthoLin(swigCPtr, dampingOrthoLin);
  }

  public void setSoftnessOrthoAng(float softnessOrthoAng) {
    BulletPINVOKE.btSliderConstraint_setSoftnessOrthoAng(swigCPtr, softnessOrthoAng);
  }

  public void setRestitutionOrthoAng(float restitutionOrthoAng) {
    BulletPINVOKE.btSliderConstraint_setRestitutionOrthoAng(swigCPtr, restitutionOrthoAng);
  }

  public void setDampingOrthoAng(float dampingOrthoAng) {
    BulletPINVOKE.btSliderConstraint_setDampingOrthoAng(swigCPtr, dampingOrthoAng);
  }

  public void setPoweredLinMotor(bool onOff) {
    BulletPINVOKE.btSliderConstraint_setPoweredLinMotor(swigCPtr, onOff);
  }

  public bool getPoweredLinMotor() {
    bool ret = BulletPINVOKE.btSliderConstraint_getPoweredLinMotor(swigCPtr);
    return ret;
  }

  public void setTargetLinMotorVelocity(float targetLinMotorVelocity) {
    BulletPINVOKE.btSliderConstraint_setTargetLinMotorVelocity(swigCPtr, targetLinMotorVelocity);
  }

  public float getTargetLinMotorVelocity() {
    float ret = BulletPINVOKE.btSliderConstraint_getTargetLinMotorVelocity(swigCPtr);
    return ret;
  }

  public void setMaxLinMotorForce(float maxLinMotorForce) {
    BulletPINVOKE.btSliderConstraint_setMaxLinMotorForce(swigCPtr, maxLinMotorForce);
  }

  public float getMaxLinMotorForce() {
    float ret = BulletPINVOKE.btSliderConstraint_getMaxLinMotorForce(swigCPtr);
    return ret;
  }

  public void setPoweredAngMotor(bool onOff) {
    BulletPINVOKE.btSliderConstraint_setPoweredAngMotor(swigCPtr, onOff);
  }

  public bool getPoweredAngMotor() {
    bool ret = BulletPINVOKE.btSliderConstraint_getPoweredAngMotor(swigCPtr);
    return ret;
  }

  public void setTargetAngMotorVelocity(float targetAngMotorVelocity) {
    BulletPINVOKE.btSliderConstraint_setTargetAngMotorVelocity(swigCPtr, targetAngMotorVelocity);
  }

  public float getTargetAngMotorVelocity() {
    float ret = BulletPINVOKE.btSliderConstraint_getTargetAngMotorVelocity(swigCPtr);
    return ret;
  }

  public void setMaxAngMotorForce(float maxAngMotorForce) {
    BulletPINVOKE.btSliderConstraint_setMaxAngMotorForce(swigCPtr, maxAngMotorForce);
  }

  public float getMaxAngMotorForce() {
    float ret = BulletPINVOKE.btSliderConstraint_getMaxAngMotorForce(swigCPtr);
    return ret;
  }

  public float getLinearPos() {
    float ret = BulletPINVOKE.btSliderConstraint_getLinearPos(swigCPtr);
    return ret;
  }

  public float getAngularPos() {
    float ret = BulletPINVOKE.btSliderConstraint_getAngularPos(swigCPtr);
    return ret;
  }

  public bool getSolveLinLimit() {
    bool ret = BulletPINVOKE.btSliderConstraint_getSolveLinLimit(swigCPtr);
    return ret;
  }

  public float getLinDepth() {
    float ret = BulletPINVOKE.btSliderConstraint_getLinDepth(swigCPtr);
    return ret;
  }

  public bool getSolveAngLimit() {
    bool ret = BulletPINVOKE.btSliderConstraint_getSolveAngLimit(swigCPtr);
    return ret;
  }

  public float getAngDepth() {
    float ret = BulletPINVOKE.btSliderConstraint_getAngDepth(swigCPtr);
    return ret;
  }

  public void calculateTransforms(btTransform transA, btTransform transB) {
    BulletPINVOKE.btSliderConstraint_calculateTransforms(swigCPtr, btTransform.getCPtr(transA), btTransform.getCPtr(transB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void testLinLimits() {
    BulletPINVOKE.btSliderConstraint_testLinLimits(swigCPtr);
  }

  public void testAngLimits() {
    BulletPINVOKE.btSliderConstraint_testAngLimits(swigCPtr);
  }

  public btVector3 getAncorInA() {
    btVector3 ret = new btVector3(BulletPINVOKE.btSliderConstraint_getAncorInA(swigCPtr), true);
    return ret;
  }

  public btVector3 getAncorInB() {
    btVector3 ret = new btVector3(BulletPINVOKE.btSliderConstraint_getAncorInB(swigCPtr), true);
    return ret;
  }

  public bool getUseFrameOffset() {
    bool ret = BulletPINVOKE.btSliderConstraint_getUseFrameOffset(swigCPtr);
    return ret;
  }

  public void setUseFrameOffset(bool frameOffsetOnOff) {
    BulletPINVOKE.btSliderConstraint_setUseFrameOffset(swigCPtr, frameOffsetOnOff);
  }

  public void setFrames(btTransform frameA, btTransform frameB) {
    BulletPINVOKE.btSliderConstraint_setFrames(swigCPtr, btTransform.getCPtr(frameA), btTransform.getCPtr(frameB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setParam(int num, float value, int axis) {
    BulletPINVOKE.btSliderConstraint_setParam__SWIG_0(swigCPtr, num, value, axis);
  }

  public override void setParam(int num, float value) {
    BulletPINVOKE.btSliderConstraint_setParam__SWIG_1(swigCPtr, num, value);
  }

  public override float getParam(int num, int axis) {
    float ret = BulletPINVOKE.btSliderConstraint_getParam__SWIG_0(swigCPtr, num, axis);
    return ret;
  }

  public override float getParam(int num) {
    float ret = BulletPINVOKE.btSliderConstraint_getParam__SWIG_1(swigCPtr, num);
    return ret;
  }

  public override int calculateSerializeBufferSize() {
    int ret = BulletPINVOKE.btSliderConstraint_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public override string serialize(SWIGTYPE_p_void dataBuffer, btSerializer serializer) {
    string ret = BulletPINVOKE.btSliderConstraint_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
