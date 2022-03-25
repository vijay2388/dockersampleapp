FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app

COPY buildoutput/. /app/

EXPOSE 80

CMD ["dotnet","dockersampleapp.dll"]