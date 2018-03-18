using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Structural.Composite.Holders
{
    class WeighableHolder : IWeighableComponent
    {
        float weight;
        List<IWeighableComponent> elements;

        public WeighableHolder(float weight = 0)
        {
            this.weight = weight;
            elements = new List<IWeighableComponent>();
        }

        public void Add(IWeighableComponent item)
        {
            elements.Add(item);
        }

        public float GetWeight()
        {
            return weight + elements.Sum(el => el.GetWeight());
        }
    }
}
