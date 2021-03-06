using ApiGraphQL.UtilGraphQL;
using ApiGraphQL.UtilGraphQL.Types;
using DataRepository;
using DataRepository.Interface;
using MyGraphQLAPI.Repository.UtilGraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IJogoRepository, JogoRepository>();
builder.Services.AddScoped<IJogoGeneroRepository, JogoGeneroRepository>();
builder.Services.AddScoped<IEstudioRepository, EstudioRepository>();

builder.Services.AddScoped<DbContext>(_ =>
    new DbContext(builder.Configuration.GetConnectionString("PostgresConnection"))
);


builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<JogoType>()
    .AddType<GeneroType>()
    .AddType<EstudioType>()
    .AddMutationType<Mutation>()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();
app.MapGraphQL();
app.Run();
