English | [简体中文](./README-CN.md)


<p align="center">
<a href=" https://www.alibabacloud.com"><img src="https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg"></a>
</p>

<h1 align="center">Alibaba Cloud SDK for C#</h1>

<p align="center">
<a href="https://travis-ci.org/aliyun/aliyun-openapi-net-sdk"><img src="https://travis-ci.org/aliyun/aliyun-openapi-net-sdk.svg?branch=master" alt="Travis Build Status"></a>
<a href="https://ci.appveyor.com/project/aliyun/aliyun-openapi-net-sdk"><img src="https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?svg=true" alt="Appveyor Build Status"></a>
<a href="https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk"><img src="https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/branch/master/graph/badge.svg" alt="Codecov"></a>
<a href="https://badge.fury.io/nu/aliyun-net-sdk-core"><img src="https://badge.fury.io/nu/aliyun-net-sdk-core.svg" alt="Nuget Version"></a>
<a href="https://www.nuget.org/packages/aliyun-net-sdk-core/"><img src="https://img.shields.io/nuget/dt/aliyun-net-sdk-core.svg?label=Nuget%20Download&style=flat" alt="Nuget Version"></a>
<a href="https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/LICENSE"><img src="https://img.shields.io/badge/License-Apache%202.0-blue.svg" alt="Nuget Version"></a>
</p>


The Alibaba Cloud Client for C# (SDK) allows you to access Alibaba Cloud services such as Elastic Compute Service (ECS), Server Load Balancer (SLB), and CloudMonitor. You can access Alibaba Cloud services without the need to handle API related tasks, such as signing and constructing your requests.


