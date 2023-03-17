namespace Dashboard.StateContainers
{
	public class AppState
	{

		public bool IsShowThemeSelector { get; private set; }
		public string? SideBarColor { get; private set; }
		public string? SideBarType { get; private set; }
		public bool SideBarMinimize { get; private set; } 
		public bool NavbarFixed { get; private set; }		
		public bool DarkMode { get; private set; }

		public event Action OnChange;



		//SideBar
		public void SetSideBarColor(string color)
		{
			SideBarColor = color;
			NotifyStateChanged();
		}

		public void SetSideBarType(string type)
		{
			SideBarType = type;
			NotifyStateChanged();
		}

		public void SetSideBarMinimize()
		{			
			SideBarMinimize = !SideBarMinimize;
			NotifyStateChanged();
		}

		public void SetNavbarFixed()
		{
			NavbarFixed = !NavbarFixed;
			NotifyStateChanged();
		}		

		public void SetDarkMode()
		{
			DarkMode = !DarkMode;
			if (DarkMode) SideBarType = "bg-default";

			NotifyStateChanged();
		}


		//ThemeSelector
		public void SetIsShowThemeSelector()
		{
			IsShowThemeSelector = !IsShowThemeSelector;
			NotifyStateChanged();
		}

		private void NotifyStateChanged() => OnChange?.Invoke();
	}
}
