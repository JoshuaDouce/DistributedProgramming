# DistributedProgramming

This is a simple chat application. 
* It allows users to register using multiple authentication mechanisms
* Allows user to chat with a bot
* Allows user to chat with other people 

## Requirements

* .NET Core 3.0+

## Recomended

* Visual Studio 2019 v16.3.10+

## Getting Started

In order to fully utilize the app in a local development environment you will need to do the following

1. Enable the Secret Manager Tool for the SignalRWithAuth project
  * run command dotnet user-secrets init
  * Go to the root of the project folder (you can do this by right clicking the project and open folder location if using VS2019)
2. Follow steps for Create a Google API Console project and Client ID <a href="https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-3.0">here</a>
3. Once set up run the 2 commands below with id and secret from Google.
  * dotnet user-secrets set "Authentication:Google:ClientId" "client id".
  * dotnet user-secrets set "Authentication:Google:ClientSecret" "client secret".
4. You should now be able to run the SignalRWithAuth project.
5. You will also need to run the BotApi Project.
6. Once both are running you can open the SignalRWithAuth project in multiple tabs using an incognito window effectively creating a global chat room.
7. You can then communicate between users or send a message to the bot.
