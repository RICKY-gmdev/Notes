# Notes Management System (Cloud-Native)

A robust, containerized notes management application built with a modern .NET stack, designed for scalability and ease of deployment.

## 🚀 Technical Highlights
- **Backend:** ASP.NET Core (Minimal APIs) for high-performance service delivery.
- **Database:** PostgreSQL for reliable, relational data storage.
- **Orchestration:** Kubernetes (K8s) manifests for automated deployment and scaling.
- **Containerization:** Docker & Docker Compose for multi-container environment setup.
- **Frontend:** ASP.NET Core Web / TypeScript.

## 🏗️ Architecture
The project follows a decoupled architecture, separating the concerns of data persistence, business logic (API), and user interface (Web).

- `ftest1.Notes.Api`: The core engine handling RESTful endpoints and DB interactions.
- `f1test.Notes.Web`: The client-facing portal.
- `k8s/`: Infrastructure-as-Code (IaC) files for cluster deployment.

## 🛠️ Getting Started

### Prerequisites
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [.NET 8/9 SDK](https://dotnet.microsoft.com/download)

### Running with Docker Compose
To launch the entire stack (API, Web, and Database) with a single command:
```bash
docker-compose up --build
```
<img width="956" height="959" alt="Screenshot 2026-02-21 110419" src="https://github.com/user-attachments/assets/a789f18f-67b9-4c1f-abe5-dc3eb0209a11" />
