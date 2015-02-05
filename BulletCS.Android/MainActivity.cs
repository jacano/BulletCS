﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BulletSharp;

namespace BulletCS.Android
{
    [Activity(Label = "BulletCS.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            btBroadphaseInterface broadphase = new btDbvtBroadphase();

            btDefaultCollisionConfiguration collisionConfiguration = new btDefaultCollisionConfiguration();
            btCollisionDispatcher dispatcher = new btCollisionDispatcher(collisionConfiguration);

            btSequentialImpulseConstraintSolver solver = new btSequentialImpulseConstraintSolver();

            btDiscreteDynamicsWorld dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, broadphase, solver, collisionConfiguration);
            dynamicsWorld.setGravity(new btVector3(0, -10, 0));

            btCollisionShape groundShape = new btStaticPlaneShape(new btVector3(0, 1, 0), 1);

            btDefaultMotionState groundMotionState = new btDefaultMotionState(new btTransform(new btQuaternion(0, 0, 0, 1), new btVector3(0, -1, 0)));
            btRigidBody.btRigidBodyConstructionInfo groundRigidBodyCI = new btRigidBody.btRigidBodyConstructionInfo(0, groundMotionState, groundShape, new btVector3(0, 0, 0));
            btRigidBody groundRigidBody = new btRigidBody(groundRigidBodyCI);
            dynamicsWorld.addRigidBody(groundRigidBody);

            btDefaultMotionState fallMotionState = new btDefaultMotionState(new btTransform(new btQuaternion(0, 0, 0, 1), new btVector3(0, 50, 0)));

            btVector3 fallInertia = new btVector3(0, 0, 0);

            btCollisionShape fallShape = new btSphereShape(1);
            fallShape.calculateLocalInertia(1, fallInertia);

            btRigidBody.btRigidBodyConstructionInfo fallRigidBodyCI = new btRigidBody.btRigidBodyConstructionInfo(1, fallMotionState, fallShape, fallInertia);
            btRigidBody fallRigidBody = new btRigidBody(fallRigidBodyCI);
            dynamicsWorld.addRigidBody(fallRigidBody);

            for (int i = 0 ; i < 300 ; i++)
            {
                dynamicsWorld.stepSimulation(1 / 60.0f, 10);

                btTransform trans = new btTransform();
                fallRigidBody.getMotionState().getWorldTransform(trans);

                Console.WriteLine("sphere height: " + trans.getOrigin().getY());
            }
        }
    }
}

