using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Telegram.Bot.Types;

#nullable disable

namespace TheConversationsBot.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Conversations");

            migrationBuilder.CreateTable(
                name: "logs",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    from_id = table.Column<long>(type: "bigint", nullable: false),
                    to_id = table.Column<long>(type: "bigint", nullable: false),
                    update_message = table.Column<Message>(type: "jsonb", nullable: false),
                    exception_message = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    telegram_client_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    client_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    user_name = table.Column<string>(type: "text", nullable: false),
                    nickname = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    is_premium = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                    table.ForeignKey(
                        name: "FK_clients_users_user_id",
                        column: x => x.user_id,
                        principalSchema: "Conversations",
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "boards",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nickname = table.Column<string>(type: "text", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    board_status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boards", x => x.id);
                    table.ForeignKey(
                        name: "FK_boards_clients_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "Conversations",
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conversations",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    from_id = table.Column<long>(type: "bigint", nullable: false),
                    to_id = table.Column<long>(type: "bigint", nullable: false),
                    state = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversations", x => x.id);
                    table.ForeignKey(
                        name: "FK_conversations_clients_from_id",
                        column: x => x.from_id,
                        principalSchema: "Conversations",
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conversations_clients_to_id",
                        column: x => x.to_id,
                        principalSchema: "Conversations",
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                schema: "Conversations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    from_id = table.Column<long>(type: "bigint", nullable: false),
                    content = table.Column<Message>(type: "jsonb", nullable: false),
                    conversation_id = table.Column<long>(type: "bigint", nullable: true),
                    board_id = table.Column<long>(type: "bigint", nullable: true),
                    message_type = table.Column<int>(type: "integer", nullable: false),
                    message_status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_messages_boards_board_id",
                        column: x => x.board_id,
                        principalSchema: "Conversations",
                        principalTable: "boards",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_messages_clients_from_id",
                        column: x => x.from_id,
                        principalSchema: "Conversations",
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messages_conversations_conversation_id",
                        column: x => x.conversation_id,
                        principalSchema: "Conversations",
                        principalTable: "conversations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_boards_owner_id",
                schema: "Conversations",
                table: "boards",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_clients_user_id",
                schema: "Conversations",
                table: "clients",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_conversations_from_id",
                schema: "Conversations",
                table: "conversations",
                column: "from_id");

            migrationBuilder.CreateIndex(
                name: "IX_conversations_to_id",
                schema: "Conversations",
                table: "conversations",
                column: "to_id");

            migrationBuilder.CreateIndex(
                name: "IX_messages_board_id",
                schema: "Conversations",
                table: "messages",
                column: "board_id");

            migrationBuilder.CreateIndex(
                name: "IX_messages_conversation_id",
                schema: "Conversations",
                table: "messages",
                column: "conversation_id");

            migrationBuilder.CreateIndex(
                name: "IX_messages_from_id",
                schema: "Conversations",
                table: "messages",
                column: "from_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_phone_number",
                schema: "Conversations",
                table: "users",
                column: "phone_number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logs",
                schema: "Conversations");

            migrationBuilder.DropTable(
                name: "messages",
                schema: "Conversations");

            migrationBuilder.DropTable(
                name: "boards",
                schema: "Conversations");

            migrationBuilder.DropTable(
                name: "conversations",
                schema: "Conversations");

            migrationBuilder.DropTable(
                name: "clients",
                schema: "Conversations");

            migrationBuilder.DropTable(
                name: "users",
                schema: "Conversations");
        }
    }
}
