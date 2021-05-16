import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { movieDetailsModel } from 'src/app/shared/models/movieDetailsModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private apiService: ApiService) { }

  getMovieDetails(id: number): Observable<movieDetailsModel>
  {

    return this.apiService.getOne(`${'movies/'}`, id);

  }
  getTopRevenueMovies(): Observable<MovieCard[]>
  {

    return this.apiService.getList('Movies/toprevenue');

  }
}
