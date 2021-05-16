import { Cast } from "./cast";
import { Genre } from "./genre";

export interface movieDetailsModel {
    id: number;
    title: string;
    overview: string;
    tagline: string;
    budget: number;
    revenue?: any;
    imdbUrl?: any;
    tmdbUrl?: any;
    posterUrl: string;
    backdropUrl: string;
    originalLanguage?: any;
    releaseDate: Date;
    runTime: number;
    price: number;
    createdDate?: any;
    updatedDate?: any;
    updatedBy?: any;
    createdBy?: any;
    rating: number;
    casts: Cast[];
    genres: Genre[];
}