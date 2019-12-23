using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFShellAdvThemeing.Helpers;
using XFShellAdvThemeing.Models;
using XFShellAdvThemeing.Services;

namespace XFShellAdvThemeing
{
    /// <summary>
    /// Based on: https://docs.microsoft.com/en-us/samples/xamarin/xamarin-forms-samples/userinterface-theming/
    /// This is an optimization for Xamarin.Forms Shell apps
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            SetupCurrentTheme();
        }

        /// <summary>
        /// Set up current theme from app settings
        /// </summary>
        public void SetupCurrentTheme()
        {
            var currentTheme = Preferences.Get("CurrentAppTheme", null);
            if (currentTheme != null)
            {
                if (Enum.TryParse(currentTheme, out Theme currentThemeEnum))
                {
                    ThemeHelper.SetAppTheme(currentThemeEnum);
                }
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
