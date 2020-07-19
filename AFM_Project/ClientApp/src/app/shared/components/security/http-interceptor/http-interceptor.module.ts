import { NgModule, Injectable } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable()
export class HttpRequestInterceptor
  implements HttpInterceptor {
  intercept(req: HttpRequest<any>,
    next: HttpHandler):
    Observable<HttpEvent<any>> {
    var token =
      localStorage.getItem("bearerToken");

    if (token) {
      const newReq = req.clone(
        {
          headers: req.headers
            .set('Authorization',
              'Bearer ' + token)
        });

      return next.handle(newReq);
    }
    else {
      return next.handle(req);
    }
  }
};

@NgModule({
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpRequestInterceptor,
      multi: true
    }
  ],
  declarations: [],
  imports: [
    CommonModule 
  ]
})
export class HttpInterceptorModule { }
