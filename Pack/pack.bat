set PACKAGEVERSION=1.0.78
msbuild ..\MicrosoftWinFormsDesignerSDK_Test1.sln -p:Configuration=Release 

rem build MyButtonLibrary package
dotnet pack -p:PackageVersion=%PACKAGEVERSION% ..\MyButtonLibrary\MyButtonLibrary.csproj --configuration=Release --output Packages

rem build MyButton2Library package
dotnet pack -p:PackageVersion=%PACKAGEVERSION% ..\MyButton2Library\MyButton2Library.csproj --configuration=Release --output Packages