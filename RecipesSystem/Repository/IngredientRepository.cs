﻿using RecipesSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace RecipesSystem.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        public void Create(Ingredient ingredient)
        {
            string sql = "INSERT INTO RecipesSystem.dbo.Ingredients(Id, Description) values (" + ingredient.Id + "," + ingredient.Description + ");";
            MSSQL.ExecuteNonQuery(sql);
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM RecipesSystem.dbo.Ingredients WHERE Id = " + id + ";";
            MSSQL.ExecuteNonQuery(sql);
        }

        public Ingredient Retrieve(int id)
        {
            string sql = "SELECT * FROM RecipesSystem.dbo.Ingredients WHERE Id = " + id + ";";

            SqlDataReader dataReader = MSSQL.Execute(sql);

            if (dataReader.Read())
                return new Ingredient { Id = Convert.ToInt32(dataReader["ID"]), Description = Convert.ToString(dataReader["Description"]) };

            throw new KeyNotFoundException("Ingredient ID: " + id + " not found");
        }

        public List<Ingredient> RetrieveAll()
        {
            string sql = "SELECT * FROM RecipesSystem.dbo.Ingredients;";
            SqlDataReader dataReader = MSSQL.Execute(sql);
           
            
            List<Ingredient> ingredients = new List<Ingredient>();
            while (dataReader.Read())
            {
                Ingredient ing = new Ingredient (Convert.ToInt32(dataReader["ID"]), Convert.ToString(dataReader["Description"]) );
                ingredients.Add(ing);
            }
            return ingredients;

        }

        public void Update(Ingredient ingredient)
        {
            string sql = "UPDATE RecipesSystem.dbo.Ingredients SET DESCRIPTION WHERE Id = " + ingredient.Id + ";";
            MSSQL.ExecuteNonQuery(sql);
        }

 

    }
}
