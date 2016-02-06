using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Common;

namespace HikeFramework.Components
{
    public class HKGameObject : HKComponent
    {
        protected Dictionary<string, HKIComponent> _components = new Dictionary<string, HKIComponent>();

        public HKGameObject() 
        {
        }

        public HKIComponent GetComponent(Type type)
        {
            return null;
        }

        public T GetComponent<T>()
        {
            return default(T);
        }

        public new bool Enabled
        {
            get
            {
                return _components.First(c => (c.Value.Enabled == true)).Value != null;
            }
        }
    }
}
