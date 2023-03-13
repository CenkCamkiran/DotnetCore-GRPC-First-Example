# First Example of Dotnet Core 6 GRPC (Client And Server)

## Abstract

I was curious about GRPC. So I developed simple GRPC Client and Server projects via **.NET Core 6**.

## Philosophy

Main goal is: Develop a API that has GRPC. Stream large files for example excel files etc. In this project I used excel file.

## Contents

- [First Example of Dotnet Core 6 GRPC (Client And Server)](#first-example-of-dotnet-core-6-grpc-client-and-server)
  - [Abstract](#abstract)
  - [Philosophy](#philosophy)
  - [Contents](#contents)
  - [Features](#features)
  - [Requirements](#requirements)
    - [Docker installation](#docker-installation)
    - [Excel File to Stream Large Data](#excel-file-to-stream-large-data)
  - [Services (API Endpoints)](#services-api-endpoints)
    - [GetSalesData Method](#getsalesdata-method)
  - [Business Logic](#business-logic)
    - [GRPC Client](#grpc-client)
    - [GRPC Server](#grpc-server)
  - [Installation](#installation)
  - [Contributing](#contributing)
  - [Bug Reports \& Feature Requests](#bug-reports--feature-requests)
  - [RoadMap](#roadmap)

## Features

- Developed via **.Net Core 6**
- Uses **GRPC** for streaming large files for example excel file etc.

## Requirements

> **Note** <br />
> Currently I use **Docker version 20.10.21** and **Docker Compose version v2.6.0** <br />
> Currently I use **Linux Ubuntu 18.06 LTS** machine on Google Cloud. <br />

### Docker installation

Docker Engine and Docker Compose must be installed. Check out on Docker's offical site.

### Excel File to Stream Large Data

- Download excel file from this site: <https://eforexcel.com/wp/wp-content/uploads/2020/09/5m-Sales-Records.zip>
- Move file to **"GRPC_Server/bin/Debug/net6.0 directory"**. Rename file as **"sales_records.csv"**

## Services (API Endpoints)

### GetSalesData Method

**Parameters**

|          Name | Required |  Type   | Description                                                                                                                                                           |
| -------------:|:--------:|:-------:| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     n/a | n/a | n/a | <br/> n/a <br/><br/>                                                                     |

**Response**

```
Content of Excel file will be streamed to client. You can see from console.
```

> **Note** <br />
> :exclamation: :exclamation: :exclamation: I used deadline as 5 seconds from Now. You can remove it or change it to whatever you want :exclamation: :exclamation: :exclamation: <br />

## Business Logic

I didn't use any design patterns. This project is for learning about GRPC.

### GRPC Client

1. Connect to **GRPC Server**.
2. Invoke **GetSalesData** Method without filter. I used deadline but you can change or remove it.
3. Read messages until all the messages are fetched. Actually read excel file line by line (one row at a time) via GRPC Stream and print on console.
4. If stream ended print total number of records from excel file that streamed via GRPC.
5. If deadline or exception occurs print exception message

### GRPC Server

- Details

## Installation

Explain via Docker?

## Contributing

I am open every advice for my project. I am planning to improve myself on **.NET Core 6, Microservices and Container Technologies**. So don't hesitate comment on my project. Every idea is plus for me.

## Bug Reports & Feature Requests

Please use the Github issues.

## RoadMap

- I want to learn more details about GRPC.
