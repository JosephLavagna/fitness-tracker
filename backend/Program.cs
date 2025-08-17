using FitnessCoachApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Add API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() 
    { 
        Title = "Fitness Coach API", 
        Version = "v1",
        Description = "API for managing bodybuilding fitness coaches and training programs"
    });
    
    // Include XML comments for better API documentation
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }
});

// Register services
builder.Services.AddScoped<CoachService>();
builder.Services.AddScoped<ProgramService>();

// Add CORS policy for frontend integration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React dev server
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

// Add logging
builder.Services.AddLogging();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fitness Coach API v1");
        c.RoutePrefix = string.Empty; // Serve Swagger at root
    });
}

// Enable CORS
app.UseCors("AllowReactApp");

// Use HTTPS redirection in production
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

// Add custom middleware for request logging
app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Request: {Method} {Path}", context.Request.Method, context.Request.Path);
    
    await next();
    
    logger.LogInformation("Response: {StatusCode}", context.Response.StatusCode);
});

app.UseAuthorization();

app.MapControllers();

// Add a health check endpoint
app.MapGet("/health", () => new { 
    Status = "Healthy", 
    Timestamp = DateTime.UtcNow,
    Environment = app.Environment.EnvironmentName 
});

// Add a root endpoint with API information
app.MapGet("/", () => new { 
    Message = "Welcome to the Elite Fitness Coach API", 
    Version = "1.0.0",
    Documentation = "/swagger",
    Endpoints = new[] {
        "/api/coaches",
        "/api/coaches/featured", 
        "/api/programs",
        "/api/programs/featured"
    }
});

app.Run();
