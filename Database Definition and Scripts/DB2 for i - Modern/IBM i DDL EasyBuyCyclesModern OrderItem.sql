﻿/*******************************************************************************

CONFIDENTIAL AND PROPRIETARY INFORMATION

The receipt or possession of this document does not convey any rights to
reproduce, disclose its contents or manufacture, use or sell anything it may
describe.  Reproduction, disclosure, or use without the specific written
authorization of Surround Technologies, LLC is strictly forbidden.

Copyright ....: (C) Surround Technologies, LLC 1998 - 2021
                9197 Estero River Circle
                Estero, FL 33928
                973-743-1277
                http://www.surroundtech.com/
                 
================================================================================

Source File...: QDBSRC
Source Member.: "OrdItm"
Created by ...: Lee Paul
Created on ...: August 29, 2021
Object Type ..: Table Definition
Description ..: Order Item

BUILD COMMAND.:
RUNSQLSTM SRCFILE(EASYBUYDM3/QDBSRC) SRCMBR("OrdItm")
    COMMIT(*NONE) ERRLVL(20)

================================================================================
                             Amendment Details
                             -----------------
Date       Programmer      Description
---------- --------------- -----------------------------------------------------


*******************************************************************************
Notes:

To see the next identity value use the following SQL 
SELECT NEXT_IDENTITY_VALUE
    FROM QSYS2.SYSPARTITIONSTAT
    WHERE Table_Schema = 'EasyBuyCycles'
          AND Table_Name = 'Customer'

To see the last Value in the table use the following SQL
SELECT MAX("InternalID")
    FROM "EasyBuyCycles"."Customer";

To set the Customer Table Autoincrementing Identity Value use the follwing SQL
ALTER TABLE "EasyBuyCycles"."Customer"
   ALTER COLUMN "InternalID" RESTART WITH <the number you want>

*******************************************************************************/

SET SCHEMA "EasyBuyCycles";
-- SET SCHEMA "EasyBuyCyclesDev";

-- ALTER TABLE "OrderItem"
--    DROP CONSTRAINT "PK_OrderItem";
--    DROP CONSTRAINT "FK_OrderItem_{ReferenceTable}";

-- DROP INDEX IF EXISTS "UQ_OrderItem_{IndexDescriptor}";
DROP INDEX IF EXISTS
   "IX_OrderItem_OrderInternalID_ProductInternalID_InternalID";
DROP INDEX IF EXISTS
   "IX_OrderItem_ProductInternalID_OrderInternalID_InternalID";
DROP INDEX IF EXISTS "IX_OrderItem_OrderInternalID_InternalID";

-- DROP VIEW IF EXISTS "VW_{ViewName}_{ViewDescriptor}";

-- DROP ALIAS IF EXISTS "{AliasName}";

-- DROP TABLE IF EXISTS "OrderItem";
-- Warnng: Dropping a table will lose the data within it.

CREATE OR REPLACE TABLE "OrderItem"
    FOR SYSTEM NAME "OrdItm"  (
     "InternalID"           FOR "YD1IIID" INT NOT NULL GENERATED BY DEFAULT AS IDENTITY(MINVALUE 5000 INCREMENT BY 1 CYCLE),
     "OrderInternalID"      FOR "YD1I1OID" INT NOT NULL,
     "ProductInternalID"    FOR "YD1I1PID" INT NOT NULL,
     "Quantity"             FOR "YD1IQT" NUMERIC(4,0),
     "UnitPrice"            FOR "YD1IPRUN" NUMERIC(8,2),
     "Discount(Percent)"    FOR "YD1IDSPC" NUMERIC(4,1),
     "Memo"                 FOR "YD1IM1" NVARCHAR(100),
    
     -- Audit Stamps
     "CreatedAt"            FOR "YD1SCRDT" TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
     "CreatedBy"            FOR "YD1SCRUS" VARCHAR(128) NOT NULL,
     "CreatedWith"          FOR "YD1SCRAP" VARCHAR(255) NOT NULL,
     "LastModifiedAt"       FOR "YD1SLCDT" TIMESTAMP GENERATED ALWAYS FOR EACH ROW ON UPDATE AS ROW CHANGE TIMESTAMP NOT NULL,
     "LastModifiedBy"       FOR "YD1SLCUS" VARCHAR(128) GENERATED ALWAYS AS (SESSION_USER),
     "LastModifiedWith"     FOR "YD1SLCAP" VARCHAR(255) GENERATED ALWAYS AS (CURRENT CLIENT_APPLNAME),

      -- Primary Key Constraint
      CONSTRAINT "PK_OrderItem"
         PRIMARY KEY ("InternalID"),

      -- Referential Foreign Key Constraints
      CONSTRAINT "FK_OrderItem_Order"
         FOREIGN KEY ("OrderInternalID")
         REFERENCES "Order"("InternalID")
         ON DELETE RESTRICT ON UPDATE RESTRICT,
      CONSTRAINT "FK_OrderItem_Product"
         FOREIGN KEY ("ProductInternalID")
         REFERENCES "Product"("InternalID")
         ON DELETE RESTRICT ON UPDATE RESTRICT
   )
RCDFMT YD1IPR
ON REPLACE PRESERVE ROWS;

-- Table Description
LABEL ON TABLE "OrderItem"
   IS 'Order Item';

