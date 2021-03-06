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

public class Bullet {
  public static int btGetVersion() {
    int ret = BulletPINVOKE.btGetVersion();
    return ret;
  }

  public static float btSqrt(float y) {
    float ret = BulletPINVOKE.btSqrt(y);
    return ret;
  }

  public static float btFabs(float x) {
    float ret = BulletPINVOKE.btFabs(x);
    return ret;
  }

  public static float btCos(float x) {
    float ret = BulletPINVOKE.btCos(x);
    return ret;
  }

  public static float btSin(float x) {
    float ret = BulletPINVOKE.btSin(x);
    return ret;
  }

  public static float btTan(float x) {
    float ret = BulletPINVOKE.btTan(x);
    return ret;
  }

  public static float btAcos(float x) {
    float ret = BulletPINVOKE.btAcos(x);
    return ret;
  }

  public static float btAsin(float x) {
    float ret = BulletPINVOKE.btAsin(x);
    return ret;
  }

  public static float btAtan(float x) {
    float ret = BulletPINVOKE.btAtan(x);
    return ret;
  }

  public static float btAtan2(float x, float y) {
    float ret = BulletPINVOKE.btAtan2(x, y);
    return ret;
  }

  public static float btExp(float x) {
    float ret = BulletPINVOKE.btExp(x);
    return ret;
  }

  public static float btLog(float x) {
    float ret = BulletPINVOKE.btLog(x);
    return ret;
  }

  public static float btPow(float x, float y) {
    float ret = BulletPINVOKE.btPow(x, y);
    return ret;
  }

  public static float btFmod(float x, float y) {
    float ret = BulletPINVOKE.btFmod(x, y);
    return ret;
  }

  public static float btAtan2Fast(float y, float x) {
    float ret = BulletPINVOKE.btAtan2Fast(y, x);
    return ret;
  }

  public static bool btFuzzyZero(float x) {
    bool ret = BulletPINVOKE.btFuzzyZero(x);
    return ret;
  }

  public static bool btEqual(float a, float eps) {
    bool ret = BulletPINVOKE.btEqual(a, eps);
    return ret;
  }

  public static bool btGreaterEqual(float a, float eps) {
    bool ret = BulletPINVOKE.btGreaterEqual(a, eps);
    return ret;
  }

  public static int btIsNegative(float x) {
    int ret = BulletPINVOKE.btIsNegative(x);
    return ret;
  }

  public static float btRadians(float x) {
    float ret = BulletPINVOKE.btRadians(x);
    return ret;
  }

  public static float btDegrees(float x) {
    float ret = BulletPINVOKE.btDegrees(x);
    return ret;
  }

  public static float btFsel(float a, float b, float c) {
    float ret = BulletPINVOKE.btFsel(a, b, c);
    return ret;
  }

  public static bool btMachineIsLittleEndian() {
    bool ret = BulletPINVOKE.btMachineIsLittleEndian();
    return ret;
  }

  public static uint btSelect(uint condition, uint valueIfConditionNonZero, uint valueIfConditionZero) {
    uint ret = BulletPINVOKE.btSelect__SWIG_0(condition, valueIfConditionNonZero, valueIfConditionZero);
    return ret;
  }

  public static int btSelect(uint condition, int valueIfConditionNonZero, int valueIfConditionZero) {
    int ret = BulletPINVOKE.btSelect__SWIG_1(condition, valueIfConditionNonZero, valueIfConditionZero);
    return ret;
  }

  public static float btSelect(uint condition, float valueIfConditionNonZero, float valueIfConditionZero) {
    float ret = BulletPINVOKE.btSelect__SWIG_2(condition, valueIfConditionNonZero, valueIfConditionZero);
    return ret;
  }

  public static uint btSwapEndian(uint val) {
    uint ret = BulletPINVOKE.btSwapEndian__SWIG_0(val);
    return ret;
  }

  public static ushort btSwapEndian(ushort val) {
    ushort ret = BulletPINVOKE.btSwapEndian__SWIG_1(val);
    return ret;
  }

