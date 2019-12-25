using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFShellAdvThemeing.Models;
using XFShellAdvThemeing.Themes;

namespace XFShellAdvThemeing.Helpers
{
    public static class ThemeHelper
    {
        public static bool SetAppTheme(Theme selectedTheme)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (selectedTheme)
                {
                    case Theme.Dark:
                        mergedDictionaries.Add(new DarkTheme());
                        break;

                    case Theme.Light:
                        mergedDictionaries.Add(new LightTheme());
                        break;

                    case Theme.Pink:
                        mergedDictionaries.Add(new PinkTheme());
                        break;

                    case Theme.Gold:
                        mergedDictionaries.Add(new GoldTheme());
                        break;

                    case Theme.Blue:
                        mergedDictionaries.Add(new BlueTheme());
                        break;

                    default:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }

                return true;
            }

            return false;
        }
    }
}
