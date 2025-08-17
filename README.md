# Fitness Coach App

A modern full-stack web application for fitness coaching, featuring a React frontend with Chakra UI and a .NET 9 Web API backend.

Testing the potential of AI Agents, specifically Claude Sonnet 4

## 🏗️ Project Structure

```
fitness-coach/
├── frontend/                  # React frontend with Chakra UI
│   ├── public/
│   ├── src/
│   │   ├── components/       # Reusable UI components
│   │   ├── pages/           # Page components
│   │   ├── services/        # API service functions
│   │   ├── hooks/           # Custom React hooks
│   │   └── theme/           # Chakra UI theme configuration
│   ├── package.json
│   └── package-lock.json
├── backend/                   # .NET 9 Web API
│   ├── Controllers/          # API controllers
│   ├── Models/              # Data models
│   ├── Services/            # Business logic services
│   ├── Data/                # Mock data and context
│   └── Program.cs           # Application entry point
└── README.md
```

## 🚀 Quick Start

### Prerequisites

- **Frontend**: Node.js 18+ and npm
- **Backend**: .NET 9 SDK

### Running the Application

1. **Clone and navigate to the project:**
   ```bash
   cd fitness-coach
   ```

2. **Start the Backend (.NET 9 Web API):**
   ```bash
   cd backend
   dotnet restore
   dotnet run
   ```
   The API will be available at: `http://localhost:5000`
   API Documentation (Swagger): `http://localhost:5000/swagger`

3. **Start the Frontend (React + Chakra UI):**
   ```bash
   cd frontend
   npm install
   npm start
   ```
   The frontend will be available at: `http://localhost:3000`

## 🛠️ Technology Stack

### Frontend
- **React 18**: Modern React with functional components and hooks
- **Chakra UI**: Modular and accessible component library
- **Axios**: HTTP client for API requests
- **React Router**: Client-side routing

### Backend
- **.NET 9**: Latest .NET framework
- **ASP.NET Core Web API**: RESTful API development
- **Entity Framework Core**: Data access (configured for mock data)
- **CORS**: Cross-origin resource sharing

## 📁 Key Files

### Frontend
- `src/pages/HomePage.jsx`: Main landing page component
- `src/components/`: Reusable UI components
- `src/services/api.js`: API service functions
- `src/hooks/useCoaches.js`: Custom hook for fetching coaches

### Backend
- `Controllers/CoachesController.cs`: API endpoints for coaches
- `Models/Coach.cs`: Coach data model
- `Services/CoachService.cs`: Business logic for coach operations
- `Data/MockData.cs`: Sample data for testing

## 🔧 Development

### Adding New Features
1. **Frontend**: Create components in `src/components/` and pages in `src/pages/`
2. **Backend**: Add controllers in `Controllers/` and models in `Models/`
3. **API Integration**: Update `src/services/api.js` with new endpoints

### Styling
- Use Chakra UI components for consistent design
- Custom theme configuration in `src/theme/`
- Responsive design with Chakra UI's responsive props

## 📝 License

This project is open source and available under the [MIT License](LICENSE).
