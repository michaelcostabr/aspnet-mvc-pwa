# aspnet-mvc-pwa

An ASP.Net MVC project, with Progressive Web App support.

Although I'd rather go with an JS project, like using React or Polymer, for some situatons where the only framework available is the Microsoft .Net, it is totally possible to use the benefits of PWA, such as service workers, offline cache, add to home screen feature, and so on.

To to so, I basically created a file-new project, selected the Asp.Net MVC template, and made the adjustments to enable PWA features. All based on the Google Lighthouse recommendations.

In a nutshell, this is what a did:

1) Added a [service-worker](./aspnet-mvc-pwa/service-worker.js), and instructed to cache the basic routes of the app;
2) Added a [manifest.json](./aspnet-mvc-pwa/manifest.json) file, to declare title, icons and other PWA characteristics;
3) At the [Views/Shared/_Layout.cshtml](./aspnet-mvc-pwa/Views/Shared/_Layout.cshtml), added at the <head> section, the manifest reference, and the meta tags for PWA features;
4) Still at [Views/Shared/_Layout.cshtml](./aspnet-mvc-pwa/Views/Shared/_Layout.cshtml), added above the </body>, the script to register the serviceWorker;
5) Created a [SSLFilter](./aspnet-mvc-pwa/SSLFilter.cs) Filter to prevent the app from being used over HTTP (HTTPs is an requisite of PWA);
6) Added the filter to the RegisterGlobalFilters method of [./App_Start/FilterConfig.cs](./aspnet-mvc-pwa/App_Start/FilterConfig.cs) file.

To test is against LightHouse, it is necessary to deploy it to an webserver intead of running throught IIS Express, otherwise it will not attend to the HTTPs requirement.

Questions: Michael Costa - michaelbh@gmail.com
