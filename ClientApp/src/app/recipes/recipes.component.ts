import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html'
})
export class RecipesComponent {
  public recipes: Recipe[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Recipe[]>(baseUrl + 'api/recipes').subscribe(result => {
      this.recipes = result;
    }, error => console.error(error));
  }
}

interface Recipe {
  recipeId: number;
  dish: string;
  dishRecipe: string;
  minutesToPrepare: number;
  qualityStars: number;
}
