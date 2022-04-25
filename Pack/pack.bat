set PACKAGEVERSION=1.0.4
msbuild ..\MyButtonLibrary\MyButtonLibrary.csproj -p:Configuration=Release 
msbuild ..\MyButtonLibrary.Design\MyButtonLibrary.Design.csproj -p:Configuration=Release 
dotnet pack -p:PackageVersion=%PACKAGEVERSION% ..\MyButtonLibrary\MyButtonLibrary.csproj --configuration=Release --output Packages