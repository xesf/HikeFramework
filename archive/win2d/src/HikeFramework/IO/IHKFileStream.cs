using System;

namespace HikeFramework
{
	public interface IHKFileStream
	{
		string ReadText(string filename);
		byte[] ReadBinary(string filename);
	}
}

