import { Injectable } from '@angular/core';
import { Hello } from './hello';

@Injectable({
  providedIn: 'root'
})

export class HelloService {
  url = 'http://localhost:5258/api/hello';

  constructor() { }

  async getHello(text: string = 'hoopla'): Promise<Hello> {
    const data = await fetch(`${this.url}/${text}`);
    const hello: Hello = {
      text: (await data.json()).text
    };
    return hello;
  }
}
