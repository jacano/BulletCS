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

public class btRigidBodyFloatData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btRigidBodyFloatData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btRigidBodyFloatData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btRigidBodyFloatData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btRigidBodyFloatData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btCollisionObjectFloatData m_collisionObjectData {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_collisionObjectData_set(swigCPtr, btCollisionObjectFloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_collisionObjectData_get(swigCPtr);
      btCollisionObjectFloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObjectFloatData(cPtr, false);
      return ret;
    } 
  }

  public btMatrix3x3FloatData m_invInertiaTensorWorld {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_invInertiaTensorWorld_set(swigCPtr, btMatrix3x3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_invInertiaTensorWorld_get(swigCPtr);
      btMatrix3x3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btMatrix3x3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_linearVelocity {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_linearVelocity_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_linearVelocity_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_angularVelocity {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_angularVelocity_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_angularVelocity_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_angularFactor {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_angularFactor_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_angularFactor_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_linearFactor {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_linearFactor_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_linearFactor_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_gravity {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_gravity_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_gravity_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_gravity_acceleration {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_gravity_acceleration_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_gravity_acceleration_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_invInertiaLocal {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_invInertiaLocal_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_invInertiaLocal_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_totalForce {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_totalForce_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_totalForce_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData m_totalTorque {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_totalTorque_set(swigCPtr, btVector3FloatData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btRigidBodyFloatData_m_totalTorque_get(swigCPtr);
      btVector3FloatData ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public float m_inverseMass {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_inverseMass_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_inverseMass_get(swigCPtr);
      return ret;
    } 
  }

  public float m_linearDamping {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_linearDamping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_linearDamping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_angularDamping {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_angularDamping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_angularDamping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_additionalDampingFactor {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_additionalDampingFactor_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_additionalDampingFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float m_additionalLinearDampingThresholdSqr {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_additionalLinearDampingThresholdSqr_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_additionalLinearDampingThresholdSqr_get(swigCPtr);
      return ret;
    } 
  }

  public float m_additionalAngularDampingThresholdSqr {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_additionalAngularDampingThresholdSqr_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_additionalAngularDampingThresholdSqr_get(swigCPtr);
      return ret;
    } 
  }

  public float m_additionalAngularDampingFactor {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_additionalAngularDampingFactor_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_additionalAngularDampingFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float m_linearSleepingThreshold {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_linearSleepingThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_linearSleepingThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public float m_angularSleepingThreshold {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_angularSleepingThreshold_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btRigidBodyFloatData_m_angularSleepingThreshold_get(swigCPtr);
      return ret;
    } 
  }

  public int m_additionalDamping {
    set {
      BulletPINVOKE.btRigidBodyFloatData_m_additionalDamping_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btRigidBodyFloatData_m_additionalDamping_get(swigCPtr);
      return ret;
    } 
  }

  public btRigidBodyFloatData() : this(BulletPINVOKE.new_btRigidBodyFloatData(), true) {
  }

}

}