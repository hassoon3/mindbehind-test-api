This repo contains the API part of the test project requested by Mindbehind.

To run this project, you need to:

1- install the .net core 5

1.1 - runt ``dotnet restore`` in the solution folder.

2- if you're using visual studio, make sure you have the latest version

3.1 - Please first run the DbMigrator project to initialize the DB. It's not required by our code. But required to run the project by other modules in the project.

3.2- To run the project you can run the vs project named "MindBehind.InterviewTest.HttpApi.Host"

4- if you get troubles with SSL, refer to this guide: https://stackoverflow.com/a/64776368

5- You will be able to see the swagger api explorer and test the api

6- For detailed documentation about the project structure, you can refer to the apb.io

7- The src folder contain the code of the application, where the test folder contains the test projects. Tests are done using xUnit for unit testing, NSubstitue for mocking, and Shoudly for assertion.

8- you may find some sample files in the projects left from the template. Please ignore them.

9- The external API url is provided to the application as settings. The default value was set as "https://myjson-server.typicode.com/typicode/demo/comments" but settings in the ASP.Net core can overriden from config files as well as db setting tables

------------------------------------------------

**• Create a controller action that can be reached using the path /comment and HTTP GET method and will use the next service function to return the comments to the caller**

**• Create another action inside the same controller that can be reached using the path /comment/{id} and HTTP DELETE method**

The project contains an (application service) named "CommentsAppService". It has two methods that correspond to the required endpoints.

**• Create a service class that fetches comments from the following API endpoint (https://myjson-server.typicode.com/typicode/demo/comments) And return them to the first action controller**

Refer to the "ExternalAPIAppService.cs" with is responsable for fetching data from the external API

**• Use dependency injection for each previous component**

The forementioned services are contained in a module, so they gets injected when the host module depneds on them. From the framework documention:

> ABP's Dependency Injection system is developed based on Microsoft's dependency injection extension library (Microsoft.Extensions.DependencyInjection nuget package). So, it's documentation is valid in ABP too.

**• Use united way to return formatted error messages in case of exception**

The framework uses a united way to return error messages apon exceptions. You can check the format in the swagger page. The Delete method in the Comments service throws an exception so you can test it.

**• Use a logging service using one of the libraries you prefer, and add some logs when needed**

Logging in this framework is done using the famous SeriLog library. And available through out the app stack.

**• Use middleware that will increase a number in the request header “MB_COUNT” for each request and return it in the response**

Refer to the MindBehind.InterviewTest.Startup class. The middleware was defined in the ``Configure`` method

**• Creating unit tests as follows:**

**o Make a unit test to make sure controller function reachable**

The api for the Comments service is generated automatially by the framework. So I skipped testing it.

**o Make a unit test by Mocking the call to the previous endpoint to check that the service is calling the right endpoint**

In the test folder, refer to the "CommentAppServiceTests.cs" in the "MindBehind.InterviewTest.Application.Tests" project

**• Create a Docker file to build the project into a Docker image**
ASP.Net core apps can be dockerized and there are multiple images provided by microsoft to run it. I skipped this part for the lack of time.