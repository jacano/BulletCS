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

public class btCollisionObjectWrapper : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionObjectWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCollisionObjectWrapper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionObjectWrapper() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCollisionObjectWrapper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btCollisionObjectWrapper m_parent {
    set {
      BulletPINVOKE.btCollisionObjectWrapper_m_parent_set(swigCPtr, btCollisionObjectWrapper.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCollisionObjectWrapper_m_parent_get(swigCPtr);
      btCollisionObjectWrapper ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObjectWrapper(cPtr, false);
      return ret;
    } 
  }

  public btCollisionShape m_shape {
    set {
      BulletPINVOKE.btCollisionObjectWrapper_m_shape_set(swigCPtr, btCollisionShape.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCollisionObjectWrapper_m_shape_get(swigCPtr);
      btCollisionShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionShape(cPtr, false);
      return ret;
    } 
  }

  public btCollisionObject m_collisionObject {
    set {
      BulletPINVOKE.btCollisionObjectWrapper_m_collisionObject_set(swigCPtr, btCollisionObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCollisionObjectWrapper_m_collisionObject_get(swigCPtr);
      btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
      return ret;
    } 
  }

  public btTransform m_worldTransform {
    get {
      btTransform ret = new btTransform(BulletPINVOKE.btCollisionObjectWrapper_m_worldTransform_get(swigCPtr), false);
      return ret;
    } 
  }

  public int m_partId {
    set {
      BulletPINVOKE.btCollisionObjectWrapper_m_partId_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btCollisionObjectWrapper_m_partId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_index {
    set {
      BulletPINVOKE.btCollisionObjectWrapper_m_index_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btCollisionObjectWrapper_m_index_get(swigCPtr);
      return ret;
    } 
  }

  public btTransform getWorldTransform() {
    btTransform ret = new btTransform(BulletPINVOKE.btCollisionObjectWrapper_getWorldTransform(swigCPtr), false);
    return ret;
  }

  public btCollisionObject getCollisionObject() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionObjectWrapper_getCollisionObject(swigCPtr);
    btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
    return ret;
  }

  public btCollisionShape getCollisionShape() {
    global::System.IntPtr cPtr = BulletPINVOKE.btCollisionObjectWrapper_getCollisionShape(swigCPtr);
    btCollisionShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionShape(cPtr, false);
    return ret;
  }

}

}
