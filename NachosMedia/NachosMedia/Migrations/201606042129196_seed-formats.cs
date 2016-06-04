namespace NachosMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedformats : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Formats VALUES (1, 'CARD', 1)");
            Sql("INSERT INTO Formats VALUES (2, 'PUZZLE', 1)");
            Sql("INSERT INTO Formats VALUES (3, 'TRADITIONAL', 1)");
            Sql("INSERT INTO Formats VALUES (4, 'TABLETOP RPG', 1)");
            Sql("INSERT INTO Formats VALUES (5, 'OTHER', 1)");
            Sql("INSERT INTO Formats VALUES (6, 'HARDBACK', 2)");
            Sql("INSERT INTO Formats VALUES (7, 'PAPERBACK', 2)");
            Sql("INSERT INTO Formats VALUES (8, 'OTHER', 2)");
            Sql("INSERT INTO Formats VALUES (9, 'GRAPHIC NOVEL', 3)");
            Sql("INSERT INTO Formats VALUES (10, 'SINGLE ISSUE', 3)");
            Sql("INSERT INTO Formats VALUES (11, 'TRADE PAPERBACK', 3)");
            Sql("INSERT INTO Formats VALUES (12, 'OTHER', 3)");
            Sql("INSERT INTO Formats VALUES (13, '4K ULTRA HD BLU-RAY', 4)");
            Sql("INSERT INTO Formats VALUES (14, 'BLU-RAY', 4)");
            Sql("INSERT INTO Formats VALUES (15, 'BLU-RAY 3D', 4)");
            Sql("INSERT INTO Formats VALUES (16, 'DVD', 4)");
            Sql("INSERT INTO Formats VALUES (17, 'VHS', 4)");
            Sql("INSERT INTO Formats VALUES (18, 'OTHER', 4)");
            Sql("INSERT INTO Formats VALUES (19, 'CASSETTE', 5)");
            Sql("INSERT INTO Formats VALUES (20, 'CD', 5)");
            Sql("INSERT INTO Formats VALUES (21, 'VINYL', 5)");
            Sql("INSERT INTO Formats VALUES (22, '8-TRACK', 5)");
            Sql("INSERT INTO Formats VALUES (23, 'OTHER', 5)");
            Sql("INSERT INTO Formats VALUES (24, 'BLU-RAY', 6)");
            Sql("INSERT INTO Formats VALUES (25, 'DVD', 6)");
            Sql("INSERT INTO Formats VALUES (26, 'VHS', 6)");
            Sql("INSERT INTO Formats VALUES (27, 'OTHER', 6)");
            Sql("INSERT INTO Formats VALUES (28, 'ATARI 2600', 7)");
            Sql("INSERT INTO Formats VALUES (29, 'DREAMCAST', 7)");
            Sql("INSERT INTO Formats VALUES (30, 'GAMEBOY', 7)");
            Sql("INSERT INTO Formats VALUES (31, 'GAMEBOY ADVANCE', 7)");
            Sql("INSERT INTO Formats VALUES (32, 'GAMEBOY COLOR', 7)");
            Sql("INSERT INTO Formats VALUES (33, 'GAMECUBE', 7)");
            Sql("INSERT INTO Formats VALUES (34, 'NES', 7)");
            Sql("INSERT INTO Formats VALUES (35, 'NINTENDO DS', 7)");
            Sql("INSERT INTO Formats VALUES (36, 'NINTENDO 3DS', 7)");
            Sql("INSERT INTO Formats VALUES (37, 'N64', 7)");
            Sql("INSERT INTO Formats VALUES (38, 'PC', 7)");
            Sql("INSERT INTO Formats VALUES (39, 'PLAYSTATION', 7)");
            Sql("INSERT INTO Formats VALUES (40, 'PLAYSTATION 2', 7)");
            Sql("INSERT INTO Formats VALUES (41, 'PLAYSTATION 3', 7)");
            Sql("INSERT INTO Formats VALUES (42, 'PLAYSTATION 4', 7)");
            Sql("INSERT INTO Formats VALUES (43, 'PSP', 7)");
            Sql("INSERT INTO Formats VALUES (44, 'PS VITA', 7)");
            Sql("INSERT INTO Formats VALUES (45, 'SEGA GENESIS', 7)");
            Sql("INSERT INTO Formats VALUES (46, 'SNES', 7)");
            Sql("INSERT INTO Formats VALUES (47, 'WII', 7)");
            Sql("INSERT INTO Formats VALUES (48, 'WII U', 7)");
            Sql("INSERT INTO Formats VALUES (49, 'XBOX', 7)");
            Sql("INSERT INTO Formats VALUES (50, 'XBOX 360', 7)");
            Sql("INSERT INTO Formats VALUES (51, 'XBOX ONE', 7)");
            Sql("INSERT INTO Formats VALUES (52, 'OTHER', 7)");
            Sql("INSERT INTO Formats VALUES (53, 'OTHER', 8)");
        }
        
        public override void Down()
        {
        }
    }
}
