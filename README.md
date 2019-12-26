# XFShellAdvThemeing
Stunning App themes with Xamarin Forms Shell! 

You probably already know how to in classic Xamarin.Forms, but how about Setting up App Themes in a Xamarin.Forms Shell App?, now that's what this is for. 😉 

Check out the blog post: https://theconfuzedsourcecode.wordpress.com/2019/12/26/stunning-app-themes-in-xamarin-forms-shell-projects/

A little sneak peak:
![Android](/screenshots/PreviewStepByStepDemoAndroid.png)

>Here we're using awesome built-in Xamarin.Forms Dynamic Binding, and Styling features to implement a neat App Theming solution.
>An alternative for: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/theming
>But focused on the awesome new paradigm of Xamarin.Forms Shell!

### In a nutshell:
- Define Theme files with Colors/Fonts/Images/Icons in them
- Create Styles based on the Theme properties using Dynamic Binding
- Bind the UI Elements to the Styles created earlier
- Implement dynamic App Theme selection using MergedDictionaries
- Use XF.Essentials Preferences API to save App Theme preferences

Sample Theme File:
```xaml
﻿<?xml version="1.0" encoding="UTF-8" ?>
<ResourceDictionary
    x:Class="XFShellAdvThemeing.Themes.PinkTheme"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">

    <Color x:Key="PrimaryColor">#fc0384</Color>
    <Color x:Key="AccentColor">#ffb8dd</Color>
    <Color x:Key="SecondaryColor">White</Color>

    <Color x:Key="PageBackgroundColor">White</Color>
    <Color x:Key="NavigationBarColor">#fc0384</Color>

    <Color x:Key="PrimaryTextColor">#3d0020</Color>
    <Color x:Key="SecondaryTextColor">#610033</Color>
    <Color x:Key="TertiaryTextColor">#960050</Color>
</ResourceDictionary>
```

Sample Style:

```xaml
<Style x:Key="ButtonStyle" TargetType="Button">
    <Setter Property="BackgroundColor" Value="{DynamicResource PrimaryColor}" />
    <Setter Property="TextColor" Value="{DynamicResource SecondaryColor}" />
    <Setter Property="HeightRequest" Value="45" />
    <Setter Property="WidthRequest" Value="190" />
</Style>
```

Sample UI Element: 

```xaml
<Button
    x:Name="ChangeThemeButton"
    Clicked="ChangeThemeButton_Clicked"
    Style="{DynamicResource ButtonStyle}"
    Text="Change App Theme" />
```

Dynamic App Theme Switching:
```csharp
ICollection<ResourceDictionary> mergedDictionaries
		= Application.Current.Resources.MergedDictionaries;
...
...
case Theme.Pink:
	mergedDictionaries.Add(new PinkTheme());
	break;
...
...
```

Saving Theme Preferences: 
```csharp
Preferences.Set("CurrentAppTheme", SelectedItem.ToString());
```

Behold the beauty on Android and iOS...
![Android](/screenshots/PreviewCollectionAndroid.png)
![iOS](/screenshots/PreviewCollectioniOS.png)

