# First Example of Dotnet Core 6 GRPC

## Abstract

I was curious about GRPC. So I developed simple GRPC via **.NET Core 6**.

## Philosophy

Main goal is:  Develop GRPC stream to stream large files like excel files.

## Contents

- [First Example of Dotnet Core 6 GRPC](#first-example-of-dotnet-core-6-grpc)
  - [Abstract](#abstract)
  - [Philosophy](#philosophy)
  - [Contents](#contents)
  - [Features](#features)
  - [Requirements](#requirements)
    - [Docker installation](#docker-installation)
  - [Controllers (API Endpoints)](#controllers-api-endpoints)
    - [`GET` /api/v1/Health](#get-apiv1health)
    - [`POST` /api/v1/main/Converter](#post-apiv1mainconverter)
  - [Business Logic](#business-logic)
    - [Explain details?](#explain-details)
  - [Installation](#installation)
  - [Contributing](#contributing)
  - [Bug Reports \& Feature Requests](#bug-reports--feature-requests)
  - [RoadMap](#roadmap)

## Features

- Developed via **.Net Core 6**
- Uses **GRPC** for streaming large files

## Requirements

> **Note** <br />
> Currently I use **Docker version 20.10.21** and **Docker Compose version v2.6.0** <br />
> Currently I use **Docker Compose version v2.12.2** <br />
> Currently I use **Linux Ubuntu 18.06 LTS** machine on Google Cloud. <br />

### Docker installation

Docker Engine and Docker Compose must be installed. Check out on Docker's offical site.

<img src="./ProjectArch.png" >

## Controllers (API Endpoints)

### `GET` /api/v1/Health

**Parameters**

|          Name | Required |  Type   | Description                                                                                                                                                           |
| -------------:|:--------:|:-------:| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     n/a | n/a | n/a | <br/> n/a <br/><br/>                                                                     |

**Response**

```

//The tools that is used by webservice and microservices is running (online)
{
    "HostStatus": "Host is working!"
}

//The tools that is used by webservice and microservices is not running or online
{
    "HostStatus": "Host is not working!"
}

```

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

- Roadmap
