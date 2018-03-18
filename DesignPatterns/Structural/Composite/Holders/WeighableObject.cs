using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite.Holders
{
    class WeighableObject : IWeighableComponent
    {
        float weight;

        public WeighableObject(float weight)
        {
            this.weight = weight;
        }

        public float GetWeight()
        {
            return weight;
        }
    }
}
