using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class InitialDbCreationAndDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 1, "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.", "Action", "black_widow.jpg", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "Sci-Fi", "the_tomorrow_war.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition", "Comedy", "black_widow.jpg", new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitch Perfect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "A family falls victim to a group of mutated cannibals in a desert far away from civilization.", "Horror", "hills_have_eyes.jpg", new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hills Have Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway", "Animation", "up.jpg", new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", "pulp_fiction.jpg", new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 8, "Sniper: Legacy is a 2014 American direct-to-video action film directed by Don Michael Paul. It is the fifth installment in the Sniper film series and a sequel to Sniper: Reloaded (2011).", "full action movie", "Sniper-_Legacy_poster.jpg", new DateTime(2011, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sniper: Legacy " });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, " Smallville is an American superhero television series developed by writer-producers Alfred Gough and Miles Millar, based on the DC Comics character Superman created by Jerry Siegel and Joe Shuster.", "Drama", "smallville.jfif", new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMALLVILLE " });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, " Die Hard 2[Note 1] is a 1990 American action-thriller film and the second installment in the Die Hard film series.", "full action movie", "die_hard2.jpg", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Die Hard 2 " });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, " Hard Target is a 1993 American action film directed by Hong Kong film director John Woo in his U.S. debut.", "full action movie", "hard_target.jfif", new DateTime(1993, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "HARD TARGET" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, " Killing Them Softly is a 2012 American neo-noir crime film written and directed by Andrew Dominik and starring Brad Pitt, based on George V. Higgins' novel Cogan's Trade (1974). The film is about three small-time crooks who rob a Mob-protected illegal gambling operation, which prompts the Mob to send in two hitmen, Jackie (Pitt) and Mickey (James Gandolfini), to deal with the perpetrators.", "killing action movie", "kill_them.jpg", new DateTime(2002, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killing Them Softly" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, " Killing Me Softly is a 2002 erotic thriller film directed by Chen Kaige and starring Heather Graham and Joseph Fiennes. Based on the 1999 novel of the same name by Nicci French, it introduces several substantial changes to the story and focuses heavily on the intense sexual relationship between the two lead characters. It is Chen's first and only English-language film as of 2021.", "ROMANTIC MOVIE", "220px-Killing_Me_Softly_(film).jpg", new DateTime(2002, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killing Me Softly" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, " 71: Into the Fire (Korean: 포화 속으로) is a 2010 South Korean war drama film directed by John H. Lee and starring Cha Seung-won, Kwon Sang-woo, Choi Seunghyun (T.O.P), and Kim Seung-woo. The film was made in commemoration of those who fought during the Korean War, to raise awareness of the existence and importance of the student-soldiers during that period.", "drama", "71intofire.jpg", new DateTime(2010, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "71:INTO THE FIRE" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 15, " The Three Stooges were an American vaudeville and comedy team active from 1922 until 1970, best remembered for their 190 short subject films by Columbia Pictures. Their hallmark styles were physical farce and slapstick. Six Stooges appeared over the act's run (with only three active at any given time): Moe Howard (true name (t/n) Moses Horwitz) and Larry Fine (t/n Louis Feinberg) were mainstays throughout the ensemble's nearly 50-year run and the pivotal third stooge was played by (in order of appearance) Shemp Howard (t/n Samuel Horwitz), Curly Howard (t/n Jerome Horwitz), Shemp Howard again, Joe Besser, and Curly Joe DeRita.", "comedy ", "three_stooges.jpg", new DateTime(2012, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Three Stooges" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, "The Kick (Korean: 더 킥; Thai: วอนโดนเตะ!!) is a 2011 Thai martial arts film, directed by Prachya Pinkaew. The film follows a Korean family of taekwondo experts who immigrate to Thailand.", "full action movie ", "kick.jfif", new DateTime(2011, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "THE KICK" });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, "Behind Enemy Lines(the limit line) is a 2001 American war film directed by John Moore in his directorial debut, and starring Owen Wilson and Gene Hackman.", "full action movie ", "the_limit_line.jpg", new DateTime(2001, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "the_limit_line" });









        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
