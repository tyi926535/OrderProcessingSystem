# OrderProcessingSystem
В этом проекте представлена система построенная по архитектурному подходу REST API

Данные для подключения к SQL Server

Имя сервера:127.0.0.1,1433

Имя пользователя:sa

Пароль: ServerDB_MSSql

В папке sqlRequests находится файл с запросами для создания БД (SQLQuery1.sql)


Для создания контейнера с БД нужно скачать my-image2.tar и выполнить следующие команды:

docker load -i my-image2.tar

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=ServerDB_MSSql" -p 1433:1433 --name sqlserver2 -d my-image2:latest

