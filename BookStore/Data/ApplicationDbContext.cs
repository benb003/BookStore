using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "History",
                DisplayOrder = 1
            },
            new Category()
            {
                Id = 2,
                Name = "Science",
                DisplayOrder = 2
            },
            new Category()
            {
                Id = 3,
                Name = "Literature",
                DisplayOrder = 3
            });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 4,
                    Title = "Homo Deus: A Brief History of Tomorrow",
                    Description = "Yuval Noah Harari, author of the critically acclaimed New York Times best seller and international phenomenon Sapiens, returns with an equally original, compelling, and provocative book, turning his focus toward humanity's future and our quest to upgrade humans into gods.",
                    ISBN = "B01MYZ4OUW",
                    Author = "Yuval Noah Harari",
                    Price = 250,
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 5,
                    Title = "A Short History of Nearly Everything",
                    Description = "One of the world’s most beloved and bestselling writers takes his ultimate journey -- into the most intriguing and intractable questions that science seeks to answer.",
                    ISBN = "B0000U7N00",
                    Author = "Bill Bryson",
                    Price = 205,
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 6,
                    Title = "Mythos ",
                    Description = "Here are the thrills, grandeur, and unabashed fun of the Greek myths, stylishly retold by Stephen Fry. The legendary writer, actor, and comedian breathes life into ancient tales, from Pandora's box to Prometheus's fire, and transforms the adventures of Zeus and the Olympians into emotionally resonant and deeply funny stories, without losing any of their original wonder. Learned notes from the author offer rich cultural context. ",
                    ISBN = "B07WKRP2F2",
                    Author = "Stephen Fry",
                    Price = 295,
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 7,
                    Title = "The Children of Odin",
                    Description = "Before time as we know it began, gods and goddesses lived in the city of Asgard. Odin All Father crossed the Rainbow Bridge to walk among men in Midgard. Thor defended Asgard with his mighty hammer. Mischievous Loki was constantly getting into trouble with the other gods, and dragons and giants walked free.",
                    ISBN = "B071KZGP84",
                    Author = "Padraic Colum",
                    Price = 195,
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 8,
                    Title = "A Game of Thrones",
                    Description = "Winter is coming. Such is the stern motto of House Stark, the northernmost of the fiefdoms that owe allegiance to King Robert Baratheon in far-off King's Landing. There Eddard Stark of Winterfell rules in Robert's name.",
                    ISBN = "B0001DBI1Q",
                    Author = "George RR Martin",
                    Price = 305,
                    CategoryId = 3,
                }, new Product()
                {
                    Id = 9,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "With its first broadcast on BBC Radio 4 on March 8th, 1981, this dramatised tale of Middle Earth became an instant global classic. It boasts a truly outstanding cast including Ian Holm (as Frodo), Sir Michael Hordern (as Gandalf), Robert Stephens (as Aragorn), Bill Nighy (as Sam Gamgee) and John Le Mesurier (as Bilbo).",
                    ISBN = "B000VTQAVS",
                    Author = "J.R.R. Tolkien",
                    Price = 345,
                    CategoryId = 3,
                }, new Product()
                {
                    Id = 10,
                    Title = "Stuff Matters",
                    Description = "Why is glass see-through? What makes elastic stretchy? Why does a paper clip bend? These are the sorts of questions that Mark Miodownik is constantly asking himself. A globally renowned materials scientist, Miodownik has spent his life exploring objects as ordinary as an envelope and as unexpected as concrete cloth, uncovering the fascinating secrets that hold together our physical world.",
                    ISBN = "B00LOMPF5S",
                    Author = "Mark Miodowink",
                    Price = 275,
                    CategoryId = 3,

                }, new Product()
                {
                    Id = 11,
                    Title = "How the Periodic Table Can Now Explain Everything",
                    Description = "In 2016, with the addition of four final elements - nihonium, moscovium, tennessine and oganesson - to make a total of 118 elements, the periodic table was finally complete, rendering any pre-existing books on the subject obsolete.",
                    ISBN = "B07D5GTVYQ",
                    Author = "Tim James",
                    Price = 220,
                    CategoryId = 3,
                }, new Product()
                {
                    Id = 12,
                    Title = "How Two Men Revolutionized Physics",
                    Description = "Two of the boldest and most creative scientists of all time were Michael Faraday (1791-1867) and James Clerk Maxwell (1831-1879). This is the story of how these two men - separated in age by 40 years - discovered the existence of the electromagnetic field and devised a radically new theory which overturned the strictly mechanical view of the world that had prevailed since Newton's time. ",
                    ISBN = "B08QTQGQP4",
                    Author = "Nancy Forbes",
                    Price = 260,
                    CategoryId = 3,
                }, new Product()
                {
                    Id = 13,
                    Title = "Quantum Physics",
                    Description = "Around 1900, physicists started to discover particles like electrons, protons, and neutrons, and with these discoveries believed they could predict the internal behavior of the atom. However, once their predictions were compared to the results of experiments in the real world, it became clear that the principles of classical physics and mechanics were far from capable of explaining phenomena on the atomic scale.",
                    ISBN = "B07LFK95Y2",
                    Author = "Michael G. Raymer",
                    Price = 235,
                    CategoryId = 3,
                }, new Product()
                {
                    Id = 14,
                    Title = "The Special and the General Theory ",
                    Description = "Albert Einstein described Relativity as a \"popular explosion\" of his famous theory. Written in 1916, it introduced the lay audience to the remarkable perspective that had overturned theoretical physics.",
                    ISBN = "B002XGLDAA",
                    Author = "Albert Einstein",
                    Price = 175,
                    CategoryId = 3,
                }
                );

        }
    }
}
