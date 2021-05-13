import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {environment} from 'src/environments/environment'
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
//hhttpclient to talk to api
  constructor( protected http: HttpClient) { }
/// get array of jason objects

  getList(path: string):Observable<any[]>
  {
    var apiUrl= environment.apiUrl;

    return this.http.get('${environment.apiUrl}${path}').pipe(map(resp => resp as any[]));
  }
  //get singe json object
  getOne(path: string, id?:number){

    return this.http.get('${environment.apiUrl}${path}'+ id).pipe(
      map(resp=> resp as any)

    );
  }
  //posting stuff
  create(){


  }
  //put
  update(){

  }

  delete(){


  }
}
