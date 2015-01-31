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
%include "std_auto_ptr.i"
%include "std_common.i"
%include "std_deque.i"
%include "std_except.i"
%include "std_map.i"
%include "std_pair.i"
%include "std_shared_ptr.i"
%include "std_string.i"
%include "std_vector.i"
%include "std_wstring.i"
%include "stl.i"
%include "swigtype_inout.i"
%include "typemaps.i"
%include "wchar.i"

%ignore CProfileIterator;

%ignore btMultiSapBroadphase::quicksort (btBroadphasePairArray& a, int lo, int hi);

%ignore btSequentialImpulseConstraintSolver::getSSE2ConstraintRowSolverGeneric();
%ignore btSequentialImpulseConstraintSolver::getSSE2ConstraintRowSolverLowerLimit();

%ignore btSequentialImpulseConstraintSolver::getSSE4_1ConstraintRowSolverGeneric();
%ignore btSequentialImpulseConstraintSolver::getSSE4_1ConstraintRowSolverLowerLimit();

//%ignore btAlignedObjectArray<btBridgeProxy*> m_bridgeProxies;

%{
	#include "btBulletCollisionCommon.h"
	#include "btBulletDynamicsCommon.h"
%}

%include "btBulletCollisionCommon.h"
%include "btBulletDynamicsCommon.h"

