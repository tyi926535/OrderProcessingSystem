# OrderProcessingSystem
В этом проекте представлена система построенная по архитектурному подходу REST API

Данные для подключения к SQL Server

Имя сервера:127.0.0.1,1433

Имя пользователя:sa

Пароль: ServerDB_MSSql

docker run:
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=ServerDB_MSSql" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest

или 

docker run --hostname=b2b2bedad011 --user=mssql --env=ACCEPT_EULA=Y --env=MSSQL_SA_PASSWORD=ServerDB_MSSql --env=PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin --env=MSSQL_RPC_PORT=135 --env=CONFIG_EDGE_BUILD= --env=MSSQL_PID=developer --network=bridge -p 1433:1433 --restart=no --label='com.microsoft.product=Microsoft SQL Server' --label='com.microsoft.version=16.0.4165.4' --label='org.opencontainers.image.ref.name=ubuntu' --label='org.opencontainers.image.version=22.04' --label='vendor=Microsoft' --runtime=runc -d mcr.microsoft.com/mssql/server:2022-latest



