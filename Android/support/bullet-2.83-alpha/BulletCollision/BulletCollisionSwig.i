%module BulletCollision

%{
	///Bullet's btCollisionWorld and btCollisionObject definitions
	#include "CollisionDispatch/btCollisionWorld.h"
	#include "CollisionDispatch/btCollisionObject.h"

	///Collision Shapes
	#include "CollisionShapes/btBoxShape.h"
	#include "CollisionShapes/btSphereShape.h"
	#include "CollisionShapes/btCapsuleShape.h"
	#include "CollisionShapes/btCylinderShape.h"
	#include "CollisionShapes/btConeShape.h"
	#include "CollisionShapes/btConvexPolyhedron.h"
	#include "CollisionShapes/btStaticPlaneShape.h"
	#include "CollisionShapes/btConvexHullShape.h"
	#include "CollisionShapes/btTriangleMesh.h"
	#include "CollisionShapes/btConvexTriangleMeshShape.h"
	#include "CollisionShapes/btBvhTriangleMeshShape.h"
	#include "CollisionShapes/btScaledBvhTriangleMeshShape.h"
	#include "CollisionShapes/btTriangleMeshShape.h"
	#include "CollisionShapes/btTriangleIndexVertexArray.h"
	#include "CollisionShapes/btCompoundShape.h"
	#include "CollisionShapes/btTetrahedronShape.h"
	#include "CollisionShapes/btEmptyShape.h"
	#include "CollisionShapes/btMultiSphereShape.h"
	#include "CollisionShapes/btUniformScalingShape.h"
	#include "CollisionShapes/btPolyhedralConvexShape.h"

	///Narrowphase Collision Detector
	#include "CollisionDispatch/btSphereSphereCollisionAlgorithm.h"

	//#include "CollisionDispatch/btSphereBoxCollisionAlgorithm.h"
	#include "CollisionDispatch/btDefaultCollisionConfiguration.h"

	///Dispatching and generation of collision pairs (broadphase)
	#include "CollisionDispatch/btCollisionDispatcher.h"
	#include "BroadphaseCollision/btSimpleBroadphase.h"
	#include "BroadphaseCollision/btAxisSweep3.h"
	#include "BroadphaseCollision/btDbvtBroadphase.h"
	#include "NarrowPhaseCollision/btVoronoiSimplexSolver.h"
 
%}

    %include "arrays_csharp.i"

    #define _WIN32
	%import "../LinearMath/btScalar.h"
	%import "../LinearMath/btAlignedObjectArray.h"
    ///Bullet's btCollisionWorld and btCollisionObject definitions
	%include "CollisionDispatch/btCollisionWorld.h"
	%include "CollisionDispatch/btCollisionObject.h"

	///Collision Shapes
	%include "CollisionShapes/btBoxShape.h"
	%include "CollisionShapes/btSphereShape.h"
	%include "CollisionShapes/btCapsuleShape.h"
	%include "CollisionShapes/btCylinderShape.h"
	%include "CollisionShapes/btConeShape.h"
	%include "CollisionShapes/btStaticPlaneShape.h"
    %include "CollisionShapes/btConvexPolyhedron.h"

	%apply float INPUT[]  { const btScalar* points }
	%include "CollisionShapes/btConvexHullShape.h"
	%clear const btScalar* points;

	%include "CollisionShapes/btTriangleMesh.h"
	%include "CollisionShapes/btConvexTriangleMeshShape.h"
	%include "CollisionShapes/btBvhTriangleMeshShape.h"
	%include "CollisionShapes/btScaledBvhTriangleMeshShape.h"
	%include "CollisionShapes/btTriangleMeshShape.h"

	%apply int INPUT[]  { int* triangleIndexBase }
	%apply float INPUT[]  { btScalar* vertexBase }
	%include "CollisionShapes/btTriangleIndexVertexArray.h"
	%clear int* triangleIndexBase;
	%clear btScalar* vertexBase;

	%include "CollisionShapes/btCompoundShape.h"
	%include "CollisionShapes/btTetrahedronShape.h"
	%include "CollisionShapes/btEmptyShape.h"
	%include "CollisionShapes/btMultiSphereShape.h"
	%include "CollisionShapes/btUniformScalingShape.h"
	%include "CollisionShapes/btPolyhedralConvexShape.h"

	///Narrowphase Collision Detector
	%include "CollisionDispatch/btSphereSphereCollisionAlgorithm.h"

	//%include "CollisionDispatch/btSphereBoxCollisionAlgorithm.h"
	%include "CollisionDispatch/btDefaultCollisionConfiguration.h"

	///Dispatching and generation of collision pairs (broadphase)
	%include "CollisionDispatch/btCollisionDispatcher.h"
	%include "BroadphaseCollision/btSimpleBroadphase.h"
	%include "BroadphaseCollision/btAxisSweep3.h"
	%include "BroadphaseCollision/btDbvtBroadphase.h"

	%include "NarrowPhaseCollision/btVoronoiSimplexSolver.h"
	
	// template inst
	%template(btAlignedObjectArrayInt) btAlignedObjectArray<int>;
	%template(btAlignedObjectArraybtFace) btAlignedObjectArray<btFace>;
	%template(btAlignedObjectArrayVector3) btAlignedObjectArray<btVector3>;