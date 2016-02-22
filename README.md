# TokenBasedSecurity
This simple project is to decouple server side security code and client side viewer. Server side using ASP.NET Web API 2, Owin, and Identity, it also support CORS; Client side can use JavaScript MVC/MVVM libaries such as Angular, Sencha. So server side code and client side code can deploy to two different server. In the real project, we also need add a separate secured Resource Server, using same machineKey with Authenticate/Authorization Server, Client side need call Authenticate/Authorization Server API with HTTPS.
![api_security](https://cloud.githubusercontent.com/assets/6053471/13200618/0dde0dde-d80e-11e5-8165-ffbe44cf680a.png)
![api_security1](https://cloud.githubusercontent.com/assets/6053471/13200621/115b20d2-d80e-11e5-9473-84f7230d6b85.png)

