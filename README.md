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
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput -Recurse } ; dotnet tool run dotnet-stryker ; C:\\Program` Files\\Mozilla` Firefox\\firefox.exe \"${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput\\$(ls -Name ${workspaceFolder}\\test\\DataTools.Tests.Unit\\StrykerOutput\\ | Select-Object -First 1)\\reports\\mutation-report.html\"",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests.Unit/"
                }
            },
            "linux": {
                "command": "rm -rf ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput && dotnet-stryker --reporter \"html\" && firefox ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/`\"/reports/mutation-report.html || wslview ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/\"`ls ${workspaceFolder}/test/DataTools.Tests.Unit/StrykerOutput/`\"/reports/mutation-report.html",
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
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput -Recurse } ; dotnet tool run dotnet-stryker ; C:\\Program` Files\\Mozilla` Firefox\\firefox.exe \"${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput\\$(ls -Name ${workspaceFolder}\\test\\DataTools.Tests.Integration\\StrykerOutput\\ | Select-Object -First 1)\\reports\\mutation-report.html\"",
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
                "command": "dotnet publish src\\DataTools\\DataTools.csproj -c Release -r win10-x64 -o src\\DataTools\\bin\\Release\\netcoreapp3.1\\win10-x64\\ /p:UseAppHost=true /p:PublishSingleFile=true /p:PublishTrimmed=true"
            },
            "linux": {
                "command": "dotnet publish src/DataTools/DataTools.csproj -c Release -r linux-x64 -o src/DataTools/bin/Release/netcoreapp3.1/linux-x64/ /p:UseAppHost=true /p:PublishSingleFile=true /p:PublishTrimmed=true"
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

#### Links

```
```