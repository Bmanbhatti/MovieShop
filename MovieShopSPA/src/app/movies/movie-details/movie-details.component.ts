import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/core/services/movie.service';
import { ActivatedRoute, Router } from '@angular/router';

import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { movieDetailsModel } from 'src/app/shared/models/movieDetailsModel';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  details?: movieDetailsModel;
  ids?: string| null;
  id?: number|null;
 constructor(
   private movieService: MovieService,
   private route: ActivatedRoute
   
   ) {
  }

 ngOnInit(): void {

  this.route.paramMap.subscribe(
    params => {
      this.ids = params.get('id');
      
    }

    
  );   
    this.getMovieDetails();
  }
   
  private getMovieDetails() {

    this.id= this.ids as unknown as number;

    
    this.movieService.getMovieDetails(this.id).subscribe(m=>{ 

      this.details=m;
     
     });
  }
    
    

}