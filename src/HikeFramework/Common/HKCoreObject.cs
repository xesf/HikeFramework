using System;
using System.Diagnostics;

namespace HikeFramework.Common
{
	public abstract class HKCoreObject : IDisposable
	{
		bool _disposed = false;

		public void Dispose()
		{ 
			Dispose(true);
			GC.SuppressFinalize(this);           
		}
			
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed)
				return; 

			_disposed = true;
		}

		~HKCoreObject()
		{
			Dispose(false);
		}
	}
}
