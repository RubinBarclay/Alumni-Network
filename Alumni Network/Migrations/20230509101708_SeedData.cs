using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumni_Network.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(2930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(2615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Sub",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(4188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Description", "IsPrivate", "Name" },
                values: new object[,]
                {
                    { 1, "Talk about anything and everything related to the amazing field of computer science!", false, "Computer Science" },
                    { 2, "Discuss the mind and how it works!", false, "Psychology" },
                    { 3, "Share your experiences and knowledge about the medical field!", false, "Medicine" },
                    { 4, "Fun, interesting or even devastating topics about the world of economics. Anything goes!", false, "Economics" },
                    { 5, "Share your knowledge about the amazing world of biology!", false, "Biology" },
                    { 6, "Share your ideas and thoughts about the world of philosophy!", false, "Philosophy" },
                    { 7, "Chat about your love for math with other geeky mathimaticians.", false, "Mathematics" },
                    { 8, "Big history buff are you? Then this is the group for you!", false, "History" },
                    { 9, "For people interested in the art and similar creative fields.", false, "Art" },
                    { 10, "Want to discuss something a little off-topic. Post it in here!", false, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "FunFact", "Name", "PictureUrl", "Status", "Sub" },
                values: new object[,]
                {
                    { 1, "I'm a student at the University of Washington.", "I can solve a rubik's cube in less than 12 seconds", "John Doe", "https://randomuser.me/api/portraits/men/67.jpg", "Comp sci student at the University of Washington", "df9ea233-b53d-4e1b-b155-258bbe7df862" },
                    { 2, "Aspiring psychologist currently studing at the Stockholm University.", "I like to eat cake in the shower", "Peter Olsson", "https://randomuser.me/api/portraits/men/0.jpg", "Learing how to analyze the mind", "9d1278a9-05ed-4dc9-8a1f-ad4e1105c10b" },
                    { 3, "I'm a recent graduate from the University of Ohio.", "I'm a huge fan of the Seattle Seahawks (and psychology)", "Jane Federstone", "https://randomuser.me/api/portraits/women/27.jpg", "Newly grad from the University of Ohio", "63d13f5d-8aa6-467e-986e-450f6e716f64" },
                    { 4, null, "I secretely LOVE history hehe", "Axel Schwarzbergen", null, "Slowly becoming a professional MD", "827614eb-c54e-43ae-a637-27eb70e385a8" },
                    { 5, null, null, "Sara Svensson", null, "Interning as a nurse at the Reykjavik University Hospital", "48ae61f5-5dc8-4058-85b6-887ac20e5b03" },
                    { 6, "Destined to save the world or whatever but right now I kinda just like studying and chilling with my boy Ron.", null, "Harry McPottson", "https://randomuser.me/api/portraits/men/80.jpg", "Studying magic at Hogwarts", "c0a72b96-f65c-473e-8ff1-f89b1097a937" },
                    { 7, "Researcher by day and hardcore gamer by night. But most of the time i just sit and stare at cells through a microscope.", null, "Alice Watson", "https://randomuser.me/api/portraits/women/72.jpg", null, "59207104-f1e4-4338-a507-bb217d223fbd" },
                    { 8, "Recent Harvard Economics graduate who wasted his 20's studying 16 hours a day.", null, "Jason Bilgums", "https://randomuser.me/api/portraits/men/89.jpg", "Looking for something to do with a economics degree", "a0d48da1-29c5-4a03-9755-897fa2908da6" },
                    { 9, null, null, "Sally Parker", "https://randomuser.me/api/portraits/women/50.jpg", "Thinking very hard about something...", "67de4545-3904-4f6d-ad22-abff0fc51fc8" },
                    { 10, "I'm a nerdy programmer with a big interest in finance and getting rich.", "I made and $650 by selling my first app", "Jeffrey Thompson", "https://randomuser.me/api/portraits/men/3.jpg", "Programming my own trading bot", "6c7fe842-2a02-4e03-88da-1892b91a797c" },
                    { 11, "There is nothing I love more than zoning out and mindlessly drawing for hours on end.", "I paid off my student loans with weird art commissions", "Lucy Kim", "https://randomuser.me/api/portraits/women/60.jpg", "Currently painting a masterpiece", "39f957a0-aecc-4fc3-9445-ecd93ad2e6e6" },
                    { 12, "I've always problem solving and working on complicated problems. Hence I became a mathimatician.", null, "Muhammad Al-Salehi", "https://randomuser.me/api/portraits/men/53.jpg", "Working on my own number theorem", "01f8e89d-ee69-4279-bd22-4b0afd9e8060" }
                });

            migrationBuilder.InsertData(
                table: "GroupUser",
                columns: new[] { "GroupsId", "MembersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 10 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 8 },
                    { 4, 10 },
                    { 5, 7 },
                    { 6, 9 },
                    { 7, 12 },
                    { 8, 4 },
                    { 9, 6 },
                    { 9, 11 },
                    { 10, 6 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "ReplyParentId", "TargetGroupId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 1, "I'm going to start a new project. Any ideas?" },
                    { 2, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 7, "How do I clean out this gunk from by beakers?" },
                    { 3, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 6, "I genuinely believe the earth is flat" },
                    { 4, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 8, "Tell me your top 3 historical figures and why" },
                    { 5, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 6, "What is the meaning of life?" },
                    { 6, 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 9, "How does one learn how to draw?" },
                    { 7, 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 4, "My review of Harvards Economics program" },
                    { 8, 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 4, "Was Keynes a communist?" },
                    { 9, 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 6, "I flunked my philosophy exam..." },
                    { 10, 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", null, 3, "Can anybody become a doctor?" },
                    { 11, 10, "The best way imo to start a new project and ACTUALLY FINISH IT, is by building a project that actually interests you. So try building a project that mixes in some other thing you're interested in.", 1, 1, "Do you have any other interests?" },
                    { 12, 4, "You are delusional and need to seek medical attention ASAP", 3, 6, "Go see a therapist" },
                    { 13, 8, "Ghandi, MLK and Nicola Tesla. Cus they are all dope af", 4, 8, "Here are my top 3" },
                    { 14, 9, "You're definitively not gonna find the answer some random internet forum lol", 5, 6, "Go fish" },
                    { 15, 10, "Doubt I'll ever get in but these are some cool insights", 7, 6, "Interesting review!" },
                    { 16, 2, "I have failed plenty of exams during my time at uni, just retake and study a little harder next time ;)", 9, 9, "Never give up" },
                    { 17, 4, "You don't have to be some kind of genius to become a doctor but it does take a very long time and a lot of studying.", 10, 3, "I guess but it's hard work" },
                    { 18, 5, "Despite what a lot of people think it's not that hard. I have talked to a lot of doctors that frankly aren't so bright", 10, 3, "Of course!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Sub",
                table: "Users",
                column: "Sub",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Sub",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "GroupUser",
                keyColumns: new[] { "GroupsId", "MembersId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Sub",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 12, 17, 8, 100, DateTimeKind.Local).AddTicks(3984));
        }
    }
}
