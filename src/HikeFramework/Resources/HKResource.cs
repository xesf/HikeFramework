using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikeFramework.Resources
{
    public class HKResource : IHKResource
    {
		protected IHKFileStream _fileStream;
		
		public HKResource(IHKFileStream fileStream)
		{
			
		}
		
		public virtual void Load(string filename)
		{
			
		}
		
		protected string ReadText(string filename)
		{
			return _fileStream.ReadText (filename);
		}
		
		protected byte[] ReadBinary(string filename)
		{
			return _fileStream.ReadBinary (filename);
		}
    }
}
