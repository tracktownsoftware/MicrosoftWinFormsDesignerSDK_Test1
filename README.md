# MicrosoftWinFormsDesignerSDK_Test1

The goal is figure out how to add VS2022 design-time support for custom NET6 WinForms controls using Microsoft's Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5). Microsoft documentation is limited.

I'm playing with 2 approaches to add a design-time editor for my NET6 WinForms MyButton and MyButton2 controls:
- MyButtonLibrary.MyButton (its package uses a DesignTools server only approach)
- MyButton2Library.MyButton2 (its package uses a DesignTools server + client approach). The problem with writing DesignTools client UI code is it must be .Net Framework to work in VS2022; this means we can't leverage NET6 UI code that is already part of the NET6 control. Update: I found a way to trigger showing the NET6 dialog from DesignTools client code.

To build packages see \Pack\packNotes.txt.

Current Status:
- SUCCESS: ServerOnlyApproach (the latest package is in \Pack\package\MyButtonLibrary.1.0.78.nupkg). This approach contains DesignTools NET6 server only code. There was an issue with this NET6 dialog showing underneath VS2022 the first time it is displayed. This is fixed by setting windowstate to minimized in the constructor, and then in the load event setting windowstate to normal and then calling Activate.
- SUCCESS: ServerAndClientApproach (the latest package is in \Pack\package\MyButton2Library.1.0.78.nupkg). This approach contains DesignTools NET6 server code and DesignTools NET472 client code. Using the design-time context menu on MyButton2 you can see a button editor implemented using NET472 (SUCCESS but I don't want to reimplement my NET6 control UI in .Net Framework!) and another editor implemented using NET6 server code (see code for how I trigger the showing of the NET6 UI from NET472 DesignTools client code). There was an issue with this NET6 dialog showing underneath VS2022 the first time it is displayed. This is fixed by setting windowstate to minimized in the constructor, and then in the load event setting windowstate to normal and then calling Activate.

Test the above by installing \Pack\package\MyButtonLibrary.1.0.78.nupkg and \Pack\package\MyButton2Library.1.0.78.nupkg into a NET6 winforms project.
- From the VS2022 toolbox drop MyButton and MyButton2 onto different WinForms forms
- Use the design-time context menu to test menu items

This Microsoft blog has a few comments about the NET6 editor dialog shows behind the VS2022 window issue. See my comments above under 'Current Status" for a workaround that appears to work.
The official Microsoft position is to not use NET6 UI and rewrite the editor in .Net Framework so it can be displayed from DesignTools client code:
https://devblogs.microsoft.com/dotnet/state-of-the-windows-forms-designer-for-net-applications/comment-page-2/#comments

>This is the reason that you cannot show UI from the DesignToolsServer. (See one of my previous responses).
A Control Designer which must show a (modal) UI (Editor) should only be shown in the context of Visual Studio (the client).
So. Such a Control Designer will then always have 2 parts: One for the Client (VS, .NET Framework), one for the Server (DesignToolsServer, .NET).
They both must be delivered via NuGet and get executed in their respective contexts.

>And again, having the Designer OOP is really an architectural necessity. Framework being the host and .NET being the target is one challenge, we already have. 64 Bit Framework and 32-Bit Framework being the target (for Controls depending on 32-Bit-COM for example) can get problematic in certain scenarios as well. And Visual Studio 2022 is already 64-Bit.