## Online Demo
[OpenAPI Explorer](https://api.aliyun.com/#/?product=Ecs&api=DescribeAccessPoints&params={}&tab=DEMO&lang=CSHARP) provides the ability to call the cloud product OpenAPI online, and dynamically generate SDK Example code and quick retrieval interface, which can significantly reduce the difficulty of using the cloud API.


## Requirements
- The Alibaba Cloud C# SDK is requires：
    - **`.NET Framework 4.6.1`** or later
    - **`.NET Standard 2.0`** or later


## Installation
You must install the SDK core Nuget Package for any SDK you use. For example, to call the ECS product, you must install both the [ECS Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ecs/) and the [SDK core Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-core/).

Use Package Manager

    Install-Package aliyun-net-sdk-core
    Install-Package aliyun-net-sdk-ecs

Use .NET CLI

    dotnet add package aliyun-net-sdk-core
    dotnet add package aliyun-net-sdk-ecs


## Quick Examples
Before you begin, you need to sign up for an Alibaba Cloud account and retrieve your [Credentials](https://usercenter.console.aliyun.com/#/manage/ak).
>**Note:** To increase the security of your account, we recommend that you use the AccessKey of the RAM user to access Alibaba Cloud services.

### Initiate a call

The following code example shows the three main steps to use the Alibaba Cloud C# SDK:

- Create and initialize a DefaultAcsClient instance.

- Create a request and set parameters.

- Initiate the request and handle the response.

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class Program
{
    static void Main(string[] args)
    {
        // Create a client used for initiating a request
        IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");
        DefaultAcsClient client = new DefaultAcsClient(profile);

        try
        {
            // Create the request
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            request.PageSize = 10;

            // Initiate the request and get the response
            DescribeInstancesResponse response = client.GetAcsResponse(request);
            System.Console.WriteLine(response.TotalCount);
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

### Use BearerToken to invoke [CCC](https://www.nuget.org/packages/aliyun-net-sdk-ccc/) Product
You should install the relative Nuget Package, as it said before, when you are running the test demo in your local machine.

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.CCC.Model.V20170705;

class Program
{
    static void Main(string[] args)
    {
        // Create a client used for initiating a request
        IClientProfile profile = DefaultProfile.GetProfile("<your-region-id>");
        BearerTokenCredential bearerTokenCredential = new BearerTokenCredential("<your-bearertoken>");

        DefaultAcsClient client = new DefaultAcsClient(profile, bearerTokenCredential);

        try
        {
            // Create the request
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest();

            // Initiate the request and get the response
            var response = client.GetAcsResponse(request);
            
            //Do something as you want below
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```


## Documentation
* [Requirements](docs/0-Requirements-EN.md)
* [SSL Verify](docs/1-Verify-EN.md)
* [Debug](docs/2-Debug-EN.md)
* [Proxy](docs/3-Proxy-EN.md)
* [Timeout](docs/4-Timeout-EN.md)


## Issues
[Opening an Issue](https://github.com/aliyun/aliyun-openapi-net-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.


## Changelog
Detailed changes for each release are documented in the [release notes](aliyun-net-sdk-core/ChangeLog.txt).


## Product Nuget Packages And Details
Alibaba Cloud C# SDK Product Nuget Packages:

- [aliyun-net-sdk-alidns](https://www.nuget.org/packages/aliyun-net-sdk-alidns/)
  - Alibaba Cloud DNS (Domain Name System) helps enterprises and developers translate human-readable domain names into machine readable IP addresses for intercommunication. It then routes user requests to the corresponding websites or application servers.
- [aliyun-net-sdk-alimt](https://www.nuget.org/packages/aliyun-net-sdk-alimt/)
  - Alibaba Machine Translation is an online intelligent machine translation service created by Alibaba. Relying on leading natural language processing technology and massive Internet data advantages, Alibaba successfully launched a deep neural network translation system (NMT) based on attention mechanism to help users to cross the language gap, enjoy communication and access information, and achieve barrier-free communication. 
- [aliyun-net-sdk-arms](https://www.nuget.org/packages/aliyun-net-sdk-arms/)
  - Application Real-Time Monitoring Service (ARMS) is an end-to-end Alibaba Cloud monitoring service for Application Performance Management (APM). You can quickly develop real-time business monitoring capabilities using the frontend monitoring, application monitoring, and custom monitoring features provided by ARMS.
- [aliyun-net-sdk-arms4finance](https://www.nuget.org/packages/aliyun-net-sdk-arms4finance/)
- [aliyun-net-sdk-baas](https://www.nuget.org/packages/aliyun-net-sdk-baas/)
  - Alibaba Cloud BaaS (Blockchain as a Service ) is an enterprise-level PaaS (Platform as a Service) based on leading blockchain technologies. This service helps you build a stable, secure blockchain environment, and manage the deployment, operation, maintenance, and development of blockchains easily. Alibaba Cloud BaaS enables you to focus on business innovation.
- [aliyun-net-sdk-bssopenapi](https://www.nuget.org/packages/aliyun-net-sdk-bssopenapi/)
  - Alibaba Cloud BOA (BSS OpenAPI) is a comprehensive tool for managing Alibaba Cloud API operations related to Billing. You can use BOA to conveniently manage your Billing Accounts, orders, resource packages and bills during your using Alibaba Cloud services.
- [aliyun-net-sdk-cbn](https://www.nuget.org/packages/aliyun-net-sdk-cbn/)
- [aliyun-net-sdk-ccc](https://www.nuget.org/packages/aliyun-net-sdk-ccc/)
  - The Cloud Call Center is equipped with Interactive Voice Response (IVR), Automatic Call Distribution (ACD) and a number of productivity-enhancing applications such as 100% coverage smart QA, easy-to-use and powerful business intelligence, and flexible CRM integration method. 
- [aliyun-net-sdk-ccs](https://www.nuget.org/packages/aliyun-net-sdk-ccs/)
  - The Cloud Customer Service relies on cutting-edge technologies such as data mining, search, voice-to-text, natural voice processing, and machine learning to create a complete intelligent service system. 
- [aliyun-net-sdk-cdn](https://www.nuget.org/packages/aliyun-net-sdk-cdn/)
  - You can use content delivery network (CDN) to deliver content to users from the nodes that are nearest to them, accelerating the response to user requests and increasing the response rate. CDN also resolves the delivery latency problem that is usually caused by distribution, bandwidth, and server performance issues. CDN has been applied in multiple scenarios, including site acceleration, on-demand streaming, and live streaming.
- [aliyun-net-sdk-chatbot](https://www.nuget.org/packages/aliyun-net-sdk-chatbot/)
  - A chatbot is a communication interface that assists organizations and individuals to converse decisively. It is an Artificial Intelligence program that chats with you. It offers a wide range of information that might be applicable. You can also term them as software applications that mimic written or spoken human speech to stimulate a conversation. Currently, there are two primary ways chatbots are offered to visitors: via standalone apps and web-based applications.
- [aliyun-net-sdk-cloudapi](https://www.nuget.org/packages/aliyun-net-sdk-cloudapi/)
- [aliyun-net-sdk-cloudauth](https://www.nuget.org/packages/aliyun-net-sdk-cloudauth/)
  - The real person authentication service refers to the verification service of the natural person's true identity based on biometric identification technology such as living body detection, face comparison, and OCR identification technology.
- [aliyun-net-sdk-cloudesl](https://www.nuget.org/packages/aliyun-net-sdk-cloudesl/)
- [aliyun-net-sdk-cloudphoto](https://www.nuget.org/packages/aliyun-net-sdk-cloudphoto/)
  - The Cloud Photos is a one-stop solution for Alibaba Cloud for imaging applications. 
    In addition to providing basic functions such as image file storage and management, intelligent cloud photo album also supports intelligent analysis of image content classification and face recognition, and provides intelligent search service based on natural language understanding.
- [aliyun-net-sdk-cloudwf](https://www.nuget.org/packages/aliyun-net-sdk-cloudwf/)
- [aliyun-net-sdk-cms](https://www.nuget.org/packages/aliyun-net-sdk-cms/)
  - CloudMonitor is a service that monitors Alibaba Cloud resources and Internet applications. The cloud monitoring service can be used to collect monitoring metrics for obtaining Alibaba Cloud resources, detect Internet service availability, and set alerts for metrics.
- [aliyun-net-sdk-core](https://www.nuget.org/packages/aliyun-net-sdk-core/)
- [aliyun-net-sdk-cs](https://www.nuget.org/packages/aliyun-net-sdk-cs/)
  - The Container Service provides a high-performance, scalable container application management service that enables application lifecycle management through a Docker container on a set of cloud servers. 
- [aliyun-net-sdk-csb](https://www.nuget.org/packages/aliyun-net-sdk-csb/)
- [aliyun-net-sdk-dcdn](https://www.nuget.org/packages/aliyun-net-sdk-dcdn/)
  - Dynamic Route For CDN (DCDN) is a high-performance, reliable, and secure full site acceleration solution. This service aims to accelerate access to hybrid sites that use both dynamic and static resources. DCDN integrates multiple products and services, such as dynamic acceleration systems, smart static content caching, HTTPS, and operations security. You can use DCDN to both speed-up access and ensure the stability of your site.
- [aliyun-net-sdk-dds](https://www.nuget.org/packages/aliyun-net-sdk-dds/)
- [aliyun-net-sdk-dms-enterprise](https://www.nuget.org/packages/aliyun-net-sdk-dms-enterprise/)
  - Data Management supports relational databases such as MySQL, SQL Server, PostgreSQL, PPAS, and Petadata, OLTP databases such as DRDS, OLAP databases such as ADS and DLA, and NoSQL database management such as MongoDB and Redis. It also supports Linux server management.
- [aliyun-net-sdk-domain](https://www.nuget.org/packages/aliyun-net-sdk-domain/)
  - Alibaba Cloud Domain Name Service is a comprehensive domain name management platform that integrates domain name registration, transaction, resolution, monitoring and protection.intl/)
- [aliyun-net-sdk-drds](https://www.nuget.org/packages/aliyun-net-sdk-drds/)
  - Distributed Relational Database Service (DRDS) focuses on solving the problem of single-machine relational database extensibility. It is lightweight (stateless), flexible, stable, and efficient.
- [aliyun-net-sdk-dysms](https://www.nuget.org/packages/aliyun-net-sdk-dysms/)
- [aliyun-net-sdk-dyvmsapi](https://www.nuget.org/packages/aliyun-net-sdk-dyvmsapi/)
- [aliyun-net-sdk-ecs](https://www.nuget.org/packages/aliyun-net-sdk-ecs/)
  - Alibaba Cloud Elastic Compute Service (ECS) provides fast memory and the latest Intel CPUs to help you to power your cloud applications and achieve faster results with low latency. All ECS instances come with Anti-DDoS protection to safeguard your data and applications from DDoS and Trojan attacks.
- [aliyun-net-sdk-ehpc](https://www.nuget.org/packages/aliyun-net-sdk-ehpc/)
  - Elastic High Performance Computing (E-HPC) aggregates computing capabilities, and uses parallel computing to solve massive challenges of science, engineering, and business. E-HPC is applied to almost every aspect of our lives. E-HPC helps to solve problems in various fields including oil exploration, finance, emergency management, medicine, and IT.
- [aliyun-net-sdk-ess](https://www.nuget.org/packages/aliyun-net-sdk-ess/)
  - Auto Scaling is a management service that automatically adjusts elastic computing resources economically based on user's business needs and strategies. 
- [aliyun-net-sdk-green](https://www.nuget.org/packages/aliyun-net-sdk-green/)
  - Content security is a multimedia content intelligent identification service that supports diversified scene detection for images, videos, texts, voices, etc., effectively helping you reduce the risk of content violations. 

In the Meanwhile, there are various product nuget package below.For more infomation, please visit the [Alibaba Cloud Products & Services](https://www.alibabacloud.com/product) to get more detail.

- [aliyun-net-sdk-hpc](https://www.nuget.org/packages/aliyun-net-sdk-hpc/)
- [aliyun-net-sdk-hsm](https://www.nuget.org/packages/aliyun-net-sdk-hsm/)
- [aliyun-net-sdk-httpdns](https://www.nuget.org/packages/aliyun-net-sdk-httpdns/)
- [aliyun-net-sdk-imm](https://www.nuget.org/packages/aliyun-net-sdk-imm/)
- [aliyun-net-sdk-industry-brain](https://www.nuget.org/packages/aliyun-net-sdk-industry-brain/)
- [aliyun-net-sdk-iot](https://www.nuget.org/packages/aliyun-net-sdk-iot/)
- [aliyun-net-sdk-jarvis](https://www.nuget.org/packages/aliyun-net-sdk-jarvis/)
- [aliyun-net-sdk-kms](https://www.nuget.org/packages/aliyun-net-sdk-kms/)
- [aliyun-net-sdk-linkface](https://www.nuget.org/packages/aliyun-net-sdk-linkface/)
- [aliyun-net-sdk-live](https://www.nuget.org/packages/aliyun-net-sdk-live/)
- [aliyun-net-sdk-lubancloud](https://www.nuget.org/packages/aliyun-net-sdk-lubancloud/)
- [aliyun-net-sdk-mopen](https://www.nuget.org/packages/aliyun-net-sdk-mopen/)
- [aliyun-net-sdk-mts](https://www.nuget.org/packages/aliyun-net-sdk-mts/)
- [aliyun-net-sdk-nas](https://www.nuget.org/packages/aliyun-net-sdk-nas/)
- [aliyun-net-sdk-ons](https://www.nuget.org/packages/aliyun-net-sdk-ons/)
- [aliyun-net-sdk-ots](https://www.nuget.org/packages/aliyun-net-sdk-ots/)
- [aliyun-net-sdk-push](https://www.nuget.org/packages/aliyun-net-sdk-push/)
- [aliyun-net-sdk-pvtz](https://www.nuget.org/packages/aliyun-net-sdk-pvtz/)
- [aliyun-net-sdk-ram](https://www.nuget.org/packages/aliyun-net-sdk-ram/)
- [aliyun-net-sdk-rds](https://www.nuget.org/packages/aliyun-net-sdk-rds/)
- [aliyun-net-sdk-r-kvstore](https://www.nuget.org/packages/aliyun-net-sdk-r-kvstore/)
- [aliyun-net-sdk-ros](https://www.nuget.org/packages/aliyun-net-sdk-ros/)
- [aliyun-net-sdk-ros](https://www.nuget.org/packages/aliyun-net-sdk-ros/)
- [aliyun-net-sdk-saf](https://www.nuget.org/packages/aliyun-net-sdk-saf/)
- [aliyun-net-sdk-sas-api](https://www.nuget.org/packages/aliyun-net-sdk-sas-api/)
- [aliyun-net-sdk-scdn](https://www.nuget.org/packages/aliyun-net-sdk-scdn/)
- [aliyun-net-sdk-slb](https://www.nuget.org/packages/aliyun-net-sdk-slb/)
- [aliyun-net-sdk-smartag](https://www.nuget.org/packages/aliyun-net-sdk-smartag/)
- [aliyun-net-sdk-sms](https://www.nuget.org/packages/aliyun-net-sdk-sms/)
- [aliyun-net-sdk-sts](https://www.nuget.org/packages/aliyun-net-sdk-sts/)
- [aliyun-net-sdk-tag-inner](https://www.nuget.org/packages/aliyun-net-sdk-tag-inner/)
- [aliyun-net-sdk-tesladam](https://www.nuget.org/packages/aliyun-net-sdk-tesladam/)
- [aliyun-net-sdk-teslamaxcompute](https://www.nuget.org/packages/aliyun-net-sdk-teslamaxcompute/)
- [aliyun-net-sdk-teslastream](https://www.nuget.org/packages/aliyun-net-sdk-teslastream/)
- [aliyun-net-sdk-vod](https://www.nuget.org/packages/aliyun-net-sdk-vod/)
- [aliyun-net-sdk-vpc](https://www.nuget.org/packages/aliyun-net-sdk-vpc/)


## API Reference
You can visit the API and its parameters in [Product List](https://www.alibabacloud.com/en?spm=5176.10609282.1280361.9.62e538011pDOUG)


## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)
