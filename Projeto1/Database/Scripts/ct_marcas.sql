CREATE TABLE "Marcas" (
    "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "PaisOrigem" TEXT NOT NULL, 
    "Fundacao" INTEGER, 
    "Sede" TEXT, 
    "Imagem" BLOB 
);