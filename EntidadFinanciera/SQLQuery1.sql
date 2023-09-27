USE BancoDB; -- Utilizamos la base de datos BancoDB

-- Crear la tabla Cliente
CREATE TABLE Cliente
(
    Id INT PRIMARY KEY IDENTITY(1,1), -- Clave primaria autoincremental
    Nombre NVARCHAR(255) NOT NULL,
    Apellido NVARCHAR(255) NOT NULL,
    Dni NVARCHAR(20) NOT NULL
);

-- Crear la tabla CuentaBancaria (ajustada según tu modelo)
CREATE TABLE CuentaBancaria
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroCuenta NVARCHAR(20) NOT NULL,
    Saldo DECIMAL(18, 2) NOT NULL,
    Tipo NVARCHAR(255) NOT NULL, -- Cambiado a NVARCHAR para representar el tipo de cuenta
    ClienteId INT,
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);


-- Crear la tabla TarjetaCredito (debes ajustarla según tu modelo)
CREATE TABLE TarjetaCredito
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroTarjeta NVARCHAR(20) NOT NULL,
    LimiteCredito DECIMAL(18, 2) NOT NULL,
    SaldoDisponible DECIMAL(18, 2) NOT NULL,
    Estado INT NOT NULL,
    ClienteId INT,
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
