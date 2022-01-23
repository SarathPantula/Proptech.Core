#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Proptech.SubModules/Proptech.SubModules.csproj", "Proptech.SubModules/"]
RUN dotnet restore "Proptech.SubModules/Proptech.SubModules.csproj"
COPY . .
WORKDIR "/src/Proptech.SubModules"
RUN dotnet build "Proptech.SubModules.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Proptech.SubModules.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Proptech.SubModules.dll"]