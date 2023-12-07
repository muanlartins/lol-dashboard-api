var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
  options.AddPolicy(name: "Any", policy => { policy.WithOrigins("http://localhost:4200"); });
});

var app = builder.Build();
app.UseCors(x => x
  .AllowAnyMethod()
  .AllowAnyHeader()
  .SetIsOriginAllowed(origin => true)
  .AllowCredentials()
);

Request request = new Request();

app.MapPost("/auth", (Authorization authorization) =>
{
  request.authorization = authorization;

  return true;
});

app.MapGet("/summoner", async () =>
{
  Summoner summoner = await request.JsonRequest<Summoner>("/lol-summoner/v1/current-summoner", true);

  return summoner;
});

app.MapGet("/summoner/{summonerId}/champion/{championId}", async (string summonerId, string championId) =>
{
  Champion champion = await request.JsonRequest<Champion>(
    "/lol-champions/v1/inventories/{summonerId}/champions/{championId}"
      .Replace("{summonerId}", summonerId)
      .Replace("{championId}", championId)
  , true);

  string baseLoadScreen = await request.ImageRequest(champion.baseLoadScreenPath);
  champion.baseLoadScreen = baseLoadScreen;

  foreach (Skin skin in champion.skins) {
    string tile = await request.ImageRequest(skin.tilePath);
    skin.tile = tile;

    // string splash = await request.ImageRequest(skin.splashPath);
    // skin.splash = splash;

    if (skin.isBase) { 
      string uncenteredSplash = await request.ImageRequest(skin.uncenteredSplashPath);
      skin.uncenteredSplash = uncenteredSplash;
    }

    string loadScreen = await request.ImageRequest(skin.loadScreenPath);
    skin.loadScreen = loadScreen;
  }

  return champion;
});

app.MapGet("/summoner/{summonerId}/masteries", async (string summonerId) =>
{
  Mastery[] masteries = await 
    request.JsonRequest<Mastery[]>(
      "/lol-collections/v1/inventories/{summonerId}/champion-mastery".Replace("{summonerId}", summonerId), 
      true
    );

  return masteries;
});

app.MapGet("/champions", async () =>
{
  string version = (await request.JsonRequest<string[]>("https://ddragon.leagueoflegends.com/api/versions.json"))[0];

  Champions champions = await request.JsonRequest<Champions>(
    "https://ddragon.leagueoflegends.com/cdn/{version}/data/en_US/championFull.json"
    .Replace("{version}", version)
  );

  return champions.keys;
});

app.MapGet("/loots", async () =>
{
  Loot[] loots = await request.JsonRequest<Loot[]>("/lol-loot/v1/player-loot", true);

  return loots;
});

app.Run();
