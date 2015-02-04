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

public class btCollisionWorld : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionWorld(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCollisionWorld obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionWorld() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCollisionWorld(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btCollisionWorld(btDispatcher dispatcher, btBroadphaseInterface broadphasePairCache, btCollisionConfiguration collisionConfiguration) : this(BulletPINVOKE.new_btCollisionWorld(btDispatcher.getCPtr(dispatcher), btBroadphaseInterface.getCPtr(broadphasePairCache), btCollisionConfiguration.getCPtr(collisionConfiguration)), true) {
  }

  public void setBroadphase(btBroadphaseInterface pairCache) {
    BulletPINVOKE.btCollisionWorld_setBroadphase(swigCPtr, btBroadphaseInterface.getCPtr(pairCache));
  }

  public btBroadphaseInterface getBroadphase() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_getBroadphase__SWIG_0(swigCPtr);
    btBroadphaseInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new btBroadphaseInterface(cPtr, false);
    return ret;
  }

  public btOverlappingPairCache getPairCache() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_getPairCache(swigCPtr);
    btOverlappingPairCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new btOverlappingPairCache(cPtr, false);
    return ret;
  }

  public btDispatcher getDispatcher() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_getDispatcher__SWIG_0(swigCPtr);
    btDispatcher ret = (cPtr == global::System.IntPtr.Zero) ? null : new btDispatcher(cPtr, false);
    return ret;
  }

  public void updateSingleAabb(btCollisionObject colObj) {
    BulletPINVOKE.btCollisionWorld_updateSingleAabb(swigCPtr, btCollisionObject.getCPtr(colObj));
  }

  public virtual void updateAabbs() {
    BulletPINVOKE.btCollisionWorld_updateAabbs(swigCPtr);
  }

  public virtual void computeOverlappingPairs() {
    BulletPINVOKE.btCollisionWorld_computeOverlappingPairs(swigCPtr);
  }

  public virtual void setDebugDrawer(btIDebugDraw debugDrawer) {
    BulletPINVOKE.btCollisionWorld_setDebugDrawer(swigCPtr, btIDebugDraw.getCPtr(debugDrawer));
  }

  public virtual btIDebugDraw getDebugDrawer() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_getDebugDrawer(swigCPtr);
    btIDebugDraw ret = (cPtr == global::System.IntPtr.Zero) ? null : new btIDebugDraw(cPtr, false);
    return ret;
  }

  public virtual void debugDrawWorld() {
    BulletPINVOKE.btCollisionWorld_debugDrawWorld(swigCPtr);
  }

  public virtual void debugDrawObject(btTransform worldTransform, btCollisionShape shape, btVector3 color) {
    BulletPINVOKE.btCollisionWorld_debugDrawObject(swigCPtr, btTransform.getCPtr(worldTransform), btCollisionShape.getCPtr(shape), btVector3.getCPtr(color));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public class LocalShapeInfo : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal LocalShapeInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LocalShapeInfo obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~LocalShapeInfo() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_LocalShapeInfo(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public int m_shapePart {
      set {
        BulletPINVOKE.btCollisionWorld_LocalShapeInfo_m_shapePart_set(swigCPtr, value);
      } 
      get {
        int ret = BulletPINVOKE.btCollisionWorld_LocalShapeInfo_m_shapePart_get(swigCPtr);
        return ret;
      } 
    }
  
    public int m_triangleIndex {
      set {
        BulletPINVOKE.btCollisionWorld_LocalShapeInfo_m_triangleIndex_set(swigCPtr, value);
      } 
      get {
        int ret = BulletPINVOKE.btCollisionWorld_LocalShapeInfo_m_triangleIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public LocalShapeInfo() : this(BulletPINVOKE.new_btCollisionWorld_LocalShapeInfo(), true) {
    }
  
  }

  public class LocalRayResult : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal LocalRayResult(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LocalRayResult obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~LocalRayResult() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_LocalRayResult(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public LocalRayResult(btCollisionObject collisionObject, btCollisionWorld.LocalShapeInfo localShapeInfo, btVector3 hitNormalLocal, float hitFraction) : this(BulletPINVOKE.new_btCollisionWorld_LocalRayResult(btCollisionObject.getCPtr(collisionObject), btCollisionWorld.LocalShapeInfo.getCPtr(localShapeInfo), btVector3.getCPtr(hitNormalLocal), hitFraction), true) {
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public btCollisionObject m_collisionObject {
      set {
        BulletPINVOKE.btCollisionWorld_LocalRayResult_m_collisionObject_set(swigCPtr, btCollisionObject.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_LocalRayResult_m_collisionObject_get(swigCPtr);
        btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
        return ret;
      } 
    }
  
    public btCollisionWorld.LocalShapeInfo m_localShapeInfo {
      set {
        BulletPINVOKE.btCollisionWorld_LocalRayResult_m_localShapeInfo_set(swigCPtr, btCollisionWorld.LocalShapeInfo.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_LocalRayResult_m_localShapeInfo_get(swigCPtr);
        btCollisionWorld.LocalShapeInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionWorld.LocalShapeInfo(cPtr, false);
        return ret;
      } 
    }
  
    public btVector3 m_hitNormalLocal {
      set {
        BulletPINVOKE.btCollisionWorld_LocalRayResult_m_hitNormalLocal_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_LocalRayResult_m_hitNormalLocal_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public float m_hitFraction {
      set {
        BulletPINVOKE.btCollisionWorld_LocalRayResult_m_hitFraction_set(swigCPtr, value);
      } 
      get {
        float ret = BulletPINVOKE.btCollisionWorld_LocalRayResult_m_hitFraction_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public class RayResultCallback : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal RayResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RayResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~RayResultCallback() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_RayResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public float m_closestHitFraction {
      set {
        BulletPINVOKE.btCollisionWorld_RayResultCallback_m_closestHitFraction_set(swigCPtr, value);
      } 
      get {
        float ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_m_closestHitFraction_get(swigCPtr);
        return ret;
      } 
    }
  
    public btCollisionObject m_collisionObject {
      set {
        BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionObject_set(swigCPtr, btCollisionObject.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionObject_get(swigCPtr);
        btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
        return ret;
      } 
    }
  
    public short m_collisionFilterGroup {
      set {
        BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionFilterGroup_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionFilterGroup_get(swigCPtr);
        return ret;
      } 
    }
  
    public short m_collisionFilterMask {
      set {
        BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionFilterMask_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_m_collisionFilterMask_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint m_flags {
      set {
        BulletPINVOKE.btCollisionWorld_RayResultCallback_m_flags_set(swigCPtr, value);
      } 
      get {
        uint ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_m_flags_get(swigCPtr);
        return ret;
      } 
    }
  
    public bool hasHit() {
      bool ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_hasHit(swigCPtr);
      return ret;
    }
  
    public virtual bool needsCollision(btBroadphaseProxy proxy0) {
      bool ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_needsCollision(swigCPtr, btBroadphaseProxy.getCPtr(proxy0));
      return ret;
    }
  
    public virtual float addSingleResult(btCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace) {
      float ret = BulletPINVOKE.btCollisionWorld_RayResultCallback_addSingleResult(swigCPtr, btCollisionWorld.LocalRayResult.getCPtr(rayResult), normalInWorldSpace);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class ClosestRayResultCallback : btCollisionWorld.RayResultCallback {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
    internal ClosestRayResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btCollisionWorld_ClosestRayResultCallback_SWIGUpcast(cPtr), cMemoryOwn) {
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClosestRayResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ClosestRayResultCallback() {
      Dispose();
    }
  
    public override void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_ClosestRayResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
        base.Dispose();
      }
    }
  
    public ClosestRayResultCallback(btVector3 rayFromWorld, btVector3 rayToWorld) : this(BulletPINVOKE.new_btCollisionWorld_ClosestRayResultCallback(btVector3.getCPtr(rayFromWorld), btVector3.getCPtr(rayToWorld)), true) {
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public override float addSingleResult(btCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace) {
      float ret = BulletPINVOKE.btCollisionWorld_ClosestRayResultCallback_addSingleResult(swigCPtr, btCollisionWorld.LocalRayResult.getCPtr(rayResult), normalInWorldSpace);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class AllHitsRayResultCallback : btCollisionWorld.RayResultCallback {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
    internal AllHitsRayResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_SWIGUpcast(cPtr), cMemoryOwn) {
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AllHitsRayResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~AllHitsRayResultCallback() {
      Dispose();
    }
  
    public override void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_AllHitsRayResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
        base.Dispose();
      }
    }
  
    public AllHitsRayResultCallback(btVector3 rayFromWorld, btVector3 rayToWorld) : this(BulletPINVOKE.new_btCollisionWorld_AllHitsRayResultCallback(btVector3.getCPtr(rayFromWorld), btVector3.getCPtr(rayToWorld)), true) {
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_const_p_t m_collisionObjects {
      set {
        BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_collisionObjects_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_const_p_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_collisionObjects_get(swigCPtr);
        SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_const_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_const_p_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t m_hitNormalWorld {
      set {
        BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitNormalWorld_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitNormalWorld_get(swigCPtr);
        SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t m_hitPointWorld {
      set {
        BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitPointWorld_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitPointWorld_get(swigCPtr);
        SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_btAlignedObjectArrayT_float_t m_hitFractions {
      set {
        BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitFractions_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_float_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_m_hitFractions_get(swigCPtr);
        SWIGTYPE_p_btAlignedObjectArrayT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_float_t(cPtr, false);
        return ret;
      } 
    }
  
    public override float addSingleResult(btCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace) {
      float ret = BulletPINVOKE.btCollisionWorld_AllHitsRayResultCallback_addSingleResult(swigCPtr, btCollisionWorld.LocalRayResult.getCPtr(rayResult), normalInWorldSpace);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class LocalConvexResult : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal LocalConvexResult(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LocalConvexResult obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~LocalConvexResult() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_LocalConvexResult(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public LocalConvexResult(btCollisionObject hitCollisionObject, btCollisionWorld.LocalShapeInfo localShapeInfo, btVector3 hitNormalLocal, btVector3 hitPointLocal, float hitFraction) : this(BulletPINVOKE.new_btCollisionWorld_LocalConvexResult(btCollisionObject.getCPtr(hitCollisionObject), btCollisionWorld.LocalShapeInfo.getCPtr(localShapeInfo), btVector3.getCPtr(hitNormalLocal), btVector3.getCPtr(hitPointLocal), hitFraction), true) {
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public btCollisionObject m_hitCollisionObject {
      set {
        BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_hitCollisionObject_set(swigCPtr, btCollisionObject.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_hitCollisionObject_get(swigCPtr);
        btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
        return ret;
      } 
    }
  
    public btCollisionWorld.LocalShapeInfo m_localShapeInfo {
      set {
        BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_localShapeInfo_set(swigCPtr, btCollisionWorld.LocalShapeInfo.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_localShapeInfo_get(swigCPtr);
        btCollisionWorld.LocalShapeInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionWorld.LocalShapeInfo(cPtr, false);
        return ret;
      } 
    }
  
    public float m_hitFraction {
      set {
        BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_hitFraction_set(swigCPtr, value);
      } 
      get {
        float ret = BulletPINVOKE.btCollisionWorld_LocalConvexResult_m_hitFraction_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public class ConvexResultCallback : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ConvexResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConvexResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ConvexResultCallback() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_ConvexResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public float m_closestHitFraction {
      set {
        BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_closestHitFraction_set(swigCPtr, value);
      } 
      get {
        float ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_closestHitFraction_get(swigCPtr);
        return ret;
      } 
    }
  
    public short m_collisionFilterGroup {
      set {
        BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_collisionFilterGroup_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_collisionFilterGroup_get(swigCPtr);
        return ret;
      } 
    }
  
    public short m_collisionFilterMask {
      set {
        BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_collisionFilterMask_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_m_collisionFilterMask_get(swigCPtr);
        return ret;
      } 
    }
  
    public bool hasHit() {
      bool ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_hasHit(swigCPtr);
      return ret;
    }
  
    public virtual bool needsCollision(btBroadphaseProxy proxy0) {
      bool ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_needsCollision(swigCPtr, btBroadphaseProxy.getCPtr(proxy0));
      return ret;
    }
  
    public virtual float addSingleResult(btCollisionWorld.LocalConvexResult convexResult, bool normalInWorldSpace) {
      float ret = BulletPINVOKE.btCollisionWorld_ConvexResultCallback_addSingleResult(swigCPtr, btCollisionWorld.LocalConvexResult.getCPtr(convexResult), normalInWorldSpace);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class ClosestConvexResultCallback : btCollisionWorld.ConvexResultCallback {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
    internal ClosestConvexResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_SWIGUpcast(cPtr), cMemoryOwn) {
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClosestConvexResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ClosestConvexResultCallback() {
      Dispose();
    }
  
    public override void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_ClosestConvexResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
        base.Dispose();
      }
    }
  
    public ClosestConvexResultCallback(btVector3 convexFromWorld, btVector3 convexToWorld) : this(BulletPINVOKE.new_btCollisionWorld_ClosestConvexResultCallback(btVector3.getCPtr(convexFromWorld), btVector3.getCPtr(convexToWorld)), true) {
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public btVector3 m_convexFromWorld {
      set {
        BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_convexFromWorld_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_convexFromWorld_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public btVector3 m_convexToWorld {
      set {
        BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_convexToWorld_set(swigCPtr, btVector3.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_convexToWorld_get(swigCPtr);
        btVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new btVector3(cPtr, false);
        return ret;
      } 
    }
  
    public btCollisionObject m_hitCollisionObject {
      set {
        BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_hitCollisionObject_set(swigCPtr, btCollisionObject.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_m_hitCollisionObject_get(swigCPtr);
        btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
        return ret;
      } 
    }
  
    public override float addSingleResult(btCollisionWorld.LocalConvexResult convexResult, bool normalInWorldSpace) {
      float ret = BulletPINVOKE.btCollisionWorld_ClosestConvexResultCallback_addSingleResult(swigCPtr, btCollisionWorld.LocalConvexResult.getCPtr(convexResult), normalInWorldSpace);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public class ContactResultCallback : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ContactResultCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ContactResultCallback obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ContactResultCallback() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            BulletPINVOKE.delete_btCollisionWorld_ContactResultCallback(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public short m_collisionFilterGroup {
      set {
        BulletPINVOKE.btCollisionWorld_ContactResultCallback_m_collisionFilterGroup_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_ContactResultCallback_m_collisionFilterGroup_get(swigCPtr);
        return ret;
      } 
    }
  
    public short m_collisionFilterMask {
      set {
        BulletPINVOKE.btCollisionWorld_ContactResultCallback_m_collisionFilterMask_set(swigCPtr, value);
      } 
      get {
        short ret = BulletPINVOKE.btCollisionWorld_ContactResultCallback_m_collisionFilterMask_get(swigCPtr);
        return ret;
      } 
    }
  
    public virtual bool needsCollision(btBroadphaseProxy proxy0) {
      bool ret = BulletPINVOKE.btCollisionWorld_ContactResultCallback_needsCollision(swigCPtr, btBroadphaseProxy.getCPtr(proxy0));
      return ret;
    }
  
    public virtual float addSingleResult(btManifoldPoint cp, btCollisionObjectWrapper colObj0Wrap, int partId0, int index0, btCollisionObjectWrapper colObj1Wrap, int partId1, int index1) {
      float ret = BulletPINVOKE.btCollisionWorld_ContactResultCallback_addSingleResult(swigCPtr, btManifoldPoint.getCPtr(cp), btCollisionObjectWrapper.getCPtr(colObj0Wrap), partId0, index0, btCollisionObjectWrapper.getCPtr(colObj1Wrap), partId1, index1);
      if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public int getNumCollisionObjects() {
    int ret = BulletPINVOKE.btCollisionWorld_getNumCollisionObjects(swigCPtr);
    return ret;
  }

  public virtual void rayTest(btVector3 rayFromWorld, btVector3 rayToWorld, btCollisionWorld.RayResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_rayTest(swigCPtr, btVector3.getCPtr(rayFromWorld), btVector3.getCPtr(rayToWorld), btCollisionWorld.RayResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void convexSweepTest(btConvexShape castShape, btTransform from, btTransform to, btCollisionWorld.ConvexResultCallback resultCallback, float allowedCcdPenetration) {
    BulletPINVOKE.btCollisionWorld_convexSweepTest__SWIG_0(swigCPtr, btConvexShape.getCPtr(castShape), btTransform.getCPtr(from), btTransform.getCPtr(to), btCollisionWorld.ConvexResultCallback.getCPtr(resultCallback), allowedCcdPenetration);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void convexSweepTest(btConvexShape castShape, btTransform from, btTransform to, btCollisionWorld.ConvexResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_convexSweepTest__SWIG_1(swigCPtr, btConvexShape.getCPtr(castShape), btTransform.getCPtr(from), btTransform.getCPtr(to), btCollisionWorld.ConvexResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void contactTest(btCollisionObject colObj, btCollisionWorld.ContactResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_contactTest(swigCPtr, btCollisionObject.getCPtr(colObj), btCollisionWorld.ContactResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void contactPairTest(btCollisionObject colObjA, btCollisionObject colObjB, btCollisionWorld.ContactResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_contactPairTest(swigCPtr, btCollisionObject.getCPtr(colObjA), btCollisionObject.getCPtr(colObjB), btCollisionWorld.ContactResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void rayTestSingle(btTransform rayFromTrans, btTransform rayToTrans, btCollisionObject collisionObject, btCollisionShape collisionShape, btTransform colObjWorldTransform, btCollisionWorld.RayResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_rayTestSingle(btTransform.getCPtr(rayFromTrans), btTransform.getCPtr(rayToTrans), btCollisionObject.getCPtr(collisionObject), btCollisionShape.getCPtr(collisionShape), btTransform.getCPtr(colObjWorldTransform), btCollisionWorld.RayResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void rayTestSingleInternal(btTransform rayFromTrans, btTransform rayToTrans, btCollisionObjectWrapper collisionObjectWrap, btCollisionWorld.RayResultCallback resultCallback) {
    BulletPINVOKE.btCollisionWorld_rayTestSingleInternal(btTransform.getCPtr(rayFromTrans), btTransform.getCPtr(rayToTrans), btCollisionObjectWrapper.getCPtr(collisionObjectWrap), btCollisionWorld.RayResultCallback.getCPtr(resultCallback));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void objectQuerySingle(btConvexShape castShape, btTransform rayFromTrans, btTransform rayToTrans, btCollisionObject collisionObject, btCollisionShape collisionShape, btTransform colObjWorldTransform, btCollisionWorld.ConvexResultCallback resultCallback, float allowedPenetration) {
    BulletPINVOKE.btCollisionWorld_objectQuerySingle(btConvexShape.getCPtr(castShape), btTransform.getCPtr(rayFromTrans), btTransform.getCPtr(rayToTrans), btCollisionObject.getCPtr(collisionObject), btCollisionShape.getCPtr(collisionShape), btTransform.getCPtr(colObjWorldTransform), btCollisionWorld.ConvexResultCallback.getCPtr(resultCallback), allowedPenetration);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void objectQuerySingleInternal(btConvexShape castShape, btTransform convexFromTrans, btTransform convexToTrans, btCollisionObjectWrapper colObjWrap, btCollisionWorld.ConvexResultCallback resultCallback, float allowedPenetration) {
    BulletPINVOKE.btCollisionWorld_objectQuerySingleInternal(btConvexShape.getCPtr(castShape), btTransform.getCPtr(convexFromTrans), btTransform.getCPtr(convexToTrans), btCollisionObjectWrapper.getCPtr(colObjWrap), btCollisionWorld.ConvexResultCallback.getCPtr(resultCallback), allowedPenetration);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject, short collisionFilterGroup, short collisionFilterMask) {
    BulletPINVOKE.btCollisionWorld_addCollisionObject__SWIG_0(swigCPtr, btCollisionObject.getCPtr(collisionObject), collisionFilterGroup, collisionFilterMask);
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject, short collisionFilterGroup) {
    BulletPINVOKE.btCollisionWorld_addCollisionObject__SWIG_1(swigCPtr, btCollisionObject.getCPtr(collisionObject), collisionFilterGroup);
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject) {
    BulletPINVOKE.btCollisionWorld_addCollisionObject__SWIG_2(swigCPtr, btCollisionObject.getCPtr(collisionObject));
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t getCollisionObjectArray() {
    SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t ret = new SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t(BulletPINVOKE.btCollisionWorld_getCollisionObjectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public virtual void removeCollisionObject(btCollisionObject collisionObject) {
    BulletPINVOKE.btCollisionWorld_removeCollisionObject(swigCPtr, btCollisionObject.getCPtr(collisionObject));
  }

  public virtual void performDiscreteCollisionDetection() {
    BulletPINVOKE.btCollisionWorld_performDiscreteCollisionDetection(swigCPtr);
  }

  public btDispatcherInfo getDispatchInfo() {
    btDispatcherInfo ret = new btDispatcherInfo(BulletPINVOKE.btCollisionWorld_getDispatchInfo__SWIG_0(swigCPtr), false);
    return ret;
  }

  public bool getForceUpdateAllAabbs() {
    bool ret = BulletPINVOKE.btCollisionWorld_getForceUpdateAllAabbs(swigCPtr);
    return ret;
  }

  public void setForceUpdateAllAabbs(bool forceUpdateAllAabbs) {
    BulletPINVOKE.btCollisionWorld_setForceUpdateAllAabbs(swigCPtr, forceUpdateAllAabbs);
  }

  public virtual void serialize(btSerializer serializer) {
    BulletPINVOKE.btCollisionWorld_serialize(swigCPtr, btSerializer.getCPtr(serializer));
  }

}

}
