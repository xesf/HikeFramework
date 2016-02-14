using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Common;
using Windows.UI;

namespace HikeFramework.Graphics
{
    public abstract class HKCanvas : HKCoreObject, IHKCanvas
    {
        public virtual void Clear(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
