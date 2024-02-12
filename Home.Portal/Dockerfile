#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Components/FrontEnd/Portal/Home.Portal/Home.Portal.csproj", "Components/FrontEnd/Portal/Home.Portal/"]
COPY ["Components/FrontEnd/Portal/Shared.Portal/Shared.Portal.csproj", "Components/FrontEnd/Portal/Shared.Portal/"]
COPY ["Components/Framework/Core/Core.csproj", "Components/Framework/Core/"]

RUN dotnet restore "Components/FrontEnd/Portal/Home.Portal/Home.Portal.csproj"
COPY . .

COPY ["Manuals/FactStoreV1.pdf", "Components/FrontEnd/"]


WORKDIR "/src/Components/FrontEnd/Portal/Home.Portal"

RUN dotnet build "Home.Portal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Home.Portal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Home.Portal.dll"]