namespace Dashboard.StateContainers
{
	public class AppState
	{

		public bool IsShowThemeSelector { get; private set; }
		
		
		public string? SideBarColor { get; private set; }
		public string? SideBarType { get; private set; }
		public bool SideBarMinimize { get; private set; }
		public string SideBarLogo { get;  set; } = "../../assets/img/logo-ct-dark.png" ;

		public bool NavBarFixed { get; private set; }
		public bool DarkMode { get; private set; }


		public string NavBarSelectedMenus { get; private set; }
		

		public event Action OnChange;


		#region SideBar
		public void SetSideBarColor(string color)
		{
			SideBarColor = color;
			NotifyStateChanged();
		}

		public void SetSideBarType(string type)
		{
			SideBarType = type;
			NotifyStateChanged();
			SideBarLogo = (type == "bg-white") ? "../../assets/img/logo-ct-dark.png" : "../../assets/img/logo-ct.png";
		}

		public void SetSideBarMinimize()
		{
			SideBarMinimize = !SideBarMinimize;
			NotifyStateChanged();
		}

		public void SetNavbarFixed()
		{
			NavBarFixed = !NavBarFixed;
			NotifyStateChanged();
		}

		public void SetDarkMode()
		{
			DarkMode = !DarkMode;
			if (DarkMode) SideBarType = "bg-default";

			NotifyStateChanged();
		}

		#endregion

		#region ThemeSelector
		public void SetIsShowThemeSelector()
		{
			IsShowThemeSelector = !IsShowThemeSelector;
			NotifyStateChanged();
		}
		#endregion

		#region NavBar
		public void SetNavBarSelectedMenus(string text)
		{
			NavBarSelectedMenus = text;
			NotifyStateChanged();
		}
		#endregion

		private void NotifyStateChanged() => OnChange?.Invoke();
	}
}