-- Column Labels - Description (50 Chars)
LABEL ON COLUMN "OrderItem" (
     "InternalID"           TEXT IS 'Internal ID',
     "OrderInternalID"      TEXT IS 'Order Internal ID',
     "ProductInternalID"    TEXT IS 'Product Internal ID',
     "Quantity"             TEXT IS 'Quantity',
     "UnitPrice"            TEXT IS 'Unit Price',
     "Discount(Percent)"    TEXT IS 'Discount (Percent)',
     "Memo"                 TEXT IS 'Memo',

     "CreatedAt"            TEXT IS 'Create At',
     "CreatedBy"            TEXT IS 'Create By',
     "CreatedWith"          TEXT IS 'Create With',
     "LastModifiedAt"       TEXT IS 'Modified At',
     "LastModifiedBy"       TEXT IS 'Modified By',
     "LastModifiedWith"     TEXT IS 'Modified With'
     );

-- Column Labels - Column Headings (3 x 20 Chars)
LABEL ON COLUMN "OrderItem" (
--                             |1-------------------2-------------------3-------------------|
     "InternalID"           IS 'Internal ID',
     "OrderInternalID"      IS 'Order               Internal ID',
     "ProductInternalID"    IS 'Product             Internal ID',
     "Quantity"             IS 'Quantity',
     "UnitPrice"            IS 'Unit Price',
     "Discount(Percent)"    IS 'Discount (Percent)',
     "Memo"                 IS 'Memo',

     "CreatedAt"            IS 'Create At',
     "CreatedBy"            IS 'Create By',
     "CreatedWith"          IS 'Create With',
     "LastModifiedAt"       IS 'Modified At',
     "LastModifiedBy"       IS 'Modified By',
     "LastModifiedWith"     IS 'Modified With'
     );

-- Grant Table Access
GRANT DELETE, INSERT, SELECT, UPDATE
ON "OrderItem" TO PUBLIC WITH GRANT OPTION ;

GRANT ALTER, DELETE, INDEX, INSERT, REFERENCES, SELECT, UPDATE
ON "OrderItem" TO QPGMR WITH GRANT OPTION ;

-- Unique Indexes
-- CREATE UNIQUE |WHERE NOT NULL| INDEX "UQ_OrderItem_#"
--    FOR SYSTEM NAME "{IndexSystemName}"
--    ON "OrderItem" (
--    {IndexColumns}
--    WHERE {FilterCondition}
--    );
-- LABEL ON INDEX "UQ_OrderItem_#"
--    IS 'Sort by {IndexColumnDescriptions}';

-- Indexes
CREATE INDEX "IX_OrderItem_OrderInternalID_ProductInternalID_InternalID"
   FOR SYSTEM NAME "YD1IIX1"
   ON "OrderItem" (
   "OrderInternalID", "ProductInternalID", "InternalID"
   );
LABEL ON INDEX "IX_OrderItem_OrderInternalID_ProductInternalID_InternalID"
   IS 'Sort by Order and Product Internal IDs';

CREATE INDEX "IX_OrderItem_ProductInternalID_OrderInternalID_InternalID"
   FOR SYSTEM NAME "YD1IIX2"
   ON "OrderItem" (
   "ProductInternalID", "OrderInternalID", "InternalID"
   );
LABEL ON INDEX "IX_OrderItem_ProductInternalID_OrderInternalID_InternalID"
   IS 'Sort by Product and Order Internal IDs';

CREATE INDEX "IX_OrderItem_OrderInternalID_InternalID"
   FOR SYSTEM NAME "YD1IIX3"
   ON "OrderItem" (
   "OrderInternalID", "InternalID"
   );
LABEL ON INDEX "IX_OrderItem_OrderInternalID_InternalID"
   IS 'Sort by Order Internal ID';

-- Views
-- CREATE OR REPLACE VIEW "VW_AccountTable_<Descriptors>"
--     FOR SYSTEM NAME "FACCTV01" AS
--          < View Definition >
-- ;
-- LABEL ON TABLE "VVW_AccountTable_<Descriptors>"
--    IS 'View Description';

-- LABEL ON COLUMN "VW_AccountTable_<Descriptors>" (
--      <ViewColumnName> TEXT IS 'View Column Description'
--      );

-- LABEL ON COLUMN "VW_AccountTable_<Descriptors>" (
--      <ViewColumnName> IS 'View Column Description'
--      );

-- GRANT SELECT
-- ON "VW_AccountTable_<Descriptors>" TO PUBLIC WITH GRANT OPTION ;

-- GRANT ALTER, REFERENCES, SELECT
-- ON "VW_AccountTable_<Descriptors>" TO QPGMR WITH GRANT OPTION ;
   
-- Aliases
-- CREATE OR REPLACE ALIAS {AliasName} FOR "AccountTable";

-- Triggers
CREATE OR REPLACE TRIGGER "OrderItem_InsertStamps"
   NO CASCADE BEFORE INSERT ON "OrderItem"
   REFERENCING NEW AS NEW_ROW
   FOR EACH ROW MODE DB2ROW
   SET NEW_ROW."CreatedBy" = COALESCE(NEW_ROW."CreatedBy", SESSION_USER),
       NEW_ROW."CreatedWith" = COALESCE(NEW_ROW."CreatedWith", CURRENT CLIENT_APPLNAME);

SET SCHEMA DEFAULT;