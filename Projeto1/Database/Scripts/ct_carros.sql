CREATE TABLE "Modelos" (
    "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "MarcaId" INTEGER NOT NULL,
    "Ano" INTEGER NOT NULL,
    "Categoria" TEXT NOT NULL, -- Hatch, SUV, Sedan, etc.
    "Transmissao" TEXT NOT NULL, -- Manual, Automática
    "Combustivel" TEXT NOT NULL, -- Gasolina, Elétrico, Híbrido, etc.
    "Potencia" INTEGER NOT NULL,
    "Binario" INTEGER NOT NULL,
    "Motor" TEXT NOT NULL,
    "Tracao" TEXT NOT NULL,
    "Preco" REAL NOT NULL,
    "Imagem" BLOB,
    FOREIGN KEY("MarcaId") REFERENCES "Marcas"("Id")
);