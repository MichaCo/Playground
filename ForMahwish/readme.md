# Get it running
Ignore the AngularWeb, use the AngularWebYo.
That one is generated with `yo aspnetcore-spa`

To run it, use:

Webpack installation:
webpack is needed for HMS (hot module replacement). All angular views are pre-compiled on the server and via hms, changes get applied directly in the browser while editing the angular app/templates etc... pretty cool!
webpack will run a small webserver in the background which syncs the browser...
```
npm install -g webpack
```
The node packages have to be installed prior to run the web site...
```
npm install
```
Now run webpack configuration so that it can bundle all the things...
```
webpack --config webpack.config.vendor.js
```
Finally run the website
```
dotnet restore
dotnet run
```

Now open the page in a browser and then change one of the views, e.g. ClientApp\app\components\home\home.component.html, change the title or so... it should change the view in the browser, too!

# Docs

http://blog.stevensanderson.com/2016/05/02/angular2-react-knockout-apps-on-aspnet-core/

# Github

https://github.com/aspnet/JavaScriptServices/
