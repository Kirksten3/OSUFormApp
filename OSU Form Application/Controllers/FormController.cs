using OSU_Form_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSU_Form_Application.Controllers
{
    public class FormController : Controller
    {
        //
        // GET: /Form/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult FormVerify([Bind(Include="Name,Course,Term,Year,QuizType,AssignmentGroup,ShuffleAnswers,TimeLimit,AllowMultipleAttempts,QuizScoreKeepp,AllowedAttempts,OnlyAfterAttempt,ShowOneQuestionAtTime,LockQuestionsAfterAnswer,AccessCode,DueDate,AvailableFrom,Until,NotifyUsersQuizChange")]FormViewModel model){
            if(ModelState.IsValid){

            }
            
            return View(model);
        }
	}
}