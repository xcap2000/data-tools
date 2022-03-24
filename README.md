# Data Tools

## Project Infrastructure

### Creating The Projects

### Setting Up Git

```bash
$ git config user.name "Carlos Adriano Portes"
$ git config user.email "xcap2000@outlook.com"
```

#### Creating The Global Configuration File

```bash
$ dotnet new globaljson
```

Add the following contents to the generated global.json:

```json
{
  "sdk": {
    "version": "6.0.100",
    "rollForward": "latestMinor"
  },
  "projects": [
    "src",
    "test"
  ]
}
```

\* Be sure to have this framework version installed for development.

#### Creating The Ignore File

Create a file named .gitignore with the following contents:

```
.vs
bin
obj
*csproj.user
lcov.info
StrykerOutput
sqltools*
```

#### Creating The OmniSharp Configuration File

Create a file named omnisharp.json with the following contents:

```json
{
    "RoslynExtensionsOptions": {
        "enableAnalyzersSupport": true
    }
}
```

#### Creating The Folder Infrastructure

```bash
$ mkdir .vscode
$ mkdir doc
$ mkdir src
$ mkdir test
```

#### Creating Main Project

```bash
$ mkdir src/DataTools
$ dotnet new gtkapp -n DataTools -o src/DataTools
$ dotnet add src/DataTools/DataTools.csproj package Microsoft.CodeAnalysis.CSharp.Workspaces --version 4.0.1
$ dotnet add src/DataTools/DataTools.csproj package Unity --version 5.11.10
$ dotnet add src/DataTools/DataTools.csproj package Roslynator.Analyzers --version 3.2.2
```

Edit src/DataTools/DataTools.csproj to configure it as following:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    ...
    <AssemblyName>data-tools</AssemblyName>
    <Version>0.1.0</Version>
    <Authors>Carlos Adriano Portes</Authors>
    <Company>Carpe Diem</Company>
    <Product>DataTools</Product>
    <PackageId>CarpeDiem.DataTools</PackageId>
    <AssemblyVersion>0.1.0.0</AssemblyVersion>
    <FileVersion>0.1.0.0</FileVersion>
    <NeutralLanguage>en</NeutralLanguage>
    <Description>Data Tools Application</Description>
    <Copyright>Carpe Diem</Copyright>
    <PackageLicenseUrl></PackageLicenseUrl>
    <PackageProjectUrl></PackageProjectUrl>
    <PackageIconUrl></PackageIconUrl>
    <RepositoryUrl>https://github.com/xcap2000/data-tools</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <PackageTags></PackageTags>
    <PackageReleaseNotes>Release</PackageReleaseNotes>
    <IsPackable>false</IsPackable>
    <RootNamespace>CarpeDiem.DataTools</RootNamespace>
    <Nullable>enable</Nullable>
    <CodeAnalysisRuleSet>DataTools.ruleset</CodeAnalysisRuleSet>
    <GenerateFullPaths>true</GenerateFullPaths>
    ...
  </PropertyGroup>
  ...
</Project>
```

#### Creating The Unit Test Project

```bash
$ mkdir test/DataTools.Tests.Unit
$ dotnet new xunit -n DataTools.Tests.Unit -o test/DataTools.Tests.Unit
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj reference src/DataTools/DataTools.csproj
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package Microsoft.CodeAnalysis.CSharp.Workspaces --version 4.0.1
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package coverlet.msbuild --version 3.1.0
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package Roslynator.Analyzers --version 3.2.2
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package NSubstitute --version 4.2.2
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package NSubstitute.Analyzers.CSharp --version 1.0.15
$ dotnet add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.0
```

Edit src/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj to configure it as following:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    ...
    <Version>0.1.0</Version>
    <Authors>Carlos Adriano Portes</Authors>
    <Company>Carpe Diem</Company>
    <Product>RefreshMaint</Product>
    <PackageId>DataTools.Tests.Unit</PackageId>
    <AssemblyVersion>0.1.0.0</AssemblyVersion>
    <FileVersion>0.1.0.0</FileVersion>
    <NeutralLanguage>en</NeutralLanguage>
    <Description>RefreshMaint MVC Application Tests</Description>
    <Copyright>Carpe Diem</Copyright>
    <PackageLicenseUrl></PackageLicenseUrl>
    <PackageProjectUrl></PackageProjectUrl>
    <PackageIconUrl></PackageIconUrl>
    <RepositoryUrl>https://github.com/xcap2000/data-tools</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <PackageTags></PackageTags>
    <PackageReleaseNotes>Release</PackageReleaseNotes>
    <IsPackable>false</IsPackable>
    <RootNamespace>CarpeDiem.DataTools</RootNamespace>
    <Nullable>enable</Nullable>
    <CodeAnalysisRuleSet>DataTools.Tests.Unit.ruleset</CodeAnalysisRuleSet>
    <GenerateFullPaths>true</GenerateFullPaths>
    ...
  </PropertyGroup>
  ...
</Project>
```

