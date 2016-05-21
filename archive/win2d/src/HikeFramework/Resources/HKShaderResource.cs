using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Graphics;

namespace HikeFramework.Resources
{
    public class HKShaderResource : HKResource, IHKResource
    {
        public HKShaderType ShaderType { get; set; }
        public string ShaderCode { get; set; }
		
		public HKShaderResource(IHKFileStream fileStream)
			: base(fileStream)
		{
		}
		
		public override void Load(string filename)
        {
			this.ShaderCode = this.ReadText (filename);
        }
    }
}
