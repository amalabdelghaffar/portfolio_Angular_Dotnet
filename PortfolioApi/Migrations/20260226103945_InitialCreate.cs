using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Issuer = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunityActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Organization = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Degree = table.Column<string>(type: "TEXT", nullable: false),
                    Institution = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Technologies = table.Column<string>(type: "TEXT", nullable: false),
                    IsCurrent = table.Column<bool>(type: "INTEGER", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Proficiency = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    GithubUrl = table.Column<string>(type: "TEXT", nullable: false),
                    LinkedinUrl = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Date", "Description", "Issuer", "Name" },
                values: new object[,]
                {
                    { 1, "2022", "Certification en cybersécurité éthique et tests de pénétration IoT.", "Certification", "Introduction to Ethical Hacking and IOT Cybersecurity / IOT Equipment Penetration Test" },
                    { 2, "2022", "Participation et certification au hackathon Cybersecurity & Smart Factory.", "Hackathon", "Cybersecurity & Smart Factory – Hackathon .01" },
                    { 3, "2022", "Certification Python orientée data science.", "Online Platform", "Python for Data Science" },
                    { 4, "2022", "Formation aux premiers secours.", "Club CRT-ISIMS", "First Aid Training" },
                    { 5, "2022", "Certification en marketing digital.", "CLUB-Tunivision-ESSTHS", "Digital Marketing" }
                });

            migrationBuilder.InsertData(
                table: "CommunityActivities",
                columns: new[] { "Id", "EndDate", "Order", "Organization", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, "Aujourd'hui", 1, "Junior Chamber International Tunisia", "Vice-Président", "Janvier 2023" },
                    { 2, "Décembre 2022", 2, "Junior Chamber International Tunisia", "Secrétaire Général", "Janvier 2021" },
                    { 3, "Novembre 2021", 3, "Tunisian Red Crescent-Club ISIMS", "Trésorier", "Novembre 2020" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "Description", "EndDate", "Institution", "Location", "Order", "StartDate" },
                values: new object[,]
                {
                    { 1, "Software Engineering", "Formation en ingénierie logicielle avec spécialisation en développement fullstack et technologies modernes.", "En cours", "Institute of Advanced Sciences and Technology", "Sfax, Tunisia", 1, "Septembre 2023" },
                    { 2, "Licence en Informatique – Big Data & Data Analysis", "Licence spécialisée en Big Data et analyse de données.", "Juin 2023", "Higher Institute of Computer Science and Multimedia (ISIMS)", "Sfax, Tunisia", 2, "Septembre 2020" },
                    { 3, "Baccalauréat en Sciences Expérimentales", "Baccalauréat dans la filière sciences expérimentales.", "Juillet 2020", "Lycée Menzel Hayet Monastir", "Manzel Hayet, Tunisia", 3, "Septembre 2019" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "Description", "EndDate", "IsCurrent", "Location", "Order", "StartDate", "Technologies", "Title" },
                values: new object[,]
                {
                    { 1, "DigitalClick", "Développement et maintenance de modules Odoo. Gestion des ERP, CRM, Achat, Ventes, Comptabilité et Inventaire.", "", true, "Safaqis, SF, Tunisia", 1, "Avril 2025", "Python, Odoo, XML, ERP, CRM", "Odoo/Python Developer" },
                    { 2, "Digital Click", "Développement fullstack avec ASP.NET MVC, SSMS, Entity Framework, Identity et Nuget. Intégration de WordPress, Elementor, WPbakery, SEO, WooCommerce, Brevo et Mailchimp.", "Avril 2025", false, "Sfax, Tunisia", 2, "Novembre 2024", "ASP.NET, MVC, SSMS, Entity Framework, GIT, DEVEXTREAM, WordPress, Elementor, SEO, WooCommerce", "Fullstack Developer" },
                    { 3, "Amatab", "Management et développement de sites WordPress. Intégration et configuration de plugins (SMTP, WPForms). Hébergement avec Hostinger. Administration et optimisation des environnements Microsoft 365 (SharePoint, Power Apps, Teams).", "Novembre 2024", false, "SFAX, Tunisia", 3, "Septembre 2024", "WordPress, SMTP, WPForms, Hostinger, Microsoft 365, SharePoint, Power Apps, CRM", "WordPress Developer & Microsoft 365 CRM Maintenance" },
                    { 4, "Anavid", "Nettoyage de données, gestion d'équipe, analyse de données, annotation et collection de données. Segmentation, SCRUM, Ubuntu.", "Juin 2024", false, "Sfax, Tunisia", 4, "Juillet 2023", "Python, Data Analysis, Data Cleaning, Segmentation, SCRUM, Microsoft Excel", "Data Analysts Manager" },
                    { 5, "Anavid", "PFE: Estimation du nombre de personnes dans une foule en utilisant des modèles de deep learning implémentés dans une interface web Flask.", "Mai 2023", false, "Sfax, Sakiet Ezzit, Tunisia", 5, "Février 2023", "Python, Deep Learning, Flask, Computer Vision", "Intern – Crowd Counting AI" },
                    { 6, "Optimal Solution", "Développement d'un module de segmentation RFM des clients sous Odoo 15, avec analyse de données, visualisation et Python.", "Septembre 2022", false, "Sahloul/Sousse, Tunisia", 6, "Juillet 2022", "Odoo 15, Python, Data Analysis, Segmentation, Visualization", "Summer Internship – RFM Segmentation" },
                    { 7, "ISIMS", "Développement d'une plateforme web avec Laravel. Architecture MVC, modélisation UML, CRUD, Docker.", "2022", false, "Sfax, Tunisia", 7, "2022", "Laravel, PHP, MVC, UML, CRUD, Docker", "Web Platform Developer (Laravel/PHP)" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Level", "Name", "Proficiency" },
                values: new object[,]
                {
                    { 1, 100, "Arabe", "Langue maternelle" },
                    { 2, 85, "Français", "Courant" },
                    { 3, 75, "Anglais", "Intermédiaire avancé" },
                    { 4, 40, "Allemand", "Notions de base" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "About", "AvatarUrl", "Email", "FullName", "GithubUrl", "LinkedinUrl", "Location", "Phone", "Title" },
                values: new object[] { 1, "Passionate Full-Stack Developer and Software Engineering student with expertise in .NET, Angular, Python, and Odoo. Experienced in ERP development, web platforms, data analysis, and AI/ML solutions. Driven by innovation and committed to building robust, scalable applications.", "/assets/avatar.jpg", "abdelgaffaramal@gmail.com", "Ben Abdelghaffar AMAL", "https://github.com/amalabdelghaffar", "https://www.linkedin.com/in/amalbenabdelghaffar/", "Sfax, Tunisia", "21 491 299", "Software Engineering Student | Full-Stack Developer" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Category", "Icon", "Level", "Name" },
                values: new object[,]
                {
                    { 1, "Programming Languages", "devicon-python-plain", 90, "Python" },
                    { 2, "Programming Languages", "devicon-csharp-plain", 85, "C#" },
                    { 3, "Programming Languages", "devicon-java-plain", 70, "Java" },
                    { 4, "Programming Languages", "devicon-php-plain", 75, "PHP" },
                    { 5, "Programming Languages", "devicon-c-plain", 65, "C" },
                    { 6, "Web Development", "devicon-angularjs-plain", 85, "Angular" },
                    { 7, "Web Development", "devicon-dotnetcore-plain", 85, "ASP.NET MVC" },
                    { 8, "Web Development", "devicon-laravel-plain", 75, "Laravel" },
                    { 9, "Web Development", "devicon-flutter-plain", 60, "Flutter" },
                    { 10, "Web Development", "devicon-wordpress-plain", 80, "WordPress" },
                    { 11, "Web Development", "devicon-html5-plain", 90, "HTML/CSS" },
                    { 12, "Web Development", "devicon-javascript-plain", 80, "JavaScript" },
                    { 13, "Web Development", "devicon-flask-original", 75, "Flask" },
                    { 14, "Web Development", "devicon-bootstrap-plain", 85, "Bootstrap" },
                    { 15, "Artificial Intelligence", "devicon-tensorflow-original", 75, "TensorFlow" },
                    { 16, "Artificial Intelligence", "devicon-opencv-plain", 70, "OpenCV" },
                    { 17, "Artificial Intelligence", "fas fa-brain", 75, "Machine Learning" },
                    { 18, "Artificial Intelligence", "fas fa-network-wired", 70, "Deep Learning" },
                    { 19, "Tools & Others", "devicon-git-plain", 85, "Git" },
                    { 20, "Tools & Others", "devicon-docker-plain", 70, "Docker" },
                    { 21, "Tools & Others", "devicon-mysql-plain", 80, "SQL" },
                    { 22, "Tools & Others", "fas fa-chart-bar", 70, "Power BI" },
                    { 23, "Tools & Others", "devicon-figma-plain", 65, "Figma" },
                    { 24, "Tools & Others", "fas fa-cogs", 85, "Odoo" },
                    { 25, "Methodology", "fas fa-tasks", 80, "Scrum/Kanban" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "CommunityActivities");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
