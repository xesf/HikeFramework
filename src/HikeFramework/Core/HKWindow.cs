using HikeFramework.Common;
using HikeFramework.Extensions;
using System;

namespace HikeFramework.Core
{
	public abstract class HKWindow : HKCoreObject, IHKWindow
	{
        public event EventHandler<EventArgs> Opening;
        public event EventHandler<EventArgs> Closing;
		
		public HKWindow(string title, int width, int height)
		{
			this.Title = title;

			if (this.Title.IsNullOrEmpty())
				this.Title = "Hike Framework";

			this.Width = width;
			this.Height = height; 
		}

		public HKWindow(string title, int width, int height, bool fullscreen)
			: this(title, width, height) {
			this.IsFullScreen = fullscreen;
		}

		public string Title { get; set; }

		public int Width { get; set; }
		public int Height { get; set; }

		public bool IsFullScreen { get; set; }

		public virtual void Initialize() 
        {
			throw new NotImplementedException ();
		}

		public virtual void ProcessEvents() 
        {
			throw new NotImplementedException ();
		}

        public virtual void OnOpening(object sender, EventArgs e)
        {
            Opening?.Invoke(sender, e);
        }

        public virtual void OnClosing(object sender, EventArgs e) 
		{
            Closing?.Invoke(sender, e);
		}
	}
}
