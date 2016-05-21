using System;
using System.IO;
using HikeFramework.Common;

namespace HikeFramework
{
	public class HKFileStream : HKCoreObject, IHKFileStream
	{
		public string FileName { get; set; }
		
		public HKFileStream (string filename)
		{
			this.FileName = filename;
		}

		#region IHKFileStream implementation

		public virtual string ReadText (string filename)
		{
			throw new NotImplementedException ();
		}

		public virtual byte[] ReadBinary (string filename)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

