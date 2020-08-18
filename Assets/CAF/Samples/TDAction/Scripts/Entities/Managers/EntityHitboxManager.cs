﻿using CAF.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDAction.Entities
{
    public class EntityHitboxManager : CAF.Entities.EntityHitboxManager
    {
        public EntityHitboxManager(EntityCombatManager combatManager, EntityManager manager) 
            : base(combatManager, manager)
        {
            
        }

        protected override Hitbox InstantiateHitbox(Vector3 position, Quaternion rotation)
        {
            return GameObject.Instantiate(((EntityManager)manager).hitboxPrefab, position, rotation);
        }

        protected override Vector3 GetHitboxPosition(BoxDefinition hitboxDefinition)
        {
            return manager.transform.position
                + manager.GetVisualBasedDirection(Vector3.right) * hitboxDefinition.offset.x * ((EntityManager)manager).FaceDirection
                + manager.GetVisualBasedDirection(Vector3.up) * hitboxDefinition.offset.y;
        }

        protected override Quaternion GetHitboxRotation(BoxDefinition hitboxDefinition)
        {
            return Quaternion.Euler(manager.visual.transform.eulerAngles 
                + hitboxDefinition.rotation);
        }
    }
}
