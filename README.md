# .NET MAUI Localization Solution

The .NET MAUI localization feature that people tend to replicate across multiple apps. As intially i have created simple example with english and hindi language.

# Build Status
If you like to live dangerously, you can use our nightly feed to try out the latest and greatest.

# Getting Started
1. Create .net MAUI project
2. Create resx folder in resource folder in .net MAUI solution
3. Add resx files according to your language need.
4. Add resx resource file namesapce on your main page.
5. use resx resources

# XAML usage
In order to make use of the toolkit within XAML you can use this namespace:

xmlns:resource="clr-namespace:NetMauiLocalizationSample.Resources.resx"

<Label>
    <Label.FormattedText>
        <FormattedString>
            <Span Text="{x:Static resource:AppResources.lblEmail}" FontAttributes="Bold" />
            <Span Text="{x:Static resource:AppResources.lblEmailValue}"  /> 
        </FormattedString>
    </Label.FormattedText>
 </Label>


![iOS](https://user-images.githubusercontent.com/100989615/174484081-4c8abbfa-54d2-4cda-b8ad-256ee8d0e477.jpg)

![Android](https://user-images.githubusercontent.com/100989615/174484090-adaeedc1-dd49-4646-b8d7-ac41ec5bb27f.jpg)
