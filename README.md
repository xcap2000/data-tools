# Data Tools

The aim of this project is to create data related tools to import, export and convert data to and from diverse source and destinations.

After clonning be sure to run the following tasks (on vscode press ctrl+shift+b):

```
all: restore
all: tool restore
```

And initialize git flow with defaults:

```bash
$ git flow init
```

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
$ dotnet new winforms -n DataTools -o src/DataTools
$ dotnet add src/DataTools/DataTools.csproj package Microsoft.CodeAnalysis.CSharp.Workspaces --version 4.0.1
$ dotnet add src/DataTools/DataTools.csproj package Autofac --version 6.3.0
$ dotnet add src/DataTools/DataTools.csproj package Roslynator.Analyzers --version 3.2.2
$ dotnet add src/DataTools/DataTools.csproj package Prism.Core --version 8.1.97
$ dotnet add src/DataTools/DataTools.csproj package Microsoft.EntityFrameworkCore.Design --version 6.0.16
$ dotnet add src/DataTools/DataTools.csproj package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.16
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

#### Creating The Test Project

```bash
$ mkdir test/DataTools.Tests
$ dotnet new xunit -n DataTools.Tests -o test/DataTools.Tests
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj reference src/DataTools/DataTools.csproj
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package Autofac --version 6.3.0
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package Microsoft.CodeAnalysis.CSharp.Workspaces --version 4.0.1
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package coverlet.msbuild --version 3.1.0
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package Roslynator.Analyzers --version 3.2.2
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package NSubstitute --version 4.2.2
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package NSubstitute.Analyzers.CSharp --version 1.0.15
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.16
$ dotnet add test/DataTools.Tests/DataTools.Tests.csproj package MockQueryable.NSubstitute --version 6.0.1
```

Edit src/DataTools.Tests/DataTools.Tests.csproj to configure it as following:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    ...
    <Version>0.1.0</Version>
    <Authors>Carlos Adriano Portes</Authors>
    <Company>Carpe Diem</Company>
    <Product>RefreshMaint</Product>
    <PackageId>DataTools.Tests</PackageId>
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
    <CodeAnalysisRuleSet>DataTools.Tests.ruleset</CodeAnalysisRuleSet>
    <GenerateFullPaths>true</GenerateFullPaths>
    ...
  </PropertyGroup>
  ...
