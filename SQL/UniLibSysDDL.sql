/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/16/2023 10:00:42 PM                        */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   TITLE                varchar(64)          not null,
   ISBN                 varchar(20)          not null,
   AUTHOR               varchar(64)          not null,
   CATEGORY             varchar(64)          not null,
   PUBLICATION_YEAR     datetime             not null,
   constraint PK_BOOK primary key (ISBN)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   EMAIL                varchar(256)         not null,
   PASSWORD             varchar(64)          not null,
   FIRST_NAME           varchar(64)          not null,
   LAST_NAME            varchar(64)          not null,
   ROLE                 varchar(20)          null,
   YEAR                 int                  null,
   constraint PK_USER primary key (EMAIL)
)
go


/* The following constraints are written manually */

ALTER TABLE "USER"
ADD CONSTRAINT ROLE_TYPES CHECK(ROLE in ('Student','Admin'))


ALTER TABLE "USER"
ADD CONSTRAINT YEAR_VALIDATION CHECK(YEAR BETWEEN 1 and 5)


ALTER TABLE "USER"
ADD CONSTRAINT EMAIL_VALIDATION CHECK(EMAIL LIKE '%_@%_.%_')

ALTER TABLE "USER"
ADD CONSTRAINT PASSWORD_VALIDATION CHECK(LEN(PASSWORD) BETWEEN 8 AND 20)