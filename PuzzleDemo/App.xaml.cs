using System;
using System.Windows;
using System.Configuration;

namespace PuzzleProject
{

	public partial class app : Application
	{
		void AppStartup(object sender, StartupEventArgs args)
		{
			Window mainWindow = new Puzzle();
			mainWindow.Show();
		}

	}
}