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

public class btCompoundShapeChild : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCompoundShapeChild(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btCompoundShapeChild obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCompoundShapeChild() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btCompoundShapeChild(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public btTransform m_transform {
    set {
      BulletPINVOKE.btCompoundShapeChild_m_transform_set(swigCPtr, btTransform.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCompoundShapeChild_m_transform_get(swigCPtr);
      btTransform ret = (cPtr == global::System.IntPtr.Zero) ? null : new btTransform(cPtr, false);
      return ret;
    } 
  }

  public btCollisionShape m_childShape {
    set {
      BulletPINVOKE.btCompoundShapeChild_m_childShape_set(swigCPtr, btCollisionShape.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCompoundShapeChild_m_childShape_get(swigCPtr);
      btCollisionShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionShape(cPtr, false);
      return ret;
    } 
  }

  public int m_childShapeType {
    set {
      BulletPINVOKE.btCompoundShapeChild_m_childShapeType_set(swigCPtr, value);
    } 
    get {
      int ret = BulletPINVOKE.btCompoundShapeChild_m_childShapeType_get(swigCPtr);
      return ret;
    } 
  }

  public float m_childMargin {
    set {
      BulletPINVOKE.btCompoundShapeChild_m_childMargin_set(swigCPtr, value);
    } 
    get {
      float ret = BulletPINVOKE.btCompoundShapeChild_m_childMargin_get(swigCPtr);
      return ret;
    } 
  }

  public btDbvtNode m_node {
    set {
      BulletPINVOKE.btCompoundShapeChild_m_node_set(swigCPtr, btDbvtNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.btCompoundShapeChild_m_node_get(swigCPtr);
      btDbvtNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new btDbvtNode(cPtr, false);
      return ret;
    } 
  }

  public btCompoundShapeChild() : this(BulletPINVOKE.new_btCompoundShapeChild(), true) {
  }

}

}
