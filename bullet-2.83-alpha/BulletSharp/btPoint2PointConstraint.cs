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

public class btPoint2PointConstraint : btTypedConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btPoint2PointConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btPoint2PointConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btPoint2PointConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPoint2PointConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btPoint2PointConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool m_useSolveConstraintObsolete {
    set {
      BulletPINVOKE.btPoint2PointConstraint_m_useSolveConstraintObsolete_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btPoint2PointConstraint_m_useSolveConstraintObsolete_get(swigCPtr);
      return ret;
    } 
  }

  public btConstraintSetting m_setting {
    set {
      BulletPINVOKE.btPoint2PointConstraint_m_setting_set(swigCPtr, btConstraintSetting.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btPoint2PointConstraint_m_setting_get(swigCPtr);
      btConstraintSetting ret = (cPtr == global::System.IntPtr.Zero) ? null : new btConstraintSetting(cPtr, false);
      return ret;
    } 
  }

  public btPoint2PointConstraint(btRigidBody rbA, btRigidBody rbB, btVector3 pivotInA, btVector3 pivotInB) : this(BulletPINVOKE.new_btPoint2PointConstraint__SWIG_0(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), btVector3.getCPtr(pivotInA), btVector3.getCPtr(pivotInB)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btPoint2PointConstraint(btRigidBody rbA, btVector3 pivotInA) : this(BulletPINVOKE.new_btPoint2PointConstraint__SWIG_1(btRigidBody.getCPtr(rbA), btVector3.getCPtr(pivotInA)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void buildJacobian() {
    BulletPINVOKE.btPoint2PointConstraint_buildJacobian(swigCPtr);
  }

  public override void getInfo1(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btPoint2PointConstraint_getInfo1(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public void getInfo1NonVirtual(btTypedConstraint.btConstraintInfo1 info) {
    BulletPINVOKE.btPoint2PointConstraint_getInfo1NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo1.getCPtr(info));
  }

  public override void getInfo2(btTypedConstraint.btConstraintInfo2 info) {
    BulletPINVOKE.btPoint2PointConstraint_getInfo2(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info));
  }

  public void getInfo2NonVirtual(btTypedConstraint.btConstraintInfo2 info, btTransform body0_trans, btTransform body1_trans) {
    BulletPINVOKE.btPoint2PointConstraint_getInfo2NonVirtual(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info), btTransform.getCPtr(body0_trans), btTransform.getCPtr(body1_trans));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updateRHS(float timeStep) {
    BulletPINVOKE.btPoint2PointConstraint_updateRHS(swigCPtr, timeStep);
  }

  public void setPivotA(btVector3 pivotA) {
    BulletPINVOKE.btPoint2PointConstraint_setPivotA(swigCPtr, btVector3.getCPtr(pivotA));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPivotB(btVector3 pivotB) {
    BulletPINVOKE.btPoint2PointConstraint_setPivotB(swigCPtr, btVector3.getCPtr(pivotB));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btVector3 getPivotInA() {
    btVector3 ret = new btVector3(BulletPINVOKE.btPoint2PointConstraint_getPivotInA(swigCPtr), false);
    return ret;
  }

  public btVector3 getPivotInB() {
    btVector3 ret = new btVector3(BulletPINVOKE.btPoint2PointConstraint_getPivotInB(swigCPtr), false);
    return ret;
  }

  public override void setParam(int num, float value, int axis) {
    BulletPINVOKE.btPoint2PointConstraint_setParam__SWIG_0(swigCPtr, num, value, axis);
  }

  public override void setParam(int num, float value) {
    BulletPINVOKE.btPoint2PointConstraint_setParam__SWIG_1(swigCPtr, num, value);
  }

  public override float getParam(int num, int axis) {
    float ret = BulletPINVOKE.btPoint2PointConstraint_getParam__SWIG_0(swigCPtr, num, axis);
    return ret;
  }

  public override float getParam(int num) {
    float ret = BulletPINVOKE.btPoint2PointConstraint_getParam__SWIG_1(swigCPtr, num);
    return ret;
  }

  public override int calculateSerializeBufferSize() {
    int ret = BulletPINVOKE.btPoint2PointConstraint_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public override string serialize(SWIGTYPE_p_void dataBuffer, btSerializer serializer) {
    string ret = BulletPINVOKE.btPoint2PointConstraint_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), btSerializer.getCPtr(serializer));
    return ret;
  }

}

}