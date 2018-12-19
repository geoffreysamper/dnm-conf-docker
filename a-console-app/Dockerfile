FROM microsoft/dotnet:2.1-sdk AS build
RUN mkdir /src
WORKDIR /src
COPY . ./
RUN dotnet publish ./a-console-app.csproj -o /tmp/app/  -c Release
WORKDIR /tmp/app/
ENTRYPOINT ["dotnet", "a-console-app.dll"]
 
 