#### Creating The Integration Test Project

```bash
$ mkdir test/DataTools.Tests.Integration
$ dotnet new xunit -n DataTools.Tests.Integration -o test/DataTools.Tests.Integration
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj reference src/DataTools/DataTools.csproj
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package Microsoft.CodeAnalysis.CSharp.Workspaces --version 4.0.1
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package coverlet.msbuild --version 3.1.0
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package Roslynator.Analyzers --version 3.2.2
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package Unity --version 5.11.10
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package NSubstitute --version 4.2.2
$ dotnet add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj package NSubstitute.Analyzers.CSharp --version 1.0.15
```

Edit src/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj to configure it as following:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    ...
    <Version>0.1.0</Version>
    <Authors>Carlos Adriano Portes</Authors>
    <Company>Carpe Diem</Company>
    <Product>DataTools</Product>
    <PackageId>DataTools.Tests.Integration</PackageId>
    <AssemblyVersion>0.1.0.0</AssemblyVersion>
    <FileVersion>0.1.0.0</FileVersion>
    <NeutralLanguage>en</NeutralLanguage>
    <Description>DataTools Application Integration Tests</Description>
    <Copyright>Carpe Diem</Copyright>
    <PackageLicenseUrl></PackageLicenseUrl>
    <PackageProjectUrl></PackageProjectUrl>
    <PackageIconUrl></PackageIconUrl>
    <RepositoryUrl>https://github.com/xcap2000/data-tools</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <PackageTags></PackageTags>
    <PackageReleaseNotes>Release</PackageReleaseNotes>
    <IsPackable>false</IsPackable>
    <RootNamespace>CarpeDiem.DataTools</RootNamespace>
    <Nullable>enable</Nullable>
    <CodeAnalysisRuleSet>DataTools.Tests.Integration.ruleset</CodeAnalysisRuleSet>
    <GenerateFullPaths>true</GenerateFullPaths>
    ...
  </PropertyGroup>
  ...
</Project>
```

#### Creating The Solution

```bash
$ dotnet new sln -n DataTools
$ dotnet sln DataTools.sln add src/DataTools/DataTools.csproj
$ dotnet sln DataTools.sln add test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj
$ dotnet sln DataTools.sln add test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj
```

#### Creating The Ruleset Configuration File

Create the files src/DataTools/DataTools.ruleset, test/DataTools.Tests.Unit/DataTools.Tests.Unit.ruleset and test/DataTools.Tests.Integration/DataTools.Tests.Integration.ruleset with the following contents:

```xml
<RuleSet Name="Rules" Description="Rules for this project" ToolsVersion="15.0">
   <Rules AnalyzerId="Microsoft.Analyzers.ManagedCodeAnalysis" RuleNamespace="Microsoft.Rules.Managed">
     <!--<Rule Id="RULE_ID" Action="ACTION" />-->
   </Rules>
