This tool allows you to update all packages.config and *.csproj files in a repository to use the same version of a nuget packages.

This is useful when you have 100 or more projects to update and you're not doing anything other than bumping a version.

This tool iterates all directorys looking for packages.config files and updating the version on the package you have supplied.

It then iterates all csproj files looking for the dll reference and updating what is between lib and packages in the path with the hintString. The hintNeedle should 
be something unique to that package. The dll name should suffice.

This tool does not add or remove dlls. If your package upgrade adds a dependency to another package or adds/removes a dll it will not be updated correctly. 

This tool currently only support bumping the version on a package. If your package contains more than one dll you can run it multiple times and just change the hintString
and hintNeedle for each of your dlls.


![Screenshot](readme/app.png)

```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="NLog" version="4.0.0" targetFramework="net461" />
</packages>
```
becomes
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="NLog" version="9.9.9" targetFramework="net461" />
</packages>
```

```
<Reference Include="NLog, Version=4.0.0, Culture=neutral, PublicKeyToken=5120e14c03d0593c, processorArchitecture=MSIL">
  <HintPath>..\packages\NLog.4.0.0\lib\net45\NLog.dll</HintPath>
  <Private>True</Private>
</Reference>
```	

becomes 

```
<Reference Include="NLog, Version=9.9.9, Culture=neutral, PublicKeyToken=5120e14c03d0593c, processorArchitecture=MSIL">
  <HintPath>..\packages\NLog.9.9.9\lib\net45\NLog.dll</HintPath>
  <Private>True</Private>
</Reference>
```	