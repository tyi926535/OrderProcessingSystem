# OrderProcessingSystem
В этом проекте представлена система построенная по архитектурному подходу REST API

Данные для подключения к SQL Server

Имя сервера:127.0.0.1,1433

Имя пользователя:sa

Пароль: ServerDB_MSSql

docker:
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=ServerDB_MSSql" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest


