﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EnvisionAGreenLife.Models;
using EnvisionAGreenLife.ViewModel;
using MvcBreadCrumbs;
using PagedList;

namespace EnvisionAGreenLife.Controllers
{
    public class Food_recipesController : Controller
    {
        private LeftoverRecipesEntities db = new LeftoverRecipesEntities();

        // GET: Food_recipes
        [BreadCrumb(Clear = true, Label = "Breakfast Recipes")]
        [HttpGet]
        public ActionResult breakfast_recipes(int? page, string searchString, string currentFilter)
        {
            var results = from x in db.recipes
                          select x;
            int pagesize = 9, pageindex = 1;
            breakfastList temp = new breakfastList();
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.recipe_type_id == 1
                && (s.ingredients.Contains(searchString)
                || s.name.Contains(searchString)
                || s.difficulty_assignment.Contains(searchString)
                || s.minutes.Contains(searchString)));
            }

            else
            {
                results = results.Where(x => x.recipe_type_id == 1);
            }

            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = results.ToList();
            temp.Breakfasts = list.ToPagedList(pageindex, pagesize);
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home");
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftOverRecipe", "Home"), "Left Over Recpies");
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text");
            return View(temp);
        }

        [BreadCrumb(Clear = true, Label = "Lunch Recipes")]
        [HttpGet]
        public ActionResult lunch_recipes(int? page, string searchString, string currentFilter)
        {
            var results = from x in db.recipes
                          select x;
            int pagesize = 9, pageindex = 1;
            lunchList temp = new lunchList();
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.recipe_type_id == 2
                && (s.ingredients.Contains(searchString)
                || s.name.Contains(searchString)
                || s.difficulty_assignment.Contains(searchString)
                || s.minutes.Contains(searchString)));
            }

            else
            {
                results = results.Where(x => x.recipe_type_id == 2);
            }

            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = results.ToList();
            temp.Lunch = list.ToPagedList(pageindex, pagesize);
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home");
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftOverRecipe", "Home"), "Left Over Recpies");
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text");
            return View(temp);
        }

        [BreadCrumb(Clear = true, Label = "Dinner Recipes")]
        [HttpGet]
        public ActionResult dinner_recipes(int? page, string searchString, string currentFilter)
        {
            var results = from x in db.recipes
                          select x;
            int pagesize = 9, pageindex = 1;
            dinnerList temp = new dinnerList();
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.recipe_type_id == 3
                && (s.ingredients.Contains(searchString)
                || s.name.Contains(searchString)
                || s.difficulty_assignment.Contains(searchString)
                || s.minutes.Contains(searchString)));
            }

            else
            {
                results = results.Where(x => x.recipe_type_id == 3);
            }

            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = results.ToList();
            temp.Dinner = list.ToPagedList(pageindex, pagesize);
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home");
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftOverRecipe", "Home"), "Left Over Recpies");
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text");
            return View(temp);
        }

        [BreadCrumb(Clear = true, Label = "Dinner Recipes")]
        [HttpGet]
        public ActionResult dessert_recipes(int? page, string searchString, string currentFilter)
        {
            var results = from x in db.recipes
                          select x;
            int pagesize = 9, pageindex = 1;
            dessertList temp = new dessertList();
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.recipe_type_id == 4
                   && (s.ingredients.Contains(searchString)
                   || s.name.Contains(searchString)
                   || s.difficulty_assignment.Contains(searchString)
                   || s.minutes.Contains(searchString)));
             }

            else
            {
                results = results.Where(x => x.recipe_type_id == 4);
            }

            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = results.ToList();
            temp.Dessert = list.ToPagedList(pageindex, pagesize);
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home");
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftOverRecipe", "Home"), "Left Over Recpies");
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text");
            return View(temp);
        }



        [BreadCrumb(Clear = true, Label = "Recipes")]
        [HttpGet]
        public ActionResult General_search(int? page, string searchString, string currentFilter, string Difficulty, string currentDifficulty)
        {
            var results = from x in db.recipes
                          select x;
            int pagesize = 9, pageindex = 1;
            recipeList temp = new recipeList();
            if (searchString != null || Difficulty != null)
            {
                page = 1;
            }
            else
            {
                Difficulty = currentDifficulty;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["currentDifficulty"] = Difficulty;
            if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(Difficulty))
            {
                results = results.Where(s => s.difficulty_assignment == Difficulty &&
                (s.ingredients.Contains(searchString)
                || s.name.Contains(searchString)
                || s.difficulty_assignment.Contains(searchString)
                || s.minutes.Contains(searchString)));
            }
            else
            if( String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(Difficulty))
            {
                results = results.Where(s => s.difficulty_assignment == Difficulty);
            }
            else
            if (!String.IsNullOrEmpty(searchString) && String.IsNullOrEmpty(Difficulty))
            {
                results = results.Where(s => 
                s.ingredients.Contains(searchString)
                || s.name.Contains(searchString)
                || s.difficulty_assignment.Contains(searchString)
                || s.minutes.Contains(searchString));
            }
            else
            {
                results = results.Where(x => x.recipe_type_id == 1 
                || x.recipe_type_id == 2
                || x.recipe_type_id == 3
                || x.recipe_type_id == 4);
            }

            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = results.ToList();
            temp.recipes = list.ToPagedList(pageindex, pagesize);
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home"); 
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftOverRecipe", "Home"), "Left Over Recpies");
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text",currentDifficulty);
            return View(temp);
        }

        // GET: Food_recipes/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recipe recipes = db.recipes.Find(id);
            if (recipes == null)
            {
                return HttpNotFound();
            }
            BreadCrumb.Clear();
            BreadCrumb.Add(Url.Action("Index", "Home"), "Home");
            BreadCrumb.Add(Url.Action("ReduceFoodWaste", "Home"), "Reduce Food Waste");
            BreadCrumb.Add(Url.Action("LeftoverRecipe", "Home"), "Leftover Recipes");
            BreadCrumb.Add("", recipes.name);
            List<SelectListItem> Difficulty_level = new List<SelectListItem>();
            Difficulty_level.Add(new SelectListItem() { Text = "Difficulty", Value = null });
            Difficulty_level.Add(new SelectListItem() { Text = "Easy", Value = "easy" });
            Difficulty_level.Add(new SelectListItem() { Text = "Average", Value = "average" });
            Difficulty_level.Add(new SelectListItem() { Text = "Challenging", Value = "Challenging" });
            this.ViewBag.Difficulty = new SelectList(Difficulty_level, "Value", "Text");
            var results = from x in db.recipes
                          select x;
            var list = results.Where(x => x.difficulty_assignment.Contains(recipes.difficulty_assignment) && x.recipe_type_id == recipes.recipe_type_id).OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            ViewData["SimilarRecipes"] = list;
            return View(recipes);
        }




    }
}
