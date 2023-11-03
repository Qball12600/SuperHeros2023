using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SuperHeros23App.Data;
using SuperHeros23App.Models;

namespace SuperHeros23App.Controllers
{
    public class SuperHeros23Controller : Controller
    {


        //private readonly ApplicationDbContext _context;
        //private readonly ApplicationDbContext context;
        private SuperHero23 superhero23;

        private readonly ApplicationDbContext _context;
        public SuperHeros23Controller(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: SuperHeros23Controller
        public ActionResult Index()
        {
            //Linq query to retrieve all rows from table
            var superheros23 = _context.SuperHeros23.ToList();
            return View(superheros23);
        }

        // GET: SuperHeros23Controller/Details/5
        public ActionResult Details(int id)
        {
            //Linq query to find specific row from table
            var superhero = _context.SuperHeros23.FirstOrDefault(s => s.Id == id);

            if (superhero == null)
            {
                return NotFound();
            }
            return View(superhero);
        }

        // GET: SuperHeros23Controller/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: SuperHeros23Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero23 superhero23)
        {


            if (ModelState.IsValid)
            {
                try
                { 
                    _context.SuperHeros23.Add(superhero23);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the superhero.");

                }
            }
            return View(superhero23);

        }

        private bool IsDuplicate(string name)
        {
            throw new NotImplementedException();
        }

        // GET: SuperHeros23Controller/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero23 superhero23 = _context.SuperHeros23.Find(id);
            if (superhero23 == null)
            {
                return HttpNotFound();
            }
            return View(superhero23);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        // POST: SuperHeros23Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero23 superhero23)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SuperHero23 existingSuperHero23 = _context.SuperHeros23.Find(id);

                    if (existingSuperHero23 == null)
                    {
                        return HttpNotFound();
                    }
                    existingSuperHero23.name = superhero23.name;
                    existingSuperHero23.AlterEgo = superhero23.AlterEgo;
                    existingSuperHero23.PrimaryAbility = superhero23.PrimaryAbility;
                    existingSuperHero23.SecondaryAbility = superhero23.SecondaryAbility;
                    existingSuperHero23.CatchPhrase = superhero23.CatchPhrase;

                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));

                }
                catch
                {
                    return View(superhero23);
                }
            }
            else
            {
                return View(superhero23);
            }
        }
    
        // GET: SuperHeros23Controller/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero23 superhero23 = _context.SuperHeros23.Find(id);
            if (superhero23 == null)
            {
                return HttpNotFound();
            }
            return View(superhero23);
        }

        // POST: SuperHeros23Controller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuperHero23 superHero23 = _context.SuperHeros23.Find(id);

            if (superHero23 == null) 
            {
                return HttpNotFound();
            }
            _context.SuperHeros23.Remove(superhero23);
            _context.SaveChanges();
            
                return RedirectToAction(Index);
            
          
        }

        private ActionResult RedirectToAction(Func<ActionResult> index)
        {
            throw new NotImplementedException();
        }
    }
}
