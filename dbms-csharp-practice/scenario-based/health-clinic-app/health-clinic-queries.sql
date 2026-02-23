CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO

CREATE TABLE patients (
    patient_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    dob DATE NOT NULL,
    phone VARCHAR(15) NOT NULL UNIQUE,
    email VARCHAR(100) UNIQUE,
    address VARCHAR(255),
    blood_group VARCHAR(5),
    created_at DATETIME DEFAULT GETDATE()
);


CREATE TABLE doctors (
    doctor_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    specialization VARCHAR(100) NOT NULL,
    phone VARCHAR(15),
    consultation_fee DECIMAL(10,2) NOT NULL,
    is_active BIT DEFAULT 1
);

CREATE TABLE appointments (
    appointment_id INT IDENTITY(1,1) PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    status VARCHAR(20) DEFAULT 'SCHEDULED',

    CONSTRAINT fk_appointment_patient
        FOREIGN KEY (patient_id) REFERENCES patients(patient_id),

    CONSTRAINT fk_appointment_doctor
        FOREIGN KEY (doctor_id) REFERENCES doctors(doctor_id)
);

CREATE TABLE visits (
    visit_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL UNIQUE,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    diagnosis VARCHAR(255),
    prescription VARCHAR(255),
    notes VARCHAR(500),
    visit_date DATETIME DEFAULT GETDATE(),

    CONSTRAINT fk_visit_appointment
        FOREIGN KEY (appointment_id) REFERENCES appointments(appointment_id),

    CONSTRAINT fk_visit_patient
        FOREIGN KEY (patient_id) REFERENCES patients(patient_id),

    CONSTRAINT fk_visit_doctor
        FOREIGN KEY (doctor_id) REFERENCES doctors(doctor_id)
);

CREATE TABLE bills (
    bill_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL UNIQUE,
    amount DECIMAL(10,2) NOT NULL,
    payment_status VARCHAR(20) DEFAULT 'UNPAID',
    payment_mode VARCHAR(50),
    payment_date DATETIME,

    CONSTRAINT fk_bill_visit
        FOREIGN KEY (visit_id) REFERENCES visits(visit_id)
);


CREATE TABLE audit_log (
    audit_id INT IDENTITY(1,1) PRIMARY KEY,
    table_name VARCHAR(50),
    operation VARCHAR(10),
    record_id INT,
    performed_at DATETIME DEFAULT GETDATE(),
    performed_by VARCHAR(50) DEFAULT SYSTEM_USER
);



USE HealthClinicDB;
GO

CREATE TRIGGER trg_patients_audit
ON patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted)
        INSERT INTO audit_log (table_name, operation, record_id)
        SELECT 'patients', 'INSERT', patient_id FROM inserted;

    IF EXISTS (SELECT * FROM deleted)
        INSERT INTO audit_log (table_name, operation, record_id)
        SELECT 'patients', 'DELETE', patient_id FROM deleted;
END;
GO


CREATE TRIGGER trg_appointments_audit
ON appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted)
        INSERT INTO audit_log (table_name, operation, record_id)
        SELECT 'appointments', 'INSERT', appointment_id FROM inserted;

    IF EXISTS (SELECT * FROM deleted)
        INSERT INTO audit_log (table_name, operation, record_id)
        SELECT 'appointments', 'DELETE', appointment_id FROM deleted;
END;
GO


CREATE INDEX idx_patient_phone ON patients(phone);
CREATE INDEX idx_appointment_date ON appointments(appointment_date);
CREATE INDEX idx_doctor_specialization ON doctors(specialization);








