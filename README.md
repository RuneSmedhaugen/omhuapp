# Welcome to OmhuApp!

## How to start

### Backend
- Download the project from GitHub  
- Open the folder **`taskapp-master`** in Visual Studio 2022  
- Make sure startup item is **TaskApp.API.csproj**  
- Start up the project (F5)  
- Let it finish. This we do to download the data from omhu.com's API.  
- Go to **Developer Powershell**  
- Make sure the correct folder is targeted, for example:  
- It should automatically be targeted, but if not write:  cd path/where/its/saved/taskapp-master
*(change it to actual path)*  
- If you have spaces in the path you need single quotes around it:  cd 'path with spaces/taskapp-master'
- In Developer Powershell, run:  dotnet run
- ✅ Your backend is now running.

### Frontend
- Open the folder **`Frontend`** in VS Code  
*(or VS 2022 if you don’t have VS Code, but I recommend VS Code)*  
- Open terminal  
- Like in backend, make sure the correct path is targeted, but ending with **frontend**  
- In the terminal, run:  ng serve
- Let it build. After build, you can now open:  
👉 [http://localhost:4200](http://localhost:4200)  

*(At the bottom of the terminal you’ll also see a line like → `Local: http://localhost:4200` — you can Ctrl+Click it.)*
