CREATE TABLE "Modelos" (
    "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "MarcaId" INTEGER NOT NULL,
    "Imagem" BLOB,
    "Potencia" INTEGER NOT NULL,
    "Binario" INTEGER NOT NULL,
    "Motor" TEXT NOT NULL,
    "Tracao" TEXT NOT NULL,
    "Preco" REAL NOT NULL,
    FOREIGN KEY("MarcaId") REFERENCES "Marcas"("Id")
);
