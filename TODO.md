Create specific tasks for Windows and Linux like publish.

Find a way to embed Gtk, initially embed as a resource and extract, after that, try to embed binaries like sqlite example with blazor.

https://github.com/GtkSharp/GtkSharp/blob/a23d44fb82975711cfcaa400cd7f3e4988d15bbf/Source/Libs/GtkSharp/GtkSharp.targets

<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

  <PropertyGroup>
    <GtkUrl Condition=" '$(GtkUrl)' == '' ">https://github.com/GtkSharp/Dependencies/raw/master/gtk-3.24.24.zip</GtkUrl>
    <GtkDir Condition=" '$(GtkDir)' == '' ">$(LOCALAPPDATA)\Gtk\3.24.24</GtkDir>
  </PropertyGroup>

  <Target Name="InstallGtk" BeforeTargets="Build" Condition=" '$(SkipGtkInstall)' != 'True' and '$(OS)' == 'Windows_NT' and !Exists('$(GtkDir)/libgtk-3-0.dll') ">
    <Message Importance="High" Text="Gtk has not been detected, downloading and installing it, set SkipGtkInstall to True to skip theese steps."/>
    <Message Importance="High" Text="Ignore Gtk extract errors, bug msbuild/issues/3884"/>
    <MakeDir Directories="$(GtkDir)"/>
    <DownloadFile SourceUrl="$(GtkUrl)" DestinationFolder="$(GtkDir)" DestinationFileName="gtk.zip" />
    <Unzip ContinueOnError="true" SourceFiles="$(GtkDir)/gtk.zip" DestinationFolder="$(GtkDir)" />
  </Target>

</Project>

> Executing task: dotnet build /clp:NoSummary <


Welcome to .NET 6.0!
---------------------
SDK Version: 6.0.100

Telemetry
---------
The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry   

----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate run 'dotnet dev-certs https --trust' (Windows and macOS only).
Learn about HTTPS: https://aka.ms/dotnet-https
----------------
Write your first app: https://aka.ms/dotnet-hello-world
----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
Microsoft (R) Build Engine version 17.0.0+c9eb9dd64 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  Restored D:\Users\Projects\Personal\data-tools\src\DataTools\DataTools.csproj (in 15.43 sec).
  Restored D:\Users\Projects\Personal\data-tools\test\DataTools.Tests.Integration\DataTools.Tests.Integration.csproj (in 26.9 sec).
  Restored D:\Users\Projects\Personal\data-tools\test\DataTools.Tests.Unit\DataTools.Tests.Unit.csproj (in 26.91 sec).
  DataTools -> D:\Users\Projects\Personal\data-tools\src\DataTools\bin\Debug\net6.0\data-tools.dll
  Gtk has not been detected, downloading and installing it, set SkipGtkInstall to True to skip theese steps.
  Ignore Gtk extract errors, bug msbuild/issues/3884
  Downloading from "https://github.com/GtkSharp/Dependencies/raw/master/gtk-3.24.24.zip" to "D:\Users\CPortes\AppData\Local\Gtk\3.24.24\gtk.zip" (54,086,753 bytes).        
  DataTools.Tests.Integration -> D:\Users\Projects\Personal\data-tools\test\DataTools.Tests.Integration\bin\Debug\net6.0\DataTools.Tests.Integration.dll
  DataTools.Tests.Unit -> D:\Users\Projects\Personal\data-tools\test\DataTools.Tests.Unit\bin\Debug\net6.0\DataTools.Tests.Unit.dll