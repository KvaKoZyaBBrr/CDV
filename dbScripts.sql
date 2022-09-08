CREATE TABLE "public".department (
	id integer NOT NULL,
	"name" varchar NOT NULL,
    chief_id integer NULL,
	CONSTRAINT department_pk PRIMARY KEY (id)
);

CREATE TABLE "public".employee (
	id integer NOT NULL,
	department_id integer NULL,
	chief_id integer NULL,
	"name" varchar NOT NULL,
	salary integer NOT NULL,
	CONSTRAINT employee_pk PRIMARY KEY (id),
	CONSTRAINT employee_fk FOREIGN KEY (department_id) REFERENCES "public".department(id) ON DELETE SET NULL ON UPDATE CASCADE,
	CONSTRAINT employee_fk_1 FOREIGN KEY (chief_id) REFERENCES "public".employee(id) ON DELETE SET NULL ON UPDATE CASCADE
);

ALTER TABLE "public".department ADD CONSTRAINT department_fk FOREIGN KEY (chief_id) REFERENCES "public".employee(id) ON DELETE SET NULL ON UPDATE cascade;

INSERT INTO "public".department (id, name) VALUES (1, 'D1'), (2, 'D2'), (3, 'D3');

INSERT INTO "public".employee
    (id, department_id, chief_id, name, salary)
VALUES
    (1, 1, 5, 'John', 100),
    (2, 1, 5, 'Misha', 600),
    (3, 2, 6, 'Eugen', 300),
    (4, 2, 6, 'Tolya', 400),
    (5, 3, 7, 'Stepan', 500),
    (6, 3, 7, 'Alex', 1000),
    (7, 3, NULL, 'Ivan', 1100);
