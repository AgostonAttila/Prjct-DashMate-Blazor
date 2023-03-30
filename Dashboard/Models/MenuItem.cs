﻿using System;

namespace Dashboard.Models
{
	public class MenuItem
	{
		public string Id { get; set; }
		public string? Link { get; set; }
		public string? NormalClass { get; set; }
		public string? Title { get; set; }
		public string? MiniClass { get; set; }
		public string? MiniTitle { get; set; }
		public List<MenuItem> MenuItemList { get; set; } = new List<MenuItem>();
	}

	public class SideBarMenuItem
	{
		public string? Id { get; set; }
		public string? Name { get; set; }
		public string? Icon { get; set; }
		public string? Css { get; set; }
		public string? Type { get; set; }
		public List<MenuItem> MainMenuItemList { get; set; } = new List<MenuItem>();

	}


	public class MainMenuItem
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public List<MenuItem> MenuItemList { get; set; } = new List<MenuItem>();
	}
}


