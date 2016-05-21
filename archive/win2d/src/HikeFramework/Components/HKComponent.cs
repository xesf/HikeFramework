using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Common;

namespace HikeFramework.Components
{
    public class HKComponent : HKCoreObject, HKIComponent
    {
        protected bool _enabled = true;

        public HKComponent()
        { 
        }

        public bool Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                this._enabled = value;
            }
        }
    }
}
