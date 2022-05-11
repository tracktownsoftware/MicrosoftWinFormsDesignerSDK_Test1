# MicrosoftWinFormsDesignerSDK_Test1

Trying to figure out VS2022 design-time support for a custom NET6 WinForms control.

Using use Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5), I'm playing with 2 approaches for adding design-time support to NET6 winforms controls.
- MyButtonLibrary.MyButton (its package uses a DesignTools server only approach)
- MyButton2Library.MyButton2 (its package uses a DesignTools server + client approach). The problem with writing DesignTools client UI code is it must be .Net Framework to work in VS2022; this means we can't leverage NET6 UI code that is alreay part of the NET6 control.

To build packages see \Pack\packNotes.txt.

Current Status:
- ServerOnlyApproach (the latest example package is in \Pack\package\MyButtonLibrary.1.0.61.nupkg). This approach contains DesignTools NET6 server only code. The biggest issue is the NET6 button editor dialog shows behind the VS2022 IDE window giving the impression VS2022 is frozen.
- ServerAndClientApproach (the latest example package is in \Pack\package\MyButton2Library.1.0.61.nupkg). This approach contains DesignTools NET6 server code and DesignTools NET472 client code. Using the design-time context menu on MyButton2 you can see a button editor implemented using NET472 and another editor implemented using NET6 server code (see code for how I trigger the showing of the NET6 UI from NET472 DesignTools client code). There still is an issue with the NET6 editor dialog showing behind the VS2022 giving impression VS2022 is frozen.

Two test the above nuget packages install them into a NET6 winforms project.
- From the VS2022 toolbox

