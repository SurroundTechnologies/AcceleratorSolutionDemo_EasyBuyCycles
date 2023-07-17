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
Source Member.: "Order"
Created by ...: Lee Paul
Created on ...: August 29, 2021
Object Type ..: Table Definition
Description ..: Order

BUILD COMMAND.:
RUNSQLSTM SRCFILE(EASYBUYDM3/QDBSRC) SRCMBR("Order")
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

-- ALTER TABLE "Order"
--    DROP CONSTRAINT "PK_Order",
--    DROP CONSTRAINT "FK_Order_{ReferenceTable}";

-- DROP INDEX IF EXISTS "UQ_Order_{IndexDescriptor}";
DROP INDEX IF EXISTS "IX_Order_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_CustomerInternalID_InternalID";
DROP INDEX IF EXISTS "IX_Order_CustomerInternalID_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_CustomerInternalID_ PO_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_PO_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_SalesPersonName_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_WarehouseName_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_Status_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_CustomerInternalID_Status_OrderDateTime_InternalID";
DROP INDEX IF EXISTS "IX_Order_ShippingAddressInternalID_OrderDateTime_InternalID";

-- DROP VIEW IF EXISTS "VW_{ViewName}_{ViewDescriptor}";

-- DROP ALIAS IF EXISTS "{AliasName}";

-- DROP TABLE IF EXISTS "Order";
-- Warnng: Dropping a table will lose the data within it.

CREATE OR REPLACE TABLE "Order"
    (
     "InternalID"           FOR "YD1OIID" INT NOT NULL GENERATED BY DEFAULT AS IDENTITY(MINVALUE 5000 INCREMENT BY 1 CYCLE),
     "CustomerInternalID"   FOR "YD1O1CID" INT NOT NULL,
     "OrderDateTime"        FOR "YD1ODT" TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
     "PurchaseOrderNumber" FOR "YD1OPONO" CHAR(50),
     "WarehouseInternalID"  FOR "YD1O1WID" INT,
     "WarehouseName"        FOR "YD1O1WNM" NVARCHAR(50),
     "DeliveryMemo"         FOR "YD1ODLM1" NVARCHAR(100),
     "ShippingAddressInternalID" FOR "YD1O1SID" INT,
     "OrderMemo"            FOR "YD1OM1" NVARCHAR(100),
     "Status"               FOR "YD1OST" NVARCHAR(10),
     "SalesPersonInternalID" FOR "YD1O1AID" INT,
     "SalesPersonName"      FOR "YD1O1ANM" NVARCHAR(50),
     "PurchasePoints"       FOR "YD1CPRPT" NUMERIC(8,0),
    
     -- Audit Stamps
     "CreatedAt"            FOR "YD1SCRDT" TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
     "CreatedBy"            FOR "YD1SCRUS" VARCHAR(128) NOT NULL,
     "CreatedWith"          FOR "YD1SCRAP" VARCHAR(255) NOT NULL,
     "LastModifiedAt"       FOR "YD1SLCDT" TIMESTAMP GENERATED ALWAYS FOR EACH ROW ON UPDATE AS ROW CHANGE TIMESTAMP NOT NULL,
     "LastModifiedBy"       FOR "YD1SLCUS" VARCHAR(128) GENERATED ALWAYS AS (SESSION_USER),
     "LastModifiedWith"     FOR "YD1SLCAP" VARCHAR(255) GENERATED ALWAYS AS (CURRENT CLIENT_APPLNAME),

      -- Primary Key Constraint
      CONSTRAINT "PK_Order"
         PRIMARY KEY ("InternalID"),

      -- Referential Foreign Key Constraints
      CONSTRAINT "FK_Order_Customer"
         FOREIGN KEY ("CustomerInternalID")
         REFERENCES "Customer"("InternalID")
         ON DELETE RESTRICT ON UPDATE RESTRICT,
      CONSTRAINT "FK_Order_ShippingAddress"
         FOREIGN KEY ("ShippingAddressInternalID")
         REFERENCES "ShippingAddress"("InternalID")
         ON DELETE RESTRICT ON UPDATE RESTRICT
   )
RCDFMT YD1OPR
ON REPLACE PRESERVE ROWS;

-- Table Description
LABEL ON TABLE "Order"
   IS 'Order';

-- Column Labels - Description (50 Chars)
LABEL ON COLUMN "Order" (
     "InternalID"           TEXT IS 'Internal ID',
     "CustomerInternalID"   TEXT IS 'Customer Internal ID',
     "OrderDateTime"        TEXT IS 'Order Date and Time',
     "PurchaseOrderNumber"  TEXT IS 'Purchase Order Number/ID',
     "WarehouseInternalID"  TEXT IS 'Warehouse Internal ID',
     "WarehouseName"        TEXT IS 'Warehouse Name',
     "DeliveryMemo"         TEXT IS 'Delivery Memo',
     "ShippingAddressInternalID" TEXT IS 'Shipping Address Internal ID',
     "OrderMemo"            TEXT IS 'Order Memo',
     "Status"               TEXT IS 'Status',
     "SalesPersonInternalID" TEXT IS 'Sales Person Internal ID',
     "SalesPersonName"      TEXT IS 'Sales Person Name',
     "PurchasePoints"       TEXT IS 'Purchase Points',

     "CreatedAt"            TEXT IS 'Created At',
     "CreatedBy"            TEXT IS 'Created By',
     "CreatedWith"          TEXT IS 'Created With',
     "LastModifiedAt"       TEXT IS 'Modified At',
     "LastModifiedBy"       TEXT IS 'Modified By',
     "LastModifiedWith"     TEXT IS 'Modified With'
     );

