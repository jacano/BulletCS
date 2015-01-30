%module BulletDynamics

// for nest class
struct btConstraintInfo1 
{
	int m_numConstraintRows,nub;
};

struct btConstraintInfo2 
{
	// integrator parameters: frames per second (1/stepsize), default error
	// reduction parameter (0..1).
	btScalar fps,erp;

	// for the first and second body, pointers to two (linear and angular)
	// n*3 jacobian sub matrices, stored by rows. these matrices will have
	// been initialized to 0 on entry. if the second body is zero then the
	// J2xx pointers may be 0.
	btScalar *m_J1linearAxis,*m_J1angularAxis,*m_J2linearAxis,*m_J2angularAxis;

	// elements to jump from one row to the next in J's
	int rowskip;

	// right hand sides of the equation J*v = c + cfm * lambda. cfm is the
	// "constraint force mixing" vector. c is set to zero on entry, cfm is
	// set to a constant value (typically very small or zero) value on entry.
	btScalar *m_constraintError,*cfm;

	// lo and hi limits for variables (set to -/+ infinity on entry).
	btScalar *m_lowerLimit,*m_upperLimit;

	// findex vector for variables. see the LCP solver interface for a
	// description of what this does. this is set to -1 on entry.
	// note that the returned indexes are relative to the first index of
	// the constraint.
	int *findex;
	// number of solver iterations
	int m_numIterations;

	//damping of the velocity
	btScalar	m_damping;
};

struct btVehicleRaycasterResult
{
	btVehicleRaycasterResult() :m_distFraction(btScalar(-1.)){};
	btVector3	m_hitPointInWorld;
	btVector3	m_hitNormalInWorld;
	btScalar	m_distFraction;
};

struct RaycastInfo
{
	//set by raycaster
	btVector3	m_contactNormalWS;//contactnormal
	btVector3	m_contactPointWS;//raycast hitpoint
	btScalar	m_suspensionLength;
	btVector3	m_hardPointWS;//raycast starting point
	btVector3	m_wheelDirectionWS; //direction in worldspace
	btVector3	m_wheelAxleWS; // axle in worldspace
	bool		m_isInContact;
	void*		m_groundObject; //could be general void* ptr
};

struct	btRigidBodyConstructionInfo
{
	btScalar			m_mass;

	///When a motionState is provided, the rigid body will initialize its world transform from the motion state
	///In this case, m_startWorldTransform is ignored.
	btMotionState*		m_motionState;
	btTransform	m_startWorldTransform;

	btCollisionShape*	m_collisionShape;
	btVector3			m_localInertia;
	btScalar			m_linearDamping;
	btScalar			m_angularDamping;

	///best simulation results when friction is non-zero
	btScalar			m_friction;
	///best simulation results using zero restitution.
	btScalar			m_restitution;

	btScalar			m_linearSleepingThreshold;
	btScalar			m_angularSleepingThreshold;

	//Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
	//Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
	bool				m_additionalDamping;
	btScalar			m_additionalDampingFactor;
	btScalar			m_additionalLinearDampingThresholdSqr;
	btScalar			m_additionalAngularDampingThresholdSqr;
	btScalar			m_additionalAngularDampingFactor;

	btRigidBodyConstructionInfo(	btScalar mass, btMotionState* motionState, btCollisionShape* collisionShape, const btVector3& localInertia=btVector3(0,0,0)):
	m_mass(mass),
		m_motionState(motionState),
		m_collisionShape(collisionShape),
		m_localInertia(localInertia),
		m_linearDamping(btScalar(0.)),
		m_angularDamping(btScalar(0.)),
		m_friction(btScalar(0.5)),
		m_restitution(btScalar(0.)),
		m_linearSleepingThreshold(btScalar(0.8)),
		m_angularSleepingThreshold(btScalar(1.f)),
		m_additionalDamping(false),
		m_additionalDampingFactor(btScalar(0.005)),
		m_additionalLinearDampingThresholdSqr(btScalar(0.01)),
		m_additionalAngularDampingThresholdSqr(btScalar(0.01)),
		m_additionalAngularDampingFactor(btScalar(0.01))
	{
		m_startWorldTransform.setIdentity();
	}
};

	%nestedworkaround btTypedConstraint::btConstraintInfo1;
	%nestedworkaround btTypedConstraint::btConstraintInfo2;
	%nestedworkaround btVehicleRaycaster::btVehicleRaycasterResult;
	%nestedworkaround btWheelInfo::RaycastInfo;
	%nestedworkaround btRigidBody::btRigidBodyConstructionInfo;

%{
    #include "Dynamics/btDiscreteDynamicsWorld.h"

	#include "Dynamics/btSimpleDynamicsWorld.h"
	#include "Dynamics/btRigidBody.h"

	#include "ConstraintSolver/btPoint2PointConstraint.h"
	#include "ConstraintSolver/btHingeConstraint.h"
	#include "ConstraintSolver/btConeTwistConstraint.h"
	#include "ConstraintSolver/btGeneric6DofConstraint.h"
	#include "ConstraintSolver/btSliderConstraint.h"
	#include "ConstraintSolver/btGeneric6DofSpringConstraint.h"
	#include "ConstraintSolver/btUniversalConstraint.h"
	#include "ConstraintSolver/btHinge2Constraint.h"
	#include "ConstraintSolver/btGearConstraint.h"

	#include "ConstraintSolver/btSequentialImpulseConstraintSolver.h"


	///Vehicle simulation, with wheel contact simulated by raycasts
	#include "Vehicle/btRaycastVehicle.h"

%}

    #define _WIN32
	%import "../LinearMath/btScalar.h"
	#import  "../btBulletCollisionCommon.h"
    %include "Dynamics/btDiscreteDynamicsWorld.h"

	%include "Dynamics/btSimpleDynamicsWorld.h"
	%include "Dynamics/btRigidBody.h"

	%include "ConstraintSolver/btPoint2PointConstraint.h"
	%include "ConstraintSolver/btHingeConstraint.h"
	%include "ConstraintSolver/btConeTwistConstraint.h"
	%include "ConstraintSolver/btGeneric6DofConstraint.h"
	%include "ConstraintSolver/btSliderConstraint.h"
	%include "ConstraintSolver/btGeneric6DofSpringConstraint.h"
	%include "ConstraintSolver/btUniversalConstraint.h"
	%include "ConstraintSolver/btHinge2Constraint.h"
	%include "ConstraintSolver/btGearConstraint.h"

	%include "ConstraintSolver/btSequentialImpulseConstraintSolver.h"


	///Vehicle simulation, with wheel contact simulated by raycasts
	%include "Vehicle/btRaycastVehicle.h"

%{
typedef btTypedConstraint::btConstraintInfo1 btConstraintInfo1;
typedef btTypedConstraint::btConstraintInfo2 btConstraintInfo2;
typedef btVehicleRaycaster::btVehicleRaycasterResult btVehicleRaycasterResult;
typedef btWheelInfo::RaycastInfo RaycastInfo;
typedef btRigidBody::btRigidBodyConstructionInfo btRigidBodyConstructionInfo;
%}