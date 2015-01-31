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

public class btWheelInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btWheelInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btWheelInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btWheelInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btWheelInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class RaycastInfo : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal RaycastInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RaycastInfo obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~RaycastInfo() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btWheelInfo_RaycastInfo(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public btVector3 m_contactNormalWS {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_contactNormalWS_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_contactNormalWS_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public btVector3 m_contactPointWS {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_contactPointWS_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_contactPointWS_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public float m_suspensionLength {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_suspensionLength_set(swigCPtr, value);
      } 
      get {
        float ret = BulletPINVOKE.btWheelInfo_RaycastInfo_m_suspensionLength_get(swigCPtr);
        return ret;
      } 
    }
  
    public btVector3 m_hardPointWS {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_hardPointWS_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_hardPointWS_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public btVector3 m_wheelDirectionWS {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_wheelDirectionWS_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_wheelDirectionWS_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public btVector3 m_wheelAxleWS {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_wheelAxleWS_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_wheelAxleWS_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public bool m_isInContact {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_isInContact_set(swigCPtr, value);
      } 
      get {
        bool ret = BulletPINVOKE.btWheelInfo_RaycastInfo_m_isInContact_get(swigCPtr);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_void m_groundObject {
      set {
        BulletPINVOKE.btWheelInfo_RaycastInfo_m_groundObject_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_RaycastInfo_m_groundObject_get(swigCPtr);
        SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
        return ret;
      } 
    }
  
    public RaycastInfo() : this(BulletPINVOKE.new_btWheelInfo_RaycastInfo(), true) {
    }
  
  }

  public btWheelInfo.RaycastInfo m_raycastInfo {
    set {
      BulletPINVOKE.btWheelInfo_m_raycastInfo_set(swigCPtr, btWheelInfo.RaycastInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_raycastInfo_get(swigCPtr);
      btWheelInfo.RaycastInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new btWheelInfo.RaycastInfo(cPtr, false);
      return ret;
    } 
  }

  public btTransform m_worldTransform {
    set {
      BulletPINVOKE.btWheelInfo_m_worldTransform_set(swigCPtr, btTransform.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_worldTransform_get(swigCPtr);
      btTransform ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransform(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_chassisConnectionPointCS {
    set {
      BulletPINVOKE.btWheelInfo_m_chassisConnectionPointCS_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_chassisConnectionPointCS_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_wheelDirectionCS {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelDirectionCS_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_wheelDirectionCS_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public btVector3 m_wheelAxleCS {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelAxleCS_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_wheelAxleCS_get(swigCPtr);
      btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public float m_suspensionRestLength1 {
    set {
      BulletPINVOKE.btWheelInfo_m_suspensionRestLength1_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_suspensionRestLength1_get(swigCPtr);
      return ret;
    } 
  }

  public float m_maxSuspensionTravelCm {
    set {
      BulletPINVOKE.btWheelInfo_m_maxSuspensionTravelCm_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_maxSuspensionTravelCm_get(swigCPtr);
      return ret;
    } 
  }

  public float getSuspensionRestLength() {
    float ret = BulletPINVOKE.btWheelInfo_getSuspensionRestLength(swigCPtr);
    return ret;
  }

  public float m_wheelsRadius {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelsRadius_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_wheelsRadius_get(swigCPtr);
      return ret;
    } 
  }

  public float m_suspensionStiffness {
    set {
      BulletPINVOKE.btWheelInfo_m_suspensionStiffness_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_suspensionStiffness_get(swigCPtr);
      return ret;
    } 
  }

  public float m_wheelsDampingCompression {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelsDampingCompression_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_wheelsDampingCompression_get(swigCPtr);
      return ret;
    } 
  }

  public float m_wheelsDampingRelaxation {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelsDampingRelaxation_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_wheelsDampingRelaxation_get(swigCPtr);
      return ret;
    } 
  }

  public float m_frictionSlip {
    set {
      BulletPINVOKE.btWheelInfo_m_frictionSlip_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_frictionSlip_get(swigCPtr);
      return ret;
    } 
  }

  public float m_steering {
    set {
      BulletPINVOKE.btWheelInfo_m_steering_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_steering_get(swigCPtr);
      return ret;
    } 
  }

  public float m_rotation {
    set {
      BulletPINVOKE.btWheelInfo_m_rotation_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public float m_deltaRotation {
    set {
      BulletPINVOKE.btWheelInfo_m_deltaRotation_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_deltaRotation_get(swigCPtr);
      return ret;
    } 
  }

  public float m_rollInfluence {
    set {
      BulletPINVOKE.btWheelInfo_m_rollInfluence_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_rollInfluence_get(swigCPtr);
      return ret;
    } 
  }

  public float m_maxSuspensionForce {
    set {
      BulletPINVOKE.btWheelInfo_m_maxSuspensionForce_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_maxSuspensionForce_get(swigCPtr);
      return ret;
    } 
  }

  public float m_engineForce {
    set {
      BulletPINVOKE.btWheelInfo_m_engineForce_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_engineForce_get(swigCPtr);
      return ret;
    } 
  }

  public float m_brake {
    set {
      BulletPINVOKE.btWheelInfo_m_brake_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_brake_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_bIsFrontWheel {
    set {
      BulletPINVOKE.btWheelInfo_m_bIsFrontWheel_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletPINVOKE.btWheelInfo_m_bIsFrontWheel_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void m_clientInfo {
    set {
      BulletPINVOKE.btWheelInfo_m_clientInfo_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btWheelInfo_m_clientInfo_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public btWheelInfo() : this(BulletPINVOKE.new_btWheelInfo__SWIG_0(), true) {
  }

  public btWheelInfo(btWheelInfoConstructionInfo ci) : this(BulletPINVOKE.new_btWheelInfo__SWIG_1(btWheelInfoConstructionInfo.getCPtr(ci)), true) {
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updateWheel(btRigidBody chassis, btWheelInfo.RaycastInfo raycastInfo) {
    BulletPINVOKE.btWheelInfo_updateWheel(swigCPtr, btRigidBody.getCPtr(chassis), btWheelInfo.RaycastInfo.getCPtr(raycastInfo));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public float m_clippedInvContactDotSuspension {
    set {
      BulletPINVOKE.btWheelInfo_m_clippedInvContactDotSuspension_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_clippedInvContactDotSuspension_get(swigCPtr);
      return ret;
    } 
  }

  public float m_suspensionRelativeVelocity {
    set {
      BulletPINVOKE.btWheelInfo_m_suspensionRelativeVelocity_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_suspensionRelativeVelocity_get(swigCPtr);
      return ret;
    } 
  }

  public float m_wheelsSuspensionForce {
    set {
      BulletPINVOKE.btWheelInfo_m_wheelsSuspensionForce_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_wheelsSuspensionForce_get(swigCPtr);
      return ret;
    } 
  }

  public float m_skidInfo {
    set {
      BulletPINVOKE.btWheelInfo_m_skidInfo_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btWheelInfo_m_skidInfo_get(swigCPtr);
      return ret;
    } 
  }

}

}
