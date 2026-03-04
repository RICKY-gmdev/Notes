# 📝 Notes — Cloud-Native Notes Management System

A full-stack notes management application built with a modern .NET backend and TypeScript frontend, containerized with Docker and deployable to Kubernetes. Built as a hands-on learning project to explore cloud-native development patterns.

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core 9 (Minimal APIs) |
| Database | PostgreSQL |
| Frontend | TypeScript, HTML, CSS |
| Containers | Docker |
| Orchestration | Kubernetes (K8s) |
| CI | GitHub Actions |

---

## ✨ Features

- **CRUD Notes** — Create, read, update, and delete notes via a RESTful API
- **Minimal API Design** — Clean, lightweight endpoint structure with ASP.NET Core
- **Persistent Storage** — PostgreSQL with Entity Framework Core and migrations
- **Containerized** — Docker images for both API and frontend
- **Kubernetes Ready** — K8s manifests for deployment and service exposure
- **CI Pipeline** — GitHub Actions automatically builds and validates on every push

---

## 🏗️ Project Structure

```
Notes/
├── ftest1.Notes.Api/       # ASP.NET Core Minimal API
│   ├── Controllers/        # Route handlers
│   ├── Data/               # AppDbContext (EF Core)
│   ├── Migrations/         # Database migrations
│   ├── Models/             # Entity models
│   └── Program.cs          # App entry point
├── f1test.Notes.Web/       # TypeScript frontend
│   ├── src/                # App source
│   └── index.html          # Entry HTML
├── k8s/                    # Kubernetes manifests
└── .github/workflows/      # GitHub Actions CI
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Node.js](https://nodejs.org/) (for frontend)
- [kubectl](https://kubernetes.io/docs/tasks/tools/) (for K8s deployment)

### Run the API locally

```bash
cd ftest1.Notes.Api
dotnet restore
dotnet run
```

### Run the Frontend locally

```bash
cd f1test.Notes.Web
npm install
npm run build
```

### Deploy to Kubernetes

```bash
kubectl apply -f k8s/
```

---

## ⚙️ CI/CD

GitHub Actions runs automatically on every push to `main` and on all pull requests.

| Job | What it does |
|---|---|
| `build-api` | Restores, builds the .NET API and connects to a real PostgreSQL instance |
| `build-ui` | Installs dependencies and compiles TypeScript |

---

## 🗺️ Roadmap

- [x] CRUD Notes API
- [x] PostgreSQL + EF Core
- [x] Docker + Kubernetes setup
- [x] GitHub Actions CI
- [ ] JWT Authentication
- [ ] Pagination

---

## 📖 What I Learned

- Building Minimal APIs with ASP.NET Core 9
- Entity Framework Core with PostgreSQL
- Writing Kubernetes manifests by hand
- Setting up GitHub Actions CI with service containers
- Git branching workflow and best practices
