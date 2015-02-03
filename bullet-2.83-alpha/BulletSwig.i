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

%ignore m_bridgeProxies;

%{
#include "btBulletCollisionCommon.h"
#include "btBulletDynamicsCommon.h"
%}

%include "btBulletCollisionCommon.h"
%include "btBulletDynamicsCommon.h"

