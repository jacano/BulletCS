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

public class btHashString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btHashString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btHashString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btHashString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletPINVOKE.delete_btHashString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string m_string {
    set {
      BulletPINVOKE.btHashString_m_string_set(swigCPtr, value);
    } 
    get {
      string ret = BulletPINVOKE.btHashString_m_string_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_hash {
    set {
      BulletPINVOKE.btHashString_m_hash_set(swigCPtr, value);
    } 
    get {
      uint ret = BulletPINVOKE.btHashString_m_hash_get(swigCPtr);
      return ret;
    } 
  }

  public uint getHash() {
    uint ret = BulletPINVOKE.btHashString_getHash(swigCPtr);
    return ret;
  }

  public btHashString(string name) : this(BulletPINVOKE.new_btHashString(name), true) {
  }

  public int portableStringCompare(string src, string dst) {
    int ret = BulletPINVOKE.btHashString_portableStringCompare(swigCPtr, src, dst);
    return ret;
  }

  public bool equals(btHashString other) {
    bool ret = BulletPINVOKE.btHashString_equals(swigCPtr, btHashString.getCPtr(other));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
