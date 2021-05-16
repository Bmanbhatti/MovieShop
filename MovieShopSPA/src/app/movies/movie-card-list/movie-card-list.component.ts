import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GenreService } from 'src/app/core/services/genre.service';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { movieDetailsModel } from 'src/app/shared/models/movieDetailsModel';

@Component({
  selector: 'app-movie-card-list',
  templateUrl: './movie-card-list.component.html',
  styleUrls: ['./movie-card-list.component.css']
})
export class MovieCardListComponent implements OnInit {
  
  movies: MovieCard[] | undefined;
  ids?: string| null;
  id?: number|null;

  constructor(
    private genreService: GenreService,
    private route: ActivatedRoute
    
    ) {}

  ngOnInit(): void {
    
    this.route.paramMap.subscribe(
      params => {
        this.ids = params.get('id');
        
      });

      this.getMovieByGenre();
   
}

private getMovieByGenre() {

  this.id= this.ids as unknown as number;

  //console.log(this.id);
 this.genreService.getMoviesGenre( this.id).subscribe((m) => {
      this.movies = m;
     // console.log(this.movies);
    });

}


}
