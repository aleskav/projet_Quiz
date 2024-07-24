// Utilisation des classes du namespace
using System.Collections.Generic; 

namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public partial class ItemOption // Définition de la classe publique partielle ItemOption
    {
        public ItemOption() // Constructeur par défaut
        {
            Answer = new HashSet<Answer>(); // Initialisation de l'ensemble des réponses
        }

        public int OptionId { get; set; } // ID de l'option, clé primaire
        public string Text { get; set; } // Texte de l'option
        public bool IsRight { get; set; } // Indicateur si l'option est correcte ou non
        public int? QuestionId { get; set; } // ID de la question associée, clé étrangère

        public virtual Question Question { get; set; } // Référence à la question associée
        public virtual ICollection<Answer> Answer { get; set; } // Collection des réponses associées à cette option
    }
}
