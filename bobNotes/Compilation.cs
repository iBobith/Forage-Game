// Source: https://stackoverflow.com/questions/77498786/unable-to-locate-package-dotnet-sdk-8-0 

// Getting the .NET (Csharp) files from the internet
    // wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    // sudo dpkg -i packages-microsoft-prod.deb
    // rm packages-microsoft-prod.deb

// Installing .NET SDK
    // sudo apt-get update
    // sudo apt-get install -y dotnet-host
    // sudo apt-get install -y dotnet-sdk-8.0

// To test the installation, run the command `which dotnet` in your terminal;
    // The result should spit out something similar to the following:
        // /usr/bin/dotnet

// To run your code hit the shit + f5, or just f5 if you wish to debug at the same time.