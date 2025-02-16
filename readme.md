Hello World, Angular + .NET Core REST API
=========================================

A simple "Hello World" built using Angular with a .NET Core REST API.

## What is it?

This is a simple isomorphic application that hosts an Angular web client and a .NET Core REST service. The client displays the web page and makes an HTTP request to the .NET REST service to retrieve a string from the `/api/hello` endpoint. As simple as it is, this project demonstrates how to connect an Angular front-end with a .NET back-end.

While the REST API only returns a simple string, this could easily be expanded to utilize the Entity Framework to retrieve from a database or perform other interactions.

## API Methods

### GET /api/hello

Returns the text "Hello, World". You may optionally provide a url parameter `?text=<YOUR TEXT>` to customize the text returned.

### GET /api/hello/{text}

Returns the text specified in the url.

## Architecture

The layout of the program focuses on the [home component](https://github.com/primaryobjects/hello-angular/blob/main/client/src/app/home/home.component.html) which displays the text from the type [Hello](https://github.com/primaryobjects/hello-angular/blob/main/client/src/app/hello.ts).

The component [loads](https://github.com/primaryobjects/hello-angular/blob/main/client/src/app/home/home.component.ts#L17) the text from an Angular [service](https://github.com/primaryobjects/hello-angular/blob/main/client/src/app/hello.service.ts#L14).

Finally, the resulting text is [rendered](https://github.com/primaryobjects/hello-angular/blob/main/client/src/app/home/home.component.html#L2) on the page.

*Angular client => Angular service => .NET controller*

## Tech Stack

- Visual Studio Code
- Angular
- C# .NET Core (Web API)
- TypeScript

## License

MIT

## Author

Kory Becker http://www.primaryobjects.com/kory-becker