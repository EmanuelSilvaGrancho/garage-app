CREATE TABLE "Modelos" (
    "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "MarcaId" INTEGER NOT NULL,
    "Imagem" BLOB,
    FOREIGN KEY("MarcaId") REFERENCES "Marcas"("Id")
);