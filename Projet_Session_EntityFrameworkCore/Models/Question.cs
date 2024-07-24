// Utilisation des classes du namespace
using System.Collections.Generic;

namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public class Question // Définition de la classe publique Question
    {
        public Question() // Constructeur par défaut
        {
            Options = new HashSet<ItemOption>(); // Initialisation de l'ensemble des options
            QuestionQuizs = new HashSet<QuestionQuiz>(); // Initialisation de l'ensemble des QuestionQuiz
        }

        public int QuestionId { get; set; } // ID de la question, clé primaire
        public string Text { get; set; } // Texte de la question
        public int? CategoryId { get; set; } // ID de la catégorie associée, clé étrangère

        public virtual Category Category { get; set; } // Référence à la catégorie associée
        public virtual ICollection<ItemOption> Options { get; set; } // Collection des options associées à cette question
        public virtual ICollection<QuestionQuiz> QuestionQuizs { get; set; } // Collection des QuestionQuiz associées à cette question
    }
}
