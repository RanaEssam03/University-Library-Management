/*==============================================================*/
/* DBMS name:      SAP SQL Anywhere 17                          */
/* Created on:     5/18/2023 11:56:01 PM                        */
/*==============================================================*/


drop trigger if exists CLR_TRIGGER_BOOK;

drop trigger if exists TD_BOOK;

drop trigger if exists TU_BOOK;

drop trigger if exists CLR_TRIGGER_BOOK_RATING;

drop trigger if exists TU_BOOK_RATING;

drop trigger if exists TI_BOOK_RATING;

drop trigger if exists CLR_TRIGGER_BORROW;

drop trigger if exists TU_BORROW;

drop trigger if exists TI_BORROW;

drop trigger if exists CLR_TRIGGER_USER;

drop trigger if exists TD_USER;

drop trigger if exists TU_USER;

drop trigger if exists CLR_TRIGGER_VISIT;

drop trigger if exists TU_VISIT;

drop trigger if exists TI_VISIT;

drop table if exists BOOK;

drop index if exists BOOK_RATING.GIVES_FK;

drop index if exists BOOK_RATING.RATED_FK;

drop table if exists BOOK_RATING;

drop index if exists BORROW.BORROW2_FK;

drop index if exists BORROW.BORROW_FK;

drop table if exists BORROW;

drop table if exists "USER";

drop table if exists VISIT;

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create  table BOOK 
(
   TITLE                varchar(64)                    not null,
   ISBN                 varchar(20)                    not null,
   AUTHOR               varchar(64)                    not null,
   CATEGORY             varchar(64)                    not null,
   PUBLICATION_YEAR     date						   not null,
   AMOUNT               integer                        null,
   constraint PK_BOOK primary key clustered (ISBN)
);

/*==============================================================*/
/* Table: BOOK_RATING                                           */
/*==============================================================*/
create  table BOOK_RATING 
(
   ISBN                 varchar(20)                    not null,
   EMAIL                varchar(256)                   not null,
   RATING               integer                        null,
   "COMMENT"            varchar(1024)                  null,
   constraint PK_BOOK_RATING primary key clustered (ISBN, EMAIL)
);

/*==============================================================*/
/* Index: RATED_FK                                              */
/*==============================================================*/
create index RATED_FK on BOOK_RATING (
ISBN ASC
);

/*==============================================================*/
/* Index: GIVES_FK                                              */
/*==============================================================*/
create index GIVES_FK on BOOK_RATING (
EMAIL ASC
);

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW 
(
   EMAIL                varchar(256)                   not null,
   ISBN                 varchar(20)                    not null,
   START_DATE           date                      null,
   END_DATE             date                      null,
   constraint PK_BORROW primary key clustered (EMAIL, ISBN)
);

/*==============================================================*/
/* Index: BORROW_FK                                             */
/*==============================================================*/
create index BORROW_FK on BORROW (
EMAIL ASC
);

/*==============================================================*/
/* Index: BORROW2_FK                                            */
/*==============================================================*/
create index BORROW2_FK on BORROW (
ISBN ASC
);

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create  table "USER" 
(
   EMAIL                varchar(256)                   not null,
   [PASSWORD]             varchar(256)                    not null,
   FIRST_NAME           varchar(64)                    not null,
   LAST_NAME            varchar(64)                    not null,
   ROLE                 varchar(20)                    null,
   YEAR                 integer                        null,
   constraint PK_USER primary key clustered (EMAIL)
);

/*==============================================================*/
/* Table: VISIT                                                 */
/*==============================================================*/
create table VISIT 
(
   EMAIL                varchar(256)                   not null,
   "START"              date                      null,
   "END"                date                      null,
   constraint PK_VISIT primary key clustered (EMAIL)
);

/* The following constraints are written manually */

ALTER TABLE "USER"
ADD CONSTRAINT ROLE_TYPES CHECK(ROLE in ('Student','Admin'))


ALTER TABLE "USER"
ADD CONSTRAINT YEAR_VALIDATION CHECK(YEAR BETWEEN 1 and 5)


ALTER TABLE "USER"
ADD CONSTRAINT EMAIL_VALIDATION CHECK(EMAIL LIKE '%_@%_.%_')

ALTER TABLE "USER"
ADD CONSTRAINT PASSWORD_VALIDATION CHECK(LEN(PASSWORD) BETWEEN 8 AND 20)