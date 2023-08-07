create schema TCB;
create table TCB.users
(
    id                 serial PRIMARY KEY,
    telegram_client_id int,
    phone_number       varchar(13),
    password           varchar(24)
);


create table TCB.clients
(
    client_id        serial PRIMARY KEY,
    user_id          int,
    telegram_chat_id int,
    nickname         varchar(30),
    status           int,
    is_premium       bool,
    FOREIGN KEY (user_id)
        references tcb.users (id)
);


create table TCB.logs
(
    Datetime          date,
    from_id           int,
    to_id             int,
    actions           text,
    exception_message text,
    FOREIGN KEY (from_id)
        REFERENCES TCB.clients (client_id),
    FOREIGN KEY (to_id)
        REFERENCES TCB.clients (client_id)
);



create table TCB.anonym_chats
(
    create_date date,
    from_id     int,
    to_id       int,
    state       int,
    id          serial PRIMARY key,
    FOREIGN KEY (from_id)
        REFERENCES TCB.clients (client_id),
    FOREIGN KEY (to_id)
        REFERENCES TCB.clients (client_id)
);


create table TCB.boards
(
    id       serial PRIMARY KEY,
    nickname varchar(30),
    owner_id int,
    FOREIGN KEY (owner_id)
        REFERENCES TCB.clients (client_id)
);


create table TCB.messages
(
    id       serial PRIMARY key,
    from_id  int,
    message  text,
    chat_id  int,
    type     int,
    board_id int,
    FOREIGN KEY (from_id)
        REFERENCES TCB.clients (client_id),
    FOREIGN KEY (board_id)
        REFERENCES TCB.boards (id)
);