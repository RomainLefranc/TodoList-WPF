CREATE TABLE "Todos" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Description"	TEXT NOT NULL,
	"Status"	INTEGER NOT NULL DEFAULT 0,
	PRIMARY KEY("Id")
);