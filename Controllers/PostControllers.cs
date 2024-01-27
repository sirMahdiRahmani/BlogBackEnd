using BlogBackEnd.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlogBackEnd.Controllers;

public class PostControllers
{
    public static void Map(string baseUrl, WebApplication app)
    {
        app.MapGet("/", (BlogDb db) => db.Posts.ToList());

        app.MapGet("/{id}", (BlogDb db, int id) =>
        {
            var post =  db.Posts.Find(id);
            return post is not null 
                ? Results.Ok(post)
                : Results.NotFound();
        });

        app.MapPost("/", async (BlogDb db, Post post) =>
        {
            db.Posts.Add(post);
            await db.SaveChangesAsync();
            return Results.Created($"/{baseUrl}/{post.PostId}", post);
        });

        app.MapPut("/{id}", async (BlogDb db, int id, Post post) =>
        {
            var existingPost = db.Posts.Find(id);
            if (existingPost is null)
            {
                return Results.NotFound();
            }

            existingPost = post;
            await db.SaveChangesAsync();
            return Results.NoContent();

        });

        app.MapDelete("/{id}", async (BlogDb db, int id) =>
        {
            var post = db.Posts.Find(id);
            if (post is null)
            {
                return Results.NotFound();
            }

            db.Posts.Remove(post);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}