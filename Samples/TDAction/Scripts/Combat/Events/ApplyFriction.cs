﻿using System.Collections.Generic;
using UnityEngine;
using CAF.Combat;
using TDAction.Fighter;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace TDAction.Combat.Events
{
    public class ApplyFriction : AttackEvent
    {
        public bool xFriction;
        public bool yFriction;

        public override string GetName()
        {
            return "Friction";
        }

        public override AttackEventReturnType Evaluate(int frame, int endFrame,
            CAF.Fighters.FighterBase controller, AttackEventVariables variables)
        {
            FighterPhysicsManager physicsManager = (FighterPhysicsManager)controller.PhysicsManager;
            if (xFriction)
            {
                physicsManager.ApplyMovementFriction(variables.floatVars[0]);
            }
            if (yFriction)
            {
                physicsManager.ApplyGravityFriction(variables.floatVars[0]);
            }
            return AttackEventReturnType.NONE;
        }

#if UNITY_EDITOR
        public override void DrawEventVariables(CAF.Combat.AttackEventDefinition eventDefinition)
        {
            if (eventDefinition.variables.floatVars == null
                || eventDefinition.variables.floatVars.Count != 1)
            {
                eventDefinition.variables.floatVars = new List<float>(1);
                eventDefinition.variables.floatVars.Add(0);
            }

            xFriction = EditorGUILayout.Toggle("X-Axis", xFriction);
            yFriction = EditorGUILayout.Toggle("Y-Axis", yFriction);

            eventDefinition.variables.floatVars[0] = EditorGUILayout.FloatField("Friction",
                eventDefinition.variables.floatVars[0]);
        }
#endif
    }
}