</Project>
```

Create a file named stryker-config.all.json with the following contents:

```json
{
    "stryker-config": {
        "solution": "../../DataTools.sln",
        "project": "DataTools.csproj",
        "reporters": [
            "html"
        ],
        "mutate": [
            "!**/*Module.cs"
        ]
    }
}
```

Create a file named stryker-config.unit.json with the following contents:

```json
{
    "stryker-config": {
        "solution": "../../DataTools.sln",
        "project": "DataTools.csproj",
        "test-case-filter": "Category=Unit",
        "reporters": [
            "html"
        ],
        "mutate": [
            "!**/*Module.cs"
        ]
    }
}
```

Create a file named stryker-config.integration.json with the following contents:

```json
{
    "stryker-config": {
        "solution": "../../DataTools.sln",
        "project": "DataTools.csproj",
        "test-case-filter": "Category=Integration",
        "reporters": [
            "html"
        ],
        "mutate": [
            "!**/*Module.cs"
        ]
    }
}
```

Create a file named stryker-config.e2e.json with the following contents:

```json
{
    "stryker-config": {
        "solution": "../../DataTools.sln",
        "project": "DataTools.csproj",
        "test-case-filter": "Category=e2e",
        "reporters": [
            "html"
        ],
        "mutate": [
            "!**/*Module.cs"
        ]
    }
}
```

#### Creating The Solution

```bash
$ dotnet new sln -n DataTools
$ dotnet sln DataTools.sln add src/DataTools/DataTools.csproj
$ dotnet sln DataTools.sln add test/DataTools.Tests/DataTools.Tests.csproj
```

#### Creating The Ruleset Configuration File

Create the files src/DataTools/DataTools.ruleset, test/DataTools.Tests/DataTools.Tests.ruleset with the following contents:

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
            "program": "${workspaceFolder}/src/DataTools/bin/Debug/net6.0-windows/data-tools.dll",
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
        "**/sqltools*": true,
        "**/**csproj.user": true,
        "**/stryker-config*.json": true,
        "**/DataTools.db": true
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
            "label": "all: tool restore",
            "type": "shell",
            "group": "build",
            "command": "dotnet tool restore",
            "problemMatcher": "$msCompile",
            "presentation": {
                "reveal": "silent"
            }
        },
        {
            "label": "test: all",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
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
            "label": "test: all (watch)",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "isBackground": true,
            "windows": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
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
            "label": "test: all mutation coverage",
            "type": "shell",
            "group": "test",
            "isBackground": true,
            "windows": {
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput -Recurse } ; dotnet stryker --open-report --config-file stryker-config.all.json",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests/"
                }
            },
        },
        {
            "label": "test: unit",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "--filter",
                    "Category=Unit",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
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
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
                    "test",
                    "--filter",
                    "Category=Unit",
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
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput -Recurse } ; dotnet stryker --open-report --config-file stryker-config.unit.json",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests/"
                }
            },
        },
        {
            "label": "test: integration",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "--filter",
                    "Category=Integration",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
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
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
                    "test",
                    "--filter",
                    "Category=Integration",
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
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput -Recurse } ; dotnet stryker --open-report --config-file stryker-config.integration.json",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests/"
                }
            }
        },
        {
            "label": "test: e2e",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "windows": {
                "args": [
                    "test",
                    "--filter",
                    "Category=e2e",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
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
            "label": "test: e2e (watch)",
            "type": "process",
            "group": "test",
            "command": "dotnet",
            "isBackground": true,
            "windows": {
                "args": [
                    "watch",
                    "--project",
                    "${workspaceFolder}\\test\\DataTools.Tests\\DataTools.Tests.csproj",
                    "test",
                    "--filter",
                    "Category=e2e",
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
            "label": "test: e2e mutation coverage",
            "type": "shell",
            "group": "test",
            "isBackground": true,
            "windows": {
                "command": "If (Test-Path ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput) { rm ${workspaceFolder}\\test\\DataTools.Tests\\StrykerOutput -Recurse } ; dotnet stryker --open-report --config-file stryker-config.e2e.json",
                "options": {
                    "cwd": "${workspaceFolder}/test/DataTools.Tests/"
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
                "command": "dotnet publish src\\DataTools\\DataTools.csproj -c Debug -r win10-x64 --self-contained -o src\\DataTools\\bin\\Release\\net6.0-windows\\win10-x64\\ /p:UseAppHost=true /p:PublishSingleFile=true"
            }
        }
    ]
}
```

#### Adding Stryker

To add Stryker locally:

```bash
$ dotnet new tool-manifest
$ dotnet tool install dotnet-stryker --version 3.4.0
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

#### Adding EF Tool

To add EF Tool locally:

```bash
$ dotnet new tool-manifest
$ dotnet tool install dotnet-ef --version 6.0.16
```

To update EF Tool:

```bash
$ dotnet tool update dotnet-stryker
```

To restore EF Tool:

```bash
$ dotnet tool restore
```

To run EF Tool:

```bash
$ dotnet tool run dotnet-ef
# or 
$ dotnet dotnet-ef
```

To remove EF Tool:

```bash
$ dotnet tool uninstall dotnet-ef
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

#### Entity Framework

```bash
$ dotnet ef migrations add Initial --context TasksContext --output-dir Tasks/Contexts/Migrations/Sqlite # in project folder
$ dotnet ef database update --context TasksContext
```


#### Links

```
https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers?tabs=dotnet-core-cli
https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ilistsource?view=net-7.0&viewFallbackFrom=windowsdesktop-7.0
https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ibindinglist?view=net-7.0&viewFallbackFrom=windowsdesktop-7.0
```