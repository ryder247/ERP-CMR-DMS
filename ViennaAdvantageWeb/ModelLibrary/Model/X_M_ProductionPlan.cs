namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for M_ProductionPlan
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_M_ProductionPlan : PO
{
public X_M_ProductionPlan (Context ctx, int M_ProductionPlan_ID, Trx trxName) : base (ctx, M_ProductionPlan_ID, trxName)
{
/** if (M_ProductionPlan_ID == 0)
{
SetLine (0);	// @SQL=SELECT NVL(MAX(Line),0)+10 AS DefaultValue FROM M_ProductionPlan WHERE M_Production_ID=@M_Production_ID@
SetM_Locator_ID (0);	// @M_Locator_ID@
SetM_Product_ID (0);
SetM_ProductionPlan_ID (0);
SetM_Production_ID (0);
SetProcessed (false);	// N
SetProductionQty (0.0);	// 1
}
 */
}
public X_M_ProductionPlan (Ctx ctx, int M_ProductionPlan_ID, Trx trxName) : base (ctx, M_ProductionPlan_ID, trxName)
{
/** if (M_ProductionPlan_ID == 0)
{
SetLine (0);	// @SQL=SELECT NVL(MAX(Line),0)+10 AS DefaultValue FROM M_ProductionPlan WHERE M_Production_ID=@M_Production_ID@
SetM_Locator_ID (0);	// @M_Locator_ID@
SetM_Product_ID (0);
SetM_ProductionPlan_ID (0);
SetM_Production_ID (0);
SetProcessed (false);	// N
SetProductionQty (0.0);	// 1
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_ProductionPlan (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_ProductionPlan (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_ProductionPlan (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_M_ProductionPlan()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514381027L;
/** Last Updated Timestamp 7/29/2010 1:07:44 PM */
public static long updatedMS = 1280389064238L;
/** AD_Table_ID=385 */
public static int Table_ID;
 // =385;

/** TableName=M_ProductionPlan */
public static String Table_Name="M_ProductionPlan";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(3);
/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel()
{
return Convert.ToInt32(accessLevel.ToString());
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO(Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_M_ProductionPlan[").Append(Get_ID()).Append("]");
return sb.ToString();
}
/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description)
{
if (Description != null && Description.Length > 255)
{
log.Warning("Length > 255 - truncated");
Description = Description.Substring(0,255);
}
Set_Value ("Description", Description);
}
/** Get Description.
@return Optional short description of the record */
public String GetDescription() 
{
return (String)Get_Value("Description");
}
/** Set Line No.
@param Line Unique line for this document */
public void SetLine (int Line)
{
Set_Value ("Line", Line);
}
/** Get Line No.
@return Unique line for this document */
public int GetLine() 
{
Object ii = Get_Value("Line");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetLine().ToString());
}
/** Set Locator.
@param M_Locator_ID Warehouse Locator */
public void SetM_Locator_ID (int M_Locator_ID)
{
if (M_Locator_ID < 1) throw new ArgumentException ("M_Locator_ID is mandatory.");
Set_Value ("M_Locator_ID", M_Locator_ID);
}
/** Get Locator.
@return Warehouse Locator */
public int GetM_Locator_ID() 
{
Object ii = Get_Value("M_Locator_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}

/** M_Product_ID AD_Reference_ID=211 */
public static int M_PRODUCT_ID_AD_Reference_ID=211;
/** Set Product.
@param M_Product_ID Product, Service, Item */
public void SetM_Product_ID (int M_Product_ID)
{
if (M_Product_ID < 1) throw new ArgumentException ("M_Product_ID is mandatory.");
Set_Value ("M_Product_ID", M_Product_ID);
}
/** Get Product.
@return Product, Service, Item */
public int GetM_Product_ID() 
{
Object ii = Get_Value("M_Product_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Production Plan.
@param M_ProductionPlan_ID Plan for how a product is produced */
public void SetM_ProductionPlan_ID (int M_ProductionPlan_ID)
{
if (M_ProductionPlan_ID < 1) throw new ArgumentException ("M_ProductionPlan_ID is mandatory.");
Set_ValueNoCheck ("M_ProductionPlan_ID", M_ProductionPlan_ID);
}
/** Get Production Plan.
@return Plan for how a product is produced */
public int GetM_ProductionPlan_ID() 
{
Object ii = Get_Value("M_ProductionPlan_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Production.
@param M_Production_ID Plan for producing a product */
public void SetM_Production_ID (int M_Production_ID)
{
if (M_Production_ID < 1) throw new ArgumentException ("M_Production_ID is mandatory.");
Set_ValueNoCheck ("M_Production_ID", M_Production_ID);
}
/** Get Production.
@return Plan for producing a product */
public int GetM_Production_ID() 
{
Object ii = Get_Value("M_Production_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed)
{
Set_Value ("Processed", Processed);
}
/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() 
{
Object oo = Get_Value("Processed");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Production Quantity.
@param ProductionQty Quantity of products to produce */
public void SetProductionQty (Decimal? ProductionQty)
{
if (ProductionQty == null) throw new ArgumentException ("ProductionQty is mandatory.");
Set_Value ("ProductionQty", (Decimal?)ProductionQty);
}
/** Get Production Quantity.
@return Quantity of products to produce */
public Decimal GetProductionQty() 
{
Object bd =Get_Value("ProductionQty");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
}

}