-- Column Labels - Column Headings (3 x 20 Chars)
LABEL ON COLUMN "Order" (
--                             |1-------------------2-------------------3-------------------|
     "InternalID"           IS 'Internal ID',
     "CustomerInternalID"   IS 'Customer            Internal ID',
     "OrderDateTime"        IS 'Order Date          And Time',
     "PurchaseOrderNumber"  IS 'Purchase Order      Number/Id',
     "WarehouseInternalID"  IS 'Warehouse           Internal ID',
     "WarehouseName"        IS 'Warehouse           Name',
     "DeliveryMemo"         IS 'Delivery Memo',
     "ShippingAddressInternalID" IS 'Shipping Address    Internal ID',
     "OrderMemo"            IS 'Order Memo',
     "Status"               IS 'Status',
     "SalesPersonInternalID" IS 'Sales Person        Internal ID',
     "SalesPersonName"      IS 'Sales Person        Name',
     "PurchasePoints"       IS 'Purchase Points',

     "CreatedAt"            IS 'Created At',
     "CreatedBy"            IS 'Created By',
     "CreatedWith"          IS 'Created With',
     "LastModifiedAt"       IS 'Modified At',
     "LastModifiedBy"       IS 'Modified By',
     "LastModifiedWith"     IS 'Modified With'
     );

-- Grant Table Access
GRANT DELETE, INSERT, SELECT, UPDATE
ON "Order" TO PUBLIC WITH GRANT OPTION ;

GRANT ALTER, DELETE, INDEX, INSERT, REFERENCES, SELECT, UPDATE
ON "Order" TO QPGMR WITH GRANT OPTION ;

-- Unique Indexes
-- CREATE UNIQUE |WHERE NOT NULL| INDEX "UQ_Order_#"
--    FOR SYSTEM NAME "{IndexSystemName}"
--    ON "Order" (
--    {IndexColumns}
--    WHERE {FilterCondition}
--    );
-- LABEL ON INDEX "UQ_Order_#"
--    IS '{IndexColumnDescriptions}';


-- Indexes
CREATE INDEX "IX_Order_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX1"
   ON "Order" (
   "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_OrderDateTime_InternalID"
   IS 'Order Date/Time';

CREATE INDEX "IX_Order_CustomerInternalID_InternalID"
   FOR SYSTEM NAME "YD1OIX10"
   ON "Order" (
   "CustomerInternalID", "InternalID"
   );
LABEL ON INDEX "IX_Order_CustomerInternalID_InternalID"
   IS 'Customer Internal ID';

CREATE INDEX "IX_Order_CustomerInternalID_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX2"
   ON "Order" (
   "CustomerInternalID", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_CustomerInternalID_OrderDateTime_InternalID"
   IS 'Customer Internal ID, Order Date/Time';

CREATE INDEX "IX_Order_CustomerInternalID_ PO_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX3"
   ON "Order" (
   "CustomerInternalID",  "PurchaseOrderNumber", "OrderDateTime" DESC,
   "InternalID"
   );
LABEL ON INDEX "IX_Order_CustomerInternalID_ PO_OrderDateTime_InternalID"
   IS 'Customer Internal ID and PO No.';

CREATE INDEX "IX_Order_PO_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX4"
   ON "Order" (
   "PurchaseOrderNumber", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_PO_OrderDateTime_InternalID"
   IS 'PO No., Order Date/Time';

CREATE INDEX "IX_Order_SalesPersonName_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX5"
   ON "Order" (
   "SalesPersonName", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_SalesPersonName_OrderDateTime_InternalID"
   IS 'Sales Person Name, Order Date/Time';

CREATE INDEX "IX_Order_WarehouseName_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX6"
   ON "Order" (
   "WarehouseName", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_WarehouseName_OrderDateTime_InternalID"
   IS 'Warehouse Name';

CREATE INDEX "IX_Order_Status_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX7"
   ON "Order" (
   "Status", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX "IX_Order_Status_OrderDateTime_InternalID"
   IS 'Status, Order Data/Time';

CREATE INDEX
   "IX_Order_CustomerInternalID_Status_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX8"
   ON "Order" (
   "CustomerInternalID", "Status", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX
   "IX_Order_CustomerInternalID_Status_OrderDateTime_InternalID"
   IS 'Customer Internal ID and Status';

CREATE INDEX
   "IX_Order_ShippingAddressInternalID_OrderDateTime_InternalID"
   FOR SYSTEM NAME "YD1OIX9"
   ON "Order" (
   "ShippingAddressInternalID", "OrderDateTime" DESC, "InternalID"
   );
LABEL ON INDEX 
   "IX_Order_ShippingAddressInternalID_OrderDateTime_InternalID"
   IS 'Shipping Address Internal ID';

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
CREATE OR REPLACE TRIGGER "Order_InsertStamps"
   NO CASCADE BEFORE INSERT ON "Order"
   REFERENCING NEW AS NEW_ROW
   FOR EACH ROW MODE DB2ROW
   SET NEW_ROW."CreatedBy" = COALESCE(NEW_ROW."CreatedBy", SESSION_USER),
       NEW_ROW."CreatedWith" = COALESCE(NEW_ROW."CreatedWith", CURRENT CLIENT_APPLNAME);

SET SCHEMA DEFAULT;