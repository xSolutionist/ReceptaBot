using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ReceptaBot.Server.Data;
using ReceptaBot.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptaBot.Server.Services
{
    public class RecipeService
    {
        private readonly IMongoCollection<Recipe> _recipes;
        private readonly IOptions<MongoSettings> _config;

        public RecipeService(IOptions<MongoSettings> config)
        {
            var client = new MongoClient(_config.Value.ConnectionString);
            var database = client.GetDatabase(_config.Value.DBName);
            _recipes = database.GetCollection<Recipe>(_config.Value.Collection);
        }

        public List<Recipe> Get()
        {
            return _recipes.Find(recipe => true).ToList();
        }

        public Recipe GetById(int id) 
        {
            return _recipes.Find<Recipe>(recipe => recipe.Id == id).FirstOrDefault();
            
        }

        public Recipe Create(Recipe recipe)
        {
            _recipes.InsertOne(recipe);
            return recipe;
        }

        public void Update(int id, Recipe recipeIn)
        {
            _recipes.ReplaceOne(recipe => recipe.Id == id, recipeIn);
        }

        public void Remove(Recipe recipeIn)
        {
            _recipes.DeleteOne(recipe => recipe.Id == recipeIn.Id);
        }

        public void Remove(int id)
        {
            _recipes.DeleteOne(recipe => recipe.Id == id);
        }

    }
}
