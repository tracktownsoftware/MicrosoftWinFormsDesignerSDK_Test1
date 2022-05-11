# MicrosoftWinFormsDesignerSDK_Test1

Trying to figure out VS2022 design-time support for a custom NET6 WinForms control.

I'm playing with 2 approaches:
- DesignTools Server-only in the ServerOnlyApproach folder.
- DesignTools Server+Client in the ServerAndClientApproach folder. The problem with writing DesignTools client UI code is it must be .Net Framework to work in VS2022; this means we can;t leverage NET6 UI code that is alreay part of the NET control.

These examples use Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5) to add design-time support to the MyButtonLibrary.MyButton control.  
To build packages see \Pack\packNotes.txt.

Current Status:
- ServerOnlyApproach (the latest example package is in \Pack\package\MyButtonLibrary.1.0.61.nupkg). The biggest issue is when displaying the NET6 button editor dialog it shows behind the VS2022 IDE window giving the impression VS2022 is frozen.
- The "ServerAndClientApproach" (the latest example package is in \Pack\package\MyButton2Library.1.0.61.nupkg) contains DesignTools NET6 server code and DesignTools NET472 client code. Using the design-time context menu on MyButton2 you can see a button editor implemented using NET472 and another editor implemented using NET6 server code (see code for how I trigger the showing of the NET6 UI from NET472 DEsignTools client code.  

Two test the above nuget packages install them into a NET6 winforms project.
- From the VS2022 toolbox

