// Utilisation des classes du namespace
using System.Collections.Generic;

// Définition de l'espace de noms Projet_Session_EntityFrameworkCore.Models
namespace Projet_Session_EntityFrameworkCore.Models
{
    // Déclaration d'une classe publique appelée QuizViewModel    
    public class QuizViewModel
    {
        // Déclaration d'une propriété publique de type Quiz appelée Quiz        
        public Quiz Quiz { get; set; }

        // Déclaration d'une propriété publique de type List<Question> appelée Questions       
        public List<Question> Questions { get; set; }

        // Déclaration d'une propriété publique de type List<ItemOption> appelée Options        
        public List<ItemOption> Options { get; set; } 

    }
}
