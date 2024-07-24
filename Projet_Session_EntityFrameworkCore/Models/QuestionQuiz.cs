
namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public class QuestionQuiz // Définition de la classe publique QuestionQuiz
    {
        public int QuestionId { get; set; } // ID de la question, clé étrangère
        public int QuizId { get; set; } // ID du quiz, clé étrangère

        public virtual Question Question { get; set; } // Référence à la question associée
        public virtual Quiz Quiz { get; set; } // Référence au quiz associé
    }
}
