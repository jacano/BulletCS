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

public class btDynamicsWorld : btCollisionWorld {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btDynamicsWorld(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btDynamicsWorld_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btDynamicsWorld obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDynamicsWorld() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btDynamicsWorld(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps, float fixedTimeStep) {
    int ret = BulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_0(swigCPtr, timeStep, maxSubSteps, fixedTimeStep);
    return ret;
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps) {
    int ret = BulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_1(swigCPtr, timeStep, maxSubSteps);
    return ret;
  }

  public virtual int stepSimulation(float timeStep) {
    int ret = BulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_2(swigCPtr, timeStep);
    return ret;
  }

  public override void debugDrawWorld() {
    BulletPINVOKE.btDynamicsWorld_debugDrawWorld(swigCPtr);
  }

  public virtual void addConstraint(btTypedConstraint constraint, bool disableCollisionsBetweenLinkedBodies) {
    BulletPINVOKE.btDynamicsWorld_addConstraint__SWIG_0(swigCPtr, btTypedConstraint.getCPtr(constraint), disableCollisionsBetweenLinkedBodies);
  }

  public virtual void addConstraint(btTypedConstraint constraint) {
    BulletPINVOKE.btDynamicsWorld_addConstraint__SWIG_1(swigCPtr, btTypedConstraint.getCPtr(constraint));
  }

  public virtual void removeConstraint(btTypedConstraint constraint) {
    BulletPINVOKE.btDynamicsWorld_removeConstraint(swigCPtr, btTypedConstraint.getCPtr(constraint));
  }

  public virtual void addAction(btActionInterface action) {
    BulletPINVOKE.btDynamicsWorld_addAction(swigCPtr, btActionInterface.getCPtr(action));
  }

  public virtual void removeAction(btActionInterface action) {
    BulletPINVOKE.btDynamicsWorld_removeAction(swigCPtr, btActionInterface.getCPtr(action));
  }

  public virtual void setGravity(btVector3 gravity) {
    BulletPINVOKE.btDynamicsWorld_setGravity(swigCPtr, btVector3.getCPtr(gravity));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual btVector3 getGravity() {
    btVector3 ret = new btVector3(BulletPINVOKE.btDynamicsWorld_getGravity(swigCPtr), true);
    return ret;
  }

  public virtual void synchronizeMotionStates() {
    BulletPINVOKE.btDynamicsWorld_synchronizeMotionStates(swigCPtr);
  }

  public virtual void addRigidBody(btRigidBody body) {
    BulletPINVOKE.btDynamicsWorld_addRigidBody__SWIG_0(swigCPtr, btRigidBody.getCPtr(body));
  }

  public virtual void addRigidBody(btRigidBody body, short group, short mask) {
    BulletPINVOKE.btDynamicsWorld_addRigidBody__SWIG_1(swigCPtr, btRigidBody.getCPtr(body), group, mask);
  }

  public virtual void removeRigidBody(btRigidBody body) {
    BulletPINVOKE.btDynamicsWorld_removeRigidBody(swigCPtr, btRigidBody.getCPtr(body));
  }

  public virtual void setConstraintSolver(btConstraintSolver solver) {
    BulletPINVOKE.btDynamicsWorld_setConstraintSolver(swigCPtr, btConstraintSolver.getCPtr(solver));
  }

  public virtual btConstraintSolver getConstraintSolver() {
    global::System.IntPtr cPtr = BulletPINVOKE.btDynamicsWorld_getConstraintSolver(swigCPtr);
    btConstraintSolver ret = (cPtr == global::System.IntPtr.Zero) ? null : new btConstraintSolver(cPtr, false);
    return ret;
  }

  public virtual int getNumConstraints() {
    int ret = BulletPINVOKE.btDynamicsWorld_getNumConstraints(swigCPtr);
    return ret;
  }

  public virtual btTypedConstraint getConstraint(int index) {
    global::System.IntPtr cPtr = BulletPINVOKE.btDynamicsWorld_getConstraint__SWIG_0(swigCPtr, index);
    btTypedConstraint ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTypedConstraint(cPtr, false);
    return ret;
  }

  public virtual btDynamicsWorldType getWorldType() {
    btDynamicsWorldType ret = (btDynamicsWorldType)BulletPINVOKE.btDynamicsWorld_getWorldType(swigCPtr);
    return ret;
  }

  public virtual void clearForces() {
    BulletPINVOKE.btDynamicsWorld_clearForces(swigCPtr);
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb, SWIGTYPE_p_void worldUserInfo, bool isPreTick) {
    BulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_0(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb), SWIGTYPE_p_void.getCPtr(worldUserInfo), isPreTick);
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb, SWIGTYPE_p_void worldUserInfo) {
    BulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_1(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb), SWIGTYPE_p_void.getCPtr(worldUserInfo));
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb) {
    BulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_2(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb));
  }

  public void setWorldUserInfo(SWIGTYPE_p_void worldUserInfo) {
    BulletPINVOKE.btDynamicsWorld_setWorldUserInfo(swigCPtr, SWIGTYPE_p_void.getCPtr(worldUserInfo));
  }

  public SWIGTYPE_p_void getWorldUserInfo() {
    global::System.IntPtr cPtr = BulletPINVOKE.btDynamicsWorld_getWorldUserInfo(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public btContactSolverInfo getSolverInfo() {
    btContactSolverInfo ret = new btContactSolverInfo(BulletPINVOKE.btDynamicsWorld_getSolverInfo(swigCPtr), false);
    return ret;
  }

  public virtual void addVehicle(btActionInterface vehicle) {
    BulletPINVOKE.btDynamicsWorld_addVehicle(swigCPtr, btActionInterface.getCPtr(vehicle));
  }

  public virtual void removeVehicle(btActionInterface vehicle) {
    BulletPINVOKE.btDynamicsWorld_removeVehicle(swigCPtr, btActionInterface.getCPtr(vehicle));
  }

  public virtual void addCharacter(btActionInterface character) {
    BulletPINVOKE.btDynamicsWorld_addCharacter(swigCPtr, btActionInterface.getCPtr(character));
  }

  public virtual void removeCharacter(btActionInterface character) {
    BulletPINVOKE.btDynamicsWorld_removeCharacter(swigCPtr, btActionInterface.getCPtr(character));
  }

}

}
