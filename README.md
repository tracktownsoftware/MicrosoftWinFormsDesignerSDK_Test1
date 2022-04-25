# MicrosoftWinFormsDesignerSDK_Test1

Trying to figure out VS2022 design-time support for a custom NET6 WinForms control.

To build a package see \Pack\packNotes.txt.
The latest package I made is in \Pack\package.

The MyButtonLibrary.Design project uses Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5) to add design-time support to the MyButtonLibrary.MyButton control.  

Current Status:
- MyButton design-time context menu can change MyButton background to red, white or blue.
