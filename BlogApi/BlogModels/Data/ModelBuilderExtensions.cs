using BlogModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogModels.Data
{
    public class ModelBuilderExtensions
    {
        public static IConfiguration _configuration { get; set; }
        public static DBContext _context { get; set; }
        public static ModelBuilder modelBuilder { get; set; }


        public static void Seed()
        {
            modelBuilder.Entity<Topic>();
            modelBuilder.Entity<TopicCategory>();
            modelBuilder.Entity<Category>();
            //modelBuilder.Entity<Post>();
            //modelBuilder.Entity<Comment>();
            modelBuilder.Entity<TopicsSubbed>();

            modelBuilder.Entity<Topic>().HasData(_Topics);
            modelBuilder.Entity<Category>().HasData(_categories);
            modelBuilder.Entity<TopicCategory>().HasData(TopicCategories);
            ////modelBuilder.Entity<Post>().HasData(_Posts);
            ////modelBuilder.Entity<Comment>().HasData(_Comments);
            //modelBuilder.Entity<TopicsSubbed>().HasData(_TopicsSubbed);

        }

        private readonly static List<Topic> _Topics = new List<Topic>
        {
            new Topic
            {
                TopicID = Guid.Parse("cd079536-9ebb-4a2f-9224-bfcb2761f45f"),
                Name = "Jojo's Bizzare Adventure",
                Description = "This Topic is for people who like JoJo",
                AmountMembers = 2,
                Birthdate = DateTime.Now,
            },
            new Topic
            {
                TopicID = Guid.Parse("fc3f337b-8f46-4f9c-86bd-621be82988ef"),
                Name = "Star Wars",
                Description = "This Topic is for people who like Star wars",
                AmountMembers = 2,
                Birthdate = DateTime.Now,
            },
        };
        private readonly static List<TopicCategory> TopicCategories = new List<TopicCategory>
        {
            new TopicCategory
            {
                TopicID = Guid.Parse("cd079536-9ebb-4a2f-9224-bfcb2761f45f"),
            CategoryID = Guid.Parse("b12fb3a5-3072-4a71-b563-f1de5c16f32f"),
            },
            new TopicCategory
            {
                TopicID = Guid.Parse("cd079536-9ebb-4a2f-9224-bfcb2761f45f"),
                CategoryID = Guid.Parse("c3042674-2f22-4158-ae24-a4c32b113787"),
            },
            new TopicCategory
            {
                TopicID = Guid.Parse("fc3f337b-8f46-4f9c-86bd-621be82988ef"),
                CategoryID = Guid.Parse("4a41f853-64a7-431e-95b7-c35022a727bc"),
            },
        };
        private readonly static List<Category> _categories = new List<Category>
        {
            new Category
            {
                CategoryID= Guid.Parse("b12fb3a5-3072-4a71-b563-f1de5c16f32f"),
                Name= "Meme",
                Color="red",
                Description="This is the meme category, use this so people can see your meme faster!",
    },
            new Category
            {
                CategoryID= Guid.Parse("c3042674-2f22-4158-ae24-a4c32b113787"),
                Name= "Update",
                Color="green",
                Description="This category is used to showcase a community update.",
            },
            new Category
            {
                CategoryID= Guid.Parse("4a41f853-64a7-431e-95b7-c35022a727bc"),
                Name= "Discussion",
                Color="blue",
                Description="This category is used to tag posts as Discussion.",
            },
        };

        //private readonly static List<Post> _Posts = new List<Post>
        //{
        //    new Post
        //    {
        //        PostID = Guid.Parse("ed86f07c-1c76-4ded-bbd4-b94c5d3de26a"),
        //        Text = "Do you guys also think Jar Jar Binks is underrated?",
        //        Upvotes = 0,
        //        Downvotes = 0,
        //        DateMade = DateTime.Now,
        //        CategoryID = Guid.Parse("4a41f853-64a7-431e-95b7-c35022a727bc"),
        //        UserName = "TestUser2"
        //    },
        //    new Post
        //    {
        //        PostID = Guid.Parse("9b91f15b-7f00-419d-a33a-2ed464f6441a"),
        //        Text = "Jotaro is the best character HANDS DOWN!",
        //        Upvotes = 0,
        //        Downvotes = 0,
        //        DateMade = DateTime.Now,
        //        CategoryID = Guid.Parse("b12fb3a5-3072-4a71-b563-f1de5c16f32f"),
        //        UserName = "TestUser1"
        //    },
        //};

        //private readonly static List<Comment> _Comments = new List<Comment>
        //{
        //    new Comment
        //    {
        //        CommentID = Guid.NewGuid(),
        //        CommentText="Dude You are so WRONG, how could you be so stupid?",
        //        DateMade= DateTime.Now,
        //        Upvotes=0,
        //        Downvotes=0,
        //        PostID = Guid.Parse("9b91f15b-7f00-419d-a33a-2ed464f6441a"),
        //        UserName = "TestUser2"
        //    },
        //    new Comment
        //    {
        //        CommentID = Guid.NewGuid(),
        //        CommentText="Meh, i think he's just so unnecessary in the prequels",
        //        DateMade= DateTime.Now,
        //        Upvotes=0,
        //        Downvotes=0,
        //        PostID = Guid.Parse("ed86f07c-1c76-4ded-bbd4-b94c5d3de26a"),
        //        UserName = "TestUser1"
        //    },
        //};

        private readonly static List<TopicsSubbed> _TopicsSubbed = new List<TopicsSubbed>
        {
            new TopicsSubbed
            {
                TopicID = Guid.Parse("cd079536-9ebb-4a2f-9224-bfcb2761f45f"),
                UserID = "TestUser2",
                MadeTopic = false
            },
            new TopicsSubbed
            {
                TopicID = Guid.Parse("fc3f337b-8f46-4f9c-86bd-621be82988ef"),
                UserID = "TestUser1",
                MadeTopic = false
            },
            new TopicsSubbed
            {
                TopicID = Guid.Parse("fc3f337b-8f46-4f9c-86bd-621be82988ef"),
                UserID = "Romuald",
                MadeTopic = true
            },
            new TopicsSubbed
            {
                TopicID = Guid.Parse("cd079536-9ebb-4a2f-9224-bfcb2761f45f"),
                UserID = "Romuald",
                MadeTopic = true
            },
        };
    }
}
