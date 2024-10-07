-- Creación de la base de datos ClinicaPrivada
CREATE DATABASE IF NOT EXISTS ClinicaPrivada;
USE ClinicaPrivada;

-- Tabla Paciente
CREATE TABLE Paciente (
    Cedula VARCHAR(20) NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    PrimerApellido VARCHAR(100) NOT NULL,
    SegundoApellido VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL
);
-- Tabla PersonalMedico
CREATE TABLE PersonalMedico (
    Cedula VARCHAR(20) NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    PrimerApellido VARCHAR(100) NOT NULL,
    SegundoApellido VARCHAR(100) NOT NULL,
    Especialidad VARCHAR(100) NOT NULL,
    Experiencia VARCHAR(500) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

-- Tabla Cita 
CREATE TABLE Cita (
    CitaID INT AUTO_INCREMENT PRIMARY KEY,
    Cedula VARCHAR(20) NOT NULL,
    CedulaMedico VARCHAR(20) NOT NULL,
    MotivoConsulta VARCHAR(500) NOT NULL,
    Duracion TIME NOT NULL,
    Resultados VARCHAR(500),
    FechaHora DATETIME NOT NULL,
    Epicrisis VARCHAR(1000),  -- Agregado
    PersonalAdicional VARCHAR(500),  -- Agregado
    FOREIGN KEY (Cedula) REFERENCES Paciente(Cedula),
    FOREIGN KEY (CedulaMedico) REFERENCES PersonalMedico(Cedula)
);


-- Tabla ProcedimientoMedico
CREATE TABLE Procedimiento (
    ProcedimientoID INT AUTO_INCREMENT PRIMARY KEY,
    CitaID INT NOT NULL,  -- Relación con la cita
    Descripcion VARCHAR(500) NOT NULL,
    FechaProcedimiento DATETIME NOT NULL,
    Duracion TIME NOT NULL,
    Epicrisis VARCHAR(1000),  -- Informe del procedimiento
    FOREIGN KEY (CitaID) REFERENCES Cita(CitaID)

);

-- Tabla MedicoProcedimiento (Para médicos adicionales en procedimientos)
CREATE TABLE PersonalAdicional(
    PersonalAdicionalID INT AUTO_INCREMENT PRIMARY KEY,
    ProcedimientoID INT NOT NULL,
    CedulaMedico VARCHAR(20) NOT NULL,
    Rol VARCHAR(100),  -- Especialidad o rol del médico en el procedimiento
    FOREIGN KEY (ProcedimientoID) REFERENCES Procedimiento(ProcedimientoID),
    FOREIGN KEY (CedulaMedico) REFERENCES PersonalMedico(Cedula)
);

-- Tabla ResultadoProcedimiento (Para registrar los resultados de los procedimientos quirúrgicos)
CREATE TABLE ResultadoProcedimiento (
    ResultadoID INT AUTO_INCREMENT PRIMARY KEY,
    ProcedimientoID INT NOT NULL,
    Descripcion VARCHAR(1000),
    FechaRegistro DATETIME NOT NULL,
    FOREIGN KEY (ProcedimientoID) REFERENCES Procedimiento(ProcedimientoID)
);

-- Tabla HistorialMedico 
CREATE TABLE HistorialMedico (
    HistorialID INT AUTO_INCREMENT PRIMARY KEY,
    Cedula VARCHAR(20) NOT NULL,
    CitaID INT, 
    Descripcion VARCHAR(500) NOT NULL,
    FechaRegistro DATE NOT NULL,
    FOREIGN KEY (Cedula) REFERENCES Paciente(Cedula),
    FOREIGN KEY (CitaID) REFERENCES Cita(CitaID)  
);

-- Tabla Padecimiento
CREATE TABLE Padecimiento (
    PadecimientoID INT AUTO_INCREMENT PRIMARY KEY,
    Cedula VARCHAR(20) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    FechaInicio DATE NOT NULL,
    FOREIGN KEY (Cedula) REFERENCES Paciente(Cedula)
);

-- Tabla Tratamiento
CREATE TABLE Tratamiento (
    TratamientoID INT AUTO_INCREMENT PRIMARY KEY,
    CitaID INT NOT NULL,
    TipoTratamiento VARCHAR(100) NOT NULL,
    Duracion INT NOT NULL,
    FOREIGN KEY (CitaID) REFERENCES Cita(CitaID)
);

-- Tabla Medicamento
CREATE TABLE Medicamento (
    MedicamentoID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Dosificacion VARCHAR(100) NOT NULL,
    EfectosSecundarios VARCHAR(255) NOT NULL
);

-- Tabla TratamientoMedicamento (Actualizada con Dosificación)
CREATE TABLE TratamientoMedicamento (
    TratamientoID INT NOT NULL,
    MedicamentoID INT NOT NULL,
    Cantidad INT NOT NULL,
    Dosificacion VARCHAR(100),  -- Agregado
    PRIMARY KEY (TratamientoID, MedicamentoID),
    FOREIGN KEY (TratamientoID) REFERENCES Tratamiento(TratamientoID),
    FOREIGN KEY (MedicamentoID) REFERENCES Medicamento(MedicamentoID)
);


-- Insertar datos de prueba para pacientes
INSERT INTO Paciente (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Telefono, Email)
VALUES
('110867045', 'Juan', 'Pérez', 'González', '1985-06-15', '55512345', 'juan.perez@example.com'),
('210987654', 'Ana', 'Gómez', 'Hernández', '1990-08-22', '55556789', 'ana.gomez@example.com'),
('310234567', 'Luis', 'Martínez', 'Salazar', '1982-11-30', '55587654', 'luis.martinez@example.com'),
('420345678', 'Laura', 'Rodríguez', 'Santos', '1978-03-25', '55543210', 'laura.rodriguez@example.com'),
('530456789', 'Carlos', 'Hernández', 'Mora', '1986-12-14', '55567890', 'carlos.hernandez@example.com'),
('640567890', 'Marta', 'Lopez', 'Pérez', '1992-01-09', '55534567', 'marta.lopez@example.com'),
('750678901', 'Pedro', 'Sánchez', 'Morales', '1984-05-18', '55598765', 'pedro.sanchez@example.com'),
('120789012', 'Elena', 'Jiménez', 'Rodríguez', '1989-07-04', '55554321', 'elena.jimenez@example.com'),
('230890123', 'José', 'García', 'Alvarado', '1981-09-20', '55565432', 'jose.garcia@example.com'),
('340901234', 'Isabel', 'Morales', 'Vargas', '1993-04-10', '55532109', 'isabel.morales@example.com'),
('450012345', 'Diego', 'Fernández', 'Méndez', '1975-05-15', '55587654', 'diego.fernandez@example.com'),
('560123456', 'Sofía', 'Torres', 'Reyes', '1991-12-05', '55522222', 'sofia.torres@example.com'),
('670234567', 'Ricardo', 'Castro', 'Cruz', '1988-02-28', '55533333', 'ricardo.castro@example.com'),
('780345678', 'Natalia', 'Vásquez', 'Mora', '1994-11-11', '55544444', 'natalia.vasquez@example.com'),
('890456789', 'Andrés', 'Ríos', 'Sotelo', '1983-03-01', '55555555', 'andres.rios@example.com');

-- Insertar datos de prueba para padecimientos
INSERT INTO Padecimiento (Cedula, Descripcion, FechaInicio)
VALUES
('110867045', 'Diabetes', '2015-01-10'),
('110867045', 'Hipertensión', '2016-03-12'),
('110867045', 'Problemas cardíacos', '2018-11-05'),
('210987654', 'Asma', '2020-06-01'),
('210987654', 'Colesterol alto', '2019-07-20'),
('310234567', 'Hipotiroidismo', '2020-02-15'),
('310234567', 'Problemas digestivos', '2018-09-22'),
('420345678', 'Migrañas', '2022-01-18'),
('420345678', 'Alergias', '2021-04-10'),
('530456789', 'Artritis', '2021-11-05'),
('640567890', 'Diabetes', '2020-01-01'),
('640567890', 'Ansiedad', '2019-12-01'),
('750678901', 'Problemas cardíacos', '2020-05-10'),
('120789012', 'Colesterol alto', '2018-08-10'),
('120789012', 'Asma', '2022-05-14'),
('230890123', 'Hipotiroidismo', '2023-03-30'),
('230890123', 'Alergias', '2017-02-17'),
('340901234', 'Problemas digestivos', '2021-02-25'),
('450012345', 'Migrañas', '2022-03-14'),
('560123456', 'Diabetes', '2021-09-14');

-- Insertar datos de prueba para personal médico
INSERT INTO PersonalMedico (Cedula, Nombre, PrimerApellido, SegundoApellido, Especialidad, Experiencia, Telefono, Email)
VALUES
('789542006', 'Dr. Luis', 'Martínez', 'González', 'Cardiología', '10 años de experiencia en cardiología.', '55511111', 'luis.martinez@clinica.com'),
('107845625', 'Dra. Ana', 'Gómez', 'Hernández', 'Dermatología', '8 años de experiencia en dermatología.', '55522222', 'ana.gomez@clinica.com'),
('100967045', 'Dr. Juan', 'Pérez', 'Salazar', 'Pediatría', '12 años de experiencia en pediatría.', '55533333', 'juan.perez@clinica.com'),
('485631235', 'Dra. Laura', 'Rodríguez', 'Santos', 'Ginecología', '9 años de experiencia en ginecología.', '55544444', 'laura.rodriguez@clinica.com'),
('708466252', 'Dr. Carlos', 'Hernández', 'Mora', 'Neurología', '11 años de experiencia en neurología.', '55555555', 'carlos.hernandez@clinica.com'),
('707862563', 'Dra. Marta', 'Lopez', 'Pérez', 'Cardiología', '7 años de experiencia en Cardiología.', '55566666', 'marta.lopez@clinica.com'),
('759632563', 'Dr. Pedro', 'Sánchez', 'Morales', 'Traumatología', '15 años de experiencia en traumatología.', '55577777', 'pedro.sanchez@clinica.com'),
('326356605', 'Dra. Elena', 'Jiménez', 'Rodríguez', 'Oftalmología', '6 años de experiencia en oftalmología.', '55588888', 'elena.jimenez@clinica.com'),
('305632855', 'Dr. José', 'García', 'Alvarado', 'Oncología', '10 años de experiencia en oncología.', '55599999', 'jose.garcia@clinica.com'),
('392010557', 'Dra. Isabel', 'Morales', 'Vargas', 'Cardiología', '5 años de experiencia en Cardiología.', '55500000', 'isabel.morales@clinica.com');

-- Insertar citas
INSERT INTO Cita (Cedula, CedulaMedico, MotivoConsulta, Duracion, Resultados, FechaHora)
VALUES
('110867045', '100967045', 'Revisión general', '00:30:00', 'Resultados normales', '2024-09-01 10:00:00'),
('210987654', '107845625', 'Consulta dermatológica', '00:45:00', 'Tratamiento para eccema', '2024-09-02 14:30:00'),
('310234567', '789542006', 'Chequeo cardiaco', '01:00:00', 'Requiere seguimiento', '2024-09-03 09:00:00'),
('420345678', '485631235', 'Examen ginecológico', '00:30:00', 'Todo en orden', '2024-09-04 11:00:00'),
('530456789', '708466252', 'Chequeo neurológico', '00:50:00', 'Necesita estudios adicionales', '2024-09-05 11:00:00'),
('640567890', '100967045', 'Consulta pediátrica', '00:40:00', 'Requiere seguimiento', '2024-09-06 09:30:00'),
('750678901', '707862563', 'Chequeo cardiológico', '00:45:00', 'Estable', '2024-09-07 10:00:00'),
('120789012', '485631235', 'Revisión ginecológica', '00:30:00', 'Todo en orden', '2024-09-08 14:00:00'),
('230890123', '759632563', 'Tratamiento para fractura', '01:00:00', 'Recuperación favorable', '2024-09-09 15:00:00'),
('340901234', '305632855', 'Examen oncología', '01:15:00', 'Resultados normales', '2024-09-10 11:30:00');

-- Insertar tratamientos
INSERT INTO Tratamiento (CitaID, TipoTratamiento, Duracion)
VALUES
(1, 'Revisión general', 30),
(2, 'Tratamiento para eccema', 45),
(3, 'Chequeo cardiaco', 60),
(4, 'Examen ginecológico', 30),
(5, 'Chequeo neurológico', 50),
(6, 'Consulta pediátrica', 40),
(7, 'Chequeo cardiológico', 45),
(8, 'Revisión ginecológica', 30),
(9, 'Tratamiento para fractura', 60),
(10, 'Examen oncología', 75);

-- Insertar datos de prueba para medicamentos
INSERT INTO Medicamento (Nombre, Dosificacion, EfectosSecundarios)
VALUES
('Paracetamol', '500mg cada 8 horas', 'Náuseas, dolor de cabeza'),
('Ibuprofeno', '400mg cada 6 horas', 'Mareo, malestar estomacal'),
('Amoxicilina', '500mg cada 12 horas', 'Erupción cutánea, diarrea'),
('Omeprazol', '20mg cada mañana', 'Dolor de cabeza, mareo'),
('Loratadina', '10mg una vez al día', 'Somnolencia leve'),
('Metformina', '500mg cada 12 horas', 'Malestar gastrointestinal'),
('Atenolol', '50mg una vez al día', 'Fatiga, mareos'),
('Simvastatina', '20mg cada noche', 'Dolores musculares'),
('Ranitidina', '150mg dos veces al día', 'Dolor de cabeza, mareo'),
('Clonazepam', '1mg al dormir', 'Somnolencia, mareos');

-- Insertar relación entre tratamientos y medicamentos
INSERT INTO TratamientoMedicamento (TratamientoID, MedicamentoID, Cantidad, Dosificacion)
VALUES
(1, 1, 10, '500mg cada 8 horas'),
(2, 2, 15, '400mg cada 6 horas'),
(3, 3, 20, '500mg cada 12 horas'),
(4, 4, 10, '20mg cada mañana'),
(5, 5, 15, '10mg una vez al día'),
(6, 6, 10, '500mg cada 12 horas'),
(7, 7, 15, '50mg una vez al día'),
(8, 8, 20, '20mg cada noche'),
(9, 9, 10, '150mg dos veces al día'),
(10, 10, 15, '1mg al dormir');

-- Insertar procedimientos médicos
INSERT INTO Procedimiento (CitaID, Descripcion, FechaProcedimiento, Duracion, Epicrisis)
VALUES
(1, 'Electrocardiograma', '2024-09-11 09:00:00', '00:30:00', 'Resultados dentro de parámetros normales.'),
(2, 'Biopsia de piel', '2024-09-12 14:00:00', '01:00:00', 'Muestra enviada para análisis.'),
(3, 'Prueba de esfuerzo', '2024-09-13 10:00:00', '01:15:00', 'Se recomienda control cardiológico regular.'),
(4, 'Papanicolau', '2024-09-14 08:30:00', '00:45:00', 'Resultados a consultar en 2 semanas.'),
(5, 'Resonancia Magnética', '2024-09-15 11:00:00', '02:00:00', 'Se requiere evaluación por un neurólogo.'),
(6, 'Consulta de seguimiento', '2024-09-16 09:00:00', '00:30:00', 'Evaluación de progreso del tratamiento.'),
(7, 'Radiografía de tórax', '2024-09-17 14:00:00', '00:30:00', 'Resultados dentro de la normalidad.'),
(8, 'Ultrasonido abdominal', '2024-09-18 10:30:00', '00:50:00', 'Resultados normales.'),
(9, 'Artroscopia', '2024-09-19 09:00:00', '01:30:00', 'Intervención exitosa, reposo recomendado.'),
(10, 'Colonoscopy', '2024-09-20 11:30:00', '01:00:00', 'Sin hallazgos preocupantes.');