</RuleSet>
```

Supported Ruleset Actions Are:
* Warning
* Error
* Info
* Hidden
* None

#### Creating Extensions File

Create a file named extensions.json in the .vscode folder with the following contents:

```json
{
    "recommendations": [
        "ms-dotnettools.csharp",
        "ryanluker.vscode-coverage-gutters",
        "eamodio.gitlens",
        "ow.vscode-subword-navigation",
        "Gruntfuggly.todo-tree",
        "amodio.toggle-excluded-files",
        "pflannery.vscode-versionlens",
        "VisualStudioExptTeam.vscodeintellicode",
        "redhat.vscode-xml",
        "ms-mssql.mssql",
        "ms-azuretools.vscode-docker",
        "oderwat.indent-rainbow",
        "alefragnani.Bookmarks"
    ]
}
```

#### Creating Launch File

Create a file named launch.json in the .vscode folder with the following contents:

```json
{
    // Use IntelliSense to learn about possible attributes.
    // Hover to view descriptions of existing attributes.
    // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "all: build",
            "program": "${workspaceFolder}/src/DataTools/bin/Debug/net6.0/data-tools.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/DataTools",
            "stopAtEntry": false,
            "console": "internalConsole"
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}
```

#### Creating The VSCode Configuration File

Create a file named settings.json in the .vscode folder with the following contents:

```json
{
    "editor.formatOnSave": true,
    "editor.formatOnPaste": true,
    "files.exclude": {
        "**/.git": true,
        "**/.vscode": true,
        "**/.vs": true,
        "**/.gitignore": true,
        "**/global.json": true,
        "**/bin": true,
        "**/obj": true,
        "**/lcov.info": true,
        "**/omnisharp.json": true,
        "**/*.ruleset": true,
        "**/StrykerOutput": true,
        "**/.config": true,
        "**/sqltools*": true
    }
}
```

#### Update The VSCode KeyBindings File (Optional, subword navigation extension)

Update you keybindings.json to the following:

```json
// Place your key bindings in this file to overwrite the defaults
[
    {
        "key": "ctrl+shift+left",
        "command": "subwordNavigation.cursorSubwordLeftSelect",
        "when": "editorTextFocus"
    },
    {
        "key": "ctrl+shift+right",
        "command": "subwordNavigation.cursorSubwordRightSelect",
        "when": "editorTextFocus"
    },
    {
        "key": "ctrl+backspace",
        "command": "subwordNavigation.deleteSubwordLeft",
        "when": "editorTextFocus"
    },
    {
        "key": "ctrl+delete",
        "command": "subwordNavigation.deleteSubwordRight",
        "when": "editorTextFocus"
    },
    {
        "key": "ctrl+alt+s",
        "command": "workbench.action.files.saveAll"
    }
]
```

#### Creating The Project Tasks

Create a file named tasks.json in the .vscode folder with the following contents:

```json
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "src: run",
            "type": "process",
            "group": "build",
            "command": "dotnet",
            "isBackground": false,
            "windows": {
                "args": [
                    "run",
                    "--project",
                    "${workspaceFolder}\\src\\DataTools\\DataTools.csproj",
                    "/clp:NoSummary"
                ]
            },
            "linux": {
                "args": [
                    "run",
                    "--project",
                    "${workspaceFolder}/src/DataTools/DataTools.csproj",
                    "/clp:NoSummary"
                ]
            },
            "problemMatcher": [],
            "presentation": {
                "reveal": "always"
            }
        },
        {
            "label": "all: clean",
            "type": "shell",
            "group": "build",
            "command": "dotnet clean",
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "all: restore",
            "type": "shell",
            "group": "build",
            "command": "dotnet restore",
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "all: build",
            "type": "shell",
            "group": "build",
            "command": "dotnet build /clp:NoSummary",
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "test: unit",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "${workspaceFolder}\\test\\DataTools.Tests.Unit\\DataTools.Tests.Unit.csproj",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "linux": {
                "args": [
                    "test",
                    "${workspaceFolder}/test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "test: unit (watch)",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "isBackground": true,
            "windows": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}\\test\\DataTools.Tests.Unit\\DataTools.Tests.Unit.csproj",
                    "test",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "linux": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}/test/DataTools.Tests.Unit/DataTools.Tests.Unit.csproj",
                    "test",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "problemMatcher": [],
            "presentation": {
                "reveal": "always"
            }
        },
        {
            "label": "test: unit mutation coverage",
            "type": "shell",
            "group": "test",
            "isBackground": true,
            "windows": {
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput -Recurse } ; dotnet stryker --reporter \"html\" ; C:\\Program` Files\\Mozilla` Firefox\\firefox.exe \"${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput\\$(ls -Name ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput\\ | Select-Object -First 1)\\reports\\mutation-report.html\"",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests.Unit/"
                }
            },
            "linux": {
                "command": "rm -rf ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput && dotnet stryker --reporter \"html\" && firefox ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/`\"/reports/mutation-report.html || wslview ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/`\"/reports/mutation-report.html",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests.Unit/"
                }
            }
        },
        {
            "label": "test: integration",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "${workspaceFolder}\\test\\DataTools.Tests.Integration\\DataTools.Tests.Integration.csproj",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "linux": {
                "args": [
                    "test",
                    "${workspaceFolder}/test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "test: integration (watch)",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "isBackground": true,
            "windows": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}\\test\\DataTools.Tests.Integration\\DataTools.Tests.Integration.csproj",
                    "test",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "linux": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}/test/DataTools.Tests.Integration/DataTools.Tests.Integration.csproj",
                    "test",
                    "/clp:NoSummary",
                    "/p:CollectCoverage=true",
                    "/p:CoverletOutputFormat=lcov",
                    "/p:CoverletOutput=./lcov.info",
                    "/p:Exclude=\"[coverlet.*]*,[*]Coverlet.Core*,[System*]*,[xunit.*]*\""
                ]
            },
            "problemMatcher": [],
            "presentation": {
                "reveal": "always"
            }
        },
        {
            "label": "test: integration mutation coverage",
            "type": "shell",
            "group": "test",
            "isBackground": true,
            "windows": {
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput -Recurse } ; dotnet stryker --reporter \"html\" ; C:\\Program` Files\\Mozilla` Firefox\\firefox.exe \"${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput\\$(ls -Name ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput\\ | Select-Object -First 1)\\reports\\mutation-report.html\"",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests.Integration/"
                }
            },
            "linux": {
                "command": "rm -rf ${workspaceFolder}/test/DataTools.Tests.Integration/StrykerOutput && dotnet stryker --reporter \"html\" && firefox ${workspaceFolder}/test/DataTools.Tests.Integration/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Integration/StrykerOutput/`\"/reports/mutation-report.html || wslview ${workspaceFolder}/test/DataTools.Tests.Integration/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Integration/StrykerOutput/`\"/reports/mutation-report.html",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests.Integration/"
                }
            }
        },
        {
            "label": "src: publish",
            "type": "shell",
            "group": "build",
            "presentation": {
                "reveal": "silent"
            },
            "problemMatcher": "$msCompile",
            "windows": {
                "command": "dotnet publish src\\DataTools\\DataTools.csproj -c Release -r win10-x64 --self-contained -o src\\DataTools\\bin\\Release\\net6.0\\win10-x64\\ /p:UseAppHost=true /p:PublishSingleFile=true"
            },
            "linux": {
                "command": "dotnet publish src/DataTools/DataTools.csproj -c Release -r linux-x64 --self-contained -o src/DataTools/bin/Release/net6.0/linux-x64/ /p:UseAppHost=true /p:PublishSingleFile=true"
            }
        }
    ]
}
```

#### Adding Stryker

To add Stryker locally:

```bash
$ dotnet new tool-manifest
$ dotnet tool install dotnet-stryker --version 1.1.0
```

To update Stryker:

```bash
$ dotnet tool update dotnet-stryker
```

To restore Stryker:

```bash
$ dotnet tool restore
```

To run Stryker:

```bash
$ dotnet tool run dotnet-stryker # in the unit test project folder
# or 
$ dotnet stryker
```

To remove Stryker:

```bash
$ dotnet tool uninstall dotnet-stryker
```

#### VSCode Extensions

Go to extensions, filter by recommended and install all workspace recommendations if not installed. Disable all of them and enable just for the workspace.

#### Test Database (Docker)

```bash
$ docker run --name sqlserver -m 4G -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Jnj@12345' -p 11433:1433 -v /data/docker/volumes/data:/var/opt/mssql/data -v /data/docker/volumes/log:/var/opt/mssql/log -v /data/docker/volumes/secrets:/var/opt/mssql/secrets -d mcr.microsoft.com/mssql/server:2017-latest
```

We can add "--restart unless-stopped" during development time:

```bash
$ docker run --restart unless-stopped --name sqlserver -m 4G -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Jnj@12345' -p 11433:1433 -v /data/docker/volumes/data:/var/opt/mssql/data -v /data/docker/volumes/log:/var/opt/mssql/log -v /data/docker/volumes/secrets:/var/opt/mssql/secrets -d mcr.microsoft.com/mssql/server:2017-latest
```

Or update existing container according to the needs:

```bash
$ docker update --restart unless-stopped sqlserver # To enable.
$ docker update --restart no sqlserver # To disable, the default is no.
```

#### Tracing

Run the application and start tracing:

```bash
$ dotnet-trace collect --format Chromium -p `pidof data-tools` # Open on chrome (chrome://tracing/) or edge (edge://tracing/)
# Or
$ dotnet-trace collect --format SpeedScope -p `pidof data-tools` # Open on SpeedScope (https://www.speedscope.app/)
```

#### Disabling Gtk Download

```xml
<PropertyGroup>
    <SkipGtkInstall>true</SkipGtkInstall>
