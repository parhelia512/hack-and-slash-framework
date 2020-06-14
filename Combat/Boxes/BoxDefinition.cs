﻿using UnityEngine;

namespace CAF.Combat
{
    [System.Serializable]
    public class BoxDefinition
    {
        public BoxShapes shape;
        public Vector3 offset;
        public Vector3 size;
        public Vector3 rotation;
        public float radius;

        public BoxDefinition()
        {

        }

        public BoxDefinition(BoxDefinition other)
        {
            shape = other.shape;
            offset = other.offset;
            size = other.size;
            rotation = other.rotation;
            radius = other.radius;
        }
    }
}