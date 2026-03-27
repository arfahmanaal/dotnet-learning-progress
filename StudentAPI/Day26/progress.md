# Day 26 Progress

## Topics Covered
- OpenAPI vs Swagger vs Swashbuckle
- Swagger Uses
- Built-in .NET 9 OpenAPI (AddOpenApi + MapOpenApi)
- Swashbuckle - full interactive browser UI + JWT 
- Installing `Swashbuckle.AspNetCore`
- Program.cs setup:
  - `AddSwaggerGen()` with `OpenApiInfo` (title, version, description)
  - `AddSecurityDefinition("Bearer", ...)` - JWT Authorize button
  - `AddSecurityRequirement(...)` - applies JWT globally to all endpoints
  - `app.UseSwagger()` + `app.UseSwaggerUI()` in Development only
  - `RoutePrefix = string.Empty` - Swagger UI at root URL
- `[ProducesResponseType]`
- Testing from Swagger UI - login -> copy token -> Authorize