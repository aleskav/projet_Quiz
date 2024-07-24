// Utilisation des classes du namespace
using Microsoft.EntityFrameworkCore;


namespace Projet_Session_EntityFrameworkCore.Models
{
    public partial class QuizExamenContext : DbContext // Le contexte de la base de données.
    {
        // Les constructeurs
        public QuizExamenContext() { } // Constructeur par défaut
        public QuizExamenContext(DbContextOptions<QuizExamenContext> options) : base(options) { } // Constructeur qui prend en paramètre des options.

        // Les ensembles de données correspondant à chaque table dans la base de données.
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ItemOption> ItemOption { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionQuiz> QuestionQuiz { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }

        // Méthode appelée lors de la configuration du contexte de la base de données.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Utilise SQL Server si le contexte de la base de données n'est pas encore configuré.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=MyConnectionBD");
            }
        }

        // Méthode 'OnModelCreating' qui est exécutée lors de la création du modèle de base de données.        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de l'entité 'Answer'. La méthode 'Entity' retourne un objet utilisé pour configurer l'entité 'Answer'.
            modelBuilder.Entity<Answer>(entity =>
            {
                // Configure la propriété 'AnswerId' de l'entité 'Answer'.                
                entity.Property(e => e.AnswerId).HasColumnName("answerID");

                // Configure la propriété 'OptionId' de l'entité 'Answer'.                
                entity.Property(e => e.OptionId).HasColumnName("optionID");

                // Configure la propriété 'QuizId' de l'entité 'Answer'.                
                entity.Property(e => e.QuizId).HasColumnName("quizID");

                // Configure la relation entre l'entité 'Answer' et l'entité 'ItemOption'.                 
                entity.HasOne(d => d.Option)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.OptionId)
                    .HasConstraintName("FK__Answer__optionID__534D60F1");

                // Configure la relation entre l'entité 'Answer' et l'entité 'Quiz'.                
                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__Answer__quizID__5441852A");
            });


            // Définition de la configuration spécifique à l'entité 'Category'
            modelBuilder.Entity<Category>(entity =>
            {
                // La méthode 'Property' permet de configurer les propriétés de l'entité.                
                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                // Configuration de la propriété 'Description'. Correspond à la colonne 'description' dans la base de données.                
                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


            // Définition de la configuration spécifique à l'entité 'ItemOption'
            modelBuilder.Entity<ItemOption>(entity =>
            {
                // La méthode 'HasKey' est utilisée pour définir la clé primaire de l'entité.                 
                entity.HasKey(e => e.OptionId)
                    .HasName("PK__ItemOpti__3D5DC3C1C9C96D01");

                // La méthode 'Property' permet de configurer les propriétés de l'entité.                
                entity.Property(e => e.OptionId).HasColumnName("optionID");
                entity.Property(e => e.IsRight).HasColumnName("isRight");
                entity.Property(e => e.QuestionId).HasColumnName("questionID");
                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                // La méthode 'HasOne' est utilisée pour configurer la relation entre les entités.                
                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__ItemOptio__quest__4E88ABD4");
            });


            // Définition de la configuration spécifique à l'entité 'Question'
            modelBuilder.Entity<Question>(entity =>
            {
                // La méthode 'Property' permet de configurer les propriétés de l'entité.                
                entity.Property(e => e.QuestionId).HasColumnName("questionID");
                entity.Property(e => e.CategoryId).HasColumnName("categoryID");
                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                // La méthode 'HasOne' est utilisée pour configurer la relation entre les entités.                
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Question__catego__4BAC3F29");
            });


            // Définition de la configuration spécifique à l'entité 'QuestionQuiz'
            modelBuilder.Entity<QuestionQuiz>(entity =>
            {
                // La méthode 'HasKey' est utilisée pour configurer la clé primaire pour l'entité.                
                entity.HasKey(e => new { e.QuestionId, e.QuizId })
                    .HasName("PK__Question__AEC78053835507D7");

                // On configure les propriétés 'QuestionId' et 'QuizId' pour qu'elles correspondent                
                entity.Property(e => e.QuestionId).HasColumnName("questionID");
                entity.Property(e => e.QuizId).HasColumnName("quizID");

                // On indique qu'une entrée 'QuestionQuiz' peut être associée à une seule 'Question'.                
                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionQuizs)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionQ__quest__571DF1D5");

                // On fait la même chose pour la relation entre 'QuestionQuiz' et 'Quiz'.
                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuestionQuizs)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionQ__quizI__5812160E");
            });


            // Configuration spécifique à l'entité 'Quiz'
            modelBuilder.Entity<Quiz>(entity =>
            {
                // La méthode 'Property' est utilisée pour configurer les propriétés de l'entité 'Quiz'.                
                entity.Property(e => e.QuizId).HasColumnName("quizID");

                // On fait la même chose pour la propriété 'Email', qui correspond à la colonne 'email'.                
                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                // On fait la même chose pour la propriété 'UserName', qui correspond à la colonne 'userName'.
                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


            // Appel à une méthode partielle qui peut être utilisée pour configurer davantage le modèle
            OnModelCreatingPartial(modelBuilder);
        }

        // Déclaration de la méthode partielle qui permet de séparer la logique de configuration du modèle en morceaux plus gérables.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

