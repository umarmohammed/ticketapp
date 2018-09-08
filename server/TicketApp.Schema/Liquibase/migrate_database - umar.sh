#!/bin/sh
liquibase --driver=com.microsoft.sqlserver.jdbc.SQLServerDriver \
      --classpath="C:\tools\Microsoft JDBC Driver 4.2 for SQL Server\sqljdbc_4.2\enu\jre8\sqljdbc42.jar" \
      --changeLogFile=./db.changelog-master.xml \
      --url="jdbc:sqlserver://localhost:58247;databaseName=TicketApp_db" \
      --username=umar \
      --password=Password123 \
      migrate
