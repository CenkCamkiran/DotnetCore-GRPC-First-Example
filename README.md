# First Example of Dotnet Core 6 GRPC (Client And Server)

## Abstract

I was curious about GRPC. So I developed simple GRPC Client and Server projects via **.NET Core 6**.

## Philosophy

Main goal is:  Develop a API that has GRPC. Stream large files for example excel files etc. In this project I used excel file.

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
    - [`POST` /api/v1/main/Converter](#post-apiv1mainconverter)
  - [Business Logic](#business-logic)
    - [Explain details?](#explain-details)
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

### `POST` /api/v1/main/Converter

**Parameters**

|          Name | Required |  Type   | Description                                                                                                                                                           |
| -------------:|:--------:|:-------:| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     `file` | required | Form Data  | <br/> MP4 file to upload to API <br/><br/>                                                                     |
|     `email` | required | Form Data  | <br/> Email address to receive converted from MP4 file that sent to MP3 <br/><br/>                                                                     |

**Response**

```
//File uploaded succesfully
{
    "responseCode": 200,
    "message": "File uploaded!",
    "errorMessage": "",
    "errorCode": 0
}

//File format error
{
    "ErrorMessage": "File format must be mp4!",
    "ErrorCode": 400
}

//Error occurred while uploading the file
{
    "ErrorMessage": "Some error text",
    "ErrorCode": 500
}
```

<!-- > **Note** <br />
> :exclamation: :exclamation: :exclamation:  :exclamation: :exclamation: :exclamation: <br /> -->

## Business Logic

I used CQRS Design Pattern Web Service and other Microservices.

### Explain details?

- Details

## Installation

<!-- At the root of project, there is a folder called **'YAML-Files'**. Each folder name represents technologies that I used in this project. In that folders, there are docker-compose files corresponds to each related folder. Use them to install on **Docker Compose**.

To install the Microservices, go to **Microservices folder** and each Microservice are represented as folder name. Inside of that folders there is **docker-compose** file. Use them via creating **.env** file in your workspace or whatever you want! -->

## Contributing

I am open every advice for my project. I am planning to improve myself on **.NET Core 6, Microservices and Container Technologies**. So don't hesitate comment on my project. Every idea is plus for me.

## Bug Reports & Feature Requests

Please use the Github issues.

## RoadMap

- I want to learn more deatils about GRPC.
