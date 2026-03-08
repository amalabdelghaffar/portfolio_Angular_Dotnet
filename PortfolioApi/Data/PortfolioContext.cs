using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;

namespace PortfolioApi.Data;

public class PortfolioContext : DbContext
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Certification> Certifications { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<CommunityActivity> CommunityActivities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Profile
        modelBuilder.Entity<Profile>().HasData(new Profile
        {
            Id = 1,
            FullName = "Ben Abdelghaffar AMAL",
            Title = "Software Engineering Student | Full-Stack Developer",
            Email = "abdelgaffaramal@gmail.com",
            Phone = "21 491 299",
            Location = "Sfax, Tunisia",
            About = "Passionate Full-Stack Developer and Software Engineering student with expertise in .NET, Angular, Python, and Odoo. Experienced in ERP development, web platforms, data analysis, and AI/ML solutions. Driven by innovation and committed to building robust, scalable applications.",
            GithubUrl = "https://github.com/amalabdelghaffar",
            LinkedinUrl = "https://www.linkedin.com/in/amalbenabdelghaffar/",
            AvatarUrl = "/assets/avatar.jpg"
        });

        // Seed Experiences
        modelBuilder.Entity<Experience>().HasData(
            new Experience
            {
                Id = 8,
                Title = "Stage – Odoo 17 & OpenAI",
                Company = "Fogits",
                Location = "Sfax, Tunisia",
                StartDate = "Février 2026",
                EndDate = "",
                IsCurrent = true,
                Description = "Conception et développement d'un module Odoo 17 intelligent capable de prévoir les ventes futures et de générer des insights commerciaux exploitables en exploitant les données internes de l'ERP et les capacités d'analyse de l'API OpenAI.",
                Technologies = "Odoo 17, Python, ORM Odoo, OpenAI API, OWL Framework, Chart.js, PostgreSQL, Docker, CI/CD (GitLab/GitHub)",
                Order = 1
            },
            new Experience
            {
                Id = 1,
                Title = "Odoo/Python Developer",
                Company = "DigitalClick",
                Location = "Safaqis, SF, Tunisia",
                StartDate = "Avril 2025",
                EndDate = "",
                IsCurrent = true,
                Description = "Développement et maintenance de modules Odoo. Gestion des ERP, CRM, Achat, Ventes, Comptabilité et Inventaire.",
                Technologies = "Python, Odoo, XML, ERP, CRM",
                Order = 2
            },
            new Experience
            {
                Id = 2,
                Title = "Fullstack Developer",
                Company = "Digital Click",
                Location = "Sfax, Tunisia",
                StartDate = "Novembre 2024",
                EndDate = "Avril 2025",
                IsCurrent = false,
                Description = "Développement fullstack avec ASP.NET MVC, SSMS, Entity Framework, Identity et Nuget. Intégration de WordPress, Elementor, WPbakery, SEO, WooCommerce, Brevo et Mailchimp.",
                Technologies = "ASP.NET, MVC, SSMS, Entity Framework, GIT, DEVEXTREAM, WordPress, Elementor, SEO, WooCommerce",
                Order = 3
            },
            new Experience
            {
                Id = 3,
                Title = "WordPress Developer & Microsoft 365 CRM Maintenance",
                Company = "Amatab",
                Location = "SFAX, Tunisia",
                StartDate = "Septembre 2024",
                EndDate = "Novembre 2024",
                IsCurrent = false,
                Description = "Management et développement de sites WordPress. Intégration et configuration de plugins (SMTP, WPForms). Hébergement avec Hostinger. Administration et optimisation des environnements Microsoft 365 (SharePoint, Power Apps, Teams).",
                Technologies = "WordPress, SMTP, WPForms, Hostinger, Microsoft 365, SharePoint, Power Apps, CRM",
                Order = 4
            },
            new Experience
            {
                Id = 4,
                Title = "Data Analysts Manager",
                Company = "Anavid",
                Location = "Sfax, Tunisia",
                StartDate = "Juillet 2023",
                EndDate = "Juin 2024",
                IsCurrent = false,
                Description = "Nettoyage de données, gestion d'équipe, analyse de données, annotation et collection de données. Segmentation, SCRUM, Ubuntu.",
                Technologies = "Python, Data Analysis, Data Cleaning, Segmentation, SCRUM, Microsoft Excel",
                Order = 5
            },
            new Experience
            {
                Id = 5,
                Title = "Intern – Crowd Counting AI",
                Company = "Anavid",
                Location = "Sfax, Sakiet Ezzit, Tunisia",
                StartDate = "Février 2023",
                EndDate = "Mai 2023",
                IsCurrent = false,
                Description = "PFE: Estimation du nombre de personnes dans une foule en utilisant des modèles de deep learning implémentés dans une interface web Flask.",
                Technologies = "Python, Deep Learning, Flask, Computer Vision",
                Order = 6
            },
            new Experience
            {
                Id = 6,
                Title = "Summer Internship – RFM Segmentation",
                Company = "Optimal Solution",
                Location = "Sahloul/Sousse, Tunisia",
                StartDate = "Juillet 2022",
                EndDate = "Septembre 2022",
                IsCurrent = false,
                Description = "Développement d'un module de segmentation RFM des clients sous Odoo 15, avec analyse de données, visualisation et Python.",
                Technologies = "Odoo 15, Python, Data Analysis, Segmentation, Visualization",
                Order = 7
            },
            new Experience
            {
                Id = 7,
                Title = "Web Platform Developer (Laravel/PHP)",
                Company = "ISIMS",
                Location = "Sfax, Tunisia",
                StartDate = "2022",
                EndDate = "2022",
                IsCurrent = false,
                Description = "Développement d'une plateforme web avec Laravel. Architecture MVC, modélisation UML, CRUD, Docker.",
                Technologies = "Laravel, PHP, MVC, UML, CRUD, Docker",
                Order = 8
            }
        );

        // Seed Educations
        modelBuilder.Entity<Education>().HasData(
            new Education
            {
                Id = 1,
                Degree = "Software Engineering",
                Institution = "Institute of Advanced Sciences and Technology",
                Location = "Sfax, Tunisia",
                StartDate = "Septembre 2023",
                EndDate = "En cours",
                Description = "Formation en ingénierie logicielle avec spécialisation en développement fullstack et technologies modernes.",
                Order = 1
            },
            new Education
            {
                Id = 2,
                Degree = "Licence en Informatique – Big Data & Data Analysis",
                Institution = "Higher Institute of Computer Science and Multimedia (ISIMS)",
                Location = "Sfax, Tunisia",
                StartDate = "Septembre 2020",
                EndDate = "Juin 2023",
                Description = "Licence spécialisée en Big Data et analyse de données.",
                Order = 2
            },
            new Education
            {
                Id = 3,
                Degree = "Baccalauréat en Sciences Expérimentales",
                Institution = "Lycée Menzel Hayet Monastir",
                Location = "Manzel Hayet, Tunisia",
                StartDate = "Septembre 2019",
                EndDate = "Juillet 2020",
                Description = "Baccalauréat dans la filière sciences expérimentales.",
                Order = 3
            }
        );

        // Seed Skills
        modelBuilder.Entity<Skill>().HasData(
            // Programming Languages
            new Skill { Id = 1, Name = "Python", Category = "Programming Languages", Level = 90, Icon = "devicon-python-plain" },
            new Skill { Id = 2, Name = "C#", Category = "Programming Languages", Level = 85, Icon = "devicon-csharp-plain" },
            new Skill { Id = 3, Name = "Java", Category = "Programming Languages", Level = 70, Icon = "devicon-java-plain" },
            new Skill { Id = 4, Name = "PHP", Category = "Programming Languages", Level = 75, Icon = "devicon-php-plain" },
            new Skill { Id = 5, Name = "C", Category = "Programming Languages", Level = 65, Icon = "devicon-c-plain" },
            // Web Development
            new Skill { Id = 6, Name = "Angular", Category = "Web Development", Level = 85, Icon = "devicon-angularjs-plain" },
            new Skill { Id = 7, Name = "ASP.NET MVC", Category = "Web Development", Level = 85, Icon = "devicon-dotnetcore-plain" },
            new Skill { Id = 8, Name = "Laravel", Category = "Web Development", Level = 75, Icon = "devicon-laravel-plain" },
            new Skill { Id = 9, Name = "Flutter", Category = "Web Development", Level = 60, Icon = "devicon-flutter-plain" },
            new Skill { Id = 10, Name = "WordPress", Category = "Web Development", Level = 80, Icon = "devicon-wordpress-plain" },
            new Skill { Id = 11, Name = "HTML/CSS", Category = "Web Development", Level = 90, Icon = "devicon-html5-plain" },
            new Skill { Id = 12, Name = "JavaScript", Category = "Web Development", Level = 80, Icon = "devicon-javascript-plain" },
            new Skill { Id = 13, Name = "Flask", Category = "Web Development", Level = 75, Icon = "devicon-flask-original" },
            new Skill { Id = 14, Name = "Bootstrap", Category = "Web Development", Level = 85, Icon = "devicon-bootstrap-plain" },
            // AI & Data Science
            new Skill { Id = 15, Name = "TensorFlow", Category = "Artificial Intelligence", Level = 75, Icon = "devicon-tensorflow-original" },
            new Skill { Id = 16, Name = "OpenCV", Category = "Artificial Intelligence", Level = 70, Icon = "devicon-opencv-plain" },
            new Skill { Id = 17, Name = "Machine Learning", Category = "Artificial Intelligence", Level = 75, Icon = "fas fa-brain" },
            new Skill { Id = 18, Name = "Deep Learning", Category = "Artificial Intelligence", Level = 70, Icon = "fas fa-network-wired" },
            // Tools & Others
            new Skill { Id = 19, Name = "Git", Category = "Tools & Others", Level = 85, Icon = "devicon-git-plain" },
            new Skill { Id = 20, Name = "Docker", Category = "Tools & Others", Level = 70, Icon = "devicon-docker-plain" },
            new Skill { Id = 21, Name = "SQL", Category = "Tools & Others", Level = 80, Icon = "devicon-mysql-plain" },
            new Skill { Id = 22, Name = "Power BI", Category = "Tools & Others", Level = 70, Icon = "fas fa-chart-bar" },
            new Skill { Id = 23, Name = "Figma", Category = "Tools & Others", Level = 65, Icon = "devicon-figma-plain" },
            new Skill { Id = 24, Name = "Odoo", Category = "Tools & Others", Level = 85, Icon = "fas fa-cogs" },
            new Skill { Id = 25, Name = "Scrum/Kanban", Category = "Methodology", Level = 80, Icon = "fas fa-tasks" }
        );

        // Seed Certifications
        modelBuilder.Entity<Certification>().HasData(
            new Certification { Id = 1, Name = "Introduction to Ethical Hacking and IOT Cybersecurity / IOT Equipment Penetration Test", Issuer = "Certification", Date = "2022", Description = "Certification en cybersécurité éthique et tests de pénétration IoT." },
            new Certification { Id = 2, Name = "Cybersecurity & Smart Factory – Hackathon .01", Issuer = "Hackathon", Date = "2022", Description = "Participation et certification au hackathon Cybersecurity & Smart Factory." },
            new Certification { Id = 3, Name = "Python for Data Science", Issuer = "Online Platform", Date = "2022", Description = "Certification Python orientée data science." },
            new Certification { Id = 4, Name = "First Aid Training", Issuer = "Club CRT-ISIMS", Date = "2022", Description = "Formation aux premiers secours." },
            new Certification { Id = 5, Name = "Digital Marketing", Issuer = "CLUB-Tunivision-ESSTHS", Date = "2022", Description = "Certification en marketing digital." }
        );

        // Seed Languages
        modelBuilder.Entity<Language>().HasData(
            new Language { Id = 1, Name = "Arabe", Level = 100, Proficiency = "Langue maternelle" },
            new Language { Id = 2, Name = "Français", Level = 85, Proficiency = "Courant" },
            new Language { Id = 3, Name = "Anglais", Level = 75, Proficiency = "Intermédiaire avancé" },
            new Language { Id = 4, Name = "Allemand", Level = 40, Proficiency = "Notions de base" }
        );

        // Seed Community Activities
        modelBuilder.Entity<CommunityActivity>().HasData(
            new CommunityActivity { Id = 1, Role = "Vice-Président", Organization = "Junior Chamber International Tunisia", StartDate = "Janvier 2023", EndDate = "Aujourd'hui", Order = 1 },
            new CommunityActivity { Id = 2, Role = "Secrétaire Général", Organization = "Junior Chamber International Tunisia", StartDate = "Janvier 2021", EndDate = "Décembre 2022", Order = 2 },
            new CommunityActivity { Id = 3, Role = "Trésorier", Organization = "Tunisian Red Crescent-Club ISIMS", StartDate = "Novembre 2020", EndDate = "Novembre 2021", Order = 3 }
        );
    }
}
