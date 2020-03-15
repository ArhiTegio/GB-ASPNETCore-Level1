using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { 1, "Acne", 0 },
                    { 2, "Grune Erde", 1 },
                    { 3, "Albiro", 2 },
                    { 4, "Ronhill", 3 },
                    { 5, "Oddmolly", 4 },
                    { 6, "Boudestijn", 5 },
                    { 7, "Rosch creative culture", 6 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "BirthDay", "FirstName", "Patronymic", "SurName", "Telephone" },
                values: new object[,]
                {
                    { 30, 43, new DateTime(1977, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Леонард", "Ольгердович", "Горелов", "+7996-360-1094" },
                    { 31, 39, new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Родион", "Гастонович", "Третьяков", "+7990-696-4678" },
                    { 32, 33, new DateTime(1987, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Фанис", "Рудольфович", "Вешняков", "+7984-907-9991" },
                    { 33, 24, new DateTime(1996, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Армен", "Муслимович", "Хромов", "+7981-309-5955" },
                    { 34, 33, new DateTime(1987, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Адольф", "Власийович", "Новиков", "+7991-054-4512" },
                    { 37, 18, new DateTime(2002, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рамиз", "Власийович", "Голиков", "+7992-079-6155" },
                    { 36, 51, new DateTime(1969, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Нифонт", "Миленович", "Демидов", "+7993-399-9672" },
                    { 29, 18, new DateTime(2002, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ибрагим", "Ремович", "Сизов", "+7984-770-5237" },
                    { 38, 59, new DateTime(1961, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Алан", "Сильвестрович", "Майоров", "+7986-726-6083" },
                    { 39, 47, new DateTime(1973, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Фердинанд", "Иоаннович", "Окулов", "+7991-831-6162" },
                    { 35, 25, new DateTime(1995, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рашид", "Венедиктович", "Вешняков", "+7985-442-0284" },
                    { 28, 58, new DateTime(1962, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тамаз", "Пименович", "Поздняков", "+7987-324-8689" },
                    { 25, 39, new DateTime(1981, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Иосиф", "Ибрагимович", "Плотников", "+7986-251-5141" },
                    { 26, 52, new DateTime(1968, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Густав", "Антипович", "Комаров", "+7999-655-4472" },
                    { 40, 62, new DateTime(1958, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Новомир", "Митяович", "Платонов", "+7985-602-8267" },
                    { 24, 53, new DateTime(1967, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Клементий", "Дамирович", "Мухин", "+7983-115-2208" },
                    { 23, 63, new DateTime(1957, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вениамин", "Рашидович", "Михайлов", "+7987-370-2028" },
                    { 22, 26, new DateTime(1994, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Раис", "Митяович", "Малинин", "+7986-637-4561" },
                    { 21, 67, new DateTime(1953, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Родион", "Арамович", "Поликарпов", "+7996-431-2350" },
                    { 20, 69, new DateTime(1951, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ильхам", "Иосифович", "Пастухов", "+7994-763-5951" },
                    { 19, 48, new DateTime(1972, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Архип", "Лукьянович", "Зеленин", "+7990-558-7521" },
                    { 18, 70, new DateTime(1950, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Анвар", "Расимович", "Борисов", "+7986-113-8659" },
                    { 17, 60, new DateTime(1960, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Лукий", "Артамонович", "Фадеев", "+7999-634-6473" },
                    { 16, 45, new DateTime(1975, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Бахрам", "Вальтерович", "Шевцов", "+7983-825-6306" },
                    { 27, 68, new DateTime(1952, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Армен", "Мирославович", "Константинов", "+7998-068-8822" },
                    { 41, 53, new DateTime(1967, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Фарид", "Светозарович", "Беляев", "+7991-097-6698" },
                    { 44, 42, new DateTime(1978, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Арий", "Парфенийович", "Пирогов", "+7980-882-9698" },
                    { 43, 41, new DateTime(1979, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Марин", "Султанович", "Тихонов", "+7992-643-3041" },
                    { 67, 61, new DateTime(1959, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ануфрий", "Владиславович", "Чернов", "+7982-235-0664" },
                    { 66, 28, new DateTime(1992, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Макарий", "Акакийович", "Руднев", "+7986-688-2641" },
                    { 65, 73, new DateTime(1947, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Архип", "Зорийович", "Мещеряков", "+7984-254-5228" },
                    { 64, 34, new DateTime(1986, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Федосей", "Амадейович", "Безруков", "+7993-797-1041" },
                    { 63, 50, new DateTime(1970, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велизар", "Фаддейович", "Панков", "+7996-438-9555" },
                    { 62, 36, new DateTime(1984, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Платон", "Наильович", "Фадеев", "+7994-435-7711" },
                    { 61, 74, new DateTime(1946, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Эдуард", "Амвросийович", "Аникин", "+7983-634-2581" },
                    { 60, 29, new DateTime(1991, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Лукьян", "Арменович", "Корнилов", "+7986-481-6659" },
                    { 59, 29, new DateTime(1991, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рамиз", "Конрадович", "Волков", "+7981-143-7649" },
                    { 58, 19, new DateTime(2001, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Дементий", "Евграфович", "Уткин", "+7997-532-7215" },
                    { 57, 57, new DateTime(1963, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рамиз", "Марович", "Орлов", "+7989-455-1373" },
                    { 42, 40, new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рем", "Маринович", "Рябов", "+7999-806-7158" },
                    { 56, 20, new DateTime(2000, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вилен", "Исаакийович", "Исаев", "+7998-399-8480" },
                    { 54, 74, new DateTime(1946, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Иннокентий", "Вальтерович", "Горелов", "+7988-252-7789" },
                    { 53, 20, new DateTime(2000, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рихард", "Филимонович", "Рожков", "+7981-636-1018" },
                    { 52, 45, new DateTime(1975, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Якун", "Нифонтович", "Старостин", "+7994-758-0490" },
                    { 51, 55, new DateTime(1965, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Арам", "Мелентийович", "Леонов", "+7983-509-1005" },
                    { 50, 67, new DateTime(1953, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тимон", "Янович", "Овчинников", "+7983-581-0111" },
                    { 49, 60, new DateTime(1960, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Орландо", "Стефанович", "Троицкий", "+7984-379-4018" },
                    { 48, 41, new DateTime(1979, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Остромир", "Исайович", "Мешков", "+7992-005-8391" },
                    { 47, 53, new DateTime(1967, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рифат", "Камильович", "Краснов", "+7989-741-5656" },
                    { 46, 43, new DateTime(1977, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вениамин", "Людвигович", "Панков", "+7998-796-5223" },
                    { 45, 50, new DateTime(1970, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Пимен", "Равильович", "Мухин", "+7995-296-6191" },
                    { 15, 69, new DateTime(1951, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Хабиб", "Камильович", "Ильинский", "+7988-591-2003" },
                    { 55, 48, new DateTime(1972, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Бернар", "Джамалович", "Третьяков", "+7994-032-8446" },
                    { 14, 52, new DateTime(1968, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Федот", "Закирович", "Галкин", "+7984-227-9481" },
                    { 10, 41, new DateTime(1979, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Граф", "Мирославович", "Моисеев", "+7982-912-0476" },
                    { 12, 43, new DateTime(1977, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гоар", "Гордейович", "Гладков", "+7990-061-4358" },
                    { 13, 52, new DateTime(1968, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Гавриил", "Радиславович", "Власов", "+7993-956-0686" },
                    { 1, 54, new DateTime(1966, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Амин", "Ильясович", "Суханов", "+7981-497-4244" },
                    { 2, 62, new DateTime(1958, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Иосиф", "Бореславович", "Лаврентьев", "+7993-076-4639" },
                    { 3, 26, new DateTime(1994, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Фердинанд", "Никифорович", "Зуев", "+7999-324-9965" },
                    { 4, 47, new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Конрад", "Иакинфович", "Лебедев", "+7982-387-0662" },
                    { 5, 33, new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Краснослав", "Виленович", "Зубов", "+7983-410-7908" },
                    { 69, 54, new DateTime(1966, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Валентин", "Изяславович", "Черняев", "+7987-364-0956" },
                    { 7, 29, new DateTime(1991, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Якун", "Германович", "Герасимов", "+7988-532-9900" },
                    { 8, 47, new DateTime(1973, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Зорий", "Герасимович", "Аксенов", "+7981-824-6986" },
                    { 9, 72, new DateTime(1948, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Шамиль", "Эльдарович", "Ильинский", "+7997-385-5799" },
                    { 68, 55, new DateTime(1965, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Геласий", "Левович", "Степанов", "+7990-000-8899" },
                    { 6, 47, new DateTime(1973, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Амадей", "Гастонович", "Медведев", "+7985-412-2660" },
                    { 11, 33, new DateTime(1987, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Аарон", "Агапович", "Ильин", "+7984-274-5687" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "ImageUrl", "Name", "Order", "Price", "SectionId" },
                values: new object[,]
                {
                    { 12, 3, "product12.jpg", "Летний костюм", 11, 1025.0, 25 },
                    { 11, 3, "product11.jpg", "Джинсы женские", 10, 1025.0, 25 },
                    { 10, 3, "product10.jpg", "Женские джинсы", 9, 1025.0, 25 },
                    { 8, 1, "product8.jpg", "Костюм кролика", 7, 1025.0, 25 },
                    { 9, 1, "product9.jpg", "Красное китайское платье", 8, 1025.0, 25 },
                    { 6, 1, "product6.jpg", "Лёгкое голубое поло", 5, 1025.0, 2 },
                    { 5, 2, "product5.jpg", "Лёгкая майка", 4, 1025.0, 2 },
                    { 4, 1, "product4.jpg", "Джинсы", 3, 1025.0, 2 },
                    { 3, 1, "product3.jpg", "Красное платье", 2, 1025.0, 2 },
                    { 2, 1, "product2.jpg", "Розовое платье", 1, 1025.0, 2 },
                    { 1, 1, "product1.jpg", "Белое платье", 0, 1025.0, 2 },
                    { 7, 1, "product7.jpg", "Платье белое", 6, 1025.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "Order", "ParentId" },
                values: new object[,]
                {
                    { 7, "Для мужчин", 1, null },
                    { 1, "Спорт", 0, null },
                    { 2, "Nike", 0, 1 },
                    { 3, "Under Armour", 1, 1 },
                    { 4, "Adidas", 2, 1 },
                    { 5, "Puma", 3, 1 },
                    { 6, "ASICS", 4, 1 },
                    { 8, "Fendi", 0, 7 },
                    { 11, "Диор", 3, 7 },
                    { 10, "Valentino", 2, 7 },
                    { 30, "Обувь", 9, null },
                    { 29, "Сумки", 8, null },
                    { 28, "Одежда", 7, null },
                    { 27, "Интерьер", 6, null },
                    { 26, "Для дома", 5, null },
                    { 25, "Мода", 4, null },
                    { 24, "Для детей", 3, null },
                    { 23, "Versace", 4, 18 },
                    { 9, "Guess", 1, 7 },
                    { 22, "Dior", 3, 18 },
                    { 20, "Guess", 1, 18 },
                    { 19, "Fendi", 0, 18 },
                    { 18, "Для женщин", 2, null },
                    { 17, "Гуччи", 9, 7 },
                    { 16, "Шанель", 8, 7 },
                    { 14, "Prada", 6, 7 },
                    { 13, "Армани", 5, 7 },
                    { 12, "Версачи", 4, 7 },
                    { 21, "Valentino", 2, 18 },
                    { 15, "Дольче и Габбана", 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
