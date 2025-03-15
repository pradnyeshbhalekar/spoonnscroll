using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpoonNScroll.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpoonNScroll.Pages.Details
{
    public class DetailsModel : PageModel
    {
        public Recipe Recipe { get; set; }

        // Declare the recipes list as a static class-level variable
        private static readonly List<Recipe> recipes = new List<Recipe>
        {
            new Recipe 
            { 
                Id = 1, 
                Name = "Pasta Primavera", 
                Description = "A light and colorful pasta dish loaded with fresh seasonal vegetables in a delicate garlic and olive oil sauce.", 
                Image = "/assets/pasta-primavera.jpg", 
                Time = "30 minutes", 
                Servings = "Serves 4", 
                Ingredients = new List<string> 
                { 
                    "250g pasta (penne or fusilli)", 
                    "1 red bell pepper, sliced", 
                    "1 yellow bell pepper, sliced", 
                    "1 zucchini, sliced", 
                    "200g cherry tomatoes, halved", 
                    "3 cloves garlic, minced", 
                    "3 tbsp olive oil", 
                    "50g Parmesan cheese, grated", 
                    "Salt and black pepper to taste", 
                    "Fresh basil leaves for garnish" 
                },
                Steps = new List<string> 
                { 
                    "Boil salted water and cook pasta until al dente. Drain and set aside.", 
                    "Heat 2 tbsp olive oil in a pan over medium heat, add garlic, and sauté for 1 minute.", 
                    "Add bell peppers, zucchini, and cherry tomatoes. Cook for 5-7 minutes until tender.", 
                    "Add pasta to the pan, toss everything, and add 1 tbsp olive oil if needed.", 
                    "Season with salt and black pepper, remove from heat, and sprinkle Parmesan cheese.", 
                    "Garnish with fresh basil leaves and serve warm." 
                }
            },
            new Recipe 
            { 
                Id = 2, 
                Name = "Pizza Margherita", 
                Description = "Classic Italian pizza with a crispy thin crust topped with tomato sauce, fresh mozzarella, basil leaves, and a drizzle of olive oil.", 
                Image = "/assets/pizza-margherita.webp", 
                Time = "40 minutes", 
                Servings = "Serves 4", 
                Ingredients = new List<string> 
                { 
                    "1 pizza dough (store-bought or homemade)", 
                    "200g tomato sauce", 
                    "250g fresh mozzarella, sliced", 
                    "Fresh basil leaves", 
                    "2 tbsp olive oil", 
                    "Salt and black pepper to taste" 
                },
                Steps = new List<string> 
                { 
                    "Preheat oven to 220°C (430°F).", 
                    "Roll out pizza dough on a floured surface to desired thickness.", 
                    "Spread tomato sauce evenly over the dough, leaving a small border around the edges.", 
                    "Place mozzarella slices on top, distributing evenly.", 
                    "Bake for 12-15 minutes or until the crust is golden and cheese is melted.", 
                    "Remove from oven, garnish with fresh basil, drizzle olive oil, and serve hot." 
                }
            },
            new Recipe 
            { 
                Id = 3, 
                Name = "Fettuccine Alfredo", 
                Description = "Creamy pasta dish with tender fettuccine noodles coated in a rich parmesan cheese sauce and topped with fresh cracked pepper.", 
                Image = "/assets/fettuccine-alfredo.webp", 
                Time = "20 minutes", 
                Servings = "Serves 3", 
                Ingredients = new List<string> 
                { 
                    "250g fettuccine pasta", 
                    "4 tbsp butter", 
                    "2 cloves garlic, minced", 
                    "250ml heavy cream", 
                    "100g Parmesan cheese, grated", 
                    "Salt and black pepper to taste", 
                    "Fresh parsley for garnish" 
                },
                Steps = new List<string> 
                { 
                    "Cook fettuccine in salted water until al dente. Drain and set aside.", 
                    "In a large pan, melt butter over medium heat and sauté garlic for 1 minute.", 
                    "Stir in heavy cream and let it simmer for 2 minutes.", 
                    "Add Parmesan cheese, stirring until fully melted and smooth.", 
                    "Toss in cooked fettuccine, coating it in the sauce.", 
                    "Season with salt and black pepper, garnish with parsley, and serve warm." 
                }
            },
            new Recipe 
            { 
                Id = 4, 
                Name = "Chicken Tandoori", 
                Description = "Tender chicken marinated in yogurt and aromatic spices, then roasted to perfection with a smoky flavor and vibrant red color.", 
                Image = "/assets/chicken-tandoori.webp", 
                Time = "50 minutes", 
                Servings = "Serves 4", 
                Ingredients = new List<string> 
                { 
                    "4 chicken drumsticks", 
                    "200g yogurt", 
                    "2 tbsp tandoori spice mix", 
                    "3 cloves garlic, minced", 
                    "1-inch ginger, grated", 
                    "1 tbsp lemon juice", 
                    "Salt to taste", 
                    "2 tbsp vegetable oil" 
                },
                Steps = new List<string> 
                { 
                    "In a bowl, mix yogurt, tandoori spice mix, garlic, ginger, lemon juice, and salt.", 
                    "Coat chicken drumsticks in the marinade and refrigerate for at least 4 hours.", 
                    "Preheat oven to 200°C (400°F) and place chicken on a baking tray.", 
                    "Brush with vegetable oil and bake for 35 minutes, turning halfway through.", 
                    "Remove from oven and let rest for a few minutes.", 
                    "Serve with lemon wedges and fresh coriander." 
                }
            },
            new Recipe 
            { 
                Id = 5, 
                Name = "Lasagna", 
                Description = "Classic Italian comfort food with layers of pasta, rich meat sauce, creamy béchamel, and melted cheese baked to golden perfection.", 
                Image = "/assets/lasagna.jpg", 
                Time = "75 minutes", 
                Servings = "Serves 8", 
                Ingredients = new List<string> 
                { 
                    "12 lasagna noodles", 
                    "500g ground beef", 
                    "500g tomato sauce", 
                    "250g ricotta cheese", 
                    "250g mozzarella cheese, shredded", 
                    "250ml béchamel sauce", 
                    "2 tbsp olive oil", 
                    "Salt and pepper to taste" 
                },
                Steps = new List<string> 
                { 
                    "Preheat oven to 180°C (350°F).", 
                    "Boil lasagna noodles until al dente, then drain and set aside.", 
                    "In a pan, heat olive oil and cook ground beef until browned. Add tomato sauce and simmer for 10 minutes.", 
                    "In a baking dish, spread a layer of meat sauce, followed by lasagna noodles, ricotta cheese, and béchamel sauce.", 
                    "Repeat layering until ingredients are used up, finishing with mozzarella on top.", 
                    "Bake for 45 minutes until cheese is golden and bubbly.", 
                    "Let rest for 10 minutes before serving." 
                }
            },
            new Recipe { 
                Id = 6, 
                Name = "Bean and Cheese Burrito", 
                Description = "Hearty flour tortilla filled with refried beans, Mexican rice, melted cheese, and fresh pico de gallo, served with guacamole and sour cream.", 
                Image = "/assets/burrito.webp", 
                Time = "25 minutes", 
                Servings = "Serves 2", 
                Ingredients = new List<string> { 
                    "2 large flour tortillas", 
                    "1 cup refried beans", 
                    "1 cup Mexican rice", 
                    "1/2 cup shredded cheese (cheddar or Monterey Jack)", 
                    "1/2 cup pico de gallo", 
                    "1/4 cup sour cream", 
                    "1/4 cup guacamole" 
                }, 
                Steps = new List<string> { 
                    "Warm the tortillas on a dry pan for about 30 seconds per side.", 
                    "Spread refried beans evenly over the center of each tortilla.", 
                    "Add a layer of Mexican rice, followed by shredded cheese and pico de gallo.", 
                    "Fold in the sides of the tortilla, then roll tightly from the bottom to enclose the filling.", 
                    "Heat a pan and grill the burritos seam-side down until golden brown, about 2 minutes per side.", 
                    "Serve with guacamole and sour cream on the side." 
                } 
            },
            new Recipe { 
                Id = 7, 
                Name = "Spaghetti Carbonara", 
                Description = "Traditional Roman pasta dish with spaghetti tossed in a creamy sauce of eggs, cheese, pancetta, and black pepper for a simple yet decadent meal.", 
                Image = "/assets/spaghetti-carbonara.webp", 
                Time = "25 minutes", 
                Servings = "Serves 2", 
                Ingredients = new List<string> { 
                    "200g spaghetti", 
                    "2 egg yolks", 
                    "50g Parmesan cheese, grated", 
                    "100g pancetta, diced", 
                    "1 tbsp olive oil", 
                    "1/2 tsp black pepper", 
                    "Salt to taste" 
                }, 
                Steps = new List<string> { 
                    "Cook spaghetti in salted boiling water until al dente. Reserve 1/2 cup of pasta water before draining.", 
                    "In a bowl, whisk egg yolks and Parmesan cheese until smooth.", 
                    "Heat olive oil in a pan over medium heat and fry pancetta until crispy.", 
                    "Remove from heat, add cooked spaghetti to the pan, and mix well.", 
                    "Slowly stir in the egg-cheese mixture, adding reserved pasta water to create a creamy sauce.", 
                    "Season with black pepper, mix well, and serve immediately." 
                } 
            },
            new Recipe { 
                Id = 8, 
                Name = "Pad Thai", 
                Description = "Classic Thai stir-fried rice noodles with eggs, tofu, bean sprouts, peanuts, and lime, balanced with the perfect sweet, sour, and savory flavors.", 
                Image = "/assets/pad-thai.jpg", 
                Time = "30 minutes", 
                Servings = "Serves 3", 
                Ingredients = new List<string> { 
                    "200g rice noodles", 
                    "2 eggs", 
                    "150g tofu, cubed", 
                    "1/2 cup bean sprouts", 
                    "1/4 cup crushed peanuts", 
                    "1 lime, cut into wedges", 
                    "3 tbsp Pad Thai sauce", 
                    "1 tbsp vegetable oil", 
                    "2 cloves garlic, minced" 
                }, 
                Steps = new List<string> { 
                    "Soak rice noodles in warm water for 15 minutes, then drain.", 
                    "Heat oil in a pan over medium heat, sauté garlic for 30 seconds.", 
                    "Add tofu and stir-fry until golden brown.", 
                    "Push tofu to one side, crack eggs into the pan, and scramble.", 
                    "Add soaked noodles and Pad Thai sauce, tossing everything together.", 
                    "Stir in bean sprouts and cook for another minute.", 
                    "Serve hot, topped with crushed peanuts and lime wedges." 
                } 
            },
            new Recipe { 
                Id = 9, 
                Name = "Butter Chicken", 
                Description = "A rich and creamy North Indian dish with tender chicken simmered in a velvety tomato-based curry sauce, served with naan or rice.", 
                Image = "/assets/butter-chicken.jpg", 
                Time = "45 minutes", 
                Servings = "Serves 4", 
                Ingredients = new List<string> { 
                    "500g chicken, cubed", 
                    "2 tbsp butter", 
                    "1 cup tomato puree", 
                    "1/2 cup heavy cream", 
                    "1 tsp garam masala", 
                    "3 cloves garlic, minced", 
                    "1-inch ginger, grated", 
                    "1 tsp paprika", 
                    "Salt to taste" 
                }, 
                Steps = new List<string> { 
                    "Marinate chicken with salt, paprika, and garam masala for 30 minutes.", 
                    "Heat butter in a pan and sauté garlic and ginger until fragrant.", 
                    "Add marinated chicken and cook until browned.", 
                    "Pour in tomato puree and simmer for 15 minutes.", 
                    "Stir in heavy cream, mix well, and cook for another 5 minutes.", 
                    "Serve hot with naan or rice." 
                } 
            },
            new Recipe { 
                Id = 10, 
                Name = "Sushi Rolls", 
                Description = "Japanese-style sushi rolls made with fresh fish, avocado, cucumber, and seasoned rice, wrapped in nori and served with soy sauce.", 
                Image = "/assets/sushi-rolls.jpg", 
                Time = "50 minutes", 
                Servings = "Serves 2", 
                Ingredients = new List<string> { 
                    "1 cup sushi rice", 
                    "3 nori sheets", 
                    "100g fresh fish (salmon or tuna), sliced", 
                    "1/2 avocado, sliced", 
                    "1/2 cucumber, julienned", 
                    "2 tbsp rice vinegar", 
                    "Soy sauce for dipping" 
                }, 
                Steps = new List<string> { 
                    "Cook sushi rice, then mix with rice vinegar and let cool.", 
                    "Place a nori sheet on a bamboo mat and spread rice evenly, leaving a small border.", 
                    "Arrange fish, avocado, and cucumber on top.", 
                    "Roll tightly using the bamboo mat, applying gentle pressure.", 
                    "Slice into bite-sized pieces and serve with soy sauce." 
                } 
            },
            new Recipe { 
                Id = 11, 
                Name = "Ratatouille", 
                Description = "A classic French vegetable stew made with zucchini, eggplant, bell peppers, and tomatoes, simmered in a rich herb-infused sauce.", 
                Image = "/assets/ratatouille.jpg", 
                Time = "50 minutes", 
                Servings = "Serves 4", 
                Ingredients = new List<string> { 
                    "1 zucchini, sliced", 
                    "1 eggplant, sliced", 
                    "1 red bell pepper, diced", 
                    "2 tomatoes, chopped", 
                    "2 cloves garlic, minced", 
                    "1/2 tsp thyme", 
                    "3 tbsp olive oil", 
                    "Salt and pepper to taste" 
                }, 
                Steps = new List<string> { 
                    "Heat olive oil in a pan and sauté garlic for 30 seconds.", 
                    "Add bell pepper, zucchini, and eggplant, and cook for 5 minutes.", 
                    "Stir in tomatoes, thyme, salt, and pepper.", 
                    "Cover and simmer for 25 minutes, stirring occasionally.", 
                    "Serve hot, garnished with fresh basil." 
                } 
            },
            new Recipe { 
                Id = 12, 
                Name = "Chicken Triple Fried Rice", 
                Description = "A flavorful Indo-Chinese dish made with stir-fried rice, shredded chicken, eggs, and a mix of spicy sauces, served with crispy noodles and gravy.", 
                Image = "/assets/chicken-triple-fried-rice.webp", 
                Time = "35 minutes", 
                Servings = "Serves 3", 
                Ingredients = new List<string> { 
                    "2 cups cooked rice", 
                    "200g chicken, shredded", 
                    "2 eggs, scrambled", 
                    "1 tbsp soy sauce", 
                    "1 tbsp chili sauce", 
                    "1/2 cup crispy noodles", 
                    "2 tbsp vegetable oil" 
                }, 
                Steps = new List<string> { 
                    "Heat oil in a wok, add chicken, and stir-fry for 3 minutes.", 
                    "Push chicken aside, add eggs, and scramble.", 
                    "Add rice, soy sauce, and chili sauce, mixing well.", 
                    "Serve hot, topped with crispy noodles." 
                } 
            }
        };

        public void OnGet(int id)
        {
            // Find the recipe based on the ID
            Recipe = recipes.FirstOrDefault(r => r.Id == id);

            if (Recipe == null)
            {
                RedirectToPage("/NotFound"); 
            }
        }
    }
}
