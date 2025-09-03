Welcome to OmhuApp!

!How to start!

Backend:
-Download the project from GitHub
-Open the folder "taskapp-master" in Visual Studio 2022
-make sure startup item is TaskApp.API.csproj
-Start up the project (F5)
-Let it finish. This we do to download the data from omhu.com's API.
-Go to Developer Powershell
-Make sure the correct folder is targeted, for example C:\yourfile\yourrepo\omhuapp\taskapp-master
-It should automatically be targeted, but if not write: cd C:\yourfile\yourrepo\omhuapp\taskapp-master 
(change it to actual path)
-if you have spaces in the path you need single brackets around path like this: 
cd 'C:\yourfile\yourrepo\omhuapp\taskapp-master.'
-in the Developer Powershell, write: dotnet run
-Your backend is now running.

Frontend:
-Open the folder "Frontend" in VS code (or vs 2022 if you don't have vs code, but I recommend vs code)
-Open terminal
-Like in backend, make sure the correct path is targeted, but ending with "frontend"
-in the terminal, write: "ng serve"
-Let it build, after build, you can now open it with http://localhost:4200 
(at the bottom of the terminal you have a line saying -> Local: "url", you can hold control and click this link)