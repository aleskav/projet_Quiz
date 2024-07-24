// Utilisation des classes du namespace
using System.Collections.Generic; 

namespace Projet_Session_EntityFrameworkCore.Models // Définition de l'espace de noms
{
    public class Category // Définition de la classe publique Category
    {
        public Category() // Constructeur par défaut
        {
            Questions = new HashSet<Question>(); // Initialisation de l'ensemble de questions
        }

        public int CategoryId { get; set; } // ID de la catégorie, clé primaire
        public string Description { get; set; } // Description de la catégorie

        public virtual ICollection<Question> Questions { get; set; } // Collection de questions associées à la catégorie
    }
}
