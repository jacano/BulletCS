%module Bullet

#pragma SWIG nowarn=516, 201

%ignore operator =;
%ignore operator ==;
%ignore operator !=;

%ignore operator +;
%ignore operator -;
%ignore operator *;
%ignore operator /;
%ignore operator %;

%ignore operator +=;
%ignore operator -=;
%ignore operator *=;
%ignore operator /=;
%ignore operator %=;

%ignore operator [];
%ignore operator ();
%ignore operator new[];
%ignore operator delete[];
%ignore operator new;
%ignore operator delete;

%include "arrays_csharp.i"
%include "swigtype_inout.i"
%include "typemaps.i"
%include "wchar.i"

%ignore CProfileIterator;

%ignore btMultiSapBroadphase::quicksort (btBroadphasePairArray& a, int lo, int hi);

%ignore btSequentialImpulseConstraintSolver::getSSE2ConstraintRowSolverGeneric();
%ignore btSequentialImpulseConstraintSolver::getSSE2ConstraintRowSolverLowerLimit();

%ignore btSequentialImpulseConstraintSolver::getSSE4_1ConstraintRowSolverGeneric();
%ignore btSequentialImpulseConstraintSolver::getSSE4_1ConstraintRowSolverLowerLimit();


%ignore btAxisSweep3Internal<unsigned short>::processAllOverlappingPairs;
%ignore btAxisSweep3Internal<unsigned int>::processAllOverlappingPairs;
%ignore btAxisSweep3;
%ignore bt32BitAxisSweep3;
	
%ignore btBvhTriangleMeshShape::btBvhTriangleMeshShape(btStridingMeshInterface* meshInterface, bool useQuantizedAabbCompression, bool buildBvh = true);
%ignore btBvhTriangleMeshShape::btBvhTriangleMeshShape(btStridingMeshInterface* meshInterface, bool useQuantizedAabbCompression,const btVector3& bvhAabbMin,const btVector3& bvhAabbMax, bool buildBvh = true);

%ignore btCollisionObjectWrapper::getWorldTransform;
%ignore btCollisionObjectWrapper::getCollisionObject;

%ignore btCollisionWorld::ClosestRayResultCallback::m_rayFromWorld;
%ignore btCollisionWorld::ClosestRayResultCallback::m_rayToWorld;
%ignore btCollisionWorld::ClosestRayResultCallback::m_hitNormalWorld;
%ignore btCollisionWorld::ClosestRayResultCallback::m_hitPointWorld;
%ignore btCollisionWorld::AllHitsRayResultCallback::m_rayFromWorld;
%ignore btCollisionWorld::AllHitsRayResultCallback::m_rayToWorld;
%ignore btCollisionWorld::LocalConvexResult::m_hitNormalLocal;
%ignore btCollisionWorld::LocalConvexResult::m_hitPointLocal;
%ignore btCollisionWorld::ClosestConvexResultCallback::m_rayFromWorld;
%ignore btCollisionWorld::ClosestConvexResultCallback::m_rayToWorld;
%ignore btCollisionWorld::ClosestConvexResultCallback::m_hitNormalWorld;
%ignore btCollisionWorld::ClosestConvexResultCallback::m_hitPointWorld;

%ignore btCompoundShape::getChildShape;

%ignore btHeightfieldTerrainShape::btHeightfieldTerrainShape(int heightStickWidth,int heightStickLength, const void* heightfieldData, btScalar heightScale, btScalar minHeight, btScalar maxHeight, int upAxis, PHY_ScalarType heightDataType, bool flipQuadEdges);
%ignore btHeightfieldTerrainShape::btHeightfieldTerrainShape(int heightStickWidth,int heightStickLength,const void* heightfieldData, btScalar maxHeight,int upAxis,bool useFloatData,bool flipQuadEdges);

%ignore btManifoldPoint::m_localPointA;
%ignore btManifoldPoint::m_localPointB;
%ignore btManifoldPoint::m_positionWorldOnA;
%ignore btManifoldPoint::m_positionWorldOnB;
%ignore btManifoldPoint::m_normalWorldOnB;
%ignore btManifoldPoint::m_lateralFrictionDir1;
%ignore btManifoldPoint::m_lateralFrictionDir2;
%ignore btManifoldPoint::getPositionWorldOnA() const;
%ignore btManifoldPoint::getPositionWorldOnB() const;

%ignore btTriangleIndexVertexArray::btTriangleIndexVertexArray(int numTriangles,int* triangleIndexBase,int triangleIndexStride,int numVertices,btScalar* vertexBase,int vertexStride);
%ignore btTriangleIndexVertexArray::getIndexedMeshArray();

%ignore btManifoldPoint::getLifeTime;
%ignore btManifoldPoint::getAppliedImpulse;
%ignore btVoronoiSimplexSolver::setEqualVertexThreshold;
%ignore btVoronoiSimplexSolver::getEqualVertexThreshold;
%ignore btMultiSapBroadphase::btMultiSapProxy::m_bridgeProxies;

%ignore btHashString::getHash;
%ignore btTypedObject::getObjectType;

%ignore btClock;

/*
%ignore btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo(btScalar mass, btMotionState* motionState, btCollisionShape* collisionShape);
%ignore btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo(btScalar mass, btMotionState* motionState, btCollisionShape* collisionShape, const btVector3& localInertia);
%ignore btRigidBody::upcast(const btCollisionObject*);
%ignore btRigidBody::upcast(btCollisionObject*);
%ignore btRigidBody::btRigidBody(const btRigidBodyConstructionInfo& constructionInfo);
%ignore btRigidBody::btRigidBody(btScalar mass, btMotionState* motionState, btCollisionShape* collisionShape, const btVector3& localInertia=btVector3(0,0,0));
%ignore btRigidBody::getCollisionShape;
*/

%ignore CProfileManager;
%ignore CProfileNode;

%ignore btSolverBody::getWorldTransform;
%ignore btSolverBody::setWorldTransform;
%ignore btSolverBody::getDeltaLinearVelocity;
%ignore btSolverBody::getDeltaAngularVelocity;
%ignore btSolverBody::getPushVelocity;
%ignore btSolverBody::getTurnVelocity;

%ignore btHashString::getHash;
%ignore btTypedObject::getObjectType;
%ignore btInfMaskConverter;
%ignore btInfinityMask;
%ignore btGetInfinityMask();



%{
#include "btBulletCollisionCommon.h"
#include "btBulletDynamicsCommon.h"
%}

%include "Bullet/btBulletCollisionCommon.h"
%include "Bullet/btBulletDynamicsCommon.h"