  public static uint btSwapEndian(int val) {
    uint ret = BulletPINVOKE.btSwapEndian__SWIG_2(val);
    return ret;
  }

  public static ushort btSwapEndian(short val) {
    ushort ret = BulletPINVOKE.btSwapEndian__SWIG_3(val);
    return ret;
  }

  public static uint btSwapEndianFloat(float d) {
    uint ret = BulletPINVOKE.btSwapEndianFloat(d);
    return ret;
  }

  public static float btUnswapEndianFloat(uint a) {
    float ret = BulletPINVOKE.btUnswapEndianFloat(a);
    return ret;
  }

  public static void btSwapEndianDouble(double d, SWIGTYPE_p_unsigned_char dst) {
    BulletPINVOKE.btSwapEndianDouble(d, SWIGTYPE_p_unsigned_char.getCPtr(dst));
  }

  public static double btUnswapEndianDouble(SWIGTYPE_p_unsigned_char src) {
    double ret = BulletPINVOKE.btUnswapEndianDouble(SWIGTYPE_p_unsigned_char.getCPtr(src));
    return ret;
  }

  public static float btLargeDot(SWIGTYPE_p_float a, SWIGTYPE_p_float b, int n) {
    float ret = BulletPINVOKE.btLargeDot(SWIGTYPE_p_float.getCPtr(a), SWIGTYPE_p_float.getCPtr(b), n);
    return ret;
  }

  public static float btNormalizeAngle(float angleInRadians) {
    float ret = BulletPINVOKE.btNormalizeAngle(angleInRadians);
    return ret;
  }

