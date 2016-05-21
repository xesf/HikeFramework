using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Resources;

namespace HikeFramework.Graphics
{
    public interface IHKShaderProgram
    {
        void Link();
        void Load();
        void CreateShaderAndCompile(HKShaderResource shader);
        void Use();
    }
}
