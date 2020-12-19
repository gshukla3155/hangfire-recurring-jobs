# Hangfire Background Jobs - Recurring

# Introduction

Hangfire is an open-source framework that helps you to create, process and manage your background jobs, i.e. operations you don't want to put in your request processing pipeline.
Hangfire supports all kind of background tasks – short-running and long-running, CPU intensive and I/O intensive, one shot and recurrent.

For more information visit here
[https://www.hangfire.io/](https://www.hangfire.io/)

# Components

Hangfire allows you to kick off method calls outside of the request processing pipeline in a very easy, but reliable way. These method invocations are performed in a background thread and called background jobs.

Mainly three components:

* Client
* Server
* Storage

# About Project

The repository is meant to showcase how we can configure Hangfire to perform background recurring jobs in Console application. The console application is built with topshelf and running on self hosted port. The hangfire also has its own dasboard where you can see connected servers, recurring jobs, succeeded & failed jobs etc.

![image](https://user-images.githubusercontent.com/70849493/102690001-89071580-4228-11eb-918a-d6f9da0c9fe1.png)


![image](https://user-images.githubusercontent.com/70849493/102690038-b94eb400-4228-11eb-9e0d-189b22a2e82c.png)


![image](https://user-images.githubusercontent.com/70849493/102690052-cec3de00-4228-11eb-8825-230e6b44df8a.png)