  public static SWIGTYPE_p_void btAlignedAllocInternal(uint size, int alignment) {
    global::System.IntPtr cPtr = BulletPINVOKE.btAlignedAllocInternal(size, alignment);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public static void btAlignedFreeInternal(SWIGTYPE_p_void ptr) {
    BulletPINVOKE.btAlignedFreeInternal(SWIGTYPE_p_void.getCPtr(ptr));
  }

  public static void btAlignedAllocSetCustom(SWIGTYPE_p_f_size_t__p_void allocFunc, SWIGTYPE_p_f_p_void__void freeFunc) {
    BulletPINVOKE.btAlignedAllocSetCustom(SWIGTYPE_p_f_size_t__p_void.getCPtr(allocFunc), SWIGTYPE_p_f_p_void__void.getCPtr(freeFunc));
  }

  public static void btAlignedAllocSetCustomAligned(SWIGTYPE_p_f_size_t_int__p_void allocFunc, SWIGTYPE_p_f_p_void__void freeFunc) {
    BulletPINVOKE.btAlignedAllocSetCustomAligned(SWIGTYPE_p_f_size_t_int__p_void.getCPtr(allocFunc), SWIGTYPE_p_f_p_void__void.getCPtr(freeFunc));
  }

  public static float btDot(btVector3 v1, btVector3 v2) {
    float ret = BulletPINVOKE.btDot(btVector3.getCPtr(v1), btVector3.getCPtr(v2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float btDistance2(btVector3 v1, btVector3 v2) {
    float ret = BulletPINVOKE.btDistance2(btVector3.getCPtr(v1), btVector3.getCPtr(v2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float btDistance(btVector3 v1, btVector3 v2) {
    float ret = BulletPINVOKE.btDistance(btVector3.getCPtr(v1), btVector3.getCPtr(v2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float btAngle(btVector3 v1, btVector3 v2) {
    float ret = BulletPINVOKE.btAngle__SWIG_0(btVector3.getCPtr(v1), btVector3.getCPtr(v2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btVector3 btCross(btVector3 v1, btVector3 v2) {
    btVector3 ret = new btVector3(BulletPINVOKE.btCross(btVector3.getCPtr(v1), btVector3.getCPtr(v2)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float btTriple(btVector3 v1, btVector3 v2, btVector3 v3) {
    float ret = BulletPINVOKE.btTriple(btVector3.getCPtr(v1), btVector3.getCPtr(v2), btVector3.getCPtr(v3));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btVector3 lerp(btVector3 v1, btVector3 v2, float t) {
    btVector3 ret = new btVector3(BulletPINVOKE.lerp(btVector3.getCPtr(v1), btVector3.getCPtr(v2), t), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void btSwapScalarEndian(float sourceVal, SWIGTYPE_p_float destVal) {
    BulletPINVOKE.btSwapScalarEndian(sourceVal, SWIGTYPE_p_float.getCPtr(destVal));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void btSwapVector3Endian(btVector3 sourceVec, btVector3 destVec) {
    BulletPINVOKE.btSwapVector3Endian(btVector3.getCPtr(sourceVec), btVector3.getCPtr(destVec));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void btUnSwapVector3Endian(btVector3 vector) {
    BulletPINVOKE.btUnSwapVector3Endian(btVector3.getCPtr(vector));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static float dot(btQuaternion q1, btQuaternion q2) {
    float ret = BulletPINVOKE.dot(btQuaternion.getCPtr(q1), btQuaternion.getCPtr(q2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float length(btQuaternion q) {
    float ret = BulletPINVOKE.length(btQuaternion.getCPtr(q));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float btAngle(btQuaternion q1, btQuaternion q2) {
    float ret = BulletPINVOKE.btAngle__SWIG_1(btQuaternion.getCPtr(q1), btQuaternion.getCPtr(q2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btQuaternion inverse(btQuaternion q) {
    btQuaternion ret = new btQuaternion(BulletPINVOKE.inverse(btQuaternion.getCPtr(q)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btQuaternion slerp(btQuaternion q1, btQuaternion q2, float t) {
    btQuaternion ret = new btQuaternion(BulletPINVOKE.slerp(btQuaternion.getCPtr(q1), btQuaternion.getCPtr(q2), t), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btVector3 quatRotate(btQuaternion rotation, btVector3 v) {
    btVector3 ret = new btVector3(BulletPINVOKE.quatRotate(btQuaternion.getCPtr(rotation), btVector3.getCPtr(v)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btQuaternion shortestArcQuat(btVector3 v0, btVector3 v1) {
    btQuaternion ret = new btQuaternion(BulletPINVOKE.shortestArcQuat(btVector3.getCPtr(v0), btVector3.getCPtr(v1)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btQuaternion shortestArcQuatNormalize2(btVector3 v0, btVector3 v1) {
    btQuaternion ret = new btQuaternion(BulletPINVOKE.shortestArcQuatNormalize2(btVector3.getCPtr(v0), btVector3.getCPtr(v1)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btVector3 btAabbSupport(btVector3 halfExtents, btVector3 supportDir) {
    btVector3 ret = new btVector3(BulletPINVOKE.btAabbSupport(btVector3.getCPtr(halfExtents), btVector3.getCPtr(supportDir)), true);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float gContactBreakingThreshold {
    set {
      BulletPINVOKE.gContactBreakingThreshold_set(value);
    } 
    get {
      float ret = BulletPINVOKE.gContactBreakingThreshold_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_f_p_void__bool gContactDestroyedCallback {
    set {
      BulletPINVOKE.gContactDestroyedCallback_set(SWIGTYPE_p_f_p_void__bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.gContactDestroyedCallback_get();
      SWIGTYPE_p_f_p_void__bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void__bool(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_f_r_btManifoldPoint_p_void_p_void__bool gContactProcessedCallback {
    set {
      BulletPINVOKE.gContactProcessedCallback_set(SWIGTYPE_p_f_r_btManifoldPoint_p_void_p_void__bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.gContactProcessedCallback_get();
      SWIGTYPE_p_f_r_btManifoldPoint_p_void_p_void__bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_r_btManifoldPoint_p_void_p_void__bool(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_f_r_btManifoldPoint_p_q_const__btCollisionObjectWrapper_int_int_p_q_const__btCollisionObjectWrapper_int_int__bool gContactAddedCallback {
    set {
      BulletPINVOKE.gContactAddedCallback_set(SWIGTYPE_p_f_r_btManifoldPoint_p_q_const__btCollisionObjectWrapper_int_int_p_q_const__btCollisionObjectWrapper_int_int__bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = BulletPINVOKE.gContactAddedCallback_get();
      SWIGTYPE_p_f_r_btManifoldPoint_p_q_const__btCollisionObjectWrapper_int_int_p_q_const__btCollisionObjectWrapper_int_int__bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_r_btManifoldPoint_p_q_const__btCollisionObjectWrapper_int_int_p_q_const__btCollisionObjectWrapper_int_int__bool(cPtr, false);
      return ret;
    } 
  }

  public static int gRemovePairs {
    set {
      BulletPINVOKE.gRemovePairs_set(value);
    } 
    get {
      int ret = BulletPINVOKE.gRemovePairs_get();
      return ret;
    } 
  }

  public static int gAddedPairs {
    set {
      BulletPINVOKE.gAddedPairs_set(value);
    } 
    get {
      int ret = BulletPINVOKE.gAddedPairs_get();
      return ret;
    } 
  }

  public static int gFindPairs {
    set {
      BulletPINVOKE.gFindPairs_set(value);
    } 
    get {
      int ret = BulletPINVOKE.gFindPairs_get();
      return ret;
    } 
  }

  public static int BT_NULL_PAIR {
    get {
      int ret = BulletPINVOKE.BT_NULL_PAIR_get();
      return ret;
    } 
  }

  public static void AabbExpand(btVector3 aabbMin, btVector3 aabbMax, btVector3 expansionMin, btVector3 expansionMax) {
    BulletPINVOKE.AabbExpand(btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), btVector3.getCPtr(expansionMin), btVector3.getCPtr(expansionMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool TestPointAgainstAabb2(btVector3 aabbMin1, btVector3 aabbMax1, btVector3 point) {
    bool ret = BulletPINVOKE.TestPointAgainstAabb2(btVector3.getCPtr(aabbMin1), btVector3.getCPtr(aabbMax1), btVector3.getCPtr(point));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool TestAabbAgainstAabb2(btVector3 aabbMin1, btVector3 aabbMax1, btVector3 aabbMin2, btVector3 aabbMax2) {
    bool ret = BulletPINVOKE.TestAabbAgainstAabb2(btVector3.getCPtr(aabbMin1), btVector3.getCPtr(aabbMax1), btVector3.getCPtr(aabbMin2), btVector3.getCPtr(aabbMax2));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool TestTriangleAgainstAabb2(btVector3 vertices, btVector3 aabbMin, btVector3 aabbMax) {
    bool ret = BulletPINVOKE.TestTriangleAgainstAabb2(btVector3.getCPtr(vertices), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int btOutcode(btVector3 p, btVector3 halfExtent) {
    int ret = BulletPINVOKE.btOutcode(btVector3.getCPtr(p), btVector3.getCPtr(halfExtent));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool btRayAabb2(btVector3 rayFrom, btVector3 rayInvDirection, SWIGTYPE_p_unsigned_int raySign, btVector3 bounds, SWIGTYPE_p_float tmin, float lambda_min, float lambda_max) {
    bool ret = BulletPINVOKE.btRayAabb2(btVector3.getCPtr(rayFrom), btVector3.getCPtr(rayInvDirection), SWIGTYPE_p_unsigned_int.getCPtr(raySign), btVector3.getCPtr(bounds), SWIGTYPE_p_float.getCPtr(tmin), lambda_min, lambda_max);
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool btRayAabb(btVector3 rayFrom, btVector3 rayTo, btVector3 aabbMin, btVector3 aabbMax, SWIGTYPE_p_float param, btVector3 normal) {
    bool ret = BulletPINVOKE.btRayAabb(btVector3.getCPtr(rayFrom), btVector3.getCPtr(rayTo), btVector3.getCPtr(aabbMin), btVector3.getCPtr(aabbMax), SWIGTYPE_p_float.getCPtr(param), btVector3.getCPtr(normal));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void btTransformAabb(btVector3 halfExtents, float margin, btTransform t, btVector3 aabbMinOut, btVector3 aabbMaxOut) {
    BulletPINVOKE.btTransformAabb__SWIG_0(btVector3.getCPtr(halfExtents), margin, btTransform.getCPtr(t), btVector3.getCPtr(aabbMinOut), btVector3.getCPtr(aabbMaxOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void btTransformAabb(btVector3 localAabbMin, btVector3 localAabbMax, float margin, btTransform trans, btVector3 aabbMinOut, btVector3 aabbMaxOut) {
    BulletPINVOKE.btTransformAabb__SWIG_1(btVector3.getCPtr(localAabbMin), btVector3.getCPtr(localAabbMax), margin, btTransform.getCPtr(trans), btVector3.getCPtr(aabbMinOut), btVector3.getCPtr(aabbMaxOut));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static uint testQuantizedAabbAgainstQuantizedAabb(SWIGTYPE_p_unsigned_short aabbMin1, SWIGTYPE_p_unsigned_short aabbMax1, SWIGTYPE_p_unsigned_short aabbMin2, SWIGTYPE_p_unsigned_short aabbMax2) {
    uint ret = BulletPINVOKE.testQuantizedAabbAgainstQuantizedAabb(SWIGTYPE_p_unsigned_short.getCPtr(aabbMin1), SWIGTYPE_p_unsigned_short.getCPtr(aabbMax1), SWIGTYPE_p_unsigned_short.getCPtr(aabbMin2), SWIGTYPE_p_unsigned_short.getCPtr(aabbMax2));
    return ret;
  }

  public static int BT_HASH_NULL {
    get {
      int ret = BulletPINVOKE.BT_HASH_NULL_get();
      return ret;
    } 
  }

  public static string sBulletDNAstr {
    set {
      BulletPINVOKE.sBulletDNAstr_set(value);
    } 
    get {
      string ret = BulletPINVOKE.sBulletDNAstr_get();
      return ret;
    } 
  }

  public static int sBulletDNAlen {
    set {
      BulletPINVOKE.sBulletDNAlen_set(value);
    } 
    get {
      int ret = BulletPINVOKE.sBulletDNAlen_get();
      return ret;
    } 
  }

  public static string sBulletDNAstr64 {
    set {
      BulletPINVOKE.sBulletDNAstr64_set(value);
    } 
    get {
      string ret = BulletPINVOKE.sBulletDNAstr64_get();
      return ret;
    } 
  }

  public static int sBulletDNAlen64 {
    set {
      BulletPINVOKE.sBulletDNAlen64_set(value);
    } 
    get {
      int ret = BulletPINVOKE.sBulletDNAlen64_get();
      return ret;
    } 
  }

  public static int btStrLen(string str) {
    int ret = BulletPINVOKE.btStrLen(str);
    return ret;
  }

  public static bool Intersect(btDbvtAabbMm a, btDbvtAabbMm b) {
    bool ret = BulletPINVOKE.Intersect__SWIG_0(btDbvtAabbMm.getCPtr(a), btDbvtAabbMm.getCPtr(b));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Intersect(btDbvtAabbMm a, btVector3 b) {
    bool ret = BulletPINVOKE.Intersect__SWIG_1(btDbvtAabbMm.getCPtr(a), btVector3.getCPtr(b));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float Proximity(btDbvtAabbMm a, btDbvtAabbMm b) {
    float ret = BulletPINVOKE.Proximity(btDbvtAabbMm.getCPtr(a), btDbvtAabbMm.getCPtr(b));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int Select(btDbvtAabbMm o, btDbvtAabbMm a, btDbvtAabbMm b) {
    int ret = BulletPINVOKE.Select(btDbvtAabbMm.getCPtr(o), btDbvtAabbMm.getCPtr(a), btDbvtAabbMm.getCPtr(b));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void Merge(btDbvtAabbMm a, btDbvtAabbMm b, btDbvtAabbMm r) {
    BulletPINVOKE.Merge(btDbvtAabbMm.getCPtr(a), btDbvtAabbMm.getCPtr(b), btDbvtAabbMm.getCPtr(r));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool NotEqual(btDbvtAabbMm a, btDbvtAabbMm b) {
    bool ret = BulletPINVOKE.NotEqual(btDbvtAabbMm.getCPtr(a), btDbvtAabbMm.getCPtr(b));
    if (BulletPINVOKE.SWIGPendingException.Pending) throw BulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int gOverlappingPairs {
    set {
      BulletPINVOKE.gOverlappingPairs_set(value);
    } 
    get {
      int ret = BulletPINVOKE.gOverlappingPairs_get();
      return ret;
    } 
  }

  public static float gDeactivationTime {
    set {
      BulletPINVOKE.gDeactivationTime_set(value);
    } 
    get {
      float ret = BulletPINVOKE.gDeactivationTime_get();
      return ret;
    } 
  }

  public static bool gDisableDeactivation {
    set {
      BulletPINVOKE.gDisableDeactivation_set(value);
    } 
    get {
      bool ret = BulletPINVOKE.gDisableDeactivation_get();
      return ret;
    } 
  }

  public static float btAdjustAngleToLimits(float angleInRadians, float angleLowerLimitInRadians, float angleUpperLimitInRadians) {
    float ret = BulletPINVOKE.btAdjustAngleToLimits(angleInRadians, angleLowerLimitInRadians, angleUpperLimitInRadians);
    return ret;
  }

  public static readonly int BT_BULLET_VERSION = BulletPINVOKE.BT_BULLET_VERSION_get();
  public static readonly double BT_LARGE_FLOAT = BulletPINVOKE.BT_LARGE_FLOAT_get();
  public static readonly string btVector3DataName = BulletPINVOKE.btVector3DataName_get();
  public static readonly int ACTIVE_TAG = BulletPINVOKE.ACTIVE_TAG_get();
  public static readonly int ISLAND_SLEEPING = BulletPINVOKE.ISLAND_SLEEPING_get();
  public static readonly int WANTS_DEACTIVATION = BulletPINVOKE.WANTS_DEACTIVATION_get();
  public static readonly int DISABLE_DEACTIVATION = BulletPINVOKE.DISABLE_DEACTIVATION_get();
  public static readonly int DISABLE_SIMULATION = BulletPINVOKE.DISABLE_SIMULATION_get();
  public static readonly int BT_USE_PLACEMENT_NEW = BulletPINVOKE.BT_USE_PLACEMENT_NEW_get();
  public static readonly string btCollisionObjectDataName = BulletPINVOKE.btCollisionObjectDataName_get();
  public static readonly int MANIFOLD_CACHE_SIZE = BulletPINVOKE.MANIFOLD_CACHE_SIZE_get();
  public static readonly int USE_DISPATCH_REGISTRY_ARRAY = BulletPINVOKE.USE_DISPATCH_REGISTRY_ARRAY_get();
  public static readonly int MAX_PREFERRED_PENETRATION_DIRECTIONS = BulletPINVOKE.MAX_PREFERRED_PENETRATION_DIRECTIONS_get();
  public static readonly int USE_BANCHLESS = BulletPINVOKE.USE_BANCHLESS_get();
  public static readonly string btQuantizedBvhDataName = BulletPINVOKE.btQuantizedBvhDataName_get();
  public static readonly int MAX_SUBTREE_SIZE_IN_BYTES = BulletPINVOKE.MAX_SUBTREE_SIZE_IN_BYTES_get();
  public static readonly int MAX_NUM_PARTS_IN_BITS = BulletPINVOKE.MAX_NUM_PARTS_IN_BITS_get();
  public static readonly int BT_HEADER_LENGTH = BulletPINVOKE.BT_HEADER_LENGTH_get();
  public static readonly int TRI_INFO_V0V1_CONVEX = BulletPINVOKE.TRI_INFO_V0V1_CONVEX_get();
  public static readonly int TRI_INFO_V1V2_CONVEX = BulletPINVOKE.TRI_INFO_V1V2_CONVEX_get();
  public static readonly int TRI_INFO_V2V0_CONVEX = BulletPINVOKE.TRI_INFO_V2V0_CONVEX_get();
  public static readonly int TRI_INFO_V0V1_SWAP_NORMALB = BulletPINVOKE.TRI_INFO_V0V1_SWAP_NORMALB_get();
  public static readonly int TRI_INFO_V1V2_SWAP_NORMALB = BulletPINVOKE.TRI_INFO_V1V2_SWAP_NORMALB_get();
  public static readonly int TRI_INFO_V2V0_SWAP_NORMALB = BulletPINVOKE.TRI_INFO_V2V0_SWAP_NORMALB_get();
  public static readonly int DBVT_IMPL_GENERIC = BulletPINVOKE.DBVT_IMPL_GENERIC_get();
  public static readonly int DBVT_IMPL_SSE = BulletPINVOKE.DBVT_IMPL_SSE_get();
  public static readonly int DBVT_USE_TEMPLATE = BulletPINVOKE.DBVT_USE_TEMPLATE_get();
  public static readonly int DBVT_USE_INTRINSIC_SSE = BulletPINVOKE.DBVT_USE_INTRINSIC_SSE_get();
  public static readonly int DBVT_USE_MEMMOVE = BulletPINVOKE.DBVT_USE_MEMMOVE_get();
  public static readonly int DBVT_ENABLE_BENCHMARK = BulletPINVOKE.DBVT_ENABLE_BENCHMARK_get();
  public static readonly int DBVT_SELECT_IMPL = BulletPINVOKE.DBVT_SELECT_IMPL_get();
  public static readonly int DBVT_MERGE_IMPL = BulletPINVOKE.DBVT_MERGE_IMPL_get();
  public static readonly int DBVT_INT0_IMPL = BulletPINVOKE.DBVT_INT0_IMPL_get();
  public static readonly int DBVT_BP_PROFILE = BulletPINVOKE.DBVT_BP_PROFILE_get();
  public static readonly int DBVT_BP_PREVENTFALSEUPDATE = BulletPINVOKE.DBVT_BP_PREVENTFALSEUPDATE_get();
  public static readonly int DBVT_BP_ACCURATESLEEPING = BulletPINVOKE.DBVT_BP_ACCURATESLEEPING_get();
  public static readonly int DBVT_BP_ENABLE_BENCHMARK = BulletPINVOKE.DBVT_BP_ENABLE_BENCHMARK_get();
  public static readonly int USE_OVERLAP_TEST_ON_REMOVES = BulletPINVOKE.USE_OVERLAP_TEST_ON_REMOVES_get();
  public static readonly int BT_NO_PROFILE = BulletPINVOKE.BT_NO_PROFILE_get();
  public static readonly string btRigidBodyDataName = BulletPINVOKE.btRigidBodyDataName_get();
  public static readonly string btTypedConstraintDataName = BulletPINVOKE.btTypedConstraintDataName_get();
  public static readonly string btPoint2PointConstraintDataName = BulletPINVOKE.btPoint2PointConstraintDataName_get();
  public static readonly int _BT_USE_CENTER_LIMIT_ = BulletPINVOKE._BT_USE_CENTER_LIMIT__get();
  public static readonly string btHingeConstraintDataName = BulletPINVOKE.btHingeConstraintDataName_get();
  public static readonly string btConeTwistConstraintDataName = BulletPINVOKE.btConeTwistConstraintDataName_get();
  public static readonly string btGeneric6DofConstraintDataName = BulletPINVOKE.btGeneric6DofConstraintDataName_get();
  public static readonly int BT_6DOF_FLAGS_AXIS_SHIFT = BulletPINVOKE.BT_6DOF_FLAGS_AXIS_SHIFT_get();
  public static readonly string btSliderConstraintDataName = BulletPINVOKE.btSliderConstraintDataName_get();
  public static readonly string btGeneric6DofSpringConstraintDataName = BulletPINVOKE.btGeneric6DofSpringConstraintDataName_get();
  public static readonly string btGearConstraintDataName = BulletPINVOKE.btGearConstraintDataName_get();
}

}
