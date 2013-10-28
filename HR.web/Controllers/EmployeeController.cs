using HR.web.Models;
using HR.web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.web.Controllers
{
    public class EmployeeController : Controller
    {

        List<Employee> employees = new List<Employee>
            {
                new Employee{
                    Id = 5,
                    Name = "Moe",
                    Bio = "Moses Harry Horwitz (June 19, 1897 – May 4, 1975), known professionally as Moe Howard, was an American actor and comedian best known as the leader of The Three Stooges, the farce comedy team who starred in motion pictures and television for four decades. His distinctive hairstyle came about when he was a boy and cut off his curls with a pair of scissors, producing a ragged shape approximating a bowl cut."
                }, 
                new Employee{
                    Id = 7,
                    Name = "Larry",
                    Bio = "Fine was born to a Jewish family as Louis Feinberg[2] at 3rd and South Street in Philadelphia, Pennsylvania.[3] His father, Joseph Feinberg (who was Russian-Jewish), and mother, Fanny Lieberman, owned a watch repair and jewelry shop. In early childhood, his arm was burned with acid that his father used to test whether or not gold was real: having mistaken it for a beverage, Larry had raised the acid bottle to his lips when his father noticed and knocked it from his hand, accidentally splashing Larry's forearm. He was later given violin lessons to help strengthen the damaged muscles, a skill which would be put to use in many of the Stooges' films. He became proficient on the instrument, and his parents wanted to send him to a European music conservatory, but the outbreak of World War I prevented this. In scenes where all three Stooges are playing fiddles, only Larry is actually playing while the other two are only pantomiming. To strengthen his arm further, Larry took up boxing in his teens, fighting in (and winning) one professional bout. His father, opposed to Larry's fighting in public, put an end to his brief career as a boxer.[1]"
                },
                new Employee{
                    Id = 11,
                    Name = "Curly",
                    Bio = "Jerome Lester Jerry Horwitz (October 22, 1903 – January 18, 1952), better known by his stage name Curly Howard, was an American comedian and vaudevillian actor. He was best known as the most outrageous member of the American slapstick comedy team The Three Stooges, which also featured his older brothers Moe Howard and Shemp Howard and actor Larry Fine. Curly was generally considered the most popular and recognizable of the Stooges.[1] He was well known for his high-pitched voice and vocal expressions (nyuk-nyuk-nyuk!, woob-woob-woob!, soitenly! and barking like a dog) as well as his physical comedy, improvisations, and athleticism.[2]"
                }
            };

        public ActionResult List(int id = 0)
        {
            var model = new EmployeeListViewModel{
               Employees = employees,
               SelectedId = id
            };
            return View(model);
        }

        public ActionResult Details(int id)
        {
            Employee found = null;
            foreach (var employee in employees)
                if (employee.Id == id)
                    found = employee;

            return View(found);
        }

    }
}
