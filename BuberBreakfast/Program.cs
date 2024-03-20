// Переменная builder для внедрения зависимостей и настройки
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}

// Переменная нашего приложения с помощью которого
// можем управлять конвейером запросов
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}