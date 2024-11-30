# OrderProcessingSystem
В этом проекте представлена система построенная по архитектурному подходу REST API

Данные для подключения к SQL Server

Имя сервера:127.0.0.1,1433

Имя пользователя:sa

Пароль: ServerDB_MSSql

В папке sqlRequests находится файл с запросами для создания БД (SQLQuery1.sql) и файл сля создания контейнера (my-image2.tar)

Команды для создания контейнера:

docker load -i my-image2.tar

docker run --name sqlServer2 -d my-image2:latest

