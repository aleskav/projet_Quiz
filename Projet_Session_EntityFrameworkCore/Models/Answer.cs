
namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public class Answer // Définition de la classe publique Answer
    {
        public int AnswerId { get; set; } // ID de la réponse, clé primaire
        public int? OptionId { get; set; } // ID de l'option choisie, clé étrangère
        public int? QuizId { get; set; } // ID du quiz correspondant, clé étrangère

        public virtual ItemOption Option { get; set; } // Référence à l'option choisie
        public virtual Quiz Quiz { get; set; } // Référence au quiz correspondant
    }
}
