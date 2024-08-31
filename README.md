To use .http files in another solution copy the "rest-client.environmentVariables" field from .vscode/settings.json.

To change the variables used by .http file for test on vscode with Rest Client extension, press Ctrl+Shift+P -> Rest Client: Switch Environment -> choose one of the environments created on settings.json

You can choose which projects add to your solution by copping the project folder to you .sln root folder and execute the following command on the .sln root folder with powerShell:
"dotnet sln add (ls -r **/*.csproj)"
