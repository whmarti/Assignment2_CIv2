FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
RUN MKDIR LoginApp
WORKDIR /app/LoginApp/
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS publish


COPY *.csproj /app/LoginApp/

WORKDIR /app/LoginApp/
RUN dotnet restore 

COPY . .
RUN MKDIR out
RUN dotnet publish  -c Release -o /app/LoginApp/out

FROM base AS final
WORKDIR /app/LoginApp/out
COPY --from=publish /app/LoginApp/out .
ENTRYPOINT ["dotnet", "LoginWebApp.dll"]