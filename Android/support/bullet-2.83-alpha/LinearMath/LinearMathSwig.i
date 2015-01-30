
%module(directors="1") LinearMath

%{
   #include	"btScalar.h"
   #include "btAabbUtil2.h"
   #include	"btAlignedAllocator.h"
   #include	"btAlignedObjectArray.h"
   #include "btConvexHull.h"
   #include	"btConvexHullComputer.h"
   #include	"btDefaultMotionState.h"
   #include	"btGeometryUtil.h"
   #include	"btGrahamScan2dConvexHull.h"
   #include	"btHashMap.h"
   #include	"btIDebugDraw.h"
   #include	"btList.h"
   #include	"btMatrix3x3.h"
   #include	"btMinMax.h"
   #include	"btMotionState.h"
   #include	"btPolarDecomposition.h"
   #include	"btPoolAllocator.h"
   #include	"btQuadWord.h"
   #include	"btQuaternion.h"
   #include	"btQuickprof.h"
   #include	"btRandom.h"

   #include	"btSerializer.h"
   #include	"btStackAlloc.h"
   #include	"btTransform.h"
   #include	"btTransformUtil.h"
   #include	"btVector3.h"
%}

#define _WIN32

%include	"btScalar.h"
%include    "btAabbUtil2.h"
%include	"btAlignedAllocator.h"
%include	"btAlignedObjectArray.h"
%include    "btConvexHull.h"
%include	"btConvexHullComputer.h"
%include	"btDefaultMotionState.h"
%include	"btGeometryUtil.h"
%include	"btGrahamScan2dConvexHull.h"
%include	"btHashMap.h"

%feature("director") btIDebugDraw;
%include	"btIDebugDraw.h"

%include	"btList.h"
%include	"btMatrix3x3.h"
%include	"btMinMax.h"
%include	"btMotionState.h"
%include	"btPolarDecomposition.h"
%include	"btPoolAllocator.h"
%include	"btQuadWord.h"
%include	"btQuaternion.h"
%include	"btQuickprof.h"
%include	"btRandom.h"
%include	"btSerializer.h"
%include	"btStackAlloc.h"
%include	"btTransform.h"
%include	"btTransformUtil.h"
%include	"btVector3.h"
