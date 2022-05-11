# MicrosoftWinFormsDesignerSDK_Test1

The goal is figure out how to add VS2022 design-time support for custom NET6 WinForms controls using Microsoft's Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5). Microsoft documentation is limited.

I'm playing with 2 approaches to add a design-time editor for my NET6 WinForms MyButton and MyButton2 controls:
- MyButtonLibrary.MyButton (its package uses a DesignTools server only approach)
- MyButton2Library.MyButton2 (its package uses a DesignTools server + client approach). The problem with writing DesignTools client UI code is it must be .Net Framework to work in VS2022; this means we can't leverage NET6 UI code that is already part of the NET6 control.

To build packages see \Pack\packNotes.txt.

Current Status:
- ServerOnlyApproach (the latest package is in \Pack\package\MyButtonLibrary.1.0.61.nupkg). This approach contains DesignTools NET6 server only code. The biggest issue is the NET6 button editor dialog shows behind the VS2022 IDE window giving the impression VS2022 is frozen.
- ServerAndClientApproach (the latest package is in \Pack\package\MyButton2Library.1.0.61.nupkg). This approach contains DesignTools NET6 server code and DesignTools NET472 client code. Using the design-time context menu on MyButton2 you can see a button editor implemented using NET472 (SUCCESS but I don't want to reimplement my NET6 control UI in .Net Framework!) and another editor implemented using NET6 server code (see code for how I trigger the showing of the NET6 UI from NET472 DesignTools client code). There still is an issue with the NET6 editor dialog showing behind the VS2022 giving impression VS2022 is frozen.

Test the above nuget packages by installing them into a NET6 winforms project.
- From the VS2022 toolbox drop MyButton and MyButton2 onto different WinForms forms
- Use the design-time context menu to test menu items

