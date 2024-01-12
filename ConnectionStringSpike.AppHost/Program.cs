var builder = DistributedApplication.CreateBuilder(args);


var redisCache1 = builder.AddRedisContainer("cache1", 6379);
var redisCache2 = builder.AddRedisContainer("cache2", 6380);


builder.AddProject<Projects.MinApiExample>("minapiexample")
    .WithReference(redisCache1)
    .WithReference(redisCache2);

builder.Build().Run();
