import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genre } from 'src/app/shared/models/genre';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { movieDetailsModel } from 'src/app/shared/models/movieDetailsModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private apiService: ApiService) { }

  getAllGenres(): Observable<Genre[]> {

    // https://localhost:44385/api/Genres
    return this.apiService.getList('genres');
    // call getList() from Api Service
  }

  getMoviesGenre(id: number): Observable<MovieCard[]>
  {

    return this.apiService.getListById(`${'Movies/genre/'}`, id);

    
  }

  getMovieDetails(id: number): Observable<movieDetailsModel>
  {

    return this.apiService.getOne(`${'movies/'}`, id);

  }
}