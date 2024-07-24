// Utilisation des classes du namespace
using System.Collections.Generic;

namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public class Quiz // Définition de la classe publique Quiz
    {
        public Quiz() // Constructeur
        {
            Answers = new HashSet<Answer>(); // Initialisation des réponses à un nouvel HashSet vide
            QuestionQuizs = new HashSet<QuestionQuiz>(); // Initialisation des QuestionQuizs à un nouvel HashSet vide
        }

        public int QuizId { get; set; } // ID du quiz, clé primaire
        public string UserName { get; set; } // Nom d'utilisateur du participant au quiz
        public string Email { get; set; } // Email du participant au quiz

        public virtual ICollection<Answer> Answers { get; set; } // Collection des réponses données au quiz
        public virtual ICollection<QuestionQuiz> QuestionQuizs { get; set; } // Collection des questions présentes dans le quiz
    }
}
