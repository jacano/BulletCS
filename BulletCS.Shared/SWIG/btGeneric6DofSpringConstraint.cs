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

public class btGeneric6DofSpringConstraint : btGeneric6DofConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btGeneric6DofSpringConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btGeneric6DofSpringConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btGeneric6DofSpringConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGeneric6DofSpringConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btGeneric6DofSpringConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btGeneric6DofSpringConstraint(btRigidBody rbA, btRigidBody rbB, btTransform frameInA, btTransform frameInB, bool useLinearReferenceFrameA) : this(BulletPINVOKE.new_btGeneric6DofSpringConstraint__SWIG_0(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInA), btTransform.getCPtr(frameInB), useLinearReferenceFrameA), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btGeneric6DofSpringConstraint(btRigidBody rbB, btTransform frameInB, bool useLinearReferenceFrameB) : this(BulletPINVOKE.new_btGeneric6DofSpringConstraint__SWIG_1(btRigidBody.getCPtr(rbB), btTransform.getCPtr(frameInB), useLinearReferenceFrameB), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableSpring(int index, bool onOff) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_enableSpring(swigCPtr, index, onOff);
  }

  public void setStiffness(int index, float stiffness) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setStiffness(swigCPtr, index, stiffness);
  }

  public void setDamping(int index, float damping) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setDamping(swigCPtr, index, damping);
  }

  public void setEquilibriumPoint() {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setEquilibriumPoint__SWIG_0(swigCPtr);
  }

  public void setEquilibriumPoint(int index) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setEquilibriumPoint__SWIG_1(swigCPtr, index);
  }

  public void setEquilibriumPoint(int index, float val) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setEquilibriumPoint__SWIG_2(swigCPtr, index, val);
  }

  public virtual new void setAxis(btVector3 axis1, btVector3 axis2) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_setAxis(swigCPtr, btVector3.getCPtr(axis1), btVector3.getCPtr(axis2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getInfo2(btTypedConstraint.btConstraintInfo2 info) {
    BulletPINVOKE.btGeneric6DofSpringConstraint_getInfo2(swigCPtr, btTypedConstraint.btConstraintInfo2.getCPtr(info));
  }

  public override int calculateSerializeBufferSize() {
    int ret = BulletPINVOKE.btGeneric6DofSpringConstraint_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public override string serialize(SWIGTYPE_p_void dataBuffer, btSerializer serializer) {
    string ret = BulletPINVOKE.btGeneric6DofSpringConstraint_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
