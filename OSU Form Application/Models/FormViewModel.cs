using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSU_Form_Application.Models
{
    public class FormViewModel
    {
        [Required(ErrorMessage="Must enter a Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must enter a Course Name")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Must select a Term")]
        public string Term { get; set; }

        [Required(ErrorMessage = "Must enter a Year")]
        public string Year { get; set; }

        #region Base Quiz Parameters
        [Required(ErrorMessage = "Must select a Quiz Type")]
        public string QuizType { get; set; }

        public string AssignmentGroup { get; set; }

        public bool ShuffleAnswers { get; set; }

        public int TimeLimit { get; set; }
        #endregion

        #region AllowMultipleAttempts
        public bool AllowMultipleAttempts { get; set; }

        public string QuizScoreKeep { get; set; }

        public int AllowedAttempts { get; set; }
        #endregion

        #region StudentQuizResponses
        public bool OnlyAfterAttempt { get; set; }

        //Let students see the correct answers feedback
        #endregion

        #region QuestionViewing
        public bool ShowOneQuestionAtTime { get; set; }

        public bool LockQuestionsAfterAnswer { get; set; }
        #endregion

        public string AccessCode { get; set; }

        #region Time Parameters
        public string DueDate { get; set; }

        public string AvailableFrom { get; set; }

        public string Until { get; set; }
        #endregion

        public bool NotifyUsersQuizChange { get; set; }
    }
}