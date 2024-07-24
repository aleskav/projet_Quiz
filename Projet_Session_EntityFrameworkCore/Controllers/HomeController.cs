// Pour l'utilisation de classes du namespace
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_Session_EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Définition de l'espace de nommage
namespace Projet_Session_EntityFrameworkCore.Controllers
{
    // Déclaration du contrôleur Home
    public class HomeController : Controller
    {
        // Instanciation de l'objet contexte de la base de données
        private readonly QuizExamenContext _context;

        // Constructeur du contrôleur, initialisation du contexte de la base de données
        public HomeController(QuizExamenContext context)
        {
            _context = context;
        }

        // Méthode pour renvoyer la vue d'accueil
        public IActionResult Index()
        {
            return View();
        }

        // Méthode pour renvoyer la vue du nouveau quiz
        public IActionResult NewQuiz()
        {
            return View();
        }

        // Méthode pour générer un nouveau quiz
        [HttpPost]
        public async Task<IActionResult> ReadyQuiz(string userName, string email, int easy, int medium, int hard)
        {
            // Création d'une nouvelle instance de quiz
            Quiz newQuiz = new Quiz
            {
                UserName = userName,
                Email = email
            };

            // Ajout du nouveau quiz à la base de données
            _context.Quiz.Add(newQuiz);

            // Enregistrement des modifications dans la base de données
            await _context.SaveChangesAsync();

            // Sélection des questions faciles
            var easyQuestions = await _context.Question
                .Where(q => q.Category.Description == "easy")
                .OrderBy(r => Guid.NewGuid()) // Randomisation de l'ordre des questions
                .Take(easy)
                .ToListAsync();

            // Sélection des questions moyennes
            var mediumQuestions = await _context.Question
                .Where(q => q.Category.Description == "medium")
                .OrderBy(r => Guid.NewGuid()) // Randomisation de l'ordre des questions
                .Take(medium)
                .ToListAsync();

            // Sélection des questions difficiles
            var hardQuestions = await _context.Question
                .Where(q => q.Category.Description == "hard")
                .OrderBy(r => Guid.NewGuid()) // Randomisation de l'ordre des questions
                .Take(hard)
                .ToListAsync();

            // Combinaison de toutes les questions sélectionnées
            var allQuestions = new List<Question>();
            allQuestions.AddRange(easyQuestions);
            allQuestions.AddRange(mediumQuestions);
            allQuestions.AddRange(hardQuestions);

            // Ajout de chaque question au quiz
            foreach (var question in allQuestions)
            {
                QuestionQuiz questionQuiz = new QuestionQuiz
                {
                    QuizId = newQuiz.QuizId,
                    QuestionId = question.QuestionId
                };

                _context.QuestionQuiz.Add(questionQuiz);
            }

            // Enregistrement des modifications dans la base de données
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult PassQuiz()
        {
            // Récupérez tous les quiz de la base de données.
            var quizzes = _context.Quiz.ToList();

            // Passez les quiz à la vue.
            return View(quizzes);
        }

        [HttpPost]
        public IActionResult PassQuiz(string userName, string email, int quizID)
        {
            // Vérifiez si le quiz sélectionné existe dans la base de données et appartient à l'utilisateur spécifié.
            var quiz = _context.Quiz
                .Include(q => q.QuestionQuizs) // Incluez les relations QuestionQuiz
                .ThenInclude(qq => qq.Question) // Puis incluez les Questions à partir de ces relations
                .FirstOrDefault(q => q.QuizId == quizID && q.UserName == userName && q.Email == email);

            if (quiz == null)
            {
                // Si le quiz n'a pas été trouvé, retournez une vue d'erreur.
                return View("Error");
            }

            // Passez le quiz à la vue.
            return View("AnswersToQuiz", quiz);
        }

        [HttpPost]
        public IActionResult PassQuizDetails(int quizID, string userName, string email)
        {
            // Vérifiez si le quiz sélectionné existe dans la base de données et appartient à l'utilisateur spécifié.
            var quiz = _context.Quiz
                .Include(q => q.QuestionQuizs) // Incluez les relations QuestionQuiz
                .ThenInclude(qq => qq.Question) // Puis incluez les Questions à partir de ces relations
                .FirstOrDefault(q => q.QuizId == quizID && q.UserName == userName && q.Email == email);

            if (quiz == null)
            {
                // Si le quiz n'a pas été trouvé, retournez une vue d'erreur.
                return View("Error");
            }

            // Passez le quiz à la vue.
            return View(quiz);
        }

        [HttpPost]
        public IActionResult SubmitQuiz(int quizID, Dictionary<int, int> answers)
        {
            var quiz = _context.Quiz
                .Include(q => q.QuestionQuizs) // Incluez les relations QuestionQuiz
                .ThenInclude(qq => qq.Question) // Puis incluez les Questions à partir de ces relations
                .FirstOrDefault(q => q.QuizId == quizID);

            if (quiz == null)
            {
                // Si le quiz n'a pas été trouvé, retournez une vue d'erreur.
                return View("Error");
            }

            // Traitez les réponses soumises par l'utilisateur ici
            foreach (var questionQuiz in quiz.QuestionQuizs)
            {
                if (answers.ContainsKey(questionQuiz.QuestionId))
                {
                    var selectedOptionID = answers[questionQuiz.QuestionId];

                    // Créez une nouvelle instance de la réponse
                    var answer = new Answer
                    {
                        QuizId = quizID,
                        OptionId = selectedOptionID
                    };

                    // Ajoutez la nouvelle réponse à DbSet
                    _context.Answer.Add(answer);
                }
            }

            // Enregistrez les modifications dans la base de données
            _context.SaveChanges();

            // Affichez une vue de confirmation ou de résultats
            return View("index");
        }

        public IActionResult AnswersToQuiz(int id)
        {
            // Récupérez le quiz basé sur l'ID
            var quiz = _context.Quiz.FirstOrDefault(q => q.QuizId == id);

            if (quiz == null)
            {
                // Le quiz n'a pas été trouvé, gérez l'erreur de manière appropriée
                return NotFound();
            }

            // Passez le quiz à la vue
            return View(quiz);
        }

        [HttpGet]
        public IActionResult ReviewQuiz(string userName, string email, int quizID)
        {
            var quizzes = _context.Quiz
                .Include(q => q.Answers) // Incluez les relations Answers
                .ThenInclude(a => a.Option) // Puis incluez les Options à partir de ces relations
                .Include(q => q.QuestionQuizs) // Incluez aussi les relations QuestionQuiz
                .ThenInclude(qq => qq.Question) // Puis incluez les Questions à partir de ces relations
                .ToList();

            if (!quizzes.Any())
            {
                // Si aucun quiz n'a été trouvé, retournez une vue d'erreur.
                return View("Error");
            }

            // Passez la liste des quiz à la vue
            return View(quizzes);
        }

        public IActionResult ReviewAnswersToQuiz(int id)
        {
            // Récupère le quiz en fonction de l'ID.
            var quiz = _context.Quiz
                .Include(q => q.Answers)
                .ThenInclude(a => a.Option) // Assurez-vous d'inclure Option car vous utiliserez Option.IsRight pour calculer le score
                .FirstOrDefault(q => q.QuizId == id);

            var options = _context.ItemOption.ToList();

            if (quiz == null)
            {
                // Le quiz n'a pas été trouvé, gérez l'erreur de manière appropriée.
                return NotFound();
            }

            // Calculez le score ici en comptant le nombre de réponses correctes.
            var correctAnswers = quiz.Answers.Count(a => a.Option.IsRight);
            // Placez le score dans ViewBag pour le passer à la vue
            ViewBag.Score = correctAnswers;

            // Calculez le nombre total de questions et passez-le à la vue
            ViewBag.TotalQuestions = quiz.QuestionQuizs.Count;

            // Créez une nouvelle instance de QuizViewModel et passez-la à la vue.
            var viewModel = new QuizViewModel
            {
                Quiz = quiz,
                Options = options   // en supposant que votre QuizViewModel a une propriété pour les options
            };

            return View(viewModel);
        }
    }
}