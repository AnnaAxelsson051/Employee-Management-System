
DROP TABLE IF EXISTS "public"."aax_project";
DROP TABLE IF EXISTS "public"."aax_person";
DROP TABLE IF EXISTS "public"."aax_project_person";
CREATE TABLE "public"."aax_project" ( 
  "id" SERIAL,
  "project_name" VARCHAR(50) NOT NULL,
  CONSTRAINT "aax_project_pkey" PRIMARY KEY ("id")
);
CREATE TABLE "public"."aax_person" ( 
  "id" SERIAL,
  "person_name" VARCHAR(25) NOT NULL,
  CONSTRAINT "aax_person_pkey" PRIMARY KEY ("id")
);
CREATE TABLE "public"."aax_project_person" ( 
  "id" SERIAL,
  "project_id" INTEGER,
  "project_name" VARCHAR(50) NOT NULL,
  "person_id" INTEGER,
  "person_name" VARCHAR(25) NOT NULL,
  "hours" INTEGER NOT NULL,
  CONSTRAINT "aax_project_person_pkey" PRIMARY KEY ("id")
);
ALTER TABLE "public"."aax_project_person" ADD CONSTRAINT "FK_aax_project_person_project_id" FOREIGN KEY ("project_id") REFERENCES "public"."aax_project" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."aax_project_person" ADD CONSTRAINT "FK_aax_person_project_person_id" FOREIGN KEY ("person_id") REFERENCES "public"."aax_person" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;