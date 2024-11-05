![Oracle Logo](https://raw.githubusercontent.com/oracle/dotnet-db-samples/master/images/oracle-nuget.png) 
# Oracle.ManagedDataAccess 23.6.0
Release Notes for Oracle Data Provider for .NET, Managed Driver NuGet Package

September 2024

Managed Oracle Data Provider for .NET (ODP.NET) features optimized ADO.NET data access to the Oracle database for .NET Framework and is 100% managed code. ODP.NET allows developers to take advantage of advanced Oracle database functionality, including AI vectors, Real Application Clusters, Application Continuity, JSON Relational Duality, and Fast Connection Failover. 

This document provides information that supplements the [Oracle Data Provider for .NET (ODP.NET) documentation](https://docs.oracle.com/en/database/oracle/oracle-database/23/odpnt/index.html).

## Oracle .NET Links
* [Oracle .NET Home Page](https://www.oracle.com/database/technologies/appdev/dotnet.html)
* [GitHub - Sample Code](https://github.com/oracle/dotnet-db-samples)
* [ODP.NET Discussion Forum](https://forums.oracle.com/ords/apexds/domain/dev-community/category/odp-dot-net)
* [YouTube](https://www.youtube.com/user/OracleDOTNETTeam)
* [X (Twitter)](https://twitter.com/oracledotnet)
* [Email Newsletter Sign Up](https://go.oracle.com/LP=28277?elqCampaignId=124071&nsl=onetdev)

## New Features
* Eliminate exception when using Transparent Application Failover (TAF) SELECT mode (starting with 23.5.1)
* BINARY Vector Support
* IsFloatingPointNumber Schema Table Column Support
* Data Source Allowed Parameters Support
* Allow UNC Paths Support
* OpenTelemetry: ActivitySource.Version Support
* OpenTelemetry: SQL Normalization Support
* OpenTelemetry: db.odp.user.statement Tag Support
* AutoProxy Support
* SSL-related OracleConnection Property Support
* Azure Credentials Support for Service Principal Authentication Flow 
* SQLNET.IGNORE_ANO_ENCRYPTION_FOR_TCPS Support

## Bug Fixes since Oracle.ManagedDataAccess.Core 23.5.0
* Bug 37054477 - KEEPALIVE: TURNING ON KEEPALIVE SUCCEEDED BUT NO KEEPALIVE PACKAGES ON LINUX
* Bug 37013827 - PROVIDER SPECIFIC TYPE OBJECTS' TOSTRING() METHODS ARE NOT SENSITIVE TO SESSION'S NLS FORMAT SETTINGS
* Bug 36937681 - ORA-00917 MISSING COMMA ERROR WHEN USING Ø CHARACTER WITH CHARACTER SET ZHS16GBK 
* Bug 36913251 - EXCEPTION THROWN WHEN ODPM/C 23AI CONFIGURED FOR TAF SELECT FAILOVER 
* Bug 36831777 - LDAP: SPACE BETWEEN DIRECTORY SERVERS IN DIRECTORY_SERVERS CAUSES ORA-12154
* Bug 36736236 - SETTING THE PORT WHEN USING NOTIFICATIONS CAUSES ORA-50050: THE NOTIFICATION LISTENER IS ALREADY STARTED
* Bug 36656255 - STATEMENT CACHING NOT PROPERLY HANDLING UNDERLYING TABLE CHANGES

## Installation Changes
The following app/web.config entries are added when installing the managed ODP.NET NuGet package to your application:

1) Configuration Section Handler

A configuration section handler entry is added to the app/web.config to enable applications to add an <oracle.manageddataaccess.client> 
section for ODP.NET, Managed Driver-specific configuration.

Note: For a web app, if the same config section handler for "oracle.manageddataaccess.client" also exists in machine.config but the "Version" attribute values are different, an error message "There is a duplicate 'oracle.manageddataaccess.client' section defined." may be observed at runtime. To resolve the error, remove the "oracle.manageddataaccess.client" config section handler entry in the machine.config. If other applications on the machine depend on this machine.config entry, move the config section handler entry to each application's web.config file.

2) DbProviderFactories

The DbProviderFactories entry is added for applications that use DbProviderFactories and DbProviderFactory classes. Any DbProviderFactories entry for "Oracle.ManagedDataAccess.Client" in the machine.config will be ignored. 

3) Dependent Assembly

The dependent assembly entry is created to ignore policy DLLs for Oracle.ManagedDataAccess.dll. It directs the app to always use the Oracle.ManagedDataAccess.dll version that is specified by the "newVersion" attribute in the "bindingRedirect" element. The "newVersion" attribute corresponds to the Oracle.ManagedDataAccess.dll version which came with the NuGet package.

4) Data Sources

The data sources entry is added to provide a template on how a data source can be configured in the app/web.config. 
Simply rename the sample data source to an alias of your choosing; modify the PROTOCOL, HOST, PORT, SERVICE_NAME as required; 
and un-comment the "dataSource" element. Once that is done, the alias can be used as the "data source" attribute in 
your ODP.NET connection string.


 Copyright (c) 2024, Oracle and/or its affiliates.
