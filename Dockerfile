FROM microsoft/dotnet:2.2-sdk as build

COPY . /src
RUN dotnet publish /src/sample-netcore-app.csproj --configuration release --output /publish
    
FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine

WORKDIR /app
COPY --from=build /publish /app

ENV ASPNETCORE_URLS http://+:8080
CMD ["dotnet", "/app/sample-netcore-app.dll"]
EXPOSE 8080
