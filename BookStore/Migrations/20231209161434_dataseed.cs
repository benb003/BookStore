using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 9, 17, 14, 34, 45, DateTimeKind.Local).AddTicks(4936), 1, "History" },
                    { 2, new DateTime(2023, 12, 9, 17, 14, 34, 45, DateTimeKind.Local).AddTicks(5000), 2, "Science" },
                    { 3, new DateTime(2023, 12, 9, 17, 14, 34, 45, DateTimeKind.Local).AddTicks(5001), 3, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, "Yuval Noah Harari", 1, "Yuval Noah Harari, author of the critically acclaimed New York Times best seller and international phenomenon Sapiens, returns with an equally original, compelling, and provocative book, turning his focus toward humanity's future and our quest to upgrade humans into gods.", "B01MYZ4OUW", null, 250.0, "Homo Deus: A Brief History of Tomorrow" },
                    { 5, "Bill Bryson", 1, "One of the world’s most beloved and bestselling writers takes his ultimate journey -- into the most intriguing and intractable questions that science seeks to answer.", "B0000U7N00", null, 205.0, "A Short History of Nearly Everything" },
                    { 6, "Stephen Fry", 1, "Here are the thrills, grandeur, and unabashed fun of the Greek myths, stylishly retold by Stephen Fry. The legendary writer, actor, and comedian breathes life into ancient tales, from Pandora's box to Prometheus's fire, and transforms the adventures of Zeus and the Olympians into emotionally resonant and deeply funny stories, without losing any of their original wonder. Learned notes from the author offer rich cultural context. ", "B07WKRP2F2", null, 295.0, "Mythos " },
                    { 7, "Padraic Colum", 1, "Before time as we know it began, gods and goddesses lived in the city of Asgard. Odin All Father crossed the Rainbow Bridge to walk among men in Midgard. Thor defended Asgard with his mighty hammer. Mischievous Loki was constantly getting into trouble with the other gods, and dragons and giants walked free.", "B071KZGP84", null, 195.0, "The Children of Odin" },
                    { 8, "George RR Martin", 3, "Winter is coming. Such is the stern motto of House Stark, the northernmost of the fiefdoms that owe allegiance to King Robert Baratheon in far-off King's Landing. There Eddard Stark of Winterfell rules in Robert's name.", "B0001DBI1Q", null, 305.0, "A Game of Thrones" },
                    { 9, "J.R.R. Tolkien", 3, "With its first broadcast on BBC Radio 4 on March 8th, 1981, this dramatised tale of Middle Earth became an instant global classic. It boasts a truly outstanding cast including Ian Holm (as Frodo), Sir Michael Hordern (as Gandalf), Robert Stephens (as Aragorn), Bill Nighy (as Sam Gamgee) and John Le Mesurier (as Bilbo).", "B000VTQAVS", null, 345.0, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 10, "Mark Miodowink", 3, "Why is glass see-through? What makes elastic stretchy? Why does a paper clip bend? These are the sorts of questions that Mark Miodownik is constantly asking himself. A globally renowned materials scientist, Miodownik has spent his life exploring objects as ordinary as an envelope and as unexpected as concrete cloth, uncovering the fascinating secrets that hold together our physical world.", "B00LOMPF5S", null, 275.0, "Stuff Matters" },
                    { 11, "Tim James", 3, "In 2016, with the addition of four final elements - nihonium, moscovium, tennessine and oganesson - to make a total of 118 elements, the periodic table was finally complete, rendering any pre-existing books on the subject obsolete.", "B07D5GTVYQ", null, 220.0, "How the Periodic Table Can Now Explain Everything" },
                    { 12, "Nancy Forbes", 3, "Two of the boldest and most creative scientists of all time were Michael Faraday (1791-1867) and James Clerk Maxwell (1831-1879). This is the story of how these two men - separated in age by 40 years - discovered the existence of the electromagnetic field and devised a radically new theory which overturned the strictly mechanical view of the world that had prevailed since Newton's time. ", "B08QTQGQP4", null, 260.0, "How Two Men Revolutionized Physics" },
                    { 13, "Michael G. Raymer", 3, "Around 1900, physicists started to discover particles like electrons, protons, and neutrons, and with these discoveries believed they could predict the internal behavior of the atom. However, once their predictions were compared to the results of experiments in the real world, it became clear that the principles of classical physics and mechanics were far from capable of explaining phenomena on the atomic scale.", "B07LFK95Y2", null, 235.0, "Quantum Physics" },
                    { 14, "Albert Einstein", 3, "Albert Einstein described Relativity as a \"popular explosion\" of his famous theory. Written in 1916, it introduced the lay audience to the remarkable perspective that had overturned theoretical physics.", "B002XGLDAA", null, 175.0, "The Special and the General Theory " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
