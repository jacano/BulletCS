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

public class btOptimizedBvh : btQuantizedBvh {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btOptimizedBvh(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BulletPINVOKE.btOptimizedBvh_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btOptimizedBvh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btOptimizedBvh() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btOptimizedBvh(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public btOptimizedBvh() : this(BulletPINVOKE.new_btOptimizedBvh(), true) {
  }

  public void build(btStridingMeshInterface triangles, bool useQuantizedAabbCompression, btVector3 bvhAabbMin, btVector3 bvhAabbMax) {
    BulletPINVOKE.btOptimizedBvh_build(swigCPtr, btStridingMeshInterface.getCPtr(triangles), useQuantizedAabbCompression, btVector3.getCPtr(bvhAabbMin), btVector3.getCPtr(bvhAabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void refit(btStridingMeshInterface triangles, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btOptimizedBvh_refit(swigCPtr, btStridingMeshInterface.getCPtr(triangles), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void refitPartial(btStridingMeshInterface triangles, btVector3 aabbMin, btVector3 aabbMax) {
    BulletPINVOKE.btOptimizedBvh_refitPartial(swigCPtr, btStridingMeshInterface.getCPtr(triangles), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updateBvhNodes(btStridingMeshInterface meshInterface, int firstNode, int endNode, int index) {
    BulletPINVOKE.btOptimizedBvh_updateBvhNodes(swigCPtr, btStridingMeshInterface.getCPtr(meshInterface), firstNode, endNode, index);
  }

  public virtual bool serializeInPlace(SWIGTYPE_p_void o_alignedDataBuffer, uint i_dataBufferSize, bool i_swapEndian) {
    bool ret = BulletPINVOKE.btOptimizedBvh_serializeInPlace(swigCPtr, SWIGTYPE_p_void.getCPtr(o_alignedDataBuffer), i_dataBufferSize, i_swapEndian);
    return ret;
  }

  public new static btOptimizedBvh deSerializeInPlace(SWIGTYPE_p_void i_alignedDataBuffer, uint i_dataBufferSize, bool i_swapEndian) {
    global::System.IntPtr cPtr = BulletPINVOKE.btOptimizedBvh_deSerializeInPlace(SWIGTYPE_p_void.getCPtr(i_alignedDataBuffer), i_dataBufferSize, i_swapEndian);
    btOptimizedBvh ret = (cPtr == global::System.IntPtr.Zero) ? null : new btOptimizedBvh(cPtr, false);
    return ret;
  }

}

}