</PropertyGroup>
```

#### Installing Gtk From MSYS2

```bash
$ pacman -Ss gtk | grep i686 # Find x86
$ pacman -Ss gtk | grep x86_64 # Find x64
$ pacman -S mingw-w64-x86_64-gtk3 # x64
$ pacman -S mingw-w64-i686-gtk3 # x86
$ pacman -Ql mingw-w64-x86_64-gtk3 | grep bin # show installed dll's
$ pacman -Ql mingw-w64-i686-gtk3 | grep bin # show installed dll's
$ pacman -Si mingw-w64-x86_64-gtk3
# Package dependencies: mingw-w64-x86_64-gcc-libs mingw-w64-x86_64-adwaita-icon-theme mingw-w64-x86_64-atk mingw-w64-x86_64-cairo mingw-w64-x86_64-gdk-pixbuf2 mingw-w64-x86_64-glib2 mingw-w64-x86_64-json-glib mingw-w64-x86_64-libepoxy mingw-w64-x86_64-pango mingw-w64-x86_64-shared-mime-info mingw-w64-x86_64-gtk-update-icon-cache
$ pacman -Si mingw-w64-x86_64-gtk3
# Package dependencies: mingw-w64-i686-gcc-libs mingw-w64-i686-adwaita-icon-theme mingw-w64-i686-atk mingw-w64-i686-cairo mingw-w64-i686-gdk-pixbuf2 mingw-w64-i686-glib2 mingw-w64-i686-json-glib mingw-w64-i686-libepoxy mingw-w64-i686-pango mingw-w64-i686-shared-mime-info mingw-w64-i686-gtk-update-icon-cache
```

 x86 Needed files  (from https://github.com/miegir/GTK-for-Windows-Runtime-Environment-Installer-32/blob/master/gtk-nsis-pack/gtk3-runtime.ts.nsi):

```ini
libatk-1.0-0.dll
libbrotlicommon.dll
libbrotlidec.dll
libbz2-1.dll
libcairo-2.dll
libcairo-gobject-2.dll
libcairo-script-interpreter-2.dll
libdatrie-1.dll
libepoxy-0.dll
libexpat-1.dll
libffi-7.dll
libfontconfig-1.dll
libfreetype-6.dll
libfribidi-0.dll
libgailutil-3-0.dll
libgcc_s_dw2-1.dll
libgdk_pixbuf-2.0-0.dll
libgdk-3-0.dll
libgio-2.0-0.dll
libglib-2.0-0.dll
libgmodule-2.0-0.dll
libgmp-10.dll
libgobject-2.0-0.dll
libgraphite2.dll
libgthread-2.0-0.dll
libgtk-3-0.dll
libharfbuzz-0.dll
libiconv-2.dll
libintl-8.dll
libjpeg-8.dll
libjson-glib-1.0-0.dll
liblzma-5.dll
libp11-kit-0.dll
libpango-1.0-0.dll
libpangocairo-1.0-0.dll
libpangoft2-1.0-0.dll
libpangowin32-1.0-0.dll
libpcre-1.dll
libpixman-1-0.dll
libpng16-16.dll
librsvg-2-2.dll
libssp-0.dll
libstdc++-6.dll
libtasn1-6.dll
libthai-0.dll
libtiff-5.dll
libwinpthread-1.dll
libxml2-2.dll
zlib1.dll
```

x64 Needed files  (from https://github.com/tschoonj/GTK-for-Windows-Runtime-Environment-Installer/blob/master/gtk-nsis-pack/gtk3-runtime.ts.nsi):

```bash
libatk-1.0-0.dll
libatkmm-1.6-1.dll
libbrotlicommon.dll
libbrotlidec.dll
libbz2-1.dll
libcairo-2.dll
libcairo-gobject-2.dll
libcairo-script-interpreter-2.dll
libcairomm-1.0-1.dll
libcroco-0.6-3.dll
libdatrie-1.dll
libepoxy-0.dll
libexpat-1.dll
libexslt-0.dll
libffi-7.dll
libfontconfig-1.dll
libfreetype-6.dll
libfribidi-0.dll
libgailutil-3-0.dll
libgcc_s_dw2-1.dll
libgcc_s_seh-1.dll
libgdk_pixbuf-2.0-0.dll
libgdk-3-0.dll
libgdkmm-3.0-1.dll
libgio-2.0-0.dll
libgiomm-2.4-1.dll
libglib-2.0-0.dll
libglibmm_generate_extra_defs-2.4-1.dll
libglibmm-2.4-1.dll
libgmodule-2.0-0.dll
libgmp-10.dll
libgnutls-30.dll
libgobject-2.0-0.dll
libgraphite2.dll
libgthread-2.0-0.dll
libgtk-3-0.dll
libgtkmm-3.0-1.dll
libgtksourceview-3.0-1.dll
libgtksourceview-4-0.dll
libgtksourceviewmm-3.0-0.dll
libharfbuzz-0.dll
libhogweed-6.dll
libiconv-2.dll
libidn2-0.dll
libintl-8.dll
libjasper-4.dll
libjpeg-8.dll
libjson-glib-1.0-0.dll
liblzma-5.dll
libnettle-8.dll
libp11-kit-0.dll
libpango-1.0-0.dll
libpangocairo-1.0-0.dll
libpangoft2-1.0-0.dll
libpangomm-1.4-1.dll
libpangowin32-1.0-0.dll
libpcre-1.dll
libpeas-1.0-0.dll
libpeas-gtk-1.0-0.dll
libpixman-1-0.dll
libpng16-16.dll
libproxy-1.dll
libpsl-5.dll
librsvg-2-2.dll
libsigc-2.0-0.dll
libsoup-2.4-1.dll
libsoup-gnome-2.4-1.dll
libsqlite3-0.dll
libssp-0.dll
libstdc++-6.dll
libtasn1-6.dll
libthai-0.dll
libtiff-5.dll
libunistring-2.dll
libwinpthread-1.dll
libxml++-2.6-2.dll
libxml++-3.0-1.dll
libxml2-2.dll
libxslt-1.dll
zlib1.dll
```

#### Zip Gtk Dependencies

```bash
$ pacman -S zip
$ pacman -S mingw-w64-x86_64-tar
$ cd mingw32/bin
$ zip -9 -y -r -q gtk-3.24.31-x86.zip libatk-1.0-0.dll libbrotlicommon.dll libbrotlidec.dll libbz2-1.dll libcairo-2.dll libcairo-gobject-2.dll libcairo-script-interpreter-2.dll libdatrie-1.dll libepoxy-0.dll libexpat-1.dll libffi-7.dll libfontconfig-1.dll libfreetype-6.dll libfribidi-0.dll libgailutil-3-0.dll libgcc_s_dw2-1.dll libgdk_pixbuf-2.0-0.dll libgdk-3-0.dll libgio-2.0-0.dll libglib-2.0-0.dll libgmodule-2.0-0.dll libgmp-10.dll libgobject-2.0-0.dll libgraphite2.dll libgthread-2.0-0.dll libgtk-3-0.dll libharfbuzz-0.dll libiconv-2.dll libintl-8.dll libjpeg-8.dll libjson-glib-1.0-0.dll liblzma-5.dll libp11-kit-0.dll libpango-1.0-0.dll libpangocairo-1.0-0.dll libpangoft2-1.0-0.dll libpangowin32-1.0-0.dll libpcre-1.dll libpixman-1-0.dll libpng16-16.dll librsvg-2-2.dll libssp-0.dll libstdc++-6.dll libtasn1-6.dll libthai-0.dll libtiff-5.dll libwinpthread-1.dll libxml2-2.dll zlib1.dll gdbus.exe
$ cd mingw64/bin
$ zip -9 -y -r -q gtk-3.24.31-x64.zip libatk-1.0-0.dll libatkmm-1.6-1.dll libbrotlicommon.dll libbrotlidec.dll libbz2-1.dll libcairo-2.dll libcairo-gobject-2.dll libcairo-script-interpreter-2.dll libcairomm-1.0-1.dll libcroco-0.6-3.dll libdatrie-1.dll libepoxy-0.dll libexpat-1.dll libexslt-0.dll libffi-7.dll libfontconfig-1.dll libfreetype-6.dll libfribidi-0.dll libgailutil-3-0.dll libgcc_s_dw2-1.dll libgcc_s_seh-1.dll libgdk_pixbuf-2.0-0.dll libgdk-3-0.dll libgdkmm-3.0-1.dll libgio-2.0-0.dll libgiomm-2.4-1.dll libglib-2.0-0.dll libglibmm_generate_extra_defs-2.4-1.dll libglibmm-2.4-1.dll libgmodule-2.0-0.dll libgmp-10.dll libgnutls-30.dll libgobject-2.0-0.dll libgraphite2.dll libgthread-2.0-0.dll libgtk-3-0.dll libgtkmm-3.0-1.dll libgtksourceview-3.0-1.dll libgtksourceview-4-0.dll libgtksourceviewmm-3.0-0.dll libharfbuzz-0.dll libhogweed-6.dll libiconv-2.dll libidn2-0.dll libintl-8.dll libjasper-4.dll libjpeg-8.dll libjson-glib-1.0-0.dll liblzma-5.dll libnettle-8.dll libp11-kit-0.dll libpango-1.0-0.dll libpangocairo-1.0-0.dll libpangoft2-1.0-0.dll libpangomm-1.4-1.dll libpangowin32-1.0-0.dll libpcre-1.dll libpeas-1.0-0.dll libpeas-gtk-1.0-0.dll libpixman-1-0.dll libpng16-16.dll libproxy-1.dll libpsl-5.dll librsvg-2-2.dll libsigc-2.0-0.dll libsoup-2.4-1.dll libsoup-gnome-2.4-1.dll libsqlite3-0.dll libssp-0.dll libstdc++-6.dll libtasn1-6.dll libthai-0.dll libtiff-5.dll libunistring-2.dll libwinpthread-1.dll libxml++-2.6-2.dll libxml++-3.0-1.dll libxml2-2.dll libxslt-1.dll zlib1.dll gdbus.exe
```

#### Links

```
https://www.gtk.org/docs/installations/windows#using-gtk-from-msys2-packages
https://www.msys2.org/
https://github.com/GtkSharp/GtkSharp/issues/167
```