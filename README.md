# 🚀 Portfolio – Amal Ben Abdelghaffar
> Full-Stack Developer Portfolio built with **.NET 9 Web API** + **Angular 19**

## 📂 Structure
```
portfolio/
├── PortfolioApi/          ← Backend .NET 9 (API REST + SQLite)
└── portfolio-frontend/    ← Frontend Angular 19
```

## ▶️ Lancer le projet

### 1. Backend (.NET API) – Port 5050
```bash
cd PortfolioApi
dotnet run --launch-profile http
```
📌 API disponible sur: http://localhost:5050  
📌 Documentation Scalar: http://localhost:5050/scalar

### 2. Frontend Angular – Port 4200
```bash
cd portfolio-frontend
npx ng serve --port 4200
```
📌 Application: http://localhost:4200

## 🔌 Endpoints API
| Endpoint | Description |
|----------|-------------|
| `GET /api/profile` | Profil personnel |
| `GET /api/experiences` | Expériences pro (triées) |
| `GET /api/educations` | Formation académique |
| `GET /api/skills` | Compétences techniques |
| `GET /api/languages` | Langues |
| `GET /api/certifications` | Certifications |
| `GET /api/community` | Vie associative |

## 🛠️ Technologies
- **Backend**: ASP.NET Core 9, Entity Framework Core 9, SQLite, Scalar API docs
- **Frontend**: Angular 19, TypeScript, CSS (Custom design system)
- **BDD**: SQLite (portfolio.db, auto-créée au démarrage)
