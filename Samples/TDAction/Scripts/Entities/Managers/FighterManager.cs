﻿using CAF.Combat;
using CAF.Input;
using CAF.Simulation;
using Prime31;
using System.Collections;
using System.Collections.Generic;
using TDAction.Entities.Characters;
using TDAction.Inputs;
using UnityEngine;

namespace TDAction.Entities
{
    public class FighterManager : CAF.Fighters.FighterBase, ISimObject
    {
        public int FaceDirection { get { return faceDirection; } }


        protected int faceDirection = 1;
        public EntityAnimator entityAnimator;
        public CharacterController2D charController2D;
        public Collider2D coll;
        public EntityDefinition entityDefinition;
        public HealthManager healthManager;
        public LayerMask enemyStepLayerMask;
        public float enemyStepRadius = 2;

        public virtual void Initialize(InputControlType controlType)
        {
            InputManager.SetControlType(controlType);
        }

        public void Start()
        {
            SetupStates();
            CombatManager.OnExitHitStop += (self) => { visual.transform.localPosition = Vector3.zero; };
            if (healthManager.MaxHealth == 0)
            {
                healthManager.SetMaxHealth(entityDefinition.GetEntityStats().health);
                healthManager.SetHealth(entityDefinition.GetEntityStats().health);
            }
        }

        public virtual void SimUpdate()
        {
            Tick();
        }

        public virtual void SimLateUpdate()
        {
            LateTick();
        }

        public override void Tick()
        {
            // Shake during hitstop (only when you got hit by an attack).
            if(CombatManager.HitStop > 0
                && CombatManager.HitStun > 0)
            {
                Vector3 pos = visual.transform.localPosition;
                pos.x = (Mathf.Sign(pos.x) > 0 ? -1 : 0) * .02f;
                visual.transform.localPosition = pos;
            }

            base.Tick();
        }

        protected virtual void SetupStates()
        {

        }

        public void SetFaceDirection(int faceDirection)
        {
            this.faceDirection = faceDirection;
            Vector3 visualScale = visual.transform.localScale;
            visualScale.x = 1 * faceDirection;
            visual.transform.localScale = visualScale;
        }

        public virtual bool TryAttack()
        {
            int man = CombatManager.TryAttack();
            if (man != -1)
            {
                CombatManager.SetAttack(man);
                StateManager.ChangeState((int)EntityStates.ATTACK);
                return true;
            }
            return false;
        }

        public virtual bool TryAttack(int attackIdentifier, bool resetFrameCounter = true)
        {
            if(attackIdentifier != -1)
            {
                CombatManager.SetAttack(attackIdentifier);
                StateManager.ChangeState((int)EntityStates.ATTACK, resetFrameCounter ? 0 : StateManager.CurrentStateFrame);
                return true;
            }
            return false;
        }

        Collider2D[] enemyStepResults = new Collider2D[2];
        public virtual bool TryEnemyStep(uint bufferFrames = 3)
        {
            if (InputManager.GetButton((int)EntityInputs.JUMP, 0, true, bufferFrames).firstPress)
            {
                Physics2D.OverlapCircleNonAlloc(transform.position, enemyStepRadius, enemyStepResults, enemyStepLayerMask);
                foreach (Collider2D e in enemyStepResults)
                {
                    if(e == null)
                    {
                        continue;
                    }
                    if (e.gameObject != gameObject)
                    {
                        StateManager.ChangeState((int)EntityStates.ENEMY_STEP);
                        return true;
                    }
                }
            }
            return false;
        }

        public virtual bool TryJump()
        {
            if (InputManager.GetButton((int)EntityInputs.JUMP).firstPress)
            {
                StateManager.ChangeState(IsGrounded ? (ushort)EntityStates.JUMP_SQUAT : (ushort)EntityStates.JUMP);
                return true;
            }
            return false;
        }

        public virtual bool TryLandCancel(bool setState = true)
        {
            PhysicsManager.CheckIfGrounded();
            if (IsGrounded)
            {
                if (setState)
                {
                    StateManager.ChangeState((ushort)EntityStates.IDLE);
                }
                return true;
            }
            return false;
        }

        public EntityPhysicsManager GetPhysicsManager()
        {
            return (EntityPhysicsManager)PhysicsManager;
        }
    }
}